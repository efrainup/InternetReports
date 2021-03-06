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

    // SIR_648_TIPOS_PROGRAMACION_SALIDAS_RT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir648TiposProgramacionSalidasRtConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir648TiposProgramacionSalidasRt>
    {
        public SIR_Sir648TiposProgramacionSalidasRtConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir648TiposProgramacionSalidasRtConfiguration(string schema)
        {
            ToTable("SIR_648_TIPOS_PROGRAMACION_SALIDAS_RT", schema);
            HasKey(x => x.NIdTipoProgramacion648);

            Property(x => x.NIdTipoProgramacion648).HasColumnName(@"nIdTipoProgramacion648").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BPermiteExcesoPeso).HasColumnName(@"bPermiteExcesoPeso").HasColumnType("bit").IsOptional();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsOptional();
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("int").IsOptional();
            Property(x => x.BValidacionLectora).HasColumnName(@"bValidacionLectora").HasColumnType("bit").IsOptional();
            Property(x => x.NValidacionesRequeridas).HasColumnName(@"nValidacionesRequeridas").HasColumnType("int").IsOptional();
            Property(x => x.BDimensiones).HasColumnName(@"bDimensiones").HasColumnType("bit").IsOptional();
            Property(x => x.BConsolidado).HasColumnName(@"bConsolidado").HasColumnType("bit").IsOptional();
        }
    }

}
// </auto-generated>
