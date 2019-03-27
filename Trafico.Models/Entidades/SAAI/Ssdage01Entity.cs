using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hinojosa.RECOVFP.DataAccessLayer.Entidades.SAAI
{
    [XmlRoot(ElementName = "Ssdage01Entity")]
    public class Ssdage01Entity
    {

        /// <summary>
        /// Referencia interna del pedimento
        /// </summary>
        [Column("refcia01")]
		[XmlElement(ElementName = "refcia01")]
        public string Refcia01 { get; set; }
        /// <summary>
        /// Número de pedimento
        /// </summary>
        [Column("numped01")]
		[XmlElement(ElementName = "numped01")]
        public string Numped01 { get; set; }
        /// <summary>
        /// Fecha de pago del pedimento
        /// </summary>
        [Column("fecpag01")]
		[XmlElement(ElementName = "fecpag01")]
        public DateTime? Fecpag01 { get; set; }
        [Column("tipopr01")]
		[XmlElement(ElementName = "tipopr01")]
        public string Tipopr01 { get; set; }
        [Column("cveped01")]
		[XmlElement(ElementName = "cveped01")]
        public string Cveped01 { get; set; }
        [Column("cveadu01")]
		[XmlElement(ElementName = "cveadu01")]
        public string Cveadu01 { get; set; }
        [Column("cvesec01")]
		[XmlElement(ElementName = "cvesec01")]
        public string Cvesec01 { get; set; }
        [Column("regbar01")]
		[XmlElement(ElementName = "regbar01")]
        public string Regbar01 { get; set; }
        [Column("tipcam01")]
		[XmlElement(ElementName = "tipcam01")]
        public string Tipcam01 { get; set; }
        [Column("cvepfm01")]
		[XmlElement(ElementName = "cvepfm01")]
        public string Cvepfm01 { get; set; }
        [Column("factmo01")]
		[XmlElement(ElementName = "factmo01")]
        public string Factmo01 { get; set; }
        [Column("cvepvc01")]
		[XmlElement(ElementName = "cvepvc01")]
        public string Cvepvc01 { get; set; }
        [Column("cvepod01")]
		[XmlElement(ElementName = "cvepod01")]
        public string Cvepod01 { get; set; }
        [Column("cvecli01")]
		[XmlElement(ElementName = "cvecli01")]
        public string Cvecli01 { get; set; }
        [Column("desf0101")]
		[XmlElement(ElementName = "desf0101")]
        public string Desf0101 { get; set; }
        [Column("marnum01")]
		[XmlElement(ElementName = "marnum01")]
        public string Marnum01 { get; set; }
        [Column("totbul01")]
		[XmlElement(ElementName = "totbul01")]
        public string Totbul01 { get; set; }
        [Column("ctomar01")]
		[XmlElement(ElementName = "ctomar01")]
        public string Ctomar01 { get; set; }
        [Column("guivep01")]
		[XmlElement(ElementName = "guivep01")]
        public string Guivep01 { get; set; }
        [Column("formfa01")]
		[XmlElement(ElementName = "formfa01")]
        public string Formfa01 { get; set; }
        [Column("valfac01")]
		[XmlElement(ElementName = "valfac01")]
        public string Valfac01 { get; set; }
        [Column("pesobr01")]
		[XmlElement(ElementName = "pesobr01")]
        public string Pesobr01 { get; set; }
        [Column("mon101")]
		[XmlElement(ElementName = "mon101")]
        public string Mon101 { get; set; }
        [Column("fletes01")]
		[XmlElement(ElementName = "fletes01")]
        public string Fletes01 { get; set; }
        [Column("mon201")]
		[XmlElement(ElementName = "mon201")]
        public string Mon201 { get; set; }
        [Column("segros01")]
		[XmlElement(ElementName = "segros01")]
        public string Segros01 { get; set; }
        [Column("mon301")]
		[XmlElement(ElementName = "mon301")]
        public string Mon301 { get; set; }
        [Column("incble01")]
		[XmlElement(ElementName = "incble01")]
        public string Incble01 { get; set; }
        [Column("decble01")]
		[XmlElement(ElementName = "decble01")]
        public string Decble01 { get; set; }
        [Column("tsadta01")]
		[XmlElement(ElementName = "tsadta01")]
        public string Tsadta01 { get; set; }
        [Column("p_dta101")]
		[XmlElement(ElementName = "p_dta101")]
        public string P_dta101 { get; set; }
        [Column("p_dta201")]
		[XmlElement(ElementName = "p_dta201")]
        public string P_dta201 { get; set; }
        [Column("i_dta101")]
		[XmlElement(ElementName = "i_dta101")]
        public string I_dta101 { get; set; }
        [Column("i_dta201")]
		[XmlElement(ElementName = "i_dta201")]
        public string I_dta201 { get; set; }
        [Column("p_reca01")]
		[XmlElement(ElementName = "p_reca01")]
        public string P_reca01 { get; set; }
        [Column("t_reca01")]
		[XmlElement(ElementName = "t_reca01")]
        public string T_reca01 { get; set; }
        [Column("cvealm01")]
		[XmlElement(ElementName = "cvealm01")]
        public string Cvealm01 { get; set; }
        [Column("cvepro01")]
		[XmlElement(ElementName = "cvepro01")]
        public string Cvepro01 { get; set; }
        [Column("cvemtr01")]
		[XmlElement(ElementName = "cvemtr01")]
        public string Cvemtr01 { get; set; }
        [Column("rexter01")]
		[XmlElement(ElementName = "rexter01")]
        public string Rexter01 { get; set; }
        [Column("obser101")]
		[XmlElement(ElementName = "obser101")]
        public string Obser101 { get; set; }
        [Column("obser102")]
		[XmlElement(ElementName = "obser102")]
        public string Obser102 { get; set; }
        [Column("pedtra01")]
		[XmlElement(ElementName = "pedtra01")]
        public string Pedtra01 { get; set; }
        [Column("fecpre01")]
		[XmlElement(ElementName = "fecpre01")]
        public DateTime? Fecpre01 { get; set; }
        [Column("zonaod01")]
		[XmlElement(ElementName = "zonaod01")]
        public string Zonaod01 { get; set; }
        [Column("firmae01")]
		[XmlElement(ElementName = "firmae01")]
        public string Firmae01 { get; set; }
        [Column("firban01")]
		[XmlElement(ElementName = "firban01")]
        public string Firban01 { get; set; }
        [Column("tipped01")]
		[XmlElement(ElementName = "tipped01")]
        public string Tipped01 { get; set; }
        [Column("anexol01")]
		[XmlElement(ElementName = "anexol01")]
        public string Anexol01 { get; set; }
        [Column("firped01")]
		[XmlElement(ElementName = "firped01")]
        public string Firped01 { get; set; }
        [Column("adusec01")]
		[XmlElement(ElementName = "adusec01")]
        public string Adusec01 { get; set; }
        [Column("rfcped01")]
		[XmlElement(ElementName = "rfcped01")]
        public string Rfcped01 { get; set; }
        [Column("totveh01")]
		[XmlElement(ElementName = "totveh01")]
        public string Totveh01 { get; set; }
        [Column("rdecre01")]
		[XmlElement(ElementName = "rdecre01")]
        public string Rdecre01 { get; set; }
        [Column("pdecre01")]
		[XmlElement(ElementName = "pdecre01")]
        public string Pdecre01 { get; set; }
        [Column("edoedi01")]
		[XmlElement(ElementName = "edoedi01")]
        public string Edoedi01 { get; set; }
        [Column("cvefir01")]
		[XmlElement(ElementName = "cvefir01")]
        public string Cvefir01 { get; set; }
        [Column("cveres01")]
		[XmlElement(ElementName = "cveres01")]
        public string Cveres01 { get; set; }
        [Column("idencli01")]
		[XmlElement(ElementName = "idencli01")]
        public string Idencli01 { get; set; }
        [Column("acthis01")]
		[XmlElement(ElementName = "acthis01")]
        public string Acthis01 { get; set; }
        [Column("edoimp01")]
		[XmlElement(ElementName = "edoimp01")]
        public string Edoimp01 { get; set; }
        [Column("razimp01")]
		[XmlElement(ElementName = "razimp01")]
        public string Razimp01 { get; set; }
        [Column("numcan01")]
		[XmlElement(ElementName = "numcan01")]
        public string Numcan01 { get; set; }
        [Column("facact01")]
		[XmlElement(ElementName = "facact01")]
        public string Facact01 { get; set; }
        [Column("genexp01")]
		[XmlElement(ElementName = "genexp01")]
        public string Genexp01 { get; set; }
        [Column("pedmod01")]
		[XmlElement(ElementName = "pedmod01")]
        public string Pedmod01 { get; set; }
        [Column("patent01")]
		[XmlElement(ElementName = "patent01")]
        public string Patent01 { get; set; }
        [Column("otros01")]
		[XmlElement(ElementName = "otros01")]
        public string Otros01 { get; set; }
        [Column("sisori01")]
		[XmlElement(ElementName = "sisori01")]
        public string Sisori01 { get; set; }
        [Column("hayrec01")]
		[XmlElement(ElementName = "hayrec01")]
        public string Hayrec01 { get; set; }
        [Column("desdoc01")]
		[XmlElement(ElementName = "desdoc01")]
        public string Desdoc01 { get; set; }
        [Column("nomadu01")]
		[XmlElement(ElementName = "nomadu01")]
        public string Nomadu01 { get; set; }
        [Column("nomalm01")]
		[XmlElement(ElementName = "nomalm01")]
        public string Nomalm01 { get; set; }
        [Column("nompvc01")]
		[XmlElement(ElementName = "nompvc01")]
        public string Nompvc01 { get; set; }
        [Column("nompod01")]
		[XmlElement(ElementName = "nompod01")]
        public string Nompod01 { get; set; }
        [Column("nombar01")]
		[XmlElement(ElementName = "nombar01")]
        public string Nombar01 { get; set; }
        [Column("banbar01")]
		[XmlElement(ElementName = "banbar01")]
        public string Banbar01 { get; set; }
        [Column("nomcli01")]
		[XmlElement(ElementName = "nomcli01")]
        public string Nomcli01 { get; set; }
        [Column("rfccli01")]
		[XmlElement(ElementName = "rfccli01")]
        public string Rfccli01 { get; set; }
        [Column("domcli01")]
		[XmlElement(ElementName = "domcli01")]
        public string Domcli01 { get; set; }
        [Column("colcli01")]
		[XmlElement(ElementName = "colcli01")]
        public string Colcli01 { get; set; }
        [Column("cp_cli01")]
		[XmlElement(ElementName = "cp_cli01")]
        public string Cp_cli01 { get; set; }
        [Column("ciucli01")]
		[XmlElement(ElementName = "ciucli01")]
        public string Ciucli01 { get; set; }
        [Column("estcli01")]
		[XmlElement(ElementName = "estcli01")]
        public string Estcli01 { get; set; }
        [Column("nomrep01")]
		[XmlElement(ElementName = "nomrep01")]
        public string Nomrep01 { get; set; }
        [Column("rfcrep01")]
		[XmlElement(ElementName = "rfcrep01")]
        public string Rfcrep01 { get; set; }
        [Column("nompro01")]
		[XmlElement(ElementName = "nompro01")]
        public string Nompro01 { get; set; }
        [Column("dompro01")]
		[XmlElement(ElementName = "dompro01")]
        public string Dompro01 { get; set; }
        [Column("ciupro01")]
		[XmlElement(ElementName = "ciupro01")]
        public string Ciupro01 { get; set; }
        [Column("estpro01")]
		[XmlElement(ElementName = "estpro01")]
        public string Estpro01 { get; set; }
        [Column("taxpro01")]
		[XmlElement(ElementName = "taxpro01")]
        public string Taxpro01 { get; set; }
        [Column("cp_pro01")]
		[XmlElement(ElementName = "cp_pro01")]
        public string Cp_pro01 { get; set; }
        [Column("consec01")]
		[XmlElement(ElementName = "consec01")]
        public string Consec01 { get; set; }
        [Column("cveade01")]
		[XmlElement(ElementName = "cveade01")]
        public string Cveade01 { get; set; }
        [Column("cvesee01")]
		[XmlElement(ElementName = "cvesee01")]
        public string Cvesee01 { get; set; }
        [Column("curpcl01")]
		[XmlElement(ElementName = "curpcl01")]
        public string Curpcl01 { get; set; }
        [Column("curpfp01")]
		[XmlElement(ElementName = "curpfp01")]
        public string Curpfp01 { get; set; }
        [Column("embala01")]
		[XmlElement(ElementName = "embala01")]
        public string Embala01 { get; set; }
        [Column("cvemts01")]
		[XmlElement(ElementName = "cvemts01")]
        public string Cvemts01 { get; set; }
        [Column("cvemta01")]
		[XmlElement(ElementName = "cvemta01")]
        public string Cvemta01 { get; set; }
        [Column("nincli01")]
		[XmlElement(ElementName = "nincli01")]
        public string Nincli01 { get; set; }
        [Column("nexcli01")]
		[XmlElement(ElementName = "nexcli01")]
        public string Nexcli01 { get; set; }
        [Column("efecli01")]
		[XmlElement(ElementName = "efecli01")]
        public string Efecli01 { get; set; }
        [Column("paicli01")]
		[XmlElement(ElementName = "paicli01")]
        public string Paicli01 { get; set; }
        [Column("nomade01")]
		[XmlElement(ElementName = "nomade01")]
        public string Nomade01 { get; set; }
        [Column("regime01")]
		[XmlElement(ElementName = "regime01")]
        public string Regime01 { get; set; }
        [Column("efepro01")]
		[XmlElement(ElementName = "efepro01")]
        public string Efepro01 { get; set; }
        [Column("ninpro01")]
		[XmlElement(ElementName = "ninpro01")]
        public string Ninpro01 { get; set; }
        [Column("nexpro01")]
		[XmlElement(ElementName = "nexpro01")]
        public string Nexpro01 { get; set; }
        [Column("edomod")]
		[XmlElement(ElementName = "edomod")]
        public string Edomod { get; set; }
        [Column("edofec")]
		[XmlElement(ElementName = "edofec")]
        public string Edofec { get; set; }
        [Column("edodel")]
		[XmlElement(ElementName = "edodel")]
        public string Edodel { get; set; }
        [Column("anexoe01")]
		[XmlElement(ElementName = "anexoe01")]
        public string Anexoe01 { get; set; }
        [Column("tt_dta01")]
		[XmlElement(ElementName = "tt_dta01")]
        public string Tt_dta01 { get; set; }
        [Column("apltlc01")]
		[XmlElement(ElementName = "apltlc01")]
        public string Apltlc01 { get; set; }
        [Column("fraexc01")]
		[XmlElement(ElementName = "fraexc01")]
        public string Fraexc01 { get; set; }
        [Column("fecimp01")]
		[XmlElement(ElementName = "fecimp01")]
        public DateTime? Fecimp01 { get; set; }
        [Column("conord01")]
		[XmlElement(ElementName = "conord01")]
        public string Conord01 { get; set; }
        [Column("valseg01")]
		[XmlElement(ElementName = "valseg01")]
        public string Valseg01 { get; set; }
        [Column("pagpre01")]
		[XmlElement(ElementName = "pagpre01")]
        public string Pagpre01 { get; set; }
        [Column("valdol01")]
		[XmlElement(ElementName = "valdol01")]
        public string Valdol01 { get; set; }
        [Column("firmcc01")]
		[XmlElement(ElementName = "firmcc01")]
        public string Firmcc01 { get; set; }
        [Column("datocc01")]
		[XmlElement(ElementName = "datocc01")]
        public string Datocc01 { get; set; }
        [Column("tasmul01")]
		[XmlElement(ElementName = "tasmul01")]
        public string Tasmul01 { get; set; }
        [Column("oficio01")]
		[XmlElement(ElementName = "oficio01")]
        public string Oficio01 { get; set; }
        [Column("fecofi01")]
		[XmlElement(ElementName = "fecofi01")]
        public DateTime? Fecofi01 { get; set; }
        [Column("articu01")]
		[XmlElement(ElementName = "articu01")]
        public string Articu01 { get; set; }
        [Column("fimptm01")]
		[XmlElement(ElementName = "fimptm01")]
        public string Fimptm01 { get; set; }
        [Column("f_e_a_01")]
		[XmlElement(ElementName = "f_e_a_01")]
        public string F_e_a_01 { get; set; }
        [Column("numcer01")]
		[XmlElement(ElementName = "numcer01")]
        public string Numcer01 { get; set; }
        [Column("fecven01")]
		[XmlElement(ElementName = "fecven01")]
        public DateTime? Fecven01 { get; set; }
        [Column("vsegic01")]
		[XmlElement(ElementName = "vsegic01")]
        public string Vsegic01 { get; set; }
        [Column("cveprv01")]
		[XmlElement(ElementName = "cveprv01")]
        public string Cveprv01 { get; set; }
        [Column("nomuse01")]
		[XmlElement(ElementName = "nomuse01")]
        public string Nomuse01 { get; set; }
        [Column("impinc01")]
		[XmlElement(ElementName = "impinc01")]
        public string Impinc01 { get; set; }
        [Column("pedamp01")]
		[XmlElement(ElementName = "pedamp01")]
        public string Pedamp01 { get; set; }
        [Column("fecval01")]
		[XmlElement(ElementName = "fecval01")]
        public DateTime? Fecval01 { get; set; }
        [Column("folsol01")]
		[XmlElement(ElementName = "folsol01")]
        public string Folsol01 { get; set; }
        [Column("x_firma")]
		[XmlElement(ElementName = "x_firma")]
        public string X_firma { get; set; }
        [Column("blotra01")]
		[XmlElement(ElementName = "blotra01")]
        public string Blotra01 { get; set; }
        [Column("feac1301")]
		[XmlElement(ElementName = "feac1301")]
        public string Feac1301 { get; set; }
        [Column("rfcraz01")]
		[XmlElement(ElementName = "rfcraz01")]
        public string Rfcraz01 { get; set; }
        [Column("archva01")]
		[XmlElement(ElementName = "archva01")]
        public string Archva01 { get; set; }
        [Column("adudes01")]
		[XmlElement(ElementName = "adudes01")]
        public string Adudes01 { get; set; }
        [Column("secdes01")]
		[XmlElement(ElementName = "secdes01")]
        public string Secdes01 { get; set; }

    }

}
