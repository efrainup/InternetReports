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

    // vta_dep_garantia_det_pdv_pag_ban
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaDepGarantiaDetPdvPagBanConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VtaDepGarantiaDetPdvPagBan>
    {
        public VtaDepGarantiaDetPdvPagBanConfiguration()
            : this("dbo")
        {
        }

        public VtaDepGarantiaDetPdvPagBanConfiguration(string schema)
        {
            ToTable("vta_dep_garantia_det_pdv_pag_ban", schema);
            HasKey(x => new { x.IdFolio, x.IdPagBan, x.NumCta, x.NomBco, x.Nom, x.NumAutTran, x.Monto, x.VencTar, x.IdTem });

            Property(x => x.IdFolio).HasColumnName(@"id_folio").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPagBan).HasColumnName(@"id_pag_ban").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NumCta).HasColumnName(@"num_cta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NomBco).HasColumnName(@"nom_bco").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nom).HasColumnName(@"nom").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NumAutTran).HasColumnName(@"num_aut_tran").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Monto).HasColumnName(@"monto").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VencTar).HasColumnName(@"venc_tar").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTem).HasColumnName(@"id_tem").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>