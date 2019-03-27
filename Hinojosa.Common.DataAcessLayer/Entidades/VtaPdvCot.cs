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

    // vta_pdv_cot
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaPdvCot
    {
        [Required]
        [Display(Name = "Id pdv")]
        public int IdPdv { get; set; } // id_pdv (Primary key)

        [Required]
        [Display(Name = "Id vta aux")]
        public int IdVtaAux { get; set; } // id_vta_aux

        [Required]
        [Display(Name = "Num")]
        public int Num { get; set; } // num

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Precio")]
        public double Precio { get; set; } // precio

        [Required]
        [Display(Name = "Id almac")]
        public int IdAlmac { get; set; } // id_almac

        [Required]
        [Display(Name = "Id kardex")]
        public int IdKardex { get; set; } // id_kardex

        [Required]
        [Display(Name = "Id fac")]
        public int IdFac { get; set; } // id_fac

        [Required]
        [Display(Name = "Id pdv dev")]
        public int IdPdvDev { get; set; } // id_pdv_dev

        [Required]
        [Display(Name = "Id prom")]
        public int IdProm { get; set; } // id_prom

        [Required]
        [Display(Name = "Ptg prom")]
        public double PtgProm { get; set; } // ptg_prom

        [Required]
        [Display(Name = "Desc prom")]
        public double DescProm { get; set; } // desc_prom

        [Required]
        [Display(Name = "Abo mon")]
        public double AboMon { get; set; } // abo_mon

        [Required]
        [Display(Name = "Id tar")]
        public int IdTar { get; set; } // id_tar

        [Required]
        [Display(Name = "Ptg tar")]
        public double PtgTar { get; set; } // ptg_tar

        [Required]
        [Display(Name = "Desc tar")]
        public double DescTar { get; set; } // desc_tar

        [Required]
        [Display(Name = "Precio simptos")]
        public double PrecioSimptos { get; set; } // precio_simptos

        [Required]
        [Display(Name = "Importe simptos")]
        public double ImporteSimptos { get; set; } // importe_simptos

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "Imptos")]
        public double Imptos { get; set; } // imptos

        [Required]
        [Display(Name = "Importe total")]
        public double ImporteTotal { get; set; } // importe_total

        [Required]
        [Display(Name = "Sec")]
        public int Sec { get; set; } // sec

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Pre ori simp")]
        public double PreOriSimp { get; set; } // PreOri_Simp

        [Required]
        [Display(Name = "Pre ori cimp")]
        public double PreOriCimp { get; set; } // PreOri_Cimp

        [Required]
        [Display(Name = "Mod dcto")]
        public byte ModDcto { get; set; } // Mod_Dcto

        [Required]
        [Display(Name = "Pre lis simp")]
        public double PreLisSimp { get; set; } // pre_lis_Simp

        [Required]
        [Display(Name = "Pre lis cimp")]
        public double PreLisCimp { get; set; } // pre_lis_Cimp

        [Required]
        [Display(Name = "Id rem")]
        public int IdRem { get; set; } // id_rem

        [Required]
        [Display(Name = "Cant ped")]
        public double CantPed { get; set; } // cant_ped

        [Required]
        [Display(Name = "Cant ent")]
        public double CantEnt { get; set; } // cant_ent

        public VtaPdvCot()
        {
            IdVtaAux = 0;
            Num = 0;
            IdPro = 0;
            Cant = 0.00;
            Precio = 0.00;
            IdAlmac = 0;
            IdKardex = 0;
            IdFac = 0;
            IdPdvDev = 0;
            IdProm = 0;
            PtgProm = 0.00;
            DescProm = 0.00;
            AboMon = 0;
            IdTar = 0;
            PtgTar = 0.00;
            DescTar = 0.00;
            PrecioSimptos = 0.00;
            ImporteSimptos = 0.00;
            IdImpto = 0;
            Imptos = 0.00;
            ImporteTotal = 0.00;
            Sec = 0;
            Costo = 0.00;
            PreOriSimp = 0;
            PreOriCimp = 0;
            ModDcto = 0;
            PreLisSimp = 0.00;
            PreLisCimp = 0.00;
            IdRem = 0;
            CantPed = 0;
            CantEnt = 0;
        }
    }

}
// </auto-generated>
