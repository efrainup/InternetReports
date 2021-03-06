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

    // SIRA_32_CONF_ARCH_DETALLES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira32ConfArchDetalleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira32ConfArchDetalle>
    {
        public SIRAdmin_Sira32ConfArchDetalleConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira32ConfArchDetalleConfiguration(string schema)
        {
            ToTable("SIRA_32_CONF_ARCH_DETALLES", schema);
            HasKey(x => x.NIdConfArchDet32);

            Property(x => x.NIdConfArchDet32).HasColumnName(@"nIdConfArchDet32").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdConfArchFac31).HasColumnName(@"nIdConfArchFac31").HasColumnType("int").IsRequired();
            Property(x => x.SCampo).HasColumnName(@"sCampo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SBusqueda).HasColumnName(@"sBusqueda").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NLongitud).HasColumnName(@"nLongitud").HasColumnType("int").IsOptional();
            Property(x => x.NHoja).HasColumnName(@"nHoja").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NTipoLinea).HasColumnName(@"nTipoLinea").HasColumnType("tinyint").IsOptional();
            Property(x => x.NNumOrden).HasColumnName(@"nNumOrden").HasColumnType("int").IsOptional();
            Property(x => x.SFormato).HasColumnName(@"sFormato").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SDelimitador).HasColumnName(@"sDelimitador").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.BObligatorio).HasColumnName(@"bObligatorio").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIRAdmin_Sira31ConfArchFactura).WithMany(b => b.SIRAdmin_Sira32ConfArchDetalle).HasForeignKey(c => c.NIdConfArchFac31).WillCascadeOnDelete(false); // FK_SIRA_32_CONF_ARCH_DETALLES_SIRA_32_CONF_ARCH_DETALLES
        }
    }

}
// </auto-generated>
