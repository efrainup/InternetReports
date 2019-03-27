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

    // SIR_811_DODA_CONTENEDORES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir811DodaContenedoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir811DodaContenedore>
    {
        public SIR_Sir811DodaContenedoreConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir811DodaContenedoreConfiguration(string schema)
        {
            ToTable("SIR_811_DODA_CONTENEDORES", schema);
            HasKey(x => x.NIdDodaCont811);

            Property(x => x.NIdDodaCont811).HasColumnName(@"nIdDODACont811").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdDoda809).HasColumnName(@"nIdDODA809").HasColumnType("int").IsRequired();
            Property(x => x.SContenedor).HasColumnName(@"sContenedor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.SIR_Sir809Doda).WithMany(b => b.SIR_Sir811DodaContenedore).HasForeignKey(c => c.NIdDoda809).WillCascadeOnDelete(false); // FK_SIR_811_DODA_CONTENEDORES_SIR_809_DODA
        }
    }

}
// </auto-generated>