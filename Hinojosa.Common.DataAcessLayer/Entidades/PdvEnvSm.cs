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

    // pdv_env_sms
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PdvEnvSm
    {
        [Required]
        [Display(Name = "Id sms env")]
        public int IdSmsEnv { get; set; } // IdSmsEnv (Primary key)

        [Required]
        [Display(Name = "Id monedero")]
        public int IdMonedero { get; set; } // IdMonedero

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; } // Telefono (length: 15)

        [Required]
        [Display(Name = "Ticket")]
        public int Ticket { get; set; } // Ticket

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha reg")]
        public System.DateTime FechaReg { get; set; } // FechaReg

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required(AllowEmptyStrings = true)]
        [MaxLength(160)]
        [StringLength(160)]
        [Display(Name = "Descrip error")]
        public string DescripError { get; set; } // DescripError (length: 160)

        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // Tipo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha env")]
        public System.DateTime FechaEnv { get; set; } // FechaEnv

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // IdUsr

        [Required(AllowEmptyStrings = true)]
        [MaxLength(320)]
        [StringLength(320)]
        [Display(Name = "Descrip sms")]
        public string DescripSms { get; set; } // DescripSMS (length: 320)

        [Required]
        [Display(Name = "Id vta aux")]
        public int IdVtaAux { get; set; } // id_vta_aux

        public PdvEnvSm()
        {
            IdMonedero = 0;
            Telefono = "";
            Ticket = 0;
            Status = 0;
            DescripError = "";
            Tipo = 0;
            IdUsr = 0;
            DescripSms = "";
            IdVtaAux = 0;
        }
    }

}
// </auto-generated>