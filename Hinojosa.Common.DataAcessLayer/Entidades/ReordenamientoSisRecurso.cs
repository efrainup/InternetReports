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

    // reordenamiento_sis_recursos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ReordenamientoSisRecurso
    {
        [Required]
        [Display(Name = "Id rec")]
        public int IdRec { get; set; } // id_rec (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (Primary key) (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Mod")]
        public string Mod { get; set; } // mod (Primary key) (length: 2)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status (Primary key)

        [Required]
        [Display(Name = "Id mod")]
        public int IdMod { get; set; } // id_mod (Primary key)

        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Frm")]
        public string Frm { get; set; } // frm (Primary key) (length: 50)

        [Required]
        [Display(Name = "Id img")]
        public int IdImg { get; set; } // id_img (Primary key)

        [Required]
        [Display(Name = "Id rec pad")]
        public int IdRecPad { get; set; } // id_rec_pad (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Orden")]
        public string Orden { get; set; } // orden (Primary key) (length: 40)

        [Required]
        [Display(Name = "Modo")]
        public byte Modo { get; set; } // modo (Primary key)

        [Required]
        [Display(Name = "Nivel")]
        public byte Nivel { get; set; } // Nivel (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // descripcion (Primary key) (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Ruta")]
        public string Ruta { get; set; } // ruta (Primary key) (length: 255)

        [Required]
        [Display(Name = "Sis ori")]
        public byte SisOri { get; set; } // sis_ori (Primary key)

        [Required]
        [Display(Name = "Habilitado")]
        public byte Habilitado { get; set; } // habilitado (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Ensamblado")]
        public string Ensamblado { get; set; } // ensamblado (Primary key) (length: 60)

        [Required]
        [Display(Name = "Id tbl")]
        public int IdTbl { get; set; } // id_tbl (Primary key)

        [Required]
        [Display(Name = "Es mod logistica")]
        public bool EsModLogistica { get; set; } // esModLogistica (Primary key)

        [Required]
        [Display(Name = "B enviar ap roceda")]
        public bool BEnviarAProceda { get; set; } // bEnviarAProceda (Primary key)

        [Required]
        [Display(Name = "Vis cmp")]
        public byte VisCmp { get; set; } // vis_cmp (Primary key)
    }

}
// </auto-generated>