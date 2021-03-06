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

    // tra_viajes_srv
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TraViajesSrv
    {
        [Required]
        [Display(Name = "Id viaje srv")]
        public int IdViajeSrv { get; set; } // id_viaje_srv (Primary key)

        [Required]
        [Display(Name = "Id viaje")]
        public int IdViaje { get; set; } // id_viaje

        [Required]
        [Display(Name = "No entrega")]
        public int NoEntrega { get; set; } // no_entrega

        [Required]
        [Display(Name = "No part")]
        public int NoPart { get; set; } // no_part

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required(AllowEmptyStrings = true)]
        [MaxLength(160)]
        [StringLength(160)]
        [Display(Name = "Des pro")]
        public string DesPro { get; set; } // des_pro (length: 160)

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "Cant")]
        public int Cant { get; set; } // cant

        [Required]
        [Display(Name = "Precio")]
        public double Precio { get; set; } // precio

        [Required]
        [Display(Name = "Importe simptos")]
        public double ImporteSimptos { get; set; } // importe_simptos

        [Required]
        [Display(Name = "Imptos")]
        public double Imptos { get; set; } // imptos

        [Required]
        [Display(Name = "Total")]
        public double Total { get; set; } // total

        [Required]
        [Display(Name = "Precio bse")]
        public double PrecioBse { get; set; } // precio_bse

        [Required]
        [Display(Name = "Importe simptos bse")]
        public double ImporteSimptosBse { get; set; } // importe_simptos_bse

        [Required]
        [Display(Name = "Imptos bse")]
        public double ImptosBse { get; set; } // imptos_bse

        [Required]
        [Display(Name = "Total bse")]
        public double TotalBse { get; set; } // total_bse

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc

        [Required]
        [Display(Name = "Id doc det")]
        public int IdDocDet { get; set; } // id_doc_det

        [Required]
        [Display(Name = "Id cod tra")]
        public int IdCodTra { get; set; } // id_cod_tra

        public TraViajesSrv()
        {
            IdViaje = 0;
            NoEntrega = 0;
            NoPart = 0;
            IdPro = 0;
            DesPro = "";
            IdCenCto = 0;
            IdAlm = 0;
            IdImpto = 0;
            Cant = 0;
            Precio = 0;
            ImporteSimptos = 0;
            Imptos = 0;
            Total = 0;
            PrecioBse = 0;
            ImporteSimptosBse = 0;
            ImptosBse = 0;
            TotalBse = 0;
            IdNota = 0;
            IdTipDoc = 0;
            IdDoc = 0;
            IdDocDet = 0;
            IdCodTra = 0;
        }
    }

}
// </auto-generated>
