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

    // SIR_156_ENTRADAS_BODEGAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir156EntradasBodegaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir156EntradasBodega>
    {
        public SIR_Sir156EntradasBodegaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir156EntradasBodegaConfiguration(string schema)
        {
            ToTable("SIR_156_ENTRADAS_BODEGAS", schema);
            HasKey(x => x.NIdEntrada156);

            Property(x => x.NIdEntrada156).HasColumnName(@"nIdEntrada156").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DFechaEntrada).HasColumnName(@"dFechaEntrada").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsRequired();
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsRequired();
            Property(x => x.NIdTransportista).HasColumnName(@"nIdTransportista").HasColumnType("int").IsOptional();
            Property(x => x.NIdMedioTrans05).HasColumnName(@"nIdMedioTrans05").HasColumnType("int").IsOptional();
            Property(x => x.NTipoManejo).HasColumnName(@"nTipoManejo").HasColumnType("tinyint").IsRequired();
            Property(x => x.NTipoFlete).HasColumnName(@"nTipoFlete").HasColumnType("tinyint").IsRequired();
            Property(x => x.SNumeroCheque).HasColumnName(@"sNumeroCheque").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SCajaTractor).HasColumnName(@"sCajaTractor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NClaveCondMcia).HasColumnName(@"nClaveCondMcia").HasColumnType("tinyint").IsRequired();
            Property(x => x.NClaveEstadoMcia).HasColumnName(@"nClaveEstadoMcia").HasColumnType("tinyint").IsRequired();
            Property(x => x.BIsInBond).HasColumnName(@"bIsInBond").HasColumnType("bit").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.SBond).HasColumnName(@"sBond").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.BEsMatPeligroso).HasColumnName(@"bEsMatPeligroso").HasColumnType("bit").IsRequired();
            Property(x => x.NIdResponsable).HasColumnName(@"nIdResponsable").HasColumnType("int").IsRequired();
            Property(x => x.NIdProveedor).HasColumnName(@"nIdProveedor").HasColumnType("int").IsOptional();
            Property(x => x.SCod).HasColumnName(@"sCOD").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SChequeCod).HasColumnName(@"sChequeCOD").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SCvePedido).HasColumnName(@"sCvePedido").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SClaveEntrada).HasColumnName(@"sClaveEntrada").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SFacturas).HasColumnName(@"sFacturas").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SOrdenesClientes).HasColumnName(@"sOrdenesClientes").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SNumEconomico).HasColumnName(@"sNumEconomico").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SConsignatario).HasColumnName(@"sConsignatario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.SFacturarA).HasColumnName(@"sFacturarA").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.NIdAgenteAduanal).HasColumnName(@"nIdAgenteAduanal").HasColumnType("int").IsOptional();
            Property(x => x.SPackingList).HasColumnName(@"sPackingList").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.NIdAlmacen).HasColumnName(@"nIdAlmacen").HasColumnType("int").IsOptional();
            Property(x => x.BEsVirtual).HasColumnName(@"bEsVirtual").HasColumnType("bit").IsRequired();
            Property(x => x.NIdClienteBodega).HasColumnName(@"nIdClienteBodega").HasColumnType("int").IsOptional();
            Property(x => x.SPlacas).HasColumnName(@"sPlacas").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.NIdImex).HasColumnName(@"nIdIMEX").HasColumnType("int").IsOptional();
            Property(x => x.NIdRtConsolidado).HasColumnName(@"nIdRTConsolidado").HasColumnType("int").IsOptional();
            Property(x => x.BSinDespacho).HasColumnName(@"bSinDespacho").HasColumnType("bit").IsRequired();
            Property(x => x.BEsConsolidado).HasColumnName(@"bEsConsolidado").HasColumnType("bit").IsRequired();
            Property(x => x.DVencimiento).HasColumnName(@"dVencimiento").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.BConPrevio).HasColumnName(@"bConPrevio").HasColumnType("bit").IsRequired();
            Property(x => x.DVencimientoRecinto).HasColumnName(@"dVencimientoRecinto").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DUltimoVencimiento).HasColumnName(@"dUltimoVencimiento").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NPesoBruto).HasColumnName(@"nPesoBruto").HasColumnType("decimal").IsOptional().HasPrecision(21,10);
            Property(x => x.SDanada).HasColumnName(@"sDanada").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NFumigacion).HasColumnName(@"nFumigacion").HasColumnType("tinyint").IsOptional();
            Property(x => x.BEsCajaDirecta).HasColumnName(@"bEsCajaDirecta").HasColumnType("bit").IsRequired();
            Property(x => x.NIdTipoCont09).HasColumnName(@"nIdTipoCont09").HasColumnType("int").IsOptional();
            Property(x => x.NIdEjecutivo).HasColumnName(@"nIdEjecutivo").HasColumnType("int").IsOptional();
            Property(x => x.SNumeroInBond).HasColumnName(@"sNumeroInBond").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.STransportista).HasColumnName(@"sTransportista").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.SProveedor).HasColumnName(@"sProveedor").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NIdSeccion158).HasColumnName(@"nIdSeccion158").HasColumnType("int").IsOptional();
            Property(x => x.BUbicacionPorRt).HasColumnName(@"bUbicacionPorRT").HasColumnType("bit").IsOptional();
            Property(x => x.NTotalBultos).HasColumnName(@"nTotalBultos").HasColumnType("int").IsOptional();
            Property(x => x.NIdInbondTypes336).HasColumnName(@"nIdInbondTypes336").HasColumnType("int").IsOptional();
            Property(x => x.SEdoEmisorPlacas).HasColumnName(@"sEdoEmisorPlacas").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.BRefrigerado).HasColumnName(@"bRefrigerado").HasColumnType("bit").IsOptional();
            Property(x => x.BSobredimensionado).HasColumnName(@"bSobredimensionado").HasColumnType("bit").IsOptional();
            Property(x => x.BRegistroAnticipado).HasColumnName(@"bRegistroAnticipado").HasColumnType("bit").IsOptional();
            Property(x => x.BSobrepeso).HasColumnName(@"bSobrepeso").HasColumnType("bit").IsOptional();
            Property(x => x.BRequierePrevio).HasColumnName(@"bRequierePrevio").HasColumnType("bit").IsOptional();
            Property(x => x.NIdEmbarcador42).HasColumnName(@"nIdEmbarcador42").HasColumnType("int").IsOptional();
            Property(x => x.SEmbarcador).HasColumnName(@"sEmbarcador").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NIdMoneda03).HasColumnName(@"nIdMoneda03").HasColumnType("int").IsOptional();
            Property(x => x.SSellos).HasColumnName(@"sSellos").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.DCancelacion).HasColumnName(@"dCancelacion").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.STe).HasColumnName(@"sTE").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NTemperaturaEsperada).HasColumnName(@"nTemperaturaEsperada").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.SNivelDiesel).HasColumnName(@"sNivelDiesel").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NTipoServicio).HasColumnName(@"nTipoServicio").HasColumnType("tinyint").IsOptional();
            Property(x => x.NTemperaturaReal).HasColumnName(@"nTemperaturaReal").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.NLargoFtSobredimensionado).HasColumnName(@"nLargoFtSobredimensionado").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.NAnchoFtSobredimensionado).HasColumnName(@"nAnchoFtSobredimensionado").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.NAltoFtSobredimensionado).HasColumnName(@"nAltoFtSobredimensionado").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.NLargoMSobredimensionado).HasColumnName(@"nLargoMSobredimensionado").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.NAnchoMSobredimensionado).HasColumnName(@"nAnchoMSobredimensionado").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.NAltoMSobredimensionado).HasColumnName(@"nAltoMSobredimensionado").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.NIdSpaBodega71).HasColumnName(@"nIdSPABodega71").HasColumnType("int").IsOptional();
            Property(x => x.NIdSucursal).HasColumnName(@"nIdSucursal").HasColumnType("int").IsOptional();
            Property(x => x.NIdEntradaSalida602).HasColumnName(@"nIdEntradaSalida602").HasColumnType("int").IsOptional();
            Property(x => x.SCodMexicano).HasColumnName(@"sCODMexicano").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.NTipoCambio).HasColumnName(@"nTipoCambio").HasColumnType("decimal").IsOptional().HasPrecision(14,5);
            Property(x => x.SItn).HasColumnName(@"sITN").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NIdExentoEei659).HasColumnName(@"nIdExentoEEI659").HasColumnType("int").IsOptional();
            Property(x => x.NTipoDocumento).HasColumnName(@"nTipoDocumento").HasColumnType("tinyint").IsOptional();
            Property(x => x.BRecibeFactura).HasColumnName(@"bRecibeFactura").HasColumnType("bit").IsOptional();
            Property(x => x.BRecibeBl).HasColumnName(@"bRecibeBL").HasColumnType("bit").IsOptional();
            Property(x => x.BRecibePackingList).HasColumnName(@"bRecibePackingList").HasColumnType("bit").IsOptional();
            Property(x => x.BRecibeOtro).HasColumnName(@"bRecibeOtro").HasColumnType("bit").IsOptional();
            Property(x => x.SSello1).HasColumnName(@"sSello1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.SSello2).HasColumnName(@"sSello2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.BFleteEnviadoAxapta).HasColumnName(@"bFleteEnviadoAxapta").HasColumnType("bit").IsOptional();
            Property(x => x.SIdForaneoFletes).HasColumnName(@"sIdForaneoFletes").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DFechaCierreAdmin).HasColumnName(@"dFechaCierreAdmin").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdPlantaBodega792).HasColumnName(@"nIdPlantaBodega792").HasColumnType("int").IsOptional();
            Property(x => x.NIdRutasBodega793).HasColumnName(@"nIdRutasBodega793").HasColumnType("int").IsOptional();
            Property(x => x.NDestinoMercancia).HasColumnName(@"nDestinoMercancia").HasColumnType("int").IsOptional();
            Property(x => x.NEstatusNotificacion).HasColumnName(@"nEstatusNotificacion").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsuarioEnvioNotificacion).HasColumnName(@"nIdUsuarioEnvioNotificacion").HasColumnType("int").IsOptional();
            Property(x => x.DEnvioNotificacion).HasColumnName(@"dEnvioNotificacion").HasColumnType("datetime").IsOptional();
            Property(x => x.BTienePrevio).HasColumnName(@"bTienePrevio").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasOptional(a => a.CatAlmac).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdAlmacen).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_cat_almac
            HasOptional(a => a.CatCliente_NIdImex).WithMany(b => b.SIR_Sir156EntradasBodega_NIdImex).HasForeignKey(c => c.NIdImex).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_cat_clientes_imex
            HasOptional(a => a.CatEmp_NIdAgenteAduanal).WithMany(b => b.SIR_Sir156EntradasBodega_NIdAgenteAduanal).HasForeignKey(c => c.NIdAgenteAduanal).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_cat_emp_agente
            HasOptional(a => a.CatEmp_NIdEjecutivo).WithMany(b => b.SIR_Sir156EntradasBodega_NIdEjecutivo).HasForeignKey(c => c.NIdEjecutivo).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_cat_emp
            HasOptional(a => a.SIR_Sir03Moneda).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdMoneda03).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_SIR_03_MONEDAS
            HasOptional(a => a.SIR_Sir05MediosTransporte).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdMedioTrans05).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_SIR_05_MEDIOS_TRANSPORTE
            HasOptional(a => a.SIR_Sir09TiposContenedor).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdTipoCont09).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_SIR_09_TIPOS_CONTENEDOR
            HasOptional(a => a.SIR_Sir156EntradasBodega1).WithMany(b => b.SIR_Sir156EntradasBodega2).HasForeignKey(c => c.NIdRtConsolidado).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_SIR_156_ENTRADAS_BODEGAS
            HasOptional(a => a.SIR_Sir158SeccionesNave).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdSeccion158).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_SIR_158_SECCIONES_NAVES
            HasOptional(a => a.SIR_Sir336SedInbondType).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdInbondTypes336).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_SIR_336_SED_INBOND_TYPES
            HasOptional(a => a.SIR_Sir42Proveedore).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdEmbarcador42).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_SIR_42_PROVEEDORES
            HasOptional(a => a.SIR_Sir602EntradaSalidaPatio).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdEntradaSalida602).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_SIR_602_ENTRADA_SALIDA_PATIO
            HasOptional(a => a.SIR_Sir659ExentoEei).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdExentoEei659).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGA_SIR_659_EXENTO_EEI
            HasOptional(a => a.SIR_Sir792PlantasEntradaBodega).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdPlantaBodega792).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_SIR_792_PLANTAS_ENTRADA_BODEGA
            HasOptional(a => a.SIR_Sir793RutasEntradaBodega).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdRutasBodega793).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_SIR_793_RUTAS_ENTRADA_BODEGA
            HasRequired(a => a.CatCliente_NIdCliente).WithMany(b => b.SIR_Sir156EntradasBodega_NIdCliente).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_cat_clientes
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_cat_usr_ed
            HasRequired(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir156EntradasBodega).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_156_ENTRADAS_BODEGAS_SIR_71_SUCURSAL_PATENTE_ADUANA
            HasMany(t => t.SIR_Sir49OperacionesFactura).WithMany(t => t.SIR_Sir156EntradasBodega).Map(m =>
            {
                m.ToTable("SIR_362_OPER_FACTURAS_ENTRADA_BODEGA", "SIR");
                m.MapLeftKey("nIdEntrada156");
                m.MapRightKey("nIdOperFact49");
            });
        }
    }

}
// </auto-generated>