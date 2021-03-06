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

    // Disponible
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Disponible
    {
        [Required]
        [Display(Name = "Id disponibilidad")]
        public int IdDisponibilidad { get; set; } // id_disponibilidad (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Id equipo")]
        public string IdEquipo { get; set; } // id_equipo (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // descripcion (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } // tipo (length: 100)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Inicio")]
        public System.DateTime Inicio { get; set; } // inicio

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fin")]
        public System.DateTime Fin { get; set; } // fin

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Modo")]
        public string Modo { get; set; } // modo (length: 100)

        [Required]
        [Display(Name = "C autorizado")]
        public bool CAutorizado { get; set; } // c_autorizado

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        public Disponible()
        {
            IdEquipo = "";
            Descripcion = "";
            Tipo = "";
            Modo = "";
            CAutorizado = false;
            IdEmp = 0;
            IdProv = 0;
            IdUsr = 0;
            Status = 0;
        }
    }

}
// </auto-generated>
