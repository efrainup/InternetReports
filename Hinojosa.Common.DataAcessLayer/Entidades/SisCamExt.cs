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

    // sis_cam_ext
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisCamExt
    {
        [Required]
        [Display(Name = "Id pantalla")]
        public int IdPantalla { get; set; } // id_pantalla (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Desc pantalla")]
        public string DescPantalla { get; set; } // desc_pantalla (length: 50)

        [Required]
        [Display(Name = "Sec")]
        public int Sec { get; set; } // sec (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Campo")]
        public string Campo { get; set; } // campo (length: 30)

        ///<summary>
        /// 1=Caracter,2=Entero,3=Decimal 4=Decimal Moneda, 5=Fecha
        ///</summary>
        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        [Required]
        [Display(Name = "C neg")]
        public byte CNeg { get; set; } // c_neg

        [Required]
        [Display(Name = "Tam")]
        public int Tam { get; set; } // tam

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        public SisCamExt()
        {
            IdPantalla = 0;
            DescPantalla = "";
            Sec = 0;
            Campo = "";
            Tipo = 1;
            CNeg = 0;
            Tam = 0;
            Status = 1;
        }
    }

}
// </auto-generated>
