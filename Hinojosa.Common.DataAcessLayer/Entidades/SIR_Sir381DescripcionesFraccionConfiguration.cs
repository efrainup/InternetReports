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

    // SIR_381_DESCRIPCIONES_FRACCION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir381DescripcionesFraccionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir381DescripcionesFraccion>
    {
        public SIR_Sir381DescripcionesFraccionConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir381DescripcionesFraccionConfiguration(string schema)
        {
            ToTable("SIR_381_DESCRIPCIONES_FRACCION", schema);
            HasKey(x => new { x.NIdFracc167, x.SDescripcion });

            Property(x => x.NIdFracc167).HasColumnName(@"nIdFracc167").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.SIR_Sir167FraccionesArancelaria).WithMany(b => b.SIR_Sir381DescripcionesFraccion).HasForeignKey(c => c.NIdFracc167).WillCascadeOnDelete(false); // FK_SIR_381_DESCRIPCIONES_FRACCION_SIR_167_FRACCIONES_ARANCELARIAS
        }
    }

}
// </auto-generated>