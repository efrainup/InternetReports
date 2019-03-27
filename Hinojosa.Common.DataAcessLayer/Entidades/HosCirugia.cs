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

    // hos_cirugias
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class HosCirugia
    {
        [Required]
        [Display(Name = "Id cirugia")]
        public int IdCirugia { get; set; } // id_cirugia (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Clave")]
        public string Clave { get; set; } // clave (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // descripcion (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Id otr sis")]
        public string IdOtrSis { get; set; } // id_otr_sis (length: 25)

        [Required]
        [Display(Name = "Id tip")]
        public int IdTip { get; set; } // id_tip

        [Required]
        [Display(Name = "C activo")]
        public bool CActivo { get; set; } // c_activo

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

        public HosCirugia()
        {
            Clave = "";
            Descripcion = "";
            IdOtrSis = "";
            IdTip = 0;
            CActivo = false;
            IdUsr = 0;
            Status = 0;
        }
    }

}
// </auto-generated>