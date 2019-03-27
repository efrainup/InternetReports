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

    // pry_proyectos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PryProyecto
    {
        [Required]
        [Display(Name = "Id pry")]
        public int IdPry { get; set; } // id_pry (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        ///<summary>
        /// id del empleado responsable del proyecto
        ///</summary>
        [Required]
        [Display(Name = "Id res")]
        public int IdRes { get; set; } // id_res

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 50)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec alt")]
        public System.DateTime FecAlt { get; set; } // fec_alt

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec cer")]
        public System.DateTime FecCer { get; set; } // fec_cer

        ///<summary>
        /// Ingresos
        ///</summary>
        [Required]
        [Display(Name = "Mto ing")]
        public float MtoIng { get; set; } // mto_ing

        [Required]
        [Display(Name = "Mto dev ing")]
        public float MtoDevIng { get; set; } // mto_dev_ing

        [Required]
        [Display(Name = "Mto gto")]
        public float MtoGto { get; set; } // mto_gto

        [Required]
        [Display(Name = "Mto cto")]
        public float MtoCto { get; set; } // mto_cto

        [Required]
        [Display(Name = "Mto cto dev")]
        public float MtoCtoDev { get; set; } // mto_cto_dev

        ///<summary>
        /// 0=Cancelado 1=Abierto 2=Conculido
        ///</summary>
        [Required]
        [Display(Name = "Status")]
        public float Status { get; set; } // status

        public PryProyecto()
        {
            IdPry = 0;
            IdUsr = 0;
            IdRes = 0;
            Des = "";
            MtoIng = 0f;
            MtoDevIng = 0f;
            MtoGto = 0f;
            MtoCto = 0f;
            MtoCtoDev = 0f;
            Status = 1f;
        }
    }

}
// </auto-generated>
