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

    // tbl_layout_config
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblLayoutConfig
    {
        [Required]
        [Display(Name = "Id xml")]
        public int IdXml { get; set; } // id_xml (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Archivo xml")]
        public string ArchivoXml { get; set; } // archivo_xml (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // descripcion (Primary key) (length: 50)

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status (Primary key)

        public TblLayoutConfig()
        {
            ArchivoXml = "0x";
            FecReg = System.DateTime.Now;
            IdUsr = 0;
            Descripcion = "";
            Status = 0;
        }
    }

}
// </auto-generated>