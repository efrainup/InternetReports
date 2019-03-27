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

    // Actas_Administrativas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ActasAdministrativa
    {
        [Required]
        [Display(Name = "Id act")]
        public int IdAct { get; set; } // id_act (Primary key)

        [Display(Name = "Id act gp")]
        public int? IdActGp { get; set; } // id_act_gp

        [Display(Name = "Id tip act")]
        public int? IdTipAct { get; set; } // id_tip_act

        [Display(Name = "Id emp")]
        public int? IdEmp { get; set; } // id_emp

        [Display(Name = "Tid emp")]
        public int? TidEmp { get; set; } // tid_emp

        [Display(Name = "Id depto")]
        public int? IdDepto { get; set; } // id_depto

        [Display(Name = "Id suc")]
        public int? IdSuc { get; set; } // id_suc

        [Display(Name = "Id puesto")]
        public int? IdPuesto { get; set; } // id_puesto

        [Display(Name = "Id sup")]
        public int? IdSup { get; set; } // id_sup

        [Display(Name = "Id rep emp")]
        public int? IdRepEmp { get; set; } // id_rep_emp

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha hora")]
        public System.DateTime? FechaHora { get; set; } // fecha_hora

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Lugar lev")]
        public string LugarLev { get; set; } // lugar_lev (length: 200)

        [Display(Name = "Id mot")]
        public int? IdMot { get; set; } // id_mot

        [Display(Name = "Id ina")]
        public int? IdIna { get; set; } // id_ina

        [Display(Name = "Status")]
        public int? Status { get; set; } // status

        [Display(Name = "Id usr")]
        public int? IdUsr { get; set; } // id_usr

        [DataType(DataType.DateTime)]
        [Display(Name = "Modfech")]
        public System.DateTime? Modfech { get; set; } // modfech

        [DataType(DataType.DateTime)]
        [Display(Name = "Regfech")]
        public System.DateTime? Regfech { get; set; } // regfech

        [Display(Name = "Id cmp")]
        public int? IdCmp { get; set; } // id_cmp

        [DataType(DataType.DateTime)]
        [Display(Name = "Fech suceso")]
        public System.DateTime? FechSuceso { get; set; } // fech_suceso

        [Display(Name = "Des suceso")]
        public string DesSuceso { get; set; } // des_suceso
    }

}
// </auto-generated>
