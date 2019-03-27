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

    // mon_pol_rev_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class MonPolRevDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MonPolRevDet>
    {
        public MonPolRevDetConfiguration()
            : this("dbo")
        {
        }

        public MonPolRevDetConfiguration(string schema)
        {
            ToTable("mon_pol_rev_det", schema);
            HasKey(x => x.IdMonPolRevDet);

            Property(x => x.IdMonPolRevDet).HasColumnName(@"id_mon_pol_rev_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdMonPolRevDoc).HasColumnName(@"id_mon_pol_rev_doc").HasColumnType("int").IsRequired();
            Property(x => x.TipSdo).HasColumnName(@"tip_sdo").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.TcFm).HasColumnName(@"tc_fm").HasColumnType("float").IsRequired();
            Property(x => x.IdCtaUti).HasColumnName(@"id_cta_uti").HasColumnType("int").IsRequired();
            Property(x => x.IdCtaBce).HasColumnName(@"id_cta_bce").HasColumnType("int").IsRequired();
            Property(x => x.Utilidad).HasColumnName(@"utilidad").HasColumnType("float").IsRequired();
            Property(x => x.Perdida).HasColumnName(@"perdida").HasColumnType("float").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("float").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.STipo).HasColumnName(@"sTipo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1024);
            Property(x => x.IdCtaBco).HasColumnName(@"id_cta_bco").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
