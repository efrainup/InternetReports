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

    // SIR_793_RUTAS_ENTRADA_BODEGA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir793RutasEntradaBodegaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir793RutasEntradaBodega>
    {
        public SIR_Sir793RutasEntradaBodegaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir793RutasEntradaBodegaConfiguration(string schema)
        {
            ToTable("SIR_793_RUTAS_ENTRADA_BODEGA", schema);
            HasKey(x => x.NIdRutasBodega793);

            Property(x => x.NIdRutasBodega793).HasColumnName(@"nIdRutasBodega793").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(400);
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
