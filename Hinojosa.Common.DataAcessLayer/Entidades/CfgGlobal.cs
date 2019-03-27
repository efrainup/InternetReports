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

    // cfg_global
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CfgGlobal
    {
        [Required]
        [Display(Name = "Id cfg glb")]
        public int IdCfgGlb { get; set; } // id_cfg_glb (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Campo")]
        public string Campo { get; set; } // campo (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // descripcion (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Valor")]
        public string Valor { get; set; } // Valor (length: 300)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // fecha

        [Required]
        [Display(Name = "Id mod")]
        public int IdMod { get; set; } // id_mod

        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Orden")]
        public byte Orden { get; set; } // orden

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec mod")]
        public System.DateTime FecMod { get; set; } // fec_mod

        [Required]
        [Display(Name = "Tam")]
        public int Tam { get; set; } // tam

        [Required]
        [Display(Name = "C neg")]
        public byte CNeg { get; set; } // c_neg

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Msk")]
        public string Msk { get; set; } // msk (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Fto")]
        public string Fto { get; set; } // fto (length: 50)

        [Required]
        [Display(Name = "Msk pre")]
        public byte MskPre { get; set; } // msk_pre

        [Required]
        [Display(Name = "Valores")]
        public byte Valores { get; set; } // valores

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Rango 1")]
        public string Rango1 { get; set; } // rango1 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Rango 2")]
        public string Rango2 { get; set; } // rango2 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Lista")]
        public string Lista { get; set; } // lista (length: 2147483647)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 300)

        [Required]
        [Display(Name = "Id cfg dep")]
        public int IdCfgDep { get; set; } // id_cfg_dep

        [Required(AllowEmptyStrings = true)]
        [MaxLength(512)]
        [StringLength(512)]
        [Display(Name = "Valor dep")]
        public string ValorDep { get; set; } // valor_dep (length: 512)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Es cn glb")]
        public byte EsCnGlb { get; set; } // es_cn_glb

        [Required]
        [Display(Name = "C obl")]
        public byte CObl { get; set; } // c_obl

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Des larga")]
        public string DesLarga { get; set; } // des_larga (length: 2147483647)

        public CfgGlobal()
        {
            IdCfgGlb = 0;
            Campo = "";
            Descripcion = "";
            Valor = "";
            Fecha = System.DateTime.Now;
            IdMod = 0;
            Tipo = 0;
            IdUsr = 0;
            Orden = 0;
            FecReg = System.DateTime.Now;
            FecMod = System.DateTime.Now;
            Tam = 0;
            CNeg = 0;
            Msk = "";
            Fto = "";
            MskPre = 0;
            Valores = 0;
            Rango1 = "";
            Rango2 = "";
            Lista = "";
            Des = "";
            IdCfgDep = 0;
            ValorDep = "";
            Status = 0;
            EsCnGlb = 0;
            CObl = 0;
            DesLarga = "";
        }
    }

}
// </auto-generated>