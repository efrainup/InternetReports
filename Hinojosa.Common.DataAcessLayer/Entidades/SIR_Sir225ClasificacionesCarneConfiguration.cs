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

    // SIR_225_CLASIFICACIONES_CARNE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir225ClasificacionesCarneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir225ClasificacionesCarne>
    {
        public SIR_Sir225ClasificacionesCarneConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir225ClasificacionesCarneConfiguration(string schema)
        {
            ToTable("SIR_225_CLASIFICACIONES_CARNE", schema);
            HasKey(x => x.NIdClasifCarne225);

            Property(x => x.NIdClasifCarne225).HasColumnName(@"nIdClasifCarne225").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("int").IsRequired();
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir225ClasificacionesCarne).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_225_CLASIFICACIONES_CARNE_cat_usr_ed
        }
    }

}
// </auto-generated>
