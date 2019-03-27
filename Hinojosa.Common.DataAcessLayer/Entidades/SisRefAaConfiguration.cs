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

    // Sis_Ref_AA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRefAaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisRefAa>
    {
        public SisRefAaConfiguration()
            : this("dbo")
        {
        }

        public SisRefAaConfiguration(string schema)
        {
            ToTable("Sis_Ref_AA", schema);
            HasKey(x => x.IdRef);

            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Referencia).HasColumnName(@"referencia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.Consecutivo).HasColumnName(@"consecutivo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.NoPedimento).HasColumnName(@"no_pedimento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(7);
            Property(x => x.TipoOperacion).HasColumnName(@"tipo_operacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(11);
            Property(x => x.FechaEntradaPresentacion).HasColumnName(@"fecha_entrada_presentacion").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaPago).HasColumnName(@"fecha_pago").HasColumnType("datetime").IsRequired();
            Property(x => x.ClavePedto).HasColumnName(@"clave_pedto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.DescripcionClavePedto).HasColumnName(@"descripcion_clave_pedto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Regimen).HasColumnName(@"regimen").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.PaisOrigenDestino).HasColumnName(@"pais_origen_destino").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.NombrePaisOrigenDestino).HasColumnName(@"nombre_pais_origen_destino").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.PaisVendedorComprador).HasColumnName(@"pais_vendedor_comprador").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.NombrePaisVendedorComprador).HasColumnName(@"nombre_pais_vendedor_comprador").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.AduanaSeccion).HasColumnName(@"aduana_seccion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.NombreAduanaEntrada).HasColumnName(@"nombre_aduana_entrada").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.NombreAduanaDespacho).HasColumnName(@"nombre_aduana_despacho").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Cliente).HasColumnName(@"cliente").HasColumnType("float").IsRequired();
            Property(x => x.NombreCliente).HasColumnName(@"nombre_cliente").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Proveedor).HasColumnName(@"proveedor").HasColumnType("float").IsRequired();
            Property(x => x.NombreProveedor).HasColumnName(@"nombre_proveedor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.RegistroBuque).HasColumnName(@"registro_buque").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(9);
            Property(x => x.NombreBuque).HasColumnName(@"nombre_buque").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.BanderaBuque).HasColumnName(@"bandera_buque").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.MedioTransporte).HasColumnName(@"medio_transporte").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PesoBruto).HasColumnName(@"peso_bruto").HasColumnType("float").IsRequired();
            Property(x => x.TotalBultos).HasColumnName(@"total_bultos").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(119);
            Property(x => x.TipoCambio).HasColumnName(@"tipo_cambio").HasColumnType("float").IsRequired();
            Property(x => x.FactorParidad).HasColumnName(@"factor_paridad").HasColumnType("float").IsRequired();
            Property(x => x.PaisFactorParidad).HasColumnName(@"pais_factor_paridad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Incoterm).HasColumnName(@"incoterm").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.ValorFacturaMonedaExtranjera).HasColumnName(@"valor_factura_moneda_extranjera").HasColumnType("float").IsRequired();
            Property(x => x.Embalajes).HasColumnName(@"embalajes").HasColumnType("float").IsRequired();
            Property(x => x.Fletes).HasColumnName(@"fletes").HasColumnType("float").IsRequired();
            Property(x => x.Seguros).HasColumnName(@"seguros").HasColumnType("float").IsRequired();
            Property(x => x.Otros).HasColumnName(@"otros").HasColumnType("float").IsRequired();
            Property(x => x.Decrementables).HasColumnName(@"decrementables").HasColumnType("float").IsRequired();
            Property(x => x.ImporteDtaFp1).HasColumnName(@"importe_dta_fp1").HasColumnType("float").IsRequired();
            Property(x => x.ImporteDtaFp2).HasColumnName(@"importe_dta_fp2").HasColumnType("float").IsRequired();
            Property(x => x.ValorComercialMonedaExtranjera).HasColumnName(@"valor_comercial_moneda_extranjera").HasColumnType("float").IsRequired();
            Property(x => x.FirmaAduana).HasColumnName(@"firma_aduana").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Destinarios).HasColumnName(@"destinarios").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(254);
            Property(x => x.FechaReexpedicion).HasColumnName(@"fecha_reexpedicion").HasColumnType("datetime").IsRequired();
            Property(x => x.Transportista).HasColumnName(@"transportista").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(254);
            Property(x => x.Naviera).HasColumnName(@"naviera").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Conocimiento).HasColumnName(@"conocimiento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.FechaReconocimiento1).HasColumnName(@"fecha_reconocimiento1").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaReconocimiento2).HasColumnName(@"fecha_reconocimiento2").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaDesaduanamiento).HasColumnName(@"fecha_desaduanamiento").HasColumnType("datetime").IsRequired();
            Property(x => x.Contenedores).HasColumnName(@"contenedores").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(254);
            Property(x => x.Mercancia).HasColumnName(@"mercancia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(254);
            Property(x => x.ValorFacturaMonedaDolares).HasColumnName(@"valor_factura_moneda_dolares").HasColumnType("float").IsRequired();
            Property(x => x.ValorFacturaMonedaNacional).HasColumnName(@"valor_factura_moneda_nacional").HasColumnType("float").IsRequired();
            Property(x => x.Facturas).HasColumnName(@"facturas").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(254);
            Property(x => x.Pedido).HasColumnName(@"pedido").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.ValorComercialDolares).HasColumnName(@"valor_comercial_dolares").HasColumnType("float").IsRequired();
            Property(x => x.ValorComercialPesosmx).HasColumnName(@"valor_comercial_pesosmx").HasColumnType("float").IsRequired();
            Property(x => x.ValorAduana).HasColumnName(@"valor_aduana").HasColumnType("float").IsRequired();
            Property(x => x.ImporteIeps).HasColumnName(@"importe_ieps").HasColumnType("float").IsRequired();
            Property(x => x.ImporteCuotaCompensatoria).HasColumnName(@"importe_cuota_compensatoria").HasColumnType("float").IsRequired();
            Property(x => x.ImporteAladi).HasColumnName(@"importe_aladi").HasColumnType("float").IsRequired();
            Property(x => x.TasaIva).HasColumnName(@"tasa_iva").HasColumnType("float").IsRequired();
            Property(x => x.FormaPagoIva1).HasColumnName(@"forma_pago_iva1").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.ImporteIva1).HasColumnName(@"importe_iva1").HasColumnType("float").IsRequired();
            Property(x => x.FormaPagoIva2).HasColumnName(@"forma_pago_iva2").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.ImporteIva2).HasColumnName(@"importe_iva2").HasColumnType("float").IsRequired();
            Property(x => x.TasaAdv).HasColumnName(@"tasa_adv").HasColumnType("float").IsRequired();
            Property(x => x.FormaPagoAdv1).HasColumnName(@"forma_pago_adv1").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.ImporteAdv1).HasColumnName(@"importe_adv1").HasColumnType("float").IsRequired();
            Property(x => x.Permisos).HasColumnName(@"permisos").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(254);
            Property(x => x.TotalEfectivo).HasColumnName(@"total_efectivo").HasColumnType("float").IsRequired();
            Property(x => x.TotalOtros).HasColumnName(@"total_otros").HasColumnType("float").IsRequired();
            Property(x => x.TotalPagado).HasColumnName(@"total_pagado").HasColumnType("float").IsRequired();
            Property(x => x.PrecioUnitario).HasColumnName(@"precio_unitario").HasColumnType("float").IsRequired();
            Property(x => x.Vinculacion).HasColumnName(@"vinculacion").HasColumnType("float").IsRequired();
            Property(x => x.UnidadComercializacion).HasColumnName(@"unidad_comercializacion").HasColumnType("float").IsRequired();
            Property(x => x.CantidadUnidadComercializacion).HasColumnName(@"cantidad_unidad_comercializacion").HasColumnType("float").IsRequired();
            Property(x => x.Fracciones).HasColumnName(@"fracciones").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(254);
            Property(x => x.NoPedimentoRectificado).HasColumnName(@"no_pedimento_rectificado").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Terminal).HasColumnName(@"terminal").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Carrier).HasColumnName(@"carrier").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.PuertoOrigen).HasColumnName(@"puerto_origen").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Ctagastos).HasColumnName(@"ctagastos").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Foliocta).HasColumnName(@"foliocta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Fechacta).HasColumnName(@"fechacta").HasColumnType("datetime").IsRequired();
            Property(x => x.Totcont).HasColumnName(@"totcont").HasColumnType("float").IsRequired();
            Property(x => x.Tipocont).HasColumnName(@"tipocont").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pedidocta).HasColumnName(@"pedidocta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Dtacta).HasColumnName(@"dtacta").HasColumnType("float").IsRequired();
            Property(x => x.Muellajes).HasColumnName(@"muellajes").HasColumnType("float").IsRequired();
            Property(x => x.Maniobras).HasColumnName(@"maniobras").HasColumnType("float").IsRequired();
            Property(x => x.Almacenaje).HasColumnName(@"almacenaje").HasColumnType("float").IsRequired();
            Property(x => x.Prevalida).HasColumnName(@"prevalida").HasColumnType("float").IsRequired();
            Property(x => x.Tramrectif).HasColumnName(@"tramrectif").HasColumnType("float").IsRequired();
            Property(x => x.Certorig).HasColumnName(@"certorig").HasColumnType("float").IsRequired();
            Property(x => x.Gtscompr).HasColumnName(@"gtscompr").HasColumnType("float").IsRequired();
            Property(x => x.Servcompl).HasColumnName(@"servcompl").HasColumnType("float").IsRequired();
            Property(x => x.Otrosgts).HasColumnName(@"otrosgts").HasColumnType("float").IsRequired();
            Property(x => x.Gtsrecol).HasColumnName(@"gtsrecol").HasColumnType("float").IsRequired();
            Property(x => x.Basehon).HasColumnName(@"basehon").HasColumnType("float").IsRequired();
            Property(x => x.Honorarios).HasColumnName(@"honorarios").HasColumnType("float").IsRequired();
            Property(x => x.Hontot).HasColumnName(@"hontot").HasColumnType("float").IsRequired();
            Property(x => x.Honporcont).HasColumnName(@"honporcont").HasColumnType("float").IsRequired();
            Property(x => x.Honpordesp).HasColumnName(@"honpordesp").HasColumnType("float").IsRequired();
            Property(x => x.Honporcamn).HasColumnName(@"honporcamn").HasColumnType("float").IsRequired();
            Property(x => x.Sitbanc).HasColumnName(@"sitbanc").HasColumnType("float").IsRequired();
            Property(x => x.Erogacion).HasColumnName(@"erogacion").HasColumnType("float").IsRequired();
            Property(x => x.Baseiva).HasColumnName(@"baseiva").HasColumnType("float").IsRequired();
            Property(x => x.Ivacta).HasColumnName(@"ivacta").HasColumnType("float").IsRequired();
            Property(x => x.Ivagastos).HasColumnName(@"ivagastos").HasColumnType("float").IsRequired();
            Property(x => x.Descant).HasColumnName(@"descant").HasColumnType("float").IsRequired();
            Property(x => x.Anticipo).HasColumnName(@"anticipo").HasColumnType("float").IsRequired();
            Property(x => x.Subtotal).HasColumnName(@"subtotal").HasColumnType("float").IsRequired();
            Property(x => x.Totalcta).HasColumnName(@"totalcta").HasColumnType("float").IsRequired();
            Property(x => x.Tccta).HasColumnName(@"tccta").HasColumnType("float").IsRequired();
            Property(x => x.Sdofavor).HasColumnName(@"sdofavor").HasColumnType("float").IsRequired();
            Property(x => x.Sdopagar).HasColumnName(@"sdopagar").HasColumnType("float").IsRequired();
            Property(x => x.Observ).HasColumnName(@"observ").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Fechasolic).HasColumnName(@"fechasolic").HasColumnType("datetime").IsRequired();
            Property(x => x.Fechaelab).HasColumnName(@"fechaelab").HasColumnType("datetime").IsRequired();
            Property(x => x.Pagoimptos).HasColumnName(@"pagoimptos").HasColumnType("float").IsRequired();
            Property(x => x.Plaza).HasColumnName(@"plaza").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Observdah).HasColumnName(@"observdah").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Fechaot).HasColumnName(@"fechaot").HasColumnType("datetime").IsRequired();
            Property(x => x.Horaot).HasColumnName(@"horaot").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Fechatc).HasColumnName(@"fechatc").HasColumnType("datetime").IsRequired();
            Property(x => x.Horatc).HasColumnName(@"horatc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Fechart).HasColumnName(@"fechart").HasColumnType("datetime").IsRequired();
            Property(x => x.Transnl).HasColumnName(@"transnl").HasColumnType("float").IsRequired();
            Property(x => x.Diasfptc).HasColumnName(@"diasfptc").HasColumnType("float").IsRequired();
            Property(x => x.Diasfpot).HasColumnName(@"diasfpot").HasColumnType("float").IsRequired();
            Property(x => x.Diasottc).HasColumnName(@"diasottc").HasColumnType("float").IsRequired();
            Property(x => x.Diastcrt).HasColumnName(@"diastcrt").HasColumnType("float").IsRequired();
            Property(x => x.Terminalcc).HasColumnName(@"terminalcc").HasColumnType("float").IsRequired();
            Property(x => x.Carriercc).HasColumnName(@"carriercc").HasColumnType("float").IsRequired();
            Property(x => x.Ptoorigen).HasColumnName(@"ptoorigen").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Firmaelec).HasColumnName(@"firmaelec").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Cvetar).HasColumnName(@"cvetar").HasColumnType("float").IsRequired();
        }
    }

}
// </auto-generated>