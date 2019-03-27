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

    // SIR_212_CRITERIOS_COBRO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir212CriteriosCobroConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir212CriteriosCobro>
    {
        public SIR_Sir212CriteriosCobroConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir212CriteriosCobroConfiguration(string schema)
        {
            ToTable("SIR_212_CRITERIOS_COBRO", schema);
            HasKey(x => x.NIdCriterio212);

            Property(x => x.NIdCriterio212).HasColumnName(@"nIdCriterio212").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdCriterioPadre).HasColumnName(@"nIdCriterioPadre").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.SNombre).HasColumnName(@"sNombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BDefault).HasColumnName(@"bDefault").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasOptional(a => a.SIR_Sir212CriteriosCobro1).WithMany(b => b.SIR_Sir212CriteriosCobro2).HasForeignKey(c => c.NIdCriterioPadre).WillCascadeOnDelete(false); // FK_SIR_212_CRITERIOS_COBRO_SIR_212_CRITERIOS_COBRO
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir212CriteriosCobro).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_212_CRITERIOS_COBRO_cat_usr
        }
    }

}
// </auto-generated>