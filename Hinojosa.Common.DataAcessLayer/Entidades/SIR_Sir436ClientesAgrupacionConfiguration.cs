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

    // SIR_436_CLIENTES_AGRUPACION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir436ClientesAgrupacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir436ClientesAgrupacion>
    {
        public SIR_Sir436ClientesAgrupacionConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir436ClientesAgrupacionConfiguration(string schema)
        {
            ToTable("SIR_436_CLIENTES_AGRUPACION", schema);
            HasKey(x => x.NIdClienteAgrupacion436);

            Property(x => x.NIdClienteAgrupacion436).HasColumnName(@"nIdClienteAgrupacion436").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsRequired();
            Property(x => x.SCriterioAgrupacion).HasColumnName(@"sCriterioAgrupacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsOptional();
            Property(x => x.SModoUnion).HasColumnName(@"sModoUnion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.SLimitadorDesc).HasColumnName(@"sLimitadorDesc").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.SLimitadorObs).HasColumnName(@"sLimitadorObs").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.BAgrupacionUva).HasColumnName(@"bAgrupacionUVA").HasColumnType("bit").IsOptional();
            Property(x => x.BAgrupacionNyce).HasColumnName(@"bAgrupacionNYCE").HasColumnType("bit").IsOptional();
            Property(x => x.NCantidadMinimaAgrupacion).HasColumnName(@"nCantidadMinimaAgrupacion").HasColumnType("int").IsOptional();
            Property(x => x.BPartidasAgrupadasEnPedimento).HasColumnName(@"bPartidasAgrupadasEnPedimento").HasColumnType("bit").IsOptional();
            Property(x => x.BIdentificadoresPermisos).HasColumnName(@"bIdentificadoresPermisos").HasColumnType("bit").IsOptional();
            Property(x => x.BAgrupacionMedicos).HasColumnName(@"bAgrupacionMedicos").HasColumnType("bit").IsOptional();
            Property(x => x.BNafta).HasColumnName(@"bNafta").HasColumnType("bit").IsOptional();
            Property(x => x.BAgrupacionTipoUsoMercancia).HasColumnName(@"bAgrupacionTipoUsoMercancia").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasRequired(a => a.CatCliente).WithMany(b => b.SIR_Sir436ClientesAgrupacion).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_436_CLIENTES_AGRUPACION_cat_clientes
        }
    }

}
// </auto-generated>
