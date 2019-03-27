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

    // SIR_364_CUENTAS_ADUAN_GARANTIA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir364CuentasAduanGarantiaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir364CuentasAduanGarantia>
    {
        public SIR_Sir364CuentasAduanGarantiaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir364CuentasAduanGarantiaConfiguration(string schema)
        {
            ToTable("SIR_364_CUENTAS_ADUAN_GARANTIA", schema);
            HasKey(x => x.NIdCuentaAdu364);

            Property(x => x.NIdCuentaAdu364).HasColumnName(@"nIdCuentaAdu364").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdPedimento149).HasColumnName(@"nIdPedimento149").HasColumnType("int").IsOptional();
            Property(x => x.NIdTipoGarantia77).HasColumnName(@"nIdTipoGarantia77").HasColumnType("int").IsOptional();
            Property(x => x.SFolioConstancia).HasColumnName(@"sFolioConstancia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(17);
            Property(x => x.SNoContrato).HasColumnName(@"sNoContrato").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(17);
            Property(x => x.DConstancia).HasColumnName(@"dConstancia").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NTipodeCuenta).HasColumnName(@"nTipodeCuenta").HasColumnType("tinyint").IsOptional();
            Property(x => x.NIdEmiCta33).HasColumnName(@"nIdEmiCta33").HasColumnType("int").IsOptional();
            Property(x => x.NValorUnitario).HasColumnName(@"nValorUnitario").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.NTotalGarantia).HasColumnName(@"nTotalGarantia").HasColumnType("decimal").IsOptional().HasPrecision(14,2);
            Property(x => x.NCantidadUm).HasColumnName(@"nCantidadUM").HasColumnType("decimal").IsOptional().HasPrecision(14,4);
            Property(x => x.NTitulos).HasColumnName(@"nTitulos").HasColumnType("decimal").IsOptional().HasPrecision(11,4);
            Property(x => x.NIdFacPartAgrupada100).HasColumnName(@"nIdFacPartAgrupada100").HasColumnType("int").IsOptional();
            Property(x => x.DCalculoAuto).HasColumnName(@"dCalculoAuto").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir100FacPartAgrupada).WithMany(b => b.SIR_Sir364CuentasAduanGarantia).HasForeignKey(c => c.NIdFacPartAgrupada100).WillCascadeOnDelete(false); // FK_SIR_364_CUENTAS_ADUAN_GARANTIA_SIR_100_FAC_PART_AGRUPADAS
            HasOptional(a => a.SIR_Sir149Pedimento).WithMany(b => b.SIR_Sir364CuentasAduanGarantia).HasForeignKey(c => c.NIdPedimento149).WillCascadeOnDelete(false); // FK_SIR_364_CUENTAS_ADUAN_GARANTIA_SIR_149_PEDIMENTO
            HasOptional(a => a.SIR_Sir33EmisorasCtasAduanera).WithMany(b => b.SIR_Sir364CuentasAduanGarantia).HasForeignKey(c => c.NIdEmiCta33).WillCascadeOnDelete(false); // FK_SIR_364_CUENTAS_ADUAN_GARANTIA_SIR_33_EMISORAS_CTAS_ADUANERAS
            HasOptional(a => a.SIR_Sir77TiposGarantia).WithMany(b => b.SIR_Sir364CuentasAduanGarantia).HasForeignKey(c => c.NIdTipoGarantia77).WillCascadeOnDelete(false); // FK_SIR_364_CUENTAS_ADUAN_GARANTIA_SIR_77_TIPOS_GARANTIA
        }
    }

}
// </auto-generated>