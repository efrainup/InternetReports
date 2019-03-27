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

    // SIR_792_PLANTAS_ENTRADA_BODEGA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir792PlantasEntradaBodegaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir792PlantasEntradaBodega>
    {
        public SIR_Sir792PlantasEntradaBodegaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir792PlantasEntradaBodegaConfiguration(string schema)
        {
            ToTable("SIR_792_PLANTAS_ENTRADA_BODEGA", schema);
            HasKey(x => x.NIdPlantaBodega792);

            Property(x => x.NIdPlantaBodega792).HasColumnName(@"nIdPlantaBodega792").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("int").IsRequired();
            Property(x => x.SNombreCorto).HasColumnName(@"sNombreCorto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8);
            Property(x => x.SPlanta).HasColumnName(@"sPlanta").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(400);
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
