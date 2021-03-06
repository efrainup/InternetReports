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

    // bco_tip_cta
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoTipCtaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BcoTipCta>
    {
        public BcoTipCtaConfiguration()
            : this("dbo")
        {
        }

        public BcoTipCtaConfiguration(string schema)
        {
            ToTable("bco_tip_cta", schema);
            HasKey(x => x.IdTipCta);

            Property(x => x.IdTipCta).HasColumnName(@"id_tip_cta").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cod).HasColumnName(@"cod").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
