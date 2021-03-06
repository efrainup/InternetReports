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

    // SIR_350_BASE_GRAVABLE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir350BaseGravableConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir350BaseGravable>
    {
        public SIR_Sir350BaseGravableConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir350BaseGravableConfiguration(string schema)
        {
            ToTable("SIR_350_BASE_GRAVABLE", schema);
            HasKey(x => new { x.NIdTiposImp30, x.NIdImpForm349, x.BActualiza });

            Property(x => x.NIdTiposImp30).HasColumnName(@"nIdTiposImp30").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdImpForm349).HasColumnName(@"nIdImpForm349").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BActualiza).HasColumnName(@"bActualiza").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.SIR_Sir30TiposImpuesto).WithMany(b => b.SIR_Sir350BaseGravable).HasForeignKey(c => c.NIdTiposImp30).WillCascadeOnDelete(false); // FK_SIR_350_BASE_GRAVABLE_SIR_30_TIPOS_IMPUESTOS
            HasRequired(a => a.SIR_Sir349ImpuestosFormula).WithMany(b => b.SIR_Sir350BaseGravable).HasForeignKey(c => c.NIdImpForm349).WillCascadeOnDelete(false); // FK_SIR_350_BASE_GRAVABLE_SIR_349_IMPUESTOS_FORMULAS
        }
    }

}
// </auto-generated>
