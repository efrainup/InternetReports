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

    // SIRA_03_COLORES_MONITORES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira03ColoresMonitoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira03ColoresMonitore>
    {
        public SIRAdmin_Sira03ColoresMonitoreConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira03ColoresMonitoreConfiguration(string schema)
        {
            ToTable("SIRA_03_COLORES_MONITORES", schema);
            HasKey(x => x.NIdColorMonitor03);

            Property(x => x.NIdColorMonitor03).HasColumnName(@"nIdColorMonitor03").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdNodo).HasColumnName(@"nIdNodo").HasColumnType("int").IsRequired();
            Property(x => x.SColorVigencia).HasColumnName(@"sColorVigencia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SColorProximo).HasColumnName(@"sColorProximo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SColorVencido).HasColumnName(@"sColorVencido").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);

            // Foreign keys
            HasRequired(a => a.SisRecurso).WithMany(b => b.SIRAdmin_Sira03ColoresMonitore).HasForeignKey(c => c.NIdNodo).WillCascadeOnDelete(false); // FK_SIRA_03_COLORES_MONITORES_sis_recursos
        }
    }

}
// </auto-generated>