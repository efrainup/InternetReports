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

    // SIR_659_EXENTO_EEI
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir659ExentoEeiConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir659ExentoEei>
    {
        public SIR_Sir659ExentoEeiConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir659ExentoEeiConfiguration(string schema)
        {
            ToTable("SIR_659_EXENTO_EEI", schema);
            HasKey(x => x.NIdExentoEei659);

            Property(x => x.NIdExentoEei659).HasColumnName(@"nIdExentoEEI659").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("int").IsRequired();
            Property(x => x.SCategoria).HasColumnName(@"sCategoria").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }

}
// </auto-generated>
