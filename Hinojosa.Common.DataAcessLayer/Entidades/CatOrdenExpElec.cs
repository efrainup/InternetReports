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

    // Cat_orden_exp_elec
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatOrdenExpElec
    {
        [Required]
        [Display(Name = "Id cat orden")]
        public int IdCatOrden { get; set; } // id_cat_orden (Primary key)

        [Display(Name = "Num orden")]
        public int? NumOrden { get; set; } // num_orden

        [Display(Name = "Nom orden")]
        public string NomOrden { get; set; } // nom_orden

        [Display(Name = "Origen")]
        public int? Origen { get; set; } // origen

        [Display(Name = "Id tip doc")]
        public int? IdTipDoc { get; set; } // id_tip_doc

        [Display(Name = "Id tip arch")]
        public int? IdTipArch { get; set; } // id_tip_arch

        [Display(Name = "Orden")]
        public int? Orden { get; set; } // orden

        [Display(Name = "Pdf com")]
        public byte? PdfCom { get; set; } // pdf_com

        [Display(Name = "Status")]
        public short? Status { get; set; } // status

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime? FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Formato")]
        public int Formato { get; set; } // formato (Primary key)

        [Required]
        [Display(Name = "Id nom pdf")]
        public int IdNomPdf { get; set; } // id_nom_pdf (Primary key)

        [Required]
        [Display(Name = "Id nom zip")]
        public int IdNomZip { get; set; } // id_nom_zip (Primary key)

        [Required]
        [Display(Name = "Generar zip")]
        public int GenerarZip { get; set; } // generar_zip (Primary key)

        [Required]
        [Display(Name = "Id tip env")]
        public int IdTipEnv { get; set; } // id_tip_env (Primary key)

        [Required]
        [Display(Name = "All 1 g")]
        public byte All1G { get; set; } // all_1g (Primary key)

        [Required]
        [Display(Name = "All sir")]
        public byte AllSir { get; set; } // all_sir (Primary key)

        public CatOrdenExpElec()
        {
            Formato = 0;
            IdNomPdf = 0;
            IdNomZip = 0;
            GenerarZip = 0;
            IdTipEnv = 0;
            All1G = 0;
            AllSir = 0;
        }
    }

}
// </auto-generated>
