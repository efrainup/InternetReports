// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;

namespace Hinojosa.Common.DataAccessLayer.Entidades
{

    // Manifestacion_Valor
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ManifestacionValor
    {
        [Required]
        [Display(Name = "N ID manifestacion")]
        public int NIdManifestacion { get; set; } // nIdManifestacion (Primary key)

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S proveedor")]
        public string SProveedor { get; set; } // sProveedor (length: 100)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S pr calle")]
        public string SPrCalle { get; set; } // sPrCalle (length: 50)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S pr num exterior")]
        public string SPrNumExterior { get; set; } // sPrNumExterior (length: 20)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S pr num interior")]
        public string SPrNumInterior { get; set; } // sPrNumInterior (length: 20)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S pr ciudad")]
        public string SPrCiudad { get; set; } // sPrCiudad (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S pr estado")]
        public string SPrEstado { get; set; } // sPrEstado (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S pr pais")]
        public string SPrPais { get; set; } // sPrPais (length: 50)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S pr codigo postal")]
        public string SPrCodigoPostal { get; set; } // sPrCodigoPostal (length: 10)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S pr telefono")]
        public string SPrTelefono { get; set; } // sPrTelefono (length: 20)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S pr correo")]
        public string SPrCorreo { get; set; } // sPrCorreo (length: 30)

        [Display(Name = "N vinculacion iv")]
        public int? NVinculacionIv { get; set; } // nVinculacionIV

        [Display(Name = "N influyo vt")]
        public int? NInfluyoVt { get; set; } // nInfluyoVT

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S importador")]
        public string SImportador { get; set; } // sImportador (length: 100)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S ia pellido p")]
        public string SIApellidoP { get; set; } // sIApellidoP (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S ia pellido m")]
        public string SIApellidoM { get; set; } // sIApellidoM (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S in ombre")]
        public string SINombre { get; set; } // sINombre (length: 50)

        [MaxLength(13)]
        [StringLength(13)]
        [Display(Name = "S ir fc")]
        public string SIRfc { get; set; } // sIRfc (length: 13)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S ic alle")]
        public string SICalle { get; set; } // sICalle (length: 50)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S in um exterior")]
        public string SINumExterior { get; set; } // sINumExterior (length: 20)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S in um interior")]
        public string SINumInterior { get; set; } // sINumInterior (length: 20)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S ic olonia")]
        public string SIColonia { get; set; } // sIColonia (length: 50)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S ic odigo postal")]
        public string SICodigoPostal { get; set; } // sICodigoPostal (length: 10)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S im unicipio")]
        public string SIMunicipio { get; set; } // sIMunicipio (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S ie ntidad fed")]
        public string SIEntidadFed { get; set; } // sIEntidadFed (length: 50)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S it elefono")]
        public string SITelefono { get; set; } // sITelefono (length: 20)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S ic orreo")]
        public string SICorreo { get; set; } // sICorreo (length: 30)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S aaa pellido p")]
        public string SAaApellidoP { get; set; } // sAAApellidoP (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S aaa pellido m")]
        public string SAaApellidoM { get; set; } // sAAApellidoM (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S aan ombre")]
        public string SAaNombre { get; set; } // sAANombre (length: 50)

        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "S aap atente")]
        public string SAaPatente { get; set; } // sAAPatente (length: 4)

        [Display(Name = "N metodo val")]
        public int? NMetodoVal { get; set; } // nMetodoVal

        [MaxLength(6)]
        [StringLength(6)]
        [Display(Name = "S metodos util")]
        public string SMetodosUtil { get; set; } // sMetodosUtil (length: 6)

        [Display(Name = "S descripcion 1")]
        public string SDescripcion1 { get; set; } // sDescripcion1

        [Display(Name = "S descripcion 2")]
        public string SDescripcion2 { get; set; } // sDescripcion2

        [Display(Name = "S descripcion 3")]
        public string SDescripcion3 { get; set; } // sDescripcion3

        [Display(Name = "S descripcion 4")]
        public string SDescripcion4 { get; set; } // sDescripcion4

        [Display(Name = "S descripcion 5")]
        public string SDescripcion5 { get; set; } // sDescripcion5

        [Display(Name = "S descripcion 6")]
        public string SDescripcion6 { get; set; } // sDescripcion6

        [Display(Name = "N 1 ga nexa doc")]
        public int? N1GAnexaDoc { get; set; } // n1GAnexaDoc

        [Display(Name = "N 1 gn um hojas anexo")]
        public int? N1GNumHojasAnexo { get; set; } // n1GNumHojasAnexo

        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "S concepto no integran vt")]
        public string SConceptoNoIntegranVt { get; set; } // sConceptoNoIntegranVT (length: 4)

        [Display(Name = "N 2 ca nexa doc mv")]
        public int? N2CAnexaDocMv { get; set; } // n2CAnexaDocMV

        [Display(Name = "N 2 dn o anexa inf")]
        public int? N2DNoAnexaInf { get; set; } // n2DNoAnexaInf

        [Display(Name = "N precio mer 65")]
        public int? NPrecioMer65 { get; set; } // nPrecioMer65

        [Display(Name = "N opta por acompanaro no")]
        public int? NOptaPorAcompanaroNo { get; set; } // nOptaPorAcompanaroNo

        [Display(Name = "N 2 da nexa doc")]
        public int? N2DAnexaDoc { get; set; } // n2DAnexaDoc

        [Display(Name = "N 2 dn o anexa doc")]
        public int? N2DNoAnexaDoc { get; set; } // n2DNoAnexaDoc

        [Display(Name = "N base gravable")]
        public int? NBaseGravable { get; set; } // nBaseGravable

        [Display(Name = "N acompana doc va")]
        public int? NAcompanaDocVa { get; set; } // nAcompanaDocVA

        [Display(Name = "N valor mer provisional")]
        public int? NValorMerProvisional { get; set; } // nValorMerProvisional

        [Display(Name = "N anexa doc vm")]
        public int? NAnexaDocVm { get; set; } // nAnexaDocVM

        [Display(Name = "N manifestacion presentada")]
        public int? NManifestacionPresentada { get; set; } // nManifestacionPresentada

        [MaxLength(13)]
        [StringLength(13)]
        [Display(Name = "S 5 rfc")]
        public string S5Rfc { get; set; } // s5Rfc (length: 13)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha presentacion")]
        public System.DateTime? DFechaPresentacion { get; set; } // dFechaPresentacion

        [Display(Name = "N firma")]
        public int? NFirma { get; set; } // nFirma

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "N 5 nombre firma")]
        public string N5NombreFirma { get; set; } // n5NombreFirma (length: 100)
    }

}
// </auto-generated>