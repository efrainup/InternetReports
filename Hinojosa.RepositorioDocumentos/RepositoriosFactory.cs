using Laserfiche.RepositoryAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos
{
    public class RepositoriosFactory
    {
        public IBuscadorDocumentos<DocumentoRepositorio> CrearBuscador(Repositorio repositorio, object sesion = null)
        {

            switch (repositorio) { 
                case Repositorio.SIREFile:
                    if (sesion is WsDocumentosSirEfile.RECOValidHeader)
                    {
                        WsDocumentosSirEfile.RECOValidHeader SesionSirEFile = (WsDocumentosSirEfile.RECOValidHeader)sesion;
                        return new SIREFile.BuscadorDocumentosSIREFile(SesionSirEFile);
                    }
                    else if (sesion is SIREFile.ConexionEfile)
                    {
                        SIREFile.ConexionEfile SesionSirEFile = (SIREFile.ConexionEfile)sesion;
                        return new SIREFile.BuscadorDocumentosSIREFile(SesionSirEFile);
                    }
                return new SIREFile.BuscadorDocumentosSIREFile();
                break;
                
                case Repositorio.Laserfiche:
                    if (sesion != null)
                    {
                        //Lanzará una excepción en caso de que no sea un objecto LaserficheRepositoryAccess.Session
                        Session sesionLF = (Session)sesion;
                        return new Laserfiche.BuscadorDocumentosLaserficheRepositoryAccess(sesionLF);
                    }
                        return new Laserfiche.BuscadorDocumentosLaserficheRepositoryAccess();
                default:
                    throw new ArgumentOutOfRangeException("repositorio", "El argumento utilizado no se encuentra en el rango del enumerado Hinojosa.RepositorioDocumentos.Repositorio");
            }
        }

        public IExportadorDocumentos<DocumentoRepositorio> CrearExportador(Repositorio repositorio, object sesion = null)
        {
            switch (repositorio)
            {
                case Repositorio.SIREFile:
                    if (sesion is WsDocumentosSirEfile.RECOValidHeader)
                    {
                        WsDocumentosSirEfile.RECOValidHeader SesionSirEFile = (WsDocumentosSirEfile.RECOValidHeader)sesion;
                        return new SIREFile.ExportadorDocumentosSIREFile(SesionSirEFile);
                    }
                    return new SIREFile.ExportadorDocumentosSIREFile();
                    break;
                case Repositorio.Laserfiche:
                    if (sesion != null)
                    {
                        //Lanzará una excepción en caso de que no sea un objecto LaserficheRepositoryAccess.Session
                        Session sesionLF = (Session)sesion;

                        return new Laserfiche.ExportadorDocumentosLaserficheRepositoryAccess(sesionLF);
                    }
                    return new Laserfiche.ExportadorDocumentosLaserficheRepositoryAccess(); ;
                default:
                    throw new ArgumentOutOfRangeException("repositorio", "El argumento utilizado no se encuentra en el rango del enumerado Hinojosa.RepositorioDocumentos.Repositorio");
            }
        }

        public IOperacionesRepositorio<DocumentoRepositorio> CrearOperaciones(Repositorio repositorio, object sesion = null)
        {
            switch(repositorio)
            {
                case Repositorio.SIREFile:
                    if(sesion is WsDocumentosSirEfile.RECOValidHeader)
                    {
                        WsDocumentosSirEfile.RECOValidHeader SesionSirEFile = (WsDocumentosSirEfile.RECOValidHeader)sesion;
                        return new SIREFile.OperacionesDocumentosSIREFile(SesionSirEFile);
                    }
                    return new SIREFile.OperacionesDocumentosSIREFile();
                    break;
                case Repositorio.Laserfiche:
                default:
                    if(sesion != null)
                    {
                        Session sesionLF = sesion as Session;
                        return new Laserfiche.OperacionesDocumentosLaserficheRepositoryAccess(sesionLF);
                    }

                    return new Laserfiche.OperacionesDocumentosLaserficheRepositoryAccess();
            }
        }

        public IImportadorDocumentos<DocumentoRepositorio> CrearImportador(Repositorio repositorio, object sesion = null)
        {
            switch (repositorio)
            {
                case Repositorio.SIREFile:
                    if(sesion is WsDocumentosSirEfile.RECOValidHeader)
                    {
                        WsDocumentosSirEfile.RECOValidHeader SesionSirEFile = (WsDocumentosSirEfile.RECOValidHeader)sesion;
                        return new SIREFile.ImportadorDocumentosSIREFile(SesionSirEFile);
                    }
                    else if(sesion is SIREFile.ConexionEfile)
                    {
                        SIREFile.ConexionEfile SesionSirEFile = (SIREFile.ConexionEfile)sesion;
                        return new SIREFile.ImportadorDocumentosSIREFile(SesionSirEFile);
                    }
                    return new SIREFile.ImportadorDocumentosSIREFile();
                    break;
                case Repositorio.Laserfiche:
                default:
                    if (sesion != null)
                    {
                        Session sesionLF = sesion as Session;
                        return new Laserfiche.ImportadorDocumentosLaserficheRepositoryAccess(sesionLF);
                    }

                    return new Laserfiche.ImportadorDocumentosLaserficheRepositoryAccess();
            }

            
        }
    }
}
