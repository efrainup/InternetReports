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

    // cat_den
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatDen
    {
        [Required]
        [Display(Name = "Id den")]
        public int IdDen { get; set; } // id_den (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Descr")]
        public string Descr { get; set; } // descr (length: 25)

        [Required]
        [Display(Name = "Valor")]
        public double Valor { get; set; } // valor

        ///<summary>
        /// 1=Dinero 0=Documentos
        ///</summary>
        [Required]
        [Display(Name = "Tipo den")]
        public byte TipoDen { get; set; } // tipo_den

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        // Reverse navigation

        /// <summary>
        /// Child VtaCortesDets where [vta_cortes_det].[id_den] point to this entity (FK_vta_cortes_det_cat_den)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VtaCortesDet> VtaCortesDets { get; set; } // vta_cortes_det.FK_vta_cortes_det_cat_den

        public CatDen()
        {
            TipoDen = 0;
            Status = 1;
            VtaCortesDets = new System.Collections.Generic.List<VtaCortesDet>();
        }
    }

}
// </auto-generated>