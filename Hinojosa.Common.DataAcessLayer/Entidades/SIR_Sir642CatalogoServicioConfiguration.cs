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

    // SIR_642_CATALOGO_SERVICIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir642CatalogoServicioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir642CatalogoServicio>
    {
        public SIR_Sir642CatalogoServicioConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir642CatalogoServicioConfiguration(string schema)
        {
            ToTable("SIR_642_CATALOGO_SERVICIOS", schema);
            HasKey(x => x.NIdCatalogoServicio642);

            Property(x => x.NIdCatalogoServicio642).HasColumnName(@"nIdCatalogoServicio642").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("int").IsRequired();
            Property(x => x.SServicio).HasColumnName(@"sServicio").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsRequired();
            Property(x => x.SGrupo).HasColumnName(@"sGrupo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SClaveAxapta).HasColumnName(@"sClaveAxapta").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BEsGastoCompl).HasColumnName(@"bEsGastoCompl").HasColumnType("bit").IsOptional();
            Property(x => x.BConsultaTarifaAxapta).HasColumnName(@"bConsultaTarifaAxapta").HasColumnType("bit").IsOptional();
        }
    }

}
// </auto-generated>