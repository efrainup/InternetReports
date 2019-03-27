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

    // hos_bit_cuartos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class HosBitCuarto
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // ID (Primary key)

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required]
        [Display(Name = "Id cuarto ant")]
        public int IdCuartoAnt { get; set; } // id_cuarto_ant

        [Required]
        [Display(Name = "Id cuarto nvo")]
        public int IdCuartoNvo { get; set; } // id_cuarto_nvo

        [Required]
        [Display(Name = "C deja cuarto")]
        public byte CDejaCuarto { get; set; } // c_deja_cuarto

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        public HosBitCuarto()
        {
            IdRef = 0;
            IdCuartoAnt = 0;
            IdCuartoNvo = 0;
            CDejaCuarto = 0;
        }
    }

}
// </auto-generated>