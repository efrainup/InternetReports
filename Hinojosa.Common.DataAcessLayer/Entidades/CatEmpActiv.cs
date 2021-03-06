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

    // cat_emp_activ
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpActiv
    {
        [Required]
        [Display(Name = "Id actividad")]
        public int IdActividad { get; set; } // id_actividad (Primary key)

        [Required]
        [Display(Name = "Id rel activ")]
        public int IdRelActiv { get; set; } // id_rel_activ

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Actividad")]
        public string Actividad { get; set; } // actividad (length: 100)

        [Required]
        [Display(Name = "Id prd")]
        public int IdPrd { get; set; } // id_prd

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Duracion")]
        public string Duracion { get; set; } // duracion (length: 10)

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

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
        [Display(Name = "Id clas")]
        public int IdClas { get; set; } // id_clas

        [Required]
        [Display(Name = "Dias")]
        public int Dias { get; set; } // dias

        [Required]
        [Display(Name = "Pond")]
        public int Pond { get; set; } // pond

        [Required]
        [Display(Name = "Id lst acts")]
        public int IdLstActs { get; set; } // id_lst_acts

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Dura hr")]
        public string DuraHr { get; set; } // dura_hr (length: 50)

        [Required]
        [Display(Name = "Dura segs")]
        public long DuraSegs { get; set; } // dura_segs

        [Required]
        [Display(Name = "Pnd act")]
        public double PndAct { get; set; } // pnd_act

        [Required]
        [Display(Name = "C apl")]
        public byte CApl { get; set; } // c_apl

        [Required]
        [Display(Name = "Pnd grp")]
        public double PndGrp { get; set; } // pnd_grp

        [Required]
        [Display(Name = "Id act lay")]
        public int IdActLay { get; set; } // id_act_lay

        public CatEmpActiv()
        {
            IdActividad = 0;
            IdRelActiv = 0;
            Actividad = "";
            IdPrd = 0;
            Duracion = "";
            IdNota = 0;
            IdUsr = 0;
            Status = 1;
            IdClas = 0;
            Dias = 0;
            Pond = 0;
            IdLstActs = 0;
            DuraHr = "";
            DuraSegs = 0;
            PndAct = 0;
            CApl = 1;
            PndGrp = 0;
            IdActLay = 0;
        }
    }

}
// </auto-generated>
