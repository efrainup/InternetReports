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

    // SIR_339_SED_HARMO_TARIFF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir339SedHarmoTariffConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir339SedHarmoTariff>
    {
        public SIR_Sir339SedHarmoTariffConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir339SedHarmoTariffConfiguration(string schema)
        {
            ToTable("SIR_339_SED_HARMO_TARIFF", schema);
            HasKey(x => x.NIdHts339);

            Property(x => x.NIdHts339).HasColumnName(@"nIdHTS339").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SNumber).HasColumnName(@"sNumber").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.SDescription).HasColumnName(@"sDescription").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
