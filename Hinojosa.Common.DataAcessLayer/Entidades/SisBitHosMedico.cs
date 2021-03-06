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

    // sis_bit_hos_medico
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisBitHosMedico
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // ID (Primary key)

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref (Primary key)

        [Required]
        [Display(Name = "Id medico ant")]
        public int IdMedicoAnt { get; set; } // id_medico_ant (Primary key)

        [Required]
        [Display(Name = "Id medico act")]
        public int IdMedicoAct { get; set; } // id_medico_act (Primary key)

        [Required]
        [Display(Name = "Sis origen")]
        public byte SisOrigen { get; set; } // sis_origen (Primary key)

        [Required]
        [Display(Name = "Id evento")]
        public int IdEvento { get; set; } // id_evento (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Usr")]
        public string Usr { get; set; } // usr (Primary key) (length: 150)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        public SisBitHosMedico()
        {
            IdRef = 0;
            IdMedicoAnt = 0;
            IdMedicoAct = 0;
            SisOrigen = 0;
            IdEvento = 0;
            Usr = "";
        }
    }

}
// </auto-generated>
