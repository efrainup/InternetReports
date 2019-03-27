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

    // SIR_47_CONTENEDORES_TARIFAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir47ContenedoresTarifaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir47ContenedoresTarifa>
    {
        public SIR_Sir47ContenedoresTarifaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir47ContenedoresTarifaConfiguration(string schema)
        {
            ToTable("SIR_47_CONTENEDORES_TARIFAS", schema);
            HasKey(x => x.NIdContTarifa47);

            Property(x => x.NIdContTarifa47).HasColumnName(@"nIdContTarifa47").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdContenedor76).HasColumnName(@"nIdContenedor76").HasColumnType("int").IsRequired();
            Property(x => x.NConsecPlazo).HasColumnName(@"nConsecPlazo").HasColumnType("tinyint").IsRequired();
            Property(x => x.NPlazoDias).HasColumnName(@"nPlazoDias").HasColumnType("smallint").IsRequired();
            Property(x => x.NValorPlazo).HasColumnName(@"nValorPlazo").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir47ContenedoresTarifa).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_47_CONTENEDORES_TARIFAS_cat_usr_ed
            HasRequired(a => a.SIR_Sir76Contenedore).WithMany(b => b.SIR_Sir47ContenedoresTarifa).HasForeignKey(c => c.NIdContenedor76); // FK_SIR_47_CONTEDORES_TARIFAS_SIR_76_CONTENEDORES
        }
    }

}
// </auto-generated>