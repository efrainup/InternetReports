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

    // SIR_313_PROG_DESP_OBSERVACIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir313ProgDespObservacioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir313ProgDespObservacione>
    {
        public SIR_Sir313ProgDespObservacioneConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir313ProgDespObservacioneConfiguration(string schema)
        {
            ToTable("SIR_313_PROG_DESP_OBSERVACIONES", schema);
            HasKey(x => x.NIdDespObs313);

            Property(x => x.NIdDespObs313).HasColumnName(@"nIdDespObs313").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdProgDesp134).HasColumnName(@"nIdProgDesp134").HasColumnType("int").IsRequired();
            Property(x => x.SObservacion).HasColumnName(@"sObservacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir313ProgDespObservacione).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_313_PROG_DESP_OBSERVACIONES_cat_usr
            HasRequired(a => a.SIR_Sir134ProgramacionDespacho).WithMany(b => b.SIR_Sir313ProgDespObservacione).HasForeignKey(c => c.NIdProgDesp134).WillCascadeOnDelete(false); // FK_SIR_313_PROG_DESP_OBSERVACIONES_SIR_134_PROGRAMACION_DESPACHOS
        }
    }

}
// </auto-generated>
