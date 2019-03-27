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

    // Pase_Envio_Cuentas_LF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PaseEnvioCuentasLf
    {
        [Required]
        [Display(Name = "N ID pase")]
        public int NIdPase { get; set; } // nIdPase (Primary key)

        [Required]
        [Display(Name = "N ID referencia")]
        public int NIdReferencia { get; set; } // nIdReferencia

        [Required]
        [Display(Name = "B autorizado")]
        public bool BAutorizado { get; set; } // bAutorizado

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha autorizado")]
        public System.DateTime? DFechaAutorizado { get; set; } // dFechaAutorizado

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        [Display(Name = "B enviado")]
        public bool? BEnviado { get; set; } // bEnviado

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Fecha envio")]
        public string FechaEnvio { get; set; } // FechaEnvio (length: 25)

        [Display(Name = "N es oc")]
        public int? NEsOc { get; set; } // nEsOC

        [Display(Name = "B gastos")]
        public bool? BGastos { get; set; } // bGastos

        [Display(Name = "B pase sir")]
        public bool? BPaseSir { get; set; } // bPaseSIR

        public PaseEnvioCuentasLf()
        {
            BAutorizado = false;
            DFechaAlta = System.DateTime.Now;
            BEnviado = false;
            NEsOc = 0;
            BGastos = false;
            BPaseSir = false;
        }
    }

}
// </auto-generated>