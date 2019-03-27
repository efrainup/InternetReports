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

    // SIR_123_COTIZACIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir123CotizacioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir123Cotizacione>
    {
        public SIR_Sir123CotizacioneConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir123CotizacioneConfiguration(string schema)
        {
            ToTable("SIR_123_COTIZACIONES", schema);
            HasKey(x => x.NIdCotizacion123);

            Property(x => x.NIdCotizacion123).HasColumnName(@"nIdCotizacion123").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NCotizacion).HasColumnName(@"nCotizacion").HasColumnType("int").IsRequired();
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsOptional();
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsOptional();
            Property(x => x.NIdTipoRef).HasColumnName(@"nIdTipoRef").HasColumnType("int").IsOptional();
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NTipoCotizacion).HasColumnName(@"nTipoCotizacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsOptional();
            Property(x => x.SContacto).HasColumnName(@"sContacto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NIdMoneda).HasColumnName(@"nIdMoneda").HasColumnType("int").IsOptional();
            Property(x => x.NTipoCambio).HasColumnName(@"nTipoCambio").HasColumnType("decimal").IsOptional().HasPrecision(14,5);
            Property(x => x.NIdTipoImpuesto).HasColumnName(@"nIdTipoImpuesto").HasColumnType("int").IsOptional();
            Property(x => x.NValorDta).HasColumnName(@"nValorDTA").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NImporteDta).HasColumnName(@"nImporteDTA").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NValorAdv).HasColumnName(@"nValorADV").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NImporteAdv).HasColumnName(@"nImporteADV").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NValorIeps).HasColumnName(@"nValorIEPS").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NImporteIeps).HasColumnName(@"nImporteIEPS").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NValorOtros).HasColumnName(@"nValorOtros").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NImporteOtros).HasColumnName(@"nImporteOtros").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NValorIva).HasColumnName(@"nValorIVA").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NImporteIva).HasColumnName(@"nImporteIVA").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NMciaAduana).HasColumnName(@"nMciaAduana").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NValorComercial).HasColumnName(@"nValorComercial").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NFletesSeguros).HasColumnName(@"nFletesSeguros").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NGastos).HasColumnName(@"nGastos").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NOtrosValores).HasColumnName(@"nOtrosValores").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NGastosDeducibles).HasColumnName(@"nGastosDeducibles").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NValorAduana).HasColumnName(@"nValorAduana").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NFactorAjuste).HasColumnName(@"nFactorAjuste").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NTotalCotizacion).HasColumnName(@"nTotalCotizacion").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("tinyint").IsRequired();
            Property(x => x.NIdClaveDocto28).HasColumnName(@"nIdClaveDocto28").HasColumnType("int").IsRequired();
            Property(x => x.NTipoCambioFinan).HasColumnName(@"nTipoCambioFinan").HasColumnType("decimal").IsOptional().HasPrecision(14,5);
            Property(x => x.NFactorProrrateo).HasColumnName(@"nFactorProrrateo").HasColumnType("decimal").IsOptional().HasPrecision(14,9);
            Property(x => x.SFacturas).HasColumnName(@"sFacturas").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BIvaAmericano).HasColumnName(@"bIVAAmericano").HasColumnType("bit").IsRequired();
            Property(x => x.BIncluirGastos).HasColumnName(@"bIncluirGastos").HasColumnType("bit").IsRequired();
            Property(x => x.NPorcIvaAme).HasColumnName(@"nPorcIVAAme").HasColumnType("decimal").IsOptional().HasPrecision(4,2);
            Property(x => x.BSumaImpEnGastos).HasColumnName(@"bSumaImpEnGastos").HasColumnType("bit").IsRequired();
            Property(x => x.SNombreCliente).HasColumnName(@"sNombreCliente").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(120);
            Property(x => x.DVigencia).HasColumnName(@"dVigencia").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SNumPedimento).HasColumnName(@"sNumPedimento").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(7);
            Property(x => x.NIdEntrada156).HasColumnName(@"nIdEntrada156").HasColumnType("int").IsOptional();
            Property(x => x.NIdTipRef32).HasColumnName(@"nIdTipRef32").HasColumnType("int").IsOptional();
            Property(x => x.NIdClie07).HasColumnName(@"nIdClie07").HasColumnType("int").IsOptional();
            Property(x => x.NIdMoneda03).HasColumnName(@"nIdMoneda03").HasColumnType("int").IsOptional();
            Property(x => x.NIdIva25).HasColumnName(@"nIdIva25").HasColumnType("int").IsOptional();
            Property(x => x.NIdReferenciaTemp).HasColumnName(@"nIdReferenciaTemp").HasColumnType("int").IsOptional();
            Property(x => x.NPorcIncTotal).HasColumnName(@"nPorcIncTotal").HasColumnType("decimal").IsOptional().HasPrecision(4,2);
            Property(x => x.NGastosExtranjero).HasColumnName(@"nGastosExtranjero").HasColumnType("decimal").IsOptional().HasPrecision(16,3);
            Property(x => x.SClaveTarifa).HasColumnName(@"sClaveTarifa").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SDescripcionTarifa).HasColumnName(@"sDescripcionTarifa").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NIdResponsable).HasColumnName(@"nIdResponsable").HasColumnType("int").IsOptional();
            Property(x => x.NIdResponsable02).HasColumnName(@"nIdResponsable02").HasColumnType("int").IsOptional();
            Property(x => x.SDatosMercancia).HasColumnName(@"sDatosMercancia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.STransporte).HasColumnName(@"sTransporte").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.SGuia).HasColumnName(@"sGuia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.NIncrementables).HasColumnName(@"nIncrementables").HasColumnType("decimal").IsOptional().HasPrecision(12,2);

            // Foreign keys
            HasOptional(a => a.Admin_Adminc03Moneda).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdMoneda03).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_ADMINC_03_MONEDAS
            HasOptional(a => a.Admin_Adminc07Cliente).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdClie07).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_ADMINC_07_CLIENTES
            HasOptional(a => a.Admin_Adminc25Iva).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdIva25).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_ADMINC_25_IVA
            HasOptional(a => a.Admin_Adminc32TiposReferencia).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdTipRef32).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_ADMINC_32_TIPOS_REFERENCIAS
            HasOptional(a => a.CatCliente).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_cat_clientes
            HasOptional(a => a.CatCodImp).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdTipoImpuesto).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_cat_cod_imp
            HasOptional(a => a.CatEmp).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdResponsable).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_cat_emp
            HasOptional(a => a.MonMoneda).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdMoneda).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_mon_monedas
            HasOptional(a => a.SIR_Sir156EntradasBodega).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdEntrada156).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_SIR_156_ENTRADAS_BODEGAS
            HasOptional(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_SIR_60_REFERENCIAS
            HasOptional(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_SIR_71_SUCURSAL_PATENTE_ADUANA
            HasOptional(a => a.SisTipRef).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdTipoRef).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_sis_tip_ref
            HasRequired(a => a.SIR_Sir28ClavesDocto).WithMany(b => b.SIR_Sir123Cotizacione).HasForeignKey(c => c.NIdClaveDocto28).WillCascadeOnDelete(false); // FK_SIR_123_COTIZACIONES_SIR_28_CLAVES_DOCTOS
        }
    }

}
// </auto-generated>
