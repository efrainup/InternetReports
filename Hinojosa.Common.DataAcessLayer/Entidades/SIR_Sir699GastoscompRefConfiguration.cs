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

    // SIR_699_GASTOSCOMP_REF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir699GastoscompRefConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir699GastoscompRef>
    {
        public SIR_Sir699GastoscompRefConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir699GastoscompRefConfiguration(string schema)
        {
            ToTable("SIR_699_GASTOSCOMP_REF", schema);
            HasKey(x => x.NIdGastosComp699);

            Property(x => x.NIdGastosComp699).HasColumnName(@"nIdGastosComp699").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired();
            Property(x => x.NIdCatalogoServicio642).HasColumnName(@"nIdCatalogoServicio642").HasColumnType("int").IsRequired();
            Property(x => x.NImporte).HasColumnName(@"nImporte").HasColumnType("decimal").IsRequired().HasPrecision(15,2);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsuarioEdicion).HasColumnName(@"nIdUsuarioEdicion").HasColumnType("int").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir699GastoscompRef).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_699_GASTOSCOMP_REF_SIR_60_REFERENCIAS
            HasRequired(a => a.SIR_Sir642CatalogoServicio).WithMany(b => b.SIR_Sir699GastoscompRef).HasForeignKey(c => c.NIdCatalogoServicio642).WillCascadeOnDelete(false); // FK_SIR_699_GASTOSCOMP_REF_SIR_642_CATALOGO_SERVICIOS
        }
    }

}
// </auto-generated>
