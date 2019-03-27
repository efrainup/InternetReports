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

    // SIR_220_REMESAS_HISTORICO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir220RemesasHistoricoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir220RemesasHistorico>
    {
        public SIR_Sir220RemesasHistoricoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir220RemesasHistoricoConfiguration(string schema)
        {
            ToTable("SIR_220_REMESAS_HISTORICO", schema);
            HasKey(x => x.NIdRemHist220);

            Property(x => x.NIdRemHist220).HasColumnName(@"nIdRemHist220").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdRem206).HasColumnName(@"nIdRem206").HasColumnType("int").IsRequired();
            Property(x => x.NNumRemesa).HasColumnName(@"nNumRemesa").HasColumnType("int").IsRequired();
            Property(x => x.SPedimento).HasColumnName(@"sPedimento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(7);
            Property(x => x.SClaveDocto).HasColumnName(@"sClaveDocto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.SFirmaPedimento).HasColumnName(@"sFirmaPedimento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8);
            Property(x => x.NPatente).HasColumnName(@"nPatente").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.SNombreAgente).HasColumnName(@"sNombreAgente").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SRfcAgente).HasColumnName(@"sRFCAgente").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.SCurpAgente).HasColumnName(@"sCURPAgente").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.NCantidadMcia).HasColumnName(@"nCantidadMcia").HasColumnType("decimal").IsRequired().HasPrecision(14,2);
            Property(x => x.NNumFactura).HasColumnName(@"nNumFactura").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.NValorFacturaUs).HasColumnName(@"nValorFacturaUS").HasColumnType("decimal").IsRequired().HasPrecision(14,2);
            Property(x => x.NValorFacturaPesos).HasColumnName(@"nValorFacturaPesos").HasColumnType("decimal").IsRequired().HasPrecision(14,2);
            Property(x => x.SPlacas).HasColumnName(@"sPlacas").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.NRelacionCon).HasColumnName(@"nRelacionCon").HasColumnType("tinyint").IsRequired();
            Property(x => x.SNombreMandatario).HasColumnName(@"sNombreMandatario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SRfcMandatario).HasColumnName(@"sRFCMandatario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.SCurpMandatario).HasColumnName(@"sCURPMandatario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.DFechaImpresion).HasColumnName(@"dFechaImpresion").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.SNombreCliente).HasColumnName(@"sNombreCliente").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SRfcCliente).HasColumnName(@"sRFCCliente").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.SClaveAduana).HasColumnName(@"sClaveAduana").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.SClaveSeccion).HasColumnName(@"sClaveSeccion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.NNumBultos).HasColumnName(@"nNumBultos").HasColumnType("decimal").IsRequired().HasPrecision(14,3);
            Property(x => x.SNombreEmpleado).HasColumnName(@"sNombreEmpleado").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SClaveRecinto).HasColumnName(@"sClaveRecinto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.SNumContenedor).HasColumnName(@"sNumContenedor").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(13);
            Property(x => x.NTotalGuias).HasColumnName(@"nTotalGuias").HasColumnType("int").IsOptional();
            Property(x => x.SNumGuia).HasColumnName(@"sNumGuia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.NPesoMciaGranel).HasColumnName(@"nPesoMciaGranel").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsRequired();
            Property(x => x.STransporte).HasColumnName(@"sTransporte").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(60);
            Property(x => x.SObservacion).HasColumnName(@"sObservacion").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SInfoCargaSuelta).HasColumnName(@"sInfoCargaSuelta").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.SNumEconomico).HasColumnName(@"sNumEconomico").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.SPuerto).HasColumnName(@"sPuerto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SFirmaAduana).HasColumnName(@"sFirmaAduana").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8);
            Property(x => x.SModelo).HasColumnName(@"sModelo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.SMarca).HasColumnName(@"sMarca").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SBuque).HasColumnName(@"sBuque").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SViaje).HasColumnName(@"sViaje").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.NPeso).HasColumnName(@"nPeso").HasColumnType("decimal").IsOptional().HasPrecision(12,2);
            Property(x => x.SNombreRepresentante).HasColumnName(@"sNombreRepresentante").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SRfcRepresentante).HasColumnName(@"sRFCRepresentante").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SOrigenDestino).HasColumnName(@"sOrigenDestino").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsOptional();
            Property(x => x.NCantidadUmc).HasColumnName(@"nCantidadUMC").HasColumnType("decimal").IsOptional().HasPrecision(14,2);
            Property(x => x.NTotalValorFacturaUsd).HasColumnName(@"nTotalValorFacturaUSD").HasColumnType("decimal").IsOptional().HasPrecision(14,2);
            Property(x => x.BConFacturas).HasColumnName(@"bConFacturas").HasColumnType("bit").IsRequired();
            Property(x => x.SDimensionCont).HasColumnName(@"sDimensionCont").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.SInicialesCont).HasColumnName(@"sInicialesCont").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.SCategoriaCont).HasColumnName(@"sCategoriaCont").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.SContenedores).HasColumnName(@"sContenedores").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SClaveAduanaSalida).HasColumnName(@"sClaveAduanaSalida").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.SClaveSeccionSalida).HasColumnName(@"sClaveSeccionSalida").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1);
            Property(x => x.SCandados).HasColumnName(@"sCandados").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NSemana).HasColumnName(@"nSemana").HasColumnType("int").IsOptional();
            Property(x => x.SDireccionCliente).HasColumnName(@"sDireccionCliente").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NTipoCambio).HasColumnName(@"nTipoCambio").HasColumnType("decimal").IsOptional().HasPrecision(17,5);
            Property(x => x.DFechaPagoPed).HasColumnName(@"dFechaPagoPed").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SMedioTransporte).HasColumnName(@"sMedioTransporte").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NClaveEs).HasColumnName(@"nClaveES").HasColumnType("int").IsOptional();
            Property(x => x.NClaveArribo).HasColumnName(@"nClaveArribo").HasColumnType("int").IsOptional();
            Property(x => x.NClaveSalida).HasColumnName(@"nClaveSalida").HasColumnType("int").IsOptional();
            Property(x => x.SGuiaMaster).HasColumnName(@"sGuiaMaster").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SGuiaHouse).HasColumnName(@"sGuiaHouse").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DCruce).HasColumnName(@"dCruce").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DLlegada).HasColumnName(@"dLlegada").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SFacturaDesglose).HasColumnName(@"sFacturaDesglose").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.SLineaCruce).HasColumnName(@"sLineaCruce").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SAaAmericano).HasColumnName(@"sAAAmericano").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SPreFile).HasColumnName(@"sPreFile").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SGuiaUsa).HasColumnName(@"sGuiaUSA").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.STransportista).HasColumnName(@"sTransportista").HasColumnType("int").IsOptional();
            Property(x => x.SCurpCliente).HasColumnName(@"sCurpCliente").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SEDocument).HasColumnName(@"sEDocument").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(13);
            Property(x => x.SNombreRecinto).HasColumnName(@"sNombreRecinto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.SOperCove).HasColumnName(@"sOperCOVE").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SMarcasNumTotBultos).HasColumnName(@"sMarcasNumTotBultos").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NPesoBruto).HasColumnName(@"nPesoBruto").HasColumnType("decimal").IsOptional().HasPrecision(14,3);

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir220RemesasHistorico).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_220_REMESAS_HISTORICO_cat_usr
            HasRequired(a => a.SIR_Sir206Remesa).WithMany(b => b.SIR_Sir220RemesasHistorico).HasForeignKey(c => c.NIdRem206).WillCascadeOnDelete(false); // FK_SIR_220_REMESAS_HISTORICO_SIR_206_REMESAS
        }
    }

}
// </auto-generated>