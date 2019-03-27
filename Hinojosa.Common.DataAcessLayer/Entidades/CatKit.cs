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

    // cat_kit
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatKit
    {

        ///<summary>
        /// Join al cat_pro del producto que es un Kit
        ///</summary>
        [Required]
        [Display(Name = "Id pro kit")]
        public int IdProKit { get; set; } // id_pro_kit (Primary key)

        [Required]
        [Display(Name = "Sec")]
        public int Sec { get; set; } // sec (Primary key)

        ///<summary>
        /// join a cat_pro para determinar de que producto se compone el kit
        ///</summary>
        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro (Primary key)

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        ///<summary>
        /// 1=Servico 2=Tipo de Concepto CGA
        ///</summary>
        [Required]
        [Display(Name = "Tip")]
        public byte Tip { get; set; } // tip

        [Required]
        [Display(Name = "Id tip")]
        public int IdTip { get; set; } // id_tip

        [Required]
        [Display(Name = "Id pro lis")]
        public int IdProLis { get; set; } // id_pro_lis

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        // Foreign keys

        /// <summary>
        /// Parent CatPro pointed by [cat_kit].([IdPro]) (FK_cat_kit_cat_pro)
        /// </summary>
        public virtual CatPro CatPro { get; set; } // FK_cat_kit_cat_pro

        /// <summary>
        /// Parent CatUsr pointed by [cat_kit].([IdUsr]) (FK_cat_kit_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_cat_kit_cat_usr

        public CatKit()
        {
            IdProKit = 0;
            Sec = 0;
            IdPro = 0;
            Cant = 0;
            IdUsr = 0;
            Tip = 1;
            IdTip = 0;
            IdProLis = 0;
        }
    }

}
// </auto-generated>
