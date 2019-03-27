using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hinojosa.RECOVFP.DataAccessLayer.Entidades.Scontrol
{
    //[XmlRoot(ElementName = "LayoutDanfossModel")]
    public class LayoutDanfossModel
    {
        [XmlElement(ElementName = "movimiento")]
        public string Movimiento { get; set; }
        [XmlElement(ElementName = "numped")]
        public string NumeroPedimento { get; set; }
        [XmlElement(ElementName = "patente")]
        public string Patente { get; set; }
        [XmlElement(ElementName = "claveped")]
        public string ClavePedimento { get; set; }
        [XmlElement(ElementName = "regimen")]
        public string Regimen { get; set; }
        [XmlElement(ElementName = "tcambio")]
        public string TipoCambio { get; set; }
        [XmlElement(ElementName = "pesokg")]
        public string PesoKilogramos { get; set; }
        [XmlElement(ElementName = "aduana")]
        public string Aduana { get; set; }
        [XmlElement(ElementName = "seccion")]
        public string Seccion { get; set; }
        [XmlElement(ElementName = "cvemede")]
        public string Cvemede { get; set; }
        [XmlElement(ElementName = "cvemeda")]
        public string Cvemeda { get; set; }
        [XmlElement(ElementName = "cvemeds")]
        public string Cvemeds { get; set; }
        [XmlElement(ElementName = "semaforo")]
        public string Semaforo { get; set; }
        [XmlElement(ElementName = "valdolg")]
        public string Valdolg { get; set; }
        [XmlElement(ElementName = "valaduag")]
        public string Valaduag { get; set; }
        [XmlElement(ElementName = "valcomg")]
        public string Valcomg { get; set; }
        [XmlElement(ElementName = "valsegmn")]
        public string Valsegmn { get; set; }
        [XmlElement(ElementName = "segurosg")]
        public string Segurosg { get; set; }
        [XmlElement(ElementName = "fletesg")]
        public string Fletesg { get; set; }
        [XmlElement(ElementName = "embalag")]
        public string Embalag { get; set; }
        [XmlElement(ElementName = "otrosg")]
        public string Otrosg { get; set; }
        [XmlElement(ElementName = "firmae")]
        public string Firmae { get; set; }
        [XmlElement(ElementName = "bultos")]
        public string Bultos { get; set; }
        [XmlElement(ElementName = "fecpago")]
        public string FechaPago { get; set; }
        [XmlElement(ElementName = "fecent")]
        public string FechaEntrada { get; set; }
        [XmlElement(ElementName = "prevalida")]
        public string Prevalida { get; set; }
        [XmlElement(ElementName = "dta")]
        public string Dta { get; set; }
        [XmlElement(ElementName = "consolidad")]
        public string Consolidado { get; set; }
        [XmlElement(ElementName = "recargos")]
        public string Recargos { get; set; }
        [XmlElement(ElementName = "fprecargos")]
        public string Fprecargos { get; set; }
        [XmlElement(ElementName = "advfpgen")]
        public string Advfpgen { get; set; }
        [XmlElement(ElementName = "art303")]
        public string Art303 { get; set; }
        [XmlElement(ElementName = "fp303")]
        public string Fp303 { get; set; }
        [XmlElement(ElementName = "multas")]
        public string Multas { get; set; }
        [XmlElement(ElementName = "fpmultas")]
        public string Fpmultas { get; set; }
        [XmlElement(ElementName = "otros")]
        public string Otros { get; set; }
        [XmlElement(ElementName = "fpotros")]
        public string Fpotros { get; set; }
        [XmlElement(ElementName = "ivagen")]
        public string Ivagen { get; set; }
        [XmlElement(ElementName = "ivafpgen")]
        public string Ivafpgen { get; set; }
        [XmlElement(ElementName = "medtrans")]
        public string Medtrans { get; set; }
        [XmlElement(ElementName = "medtransfp")]
        public string Medtransfp { get; set; }
        [XmlElement(ElementName = "actualiza")]
        public string Actualiza { get; set; }
        [XmlElement(ElementName = "actfp")]
        public string Actfp { get; set; }
        [XmlElement(ElementName = "anexo")]
        public string Anexo { get; set; }
        [XmlElement(ElementName = "provedor")]
        public string Provedor { get; set; }
        [XmlElement(ElementName = "cvedanfos")]
        public string Cvedanfos { get; set; }
        [XmlElement(ElementName = "snumero")]
        public string Snumero { get; set; }
        [XmlElement(ElementName = "fecfactu")]
        public string Fecfactu { get; set; }
        [XmlElement(ElementName = "incoterm")]
        public string Incoterm { get; set; }
        [XmlElement(ElementName = "cvemoneda")]
        public string Cvemoneda { get; set; }
        [XmlElement(ElementName = "nvalmcia")]
        public string Nvalmcia { get; set; }
        [XmlElement(ElementName = "factor")]
        public string Factor { get; set; }
        [XmlElement(ElementName = "valfacus")]
        public string Valfacus { get; set; }
        [XmlElement(ElementName = "facvinc")]
        public string Facvinc { get; set; }
        [XmlElement(ElementName = "numparte")]
        public string Numparte { get; set; }
        [XmlElement(ElementName = "desmer")]
        public string Desmer { get; set; }
        [XmlElement(ElementName = "clase")]
        public string Clase { get; set; }
        [XmlElement(ElementName = "sfraccion")]
        public string Sfraccion { get; set; }
        [XmlElement(ElementName = "clasevinc")]
        public string Clasevinc { get; set; }
        [XmlElement(ElementName = "metval")]
        public string Metval { get; set; }
        [XmlElement(ElementName = "unidadcom")]
        public string Unidadcom { get; set; }
        [XmlElement(ElementName = "cantfact")]
        public string Cantfact { get; set; }
        [XmlElement(ElementName = "unidadtar")]
        public string Unidadtar { get; set; }
        [XmlElement(ElementName = "canttar")]
        public string Canttar { get; set; }
        [XmlElement(ElementName = "paisvend")]
        public string Paisvend { get; set; }
        [XmlElement(ElementName = "paisori")]
        public string Paisori { get; set; }
        [XmlElement(ElementName = "pesoneto")]
        public string Pesoneto { get; set; }
        [XmlElement(ElementName = "valdors")]
        public string Valdors { get; set; }
        [XmlElement(ElementName = "nvalorfac")]
        public string Nvalorfac { get; set; }
        [XmlElement(ElementName = "medtrans1")]
        public string Medtrans1 { get; set; }
        [XmlElement(ElementName = "valccpar")]
        public string Valccpar { get; set; }
        [XmlElement(ElementName = "complem")]
        public string Complem { get; set; }
        [XmlElement(ElementName = "tasaadv")]
        public string TasaAdv { get; set; }
        [XmlElement(ElementName = "tasaiva")]
        public string Tasaiva { get; set; }
        [XmlElement(ElementName = "bloqueo")]
        public string Bloqueo { get; set; }
        [XmlElement(ElementName = "destinata")]
        public string Destinata { get; set; }
        [XmlElement(ElementName = "partida")]
        public string Partida { get; set; }
        [XmlElement(ElementName = "cove")]
        public string Cove { get; set; }
        [XmlElement(ElementName = "pedimorig")]
        public string Pedimorig { get; set; }
        [XmlElement(ElementName = "claveoriginal")]
        public string ClaveOriginal { get; set; }
        [XmlElement(ElementName = "valagr")]
        public string Valagr { get; set; }
        [XmlElement(ElementName = "contraprestacion")]
        public string Contraprestacion { get; set; }
        [XmlElement(ElementName = "codigoconsignatario")]
        public string CodigoConsignatario { get; set; }
        [XmlElement(ElementName = "tipotasa")]
        public string TipoTasa { get; set; }
    }
}
