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

    // sis_sociales
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisSociale
    {
        [Required]
        [Display(Name = "Id sis sociales")]
        public int IdSisSociales { get; set; } // id_sis_sociales (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Usuario")]
        public string Usuario { get; set; } // usuario

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Contrasena")]
        public string Contrasena { get; set; } // contrasena

        [Required]
        [Display(Name = "Tipo")]
        public int Tipo { get; set; } // tipo

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ult mod")]
        public System.DateTime FecUltMod { get; set; } // fec_ult_mod

        [Required]
        [Display(Name = "Usr mod")]
        public int UsrMod { get; set; } // usr_mod

        public SisSociale()
        {
            Usuario = "";
            Contrasena = "";
            Tipo = 0;
            Status = 0;
            FecReg = System.DateTime.Now;
            FecUltMod = System.DateTime.Now;
            UsrMod = 0;
        }
    }

}
// </auto-generated>
