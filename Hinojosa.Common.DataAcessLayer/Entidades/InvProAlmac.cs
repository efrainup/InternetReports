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

    // inv_pro_almac
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvProAlmac
    {
        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm (Primary key)

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro (Primary key)

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [Display(Name = "Minimo")]
        public double Minimo { get; set; } // minimo

        [Required]
        [Display(Name = "Maximo")]
        public double Maximo { get; set; } // maximo

        [Required]
        [Display(Name = "Existencia")]
        public double Existencia { get; set; } // existencia

        [Required]
        [Display(Name = "Costo prom")]
        public double CostoProm { get; set; } // costo_prom

        [Required]
        [Display(Name = "Costo ult")]
        public double CostoUlt { get; set; } // costo_ult

        ///<summary>
        /// Existencia en Consignacion (ventas)
        ///</summary>
        [Required]
        [Display(Name = "En consig")]
        public double EnConsig { get; set; } // en_consig

        ///<summary>
        /// Producto que se tiene consignado (Recepciones)
        ///</summary>
        [Required]
        [Display(Name = "Consignado")]
        public double Consignado { get; set; } // consignado

        [Required]
        [Display(Name = "Reorden")]
        public double Reorden { get; set; } // reorden

        [Required]
        [Display(Name = "Id ubi 1")]
        public int IdUbi1 { get; set; } // id_ubi1

        [Required]
        [Display(Name = "Id ubi 2")]
        public int IdUbi2 { get; set; } // id_ubi2

        [Required]
        [Display(Name = "Id ubi 3")]
        public int IdUbi3 { get; set; } // id_ubi3

        [Required]
        [Display(Name = "Apartado")]
        public double Apartado { get; set; } // apartado

        [Required]
        [Display(Name = "Backorder")]
        public double Backorder { get; set; } // backorder

        [Required]
        [Display(Name = "Disponible")]
        public double Disponible { get; set; } // disponible

        [Required]
        [Display(Name = "Und en ped")]
        public double UndEnPed { get; set; } // und_en_ped

        [Required]
        [Display(Name = "Und en oc")]
        public double UndEnOc { get; set; } // und_en_oc

        [Required]
        [Display(Name = "Und en prod")]
        public double UndEnProd { get; set; } // und_en_prod

        [Required]
        [Display(Name = "Inv req mrp")]
        public int InvReqMrp { get; set; } // inv_req_mrp

        [Required]
        [Display(Name = "C inv fis")]
        public byte CInvFis { get; set; } // c_inv_fis

        [Required]
        [Display(Name = "Num dias ent prov")]
        public int NumDiasEntProv { get; set; } // num_dias_ent_prov

        [Required]
        [Display(Name = "Num dias ent prov real")]
        public int NumDiasEntProvReal { get; set; } // num_dias_ent_prov_real

        [Required]
        [Display(Name = "Num dias max inv")]
        public int NumDiasMaxInv { get; set; } // num_dias_max_inv

        [Required]
        [Display(Name = "Mult comp inv")]
        public double MultCompInv { get; set; } // mult_comp_inv

        [Required]
        [Display(Name = "Uni min comp")]
        public double UniMinComp { get; set; } // uni_min_comp

        [Required]
        [Display(Name = "Tipo tope")]
        public bool TipoTope { get; set; } // tipo_tope

        // Foreign keys

        /// <summary>
        /// Parent CatAlmac pointed by [inv_pro_almac].([IdAlm]) (FK_inv_pro_almac_cat_almac)
        /// </summary>
        public virtual CatAlmac CatAlmac { get; set; } // FK_inv_pro_almac_cat_almac

        /// <summary>
        /// Parent CatPro pointed by [inv_pro_almac].([IdPro]) (FK_inv_pro_almac_cat_pro)
        /// </summary>
        public virtual CatPro CatPro { get; set; } // FK_inv_pro_almac_cat_pro

        public InvProAlmac()
        {
            Minimo = 0;
            Maximo = 0;
            Existencia = 0;
            CostoProm = 0;
            CostoUlt = 0;
            EnConsig = 0;
            Consignado = 0;
            Reorden = 0;
            IdUbi1 = 0;
            IdUbi2 = 0;
            IdUbi3 = 0;
            Apartado = 0;
            Backorder = 0;
            Disponible = 0;
            UndEnPed = 0;
            UndEnOc = 0;
            UndEnProd = 0;
            InvReqMrp = 0;
            CInvFis = 0;
            NumDiasEntProv = 0;
            NumDiasEntProvReal = 0;
            NumDiasMaxInv = 0;
            MultCompInv = 0.00;
            UniMinComp = 0.00;
            TipoTope = true;
        }
    }

}
// </auto-generated>
