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

    // bco_iva_aux
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoIvaAuxConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BcoIvaAux>
    {
        public BcoIvaAuxConfiguration()
            : this("dbo")
        {
        }

        public BcoIvaAuxConfiguration(string schema)
        {
            ToTable("bco_iva_aux", schema);
            HasKey(x => x.IdBcoIvaAux);

            Property(x => x.IdBcoIvaAux).HasColumnName(@"id_bco_iva_aux").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRelBcoIva).HasColumnName(@"id_rel_bco_iva").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.FecDoc).HasColumnName(@"fec_doc").HasColumnType("datetime").IsRequired();
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.Importe).HasColumnName(@"importe").HasColumnType("float").IsRequired();
            Property(x => x.Imptos).HasColumnName(@"imptos").HasColumnType("float").IsRequired();
            Property(x => x.Iva).HasColumnName(@"iva").HasColumnType("float").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("float").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.ImporteBse).HasColumnName(@"importe_bse").HasColumnType("float").IsRequired();
            Property(x => x.ImptosBse).HasColumnName(@"imptos_bse").HasColumnType("float").IsRequired();
            Property(x => x.IvaBse).HasColumnName(@"iva_bse").HasColumnType("float").IsRequired();
            Property(x => x.TotalBse).HasColumnName(@"total_bse").HasColumnType("float").IsRequired();
            Property(x => x.IdRelImpDoc).HasColumnName(@"id_rel_imp_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdPag).HasColumnName(@"id_pag").HasColumnType("int").IsRequired();
            Property(x => x.IdPagDet).HasColumnName(@"id_pag_det").HasColumnType("int").IsRequired();
            Property(x => x.IdCobro).HasColumnName(@"id_cobro").HasColumnType("int").IsRequired();
            Property(x => x.IdCobroDet).HasColumnName(@"id_cobro_det").HasColumnType("int").IsRequired();
            Property(x => x.FecApl).HasColumnName(@"fec_apl").HasColumnType("datetime").IsRequired();
            Property(x => x.Aplicado).HasColumnName(@"aplicado").HasColumnType("float").IsRequired();
            Property(x => x.TcPag).HasColumnName(@"tc_pag").HasColumnType("float").IsRequired();
            Property(x => x.OperPag).HasColumnName(@"oper_pag").HasColumnType("tinyint").IsRequired();
            Property(x => x.AplicadoBse).HasColumnName(@"aplicado_bse").HasColumnType("float").IsRequired();
            Property(x => x.IvaApl).HasColumnName(@"iva_apl").HasColumnType("float").IsRequired();
            Property(x => x.IvaAplBse).HasColumnName(@"iva_apl_bse").HasColumnType("float").IsRequired();
            Property(x => x.PtgApl).HasColumnName(@"ptg_apl").HasColumnType("float").IsRequired();
            Property(x => x.TipIva).HasColumnName(@"tip_iva").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdBcoDoc).HasColumnName(@"id_bco_doc").HasColumnType("int").IsRequired();
            Property(x => x.CCnl).HasColumnName(@"c_cnl").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCtlIva).HasColumnName(@"id_ctl_iva").HasColumnType("int").IsRequired();
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.NumParc).HasColumnName(@"num_parc").HasColumnType("int").IsRequired();
            Property(x => x.IdCtlIeps).HasColumnName(@"id_ctl_ieps").HasColumnType("int").IsRequired();
            Property(x => x.PtgIvaAcr).HasColumnName(@"ptg_iva_acr").HasColumnType("float").IsRequired();
        }
    }

}
// </auto-generated>