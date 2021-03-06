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

    // mon_tip_cam_prom
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class MonTipCamProm
    {
        [Required]
        [Display(Name = "Id tip cam prom")]
        public int IdTipCamProm { get; set; } // id_tip_cam_prom (Primary key)

        [Required]
        [Display(Name = "Id per")]
        public int IdPer { get; set; } // id_per

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "Tcp calculado")]
        public float TcpCalculado { get; set; } // TCP_calculado

        [Required]
        [Display(Name = "Tcp manual")]
        public float TcpManual { get; set; } // TCP_manual

        [Required]
        [Display(Name = "C mod")]
        public bool CMod { get; set; } // c_mod

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        public MonTipCamProm()
        {
            IdPer = 0;
            IdMda = 0;
            TcpCalculado = 0.00f;
            TcpManual = 0.00f;
            CMod = false;
            IdUsr = 0;
        }
    }

}
// </auto-generated>
