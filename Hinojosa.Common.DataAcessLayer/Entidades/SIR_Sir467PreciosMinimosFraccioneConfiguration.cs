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

    // SIR_467_PRECIOS_MINIMOS_FRACCIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir467PreciosMinimosFraccioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir467PreciosMinimosFraccione>
    {
        public SIR_Sir467PreciosMinimosFraccioneConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir467PreciosMinimosFraccioneConfiguration(string schema)
        {
            ToTable("SIR_467_PRECIOS_MINIMOS_FRACCIONES", schema);
            HasKey(x => x.NIdFracc167);

            Property(x => x.NIdFracc167).HasColumnName(@"nIdFracc167").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NPrecioMinimo).HasColumnName(@"nPrecioMinimo").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("datetime").IsOptional();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir167FraccionesArancelaria).WithOptional(b => b.SIR_Sir467PreciosMinimosFraccione).WillCascadeOnDelete(false); // FK_SIR_467_PRECIOS_MINIMOS_FRACCIONES_SIR_167_FRACCIONES_ARANCELARIAS
        }
    }

}
// </auto-generated>
