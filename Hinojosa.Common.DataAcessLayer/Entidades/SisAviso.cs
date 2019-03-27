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

    // sis_avisos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisAviso
    {
        [Required]
        [Display(Name = "Id sis avisos")]
        public int IdSisAvisos { get; set; } // id_sis_avisos (Primary key)

        [Required]
        [Display(Name = "Id rec")]
        public int IdRec { get; set; } // id_rec

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Query")]
        public string Query { get; set; } // query (length: 2147483647)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; } // titulo

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Ancho lv")]
        public string AnchoLv { get; set; } // ancho_lv

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Tag lv")]
        public string TagLv { get; set; } // tag_lv

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Alineacion lv")]
        public string AlineacionLv { get; set; } // alineacion_lv

        [Required]
        [Display(Name = "Col ID tip doc")]
        public int ColIdTipDoc { get; set; } // col_id_tip_doc

        [Required]
        [Display(Name = "Col ID")]
        public int ColId { get; set; } // col_id

        [Required]
        [Display(Name = "Col serie")]
        public int ColSerie { get; set; } // col_serie

        [Required]
        [Display(Name = "Col num doc")]
        public int ColNumDoc { get; set; } // col_num_doc

        [Required]
        [Display(Name = "Col ID rec")]
        public int ColIdRec { get; set; } // col_id_rec

        [Required]
        [Display(Name = "Col titulo")]
        public int ColTitulo { get; set; } // col_titulo

        [Required]
        [Display(Name = "Col descripcion")]
        public int ColDescripcion { get; set; } // col_descripcion

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Col totales")]
        public string ColTotales { get; set; } // col_totales

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Titulo resumen")]
        public string TituloResumen { get; set; } // titulo_resumen

        [Required]
        [Display(Name = "Id img")]
        public int IdImg { get; set; } // id_img

        [Required]
        [Display(Name = "Id mod")]
        public int IdMod { get; set; } // id_mod

        public SisAviso()
        {
            IdSisAvisos = 0;
            IdRec = 0;
            Query = "";
            Titulo = "";
            AnchoLv = "";
            TagLv = "";
            AlineacionLv = "";
            ColIdTipDoc = 0;
            ColId = 0;
            ColSerie = 0;
            ColNumDoc = 0;
            ColIdRec = 0;
            ColTitulo = 0;
            ColDescripcion = 0;
            IdUsr = 0;
            Status = 0;
            ColTotales = "";
            TituloResumen = "";
            IdImg = 0;
            IdMod = 0;
        }
    }

}
// </auto-generated>