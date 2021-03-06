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

    // SIR_48_NAVIERAS_TARIFAS_PLAZOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir48NavierasTarifasPlazoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir48NavierasTarifasPlazo>
    {
        public SIR_Sir48NavierasTarifasPlazoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir48NavierasTarifasPlazoConfiguration(string schema)
        {
            ToTable("SIR_48_NAVIERAS_TARIFAS_PLAZOS", schema);
            HasKey(x => x.NIdNavTarPla48);

            Property(x => x.NIdNavTarPla48).HasColumnName(@"nIdNavTarPla48").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdNavTar36).HasColumnName(@"nIdNavTar36").HasColumnType("int").IsRequired();
            Property(x => x.NConsecPlazo).HasColumnName(@"nConsecPlazo").HasColumnType("tinyint").IsRequired();
            Property(x => x.NPlazoDias).HasColumnName(@"nPlazoDias").HasColumnType("smallint").IsRequired();
            Property(x => x.NValorPlazo).HasColumnName(@"nValorPlazo").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();
            Property(x => x.NRegistro).HasColumnName(@"nRegistro").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir48NavierasTarifasPlazo).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_48_NAVIERAS_TARIFAS_PLAZOS_cat_usr_ed
            HasRequired(a => a.SIR_Sir36NavierasTarifa).WithMany(b => b.SIR_Sir48NavierasTarifasPlazo).HasForeignKey(c => c.NIdNavTar36); // FK_ SIR_48_NAVIERAS_TARIFAS_PLAZOS_SIR_36_NAVIERAS_TARIFAS
        }
    }

}
// </auto-generated>
