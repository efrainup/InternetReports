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

    // SIR_36_NAVIERAS_TARIFAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir36NavierasTarifaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir36NavierasTarifa>
    {
        public SIR_Sir36NavierasTarifaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir36NavierasTarifaConfiguration(string schema)
        {
            ToTable("SIR_36_NAVIERAS_TARIFAS", schema);
            HasKey(x => x.NIdNavTar36);

            Property(x => x.NIdNavTar36).HasColumnName(@"nIdNavTar36").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdNaviera).HasColumnName(@"nIdNaviera").HasColumnType("int").IsRequired();
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsOptional();
            Property(x => x.NIdTipoCont09).HasColumnName(@"nIdTipoCont09").HasColumnType("int").IsRequired();
            Property(x => x.NDiasLibres).HasColumnName(@"nDiasLibres").HasColumnType("smallint").IsRequired();
            Property(x => x.NClaveAgrupa).HasColumnName(@"nClaveAgrupa").HasColumnType("int").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.DFechaCreacion).HasColumnName(@"dFechaCreacion").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();
            Property(x => x.NRegistro).HasColumnName(@"nRegistro").HasColumnType("int").IsRequired();
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.CatCliente).WithMany(b => b.SIR_Sir36NavierasTarifa).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_36_NAVIERAS_TARIFAS_cat_clientes
            HasOptional(a => a.SIR_Sir09TiposContenedor).WithMany(b => b.SIR_Sir36NavierasTarifa).HasForeignKey(c => c.NIdTipoCont09).WillCascadeOnDelete(false); // FK_SIR_36_NAVIERAS_TARIFAS_SIR_09_TIPOS_CONTENEDOR
            HasOptional(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir36NavierasTarifa).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_36_NAVIERAS_TARIFAS_SIR_71_SUCURSAL_PATENTE_ADUANA
            HasRequired(a => a.CatProv).WithMany(b => b.SIR_Sir36NavierasTarifa).HasForeignKey(c => c.NIdNaviera).WillCascadeOnDelete(false); // FK_SIR_36_NAVIERAS_TARIFAS_cat_prov
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir36NavierasTarifa).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_36_NAVIERAS_TARIFAS_cat_usr_ed
        }
    }

}
// </auto-generated>
