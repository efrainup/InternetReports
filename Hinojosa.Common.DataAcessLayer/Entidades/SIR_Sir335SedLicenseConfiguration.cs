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

    // SIR_335_SED_LICENSES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir335SedLicenseConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir335SedLicense>
    {
        public SIR_Sir335SedLicenseConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir335SedLicenseConfiguration(string schema)
        {
            ToTable("SIR_335_SED_LICENSES", schema);
            HasKey(x => x.NIdLicenses335);

            Property(x => x.NIdLicenses335).HasColumnName(@"nIdLicenses335").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SCode).HasColumnName(@"sCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.SName).HasColumnName(@"sName").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
