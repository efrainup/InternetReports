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

    // SIR_329_SED_ZIP_COD_AME_STATES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir329SedZipCodAmeStateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir329SedZipCodAmeState>
    {
        public SIR_Sir329SedZipCodAmeStateConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir329SedZipCodAmeStateConfiguration(string schema)
        {
            ToTable("SIR_329_SED_ZIP_COD_AME_STATES", schema);
            HasKey(x => x.NIdZipCodAme329);

            Property(x => x.NIdZipCodAme329).HasColumnName(@"nIdZipCodAme329").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SStateCode).HasColumnName(@"sStateCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.SZipCode).HasColumnName(@"sZipCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(9);
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
