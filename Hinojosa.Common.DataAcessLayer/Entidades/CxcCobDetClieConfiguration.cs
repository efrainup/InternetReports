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

    // cxc_cob_det_clie
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxcCobDetClieConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CxcCobDetClie>
    {
        public CxcCobDetClieConfiguration()
            : this("dbo")
        {
        }

        public CxcCobDetClieConfiguration(string schema)
        {
            ToTable("cxc_cob_det_clie", schema);
            HasKey(x => new { x.Uuid, x.IdCobro, x.IdCobroDet, x.UuidDr, x.FolioDr, x.MdaDr, x.TcDr, x.MetPagDr, x.NumParcDr, x.ImpSadoAntDr, x.ImpPagDr, x.ImpSdoInsDr, x.Cve, x.Cant, x.Udm, x.Des, x.@Base, x.Impto, x.TipFactor, x.Tasaocuota, x.TotalImpto, x.Serie, x.RfcFa });

            Property(x => x.Uuid).HasColumnName(@"uuid").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(36).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCobro).HasColumnName(@"id_cobro").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCobroDet).HasColumnName(@"id_cobro_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UuidDr).HasColumnName(@"uuid_dr").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(36).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FolioDr).HasColumnName(@"folio_dr").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MdaDr).HasColumnName(@"mda_dr").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TcDr).HasColumnName(@"tc_dr").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MetPagDr).HasColumnName(@"met_pag_dr").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NumParcDr).HasColumnName(@"num_parc_dr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ImpSadoAntDr).HasColumnName(@"ImpSadoAnt_dr").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ImpPagDr).HasColumnName(@"ImpPag_dr").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ImpSdoInsDr).HasColumnName(@"ImpSdoIns_dr").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cve).HasColumnName(@"cve").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Udm).HasColumnName(@"UDM").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.@Base).HasColumnName(@"base").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Impto).HasColumnName(@"impto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipFactor).HasColumnName(@"tip_factor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tasaocuota).HasColumnName(@"tasaocuota").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TotalImpto).HasColumnName(@"total_impto").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsOptional();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsOptional();
            Property(x => x.IdRegCob).HasColumnName(@"id_reg_cob").HasColumnType("int").IsOptional();
            Property(x => x.RfcFa).HasColumnName(@"rfc_FA").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
