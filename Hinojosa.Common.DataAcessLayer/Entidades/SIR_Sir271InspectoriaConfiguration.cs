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

    // SIR_271_INSPECTORIAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir271InspectoriaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir271Inspectoria>
    {
        public SIR_Sir271InspectoriaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir271InspectoriaConfiguration(string schema)
        {
            ToTable("SIR_271_INSPECTORIAS", schema);
            HasKey(x => x.NIdInspec271);

            Property(x => x.NIdInspec271).HasColumnName(@"nIdInspec271").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("tinyint").IsRequired();
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.NIdEntidad).HasColumnName(@"nIdEntidad").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatEdo).WithMany(b => b.SIR_Sir271Inspectoria).HasForeignKey(c => c.NIdEntidad).WillCascadeOnDelete(false); // FK_SIR_271_INSPECTORIAS_cat_edos
        }
    }

}
// </auto-generated>