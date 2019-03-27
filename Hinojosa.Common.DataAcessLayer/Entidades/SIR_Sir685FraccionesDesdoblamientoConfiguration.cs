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

    // SIR_685_ FRACCIONES_DESDOBLAMIENTO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir685FraccionesDesdoblamientoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir685FraccionesDesdoblamiento>
    {
        public SIR_Sir685FraccionesDesdoblamientoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir685FraccionesDesdoblamientoConfiguration(string schema)
        {
            ToTable("SIR_685_ FRACCIONES_DESDOBLAMIENTO", schema);
            HasKey(x => x.NIdFraccDesd685);

            Property(x => x.NIdFraccDesd685).HasColumnName(@"nIDFraccDesd685").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdFracc167).HasColumnName(@"nIdFracc167").HasColumnType("int").IsRequired();
            Property(x => x.SSubDivision).HasColumnName(@"sSubDivision").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.SCriterioDesdoblamiento).HasColumnName(@"sCriterioDesdoblamiento").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.NIdUsuarioEdicion).HasColumnName(@"nIDUsuarioEdicion").HasColumnType("int").IsOptional();
            Property(x => x.SModificaciones).HasColumnName(@"sModificaciones").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);

            // Foreign keys
            HasRequired(a => a.SIR_Sir167FraccionesArancelaria).WithMany(b => b.SIR_Sir685FraccionesDesdoblamiento).HasForeignKey(c => c.NIdFracc167).WillCascadeOnDelete(false); // SIR_685_ FRACCIONES_DESDOBLAMIENTO_SIR_167_FRACCIONES_ARANCELARIAS
        }
    }

}
// </auto-generated>
