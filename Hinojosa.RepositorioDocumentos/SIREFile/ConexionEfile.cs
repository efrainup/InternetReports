using System;
using System.Text;
using System.Security.Cryptography;
using Hinojosa.RepositorioDocumentos.WsDocumentosSirEfile;
using System.Configuration;

namespace Hinojosa.RepositorioDocumentos.SIREFile
{



    public class ConexionEfile : IDisposable
    {
        public WsDocumentosSirEfile.wsDocumentosSoapClient WSDocumentos { get; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public RECOValidHeader RecoToken { get; set; }
        private TipoDocumento[] _TiposDoc;
        public string LlaveWebService { get; set; } = "WSDDAH";

        private string newPropertyValue;

        [Obsolete("Use propiedad RecoToken")]
        public RECOValidHeader TokenRECO
        {
            get
            {
                return RecoToken;
            }
            set
            {
                RecoToken = value;
            }
        }

        public ConexionEfile()
        {
            this.Usuario = ConfigurationManager.AppSettings["UsuarioConsultaSIREFile"];
            Contraseña = ConfigurationManager.AppSettings["ContraseñaConsultaSIREFile"];
            LlaveWebService = ConfigurationManager.AppSettings["LlaveWebServiceSIREFile"];
            WSDocumentos = new WsDocumentosSirEfile.wsDocumentosSoapClient();
        }

        public ConexionEfile(string Usuario, string Password)
        {
            this.Usuario = Usuario;
            Contraseña = Password;
            LlaveWebService = ConfigurationManager.AppSettings["LlaveWebServiceSIREFile"];
            WSDocumentos = new WsDocumentosSirEfile.wsDocumentosSoapClient();
        }

        public void Conectar()
        {
            RecoToken = RecoToken ?? new RECOValidHeader();
            RecoToken.RECOToken = this.WSDocumentos.GetToken();
            RecoToken.RECOCredential = this.Encriptar(Usuario + "|" + Contraseña, LlaveWebService);
        }



        public void Dispose()
        {
            if (WSDocumentos != null && WSDocumentos.State == System.ServiceModel.CommunicationState.Opened)
                WSDocumentos.Close();
        }


        /// <summary>
        /// Función para encriptar usuario y password e introducirlo en un Token de RECO para autenticarse en los servicios Web
        /// </summary>
        /// <param name="strEncriptar">Cadena que será encriptada</param>
        /// <param name="strPK">Llave del servicio Web</param>
        /// <returns></returns>
        private byte[] Encriptar(string strEncriptar, string strPK)
        {
            PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(strPK, (byte[])null/* TODO Change to default(_) if this is not a reference type */);
            return this.Encriptar(strEncriptar, passwordDeriveBytes.GetBytes(32));
        }

        /// <summary>
        /// Función para encriptar usuario y password e introducirlo en un Token de RECO para autenticarse en los servicios Web
        /// </summary>
        /// <param name="strEncriptar">Cadena que será encriptada</param>
        /// <param name="bytPK">Llave del servicio Web en Bytes</param>
        /// <returns></returns>
        private byte[] Encriptar(string strEncriptar, byte[] bytPK)
        {
            Rijndael rijndael = Rijndael.Create();
            byte[] numArray = (byte[])null/* TODO Change to default(_) if this is not a reference type */;

            try
            {
                rijndael.Key = bytPK;
                rijndael.GenerateIV();
                byte[] bytes1 = Encoding.UTF8.GetBytes(strEncriptar);
                byte[] bytes2 = rijndael.CreateEncryptor().TransformFinalBlock(bytes1, 0, bytes1.Length);
                numArray = new byte[rijndael.IV.Length + bytes2.Length - 1 + 1];
                rijndael.IV.CopyTo((Array)numArray, 0);
                string str1 = Encoding.Default.GetString(rijndael.IV);
                string str2 = Encoding.Default.GetString(bytes2);
                string str3;

                if (str1 == str2)
                    str3 = str1 + "¯‡«í\0x25Ö›O\0x18\0x129öIÇ¤qž";

                bytes2.CopyTo((Array)numArray, rijndael.IV.Length);
            }
            catch
            {
            }
            finally
            {
                rijndael.Clear();
            }

            return numArray;
        }
    }
}