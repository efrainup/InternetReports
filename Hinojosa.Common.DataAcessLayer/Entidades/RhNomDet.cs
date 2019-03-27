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

    // rh_nom_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RhNomDet
    {
        [Required]
        [Display(Name = "Id nom det")]
        public int IdNomDet { get; set; } // id_nom_det (Primary key)

        [Required]
        [Display(Name = "Id nom")]
        public int IdNom { get; set; } // id_nom

        [Required]
        [Display(Name = "Id cpt")]
        public int IdCpt { get; set; } // id_cpt

        [Required]
        [Display(Name = "Monto")]
        public double Monto { get; set; } // monto

        [Required]
        [Display(Name = "Tipo cpt")]
        public byte TipoCpt { get; set; } // tipo_cpt

        [Required]
        [Display(Name = "C apl imss")]
        public byte CAplImss { get; set; } // c_apl_imss

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "C apl sdi")]
        public byte CAplSdi { get; set; } // c_apl_sdi

        [Required]
        [Display(Name = "Num par")]
        public int NumPar { get; set; } // num_par

        public RhNomDet()
        {
            IdNomDet = 0;
            IdNom = 0;
            IdCpt = 0;
            Monto = 0;
            TipoCpt = 0;
            CAplImss = 0;
            IdUsr = 0;
            Status = 1;
            CAplSdi = 0;
            NumPar = 0;
        }
    }

}
// </auto-generated>
