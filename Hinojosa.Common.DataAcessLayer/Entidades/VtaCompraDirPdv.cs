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

    // vta_compra_dir_pdv
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaCompraDirPdv
    {
        [Required]
        [Display(Name = "Id compra dir")]
        public int IdCompraDir { get; set; } // ID_COMPRA_DIR (Primary key)

        [Display(Name = "Id com")]
        public int? IdCom { get; set; } // ID_COM

        [Display(Name = "Id pro")]
        public int? IdPro { get; set; } // ID_PRO

        [Display(Name = "Id kardex")]
        public int? IdKardex { get; set; } // ID_KARDEX

        [Display(Name = "Id almac")]
        public int? IdAlmac { get; set; } // ID_ALMAC

        [Display(Name = "Id usr")]
        public int? IdUsr { get; set; } // ID_USR

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha reg")]
        public System.DateTime? FechaReg { get; set; } // FECHA_REG

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Num doc")]
        public string NumDoc { get; set; } // NUM_DOC (length: 20)

        [Display(Name = "Cant")]
        public double? Cant { get; set; } // CANT

        [Display(Name = "Precio")]
        public double? Precio { get; set; } // PRECIO

        [Display(Name = "Importe")]
        public double? Importe { get; set; } // IMPORTE

        [Display(Name = "Status")]
        public byte? Status { get; set; } // STATUS

        [Display(Name = "Imptos")]
        public double? Imptos { get; set; } // IMPTOS

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Udm")]
        public string Udm { get; set; } // UDM (length: 3)

        [Display(Name = "Tipo")]
        public byte? Tipo { get; set; } // TIPO
    }

}
// </auto-generated>
