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

    // tbl_alertas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblAlerta
    {
        [Required]
        [Display(Name = "Id alerta")]
        public int IdAlerta { get; set; } // IdAlerta (Primary key)

        [Required]
        [Display(Name = "Id tbl")]
        public int IdTbl { get; set; } // idTbl

        [Required]
        [Display(Name = "Id rel")]
        public int IdRel { get; set; } // idRel

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // idTipDoc

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; } // titulo (length: 50)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Msg personalizado")]
        public string MsgPersonalizado { get; set; } // msgPersonalizado

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha reg")]
        public System.DateTime FechaReg { get; set; } // fechaReg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // idUsr

        public TblAlerta()
        {
            IdAlerta = 0;
            IdTbl = 0;
            IdRel = 0;
            IdTipDoc = 0;
            Status = 1;
            Titulo = "";
            MsgPersonalizado = "";
            FechaReg = System.DateTime.Now;
            IdUsr = 0;
        }
    }

}
// </auto-generated>
