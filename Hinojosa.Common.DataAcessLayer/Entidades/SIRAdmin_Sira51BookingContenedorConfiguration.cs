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

    // SIRA_51_BOOKING_CONTENEDOR
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira51BookingContenedorConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira51BookingContenedor>
    {
        public SIRAdmin_Sira51BookingContenedorConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira51BookingContenedorConfiguration(string schema)
        {
            ToTable("SIRA_51_BOOKING_CONTENEDOR", schema);
            HasKey(x => x.NIdBookingCont51);

            Property(x => x.NIdBookingCont51).HasColumnName(@"nIdBookingCont51").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdBooking50).HasColumnName(@"nIdBooking50").HasColumnType("int").IsRequired();
            Property(x => x.NIdContenedor76).HasColumnName(@"nIdContenedor76").HasColumnType("int").IsRequired();
            Property(x => x.DFechaDoc).HasColumnName(@"dFechaDoc").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaDestinoFin).HasColumnName(@"dFechaDestinoFin").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaReingresoTerm).HasColumnName(@"dFechaReingresoTerm").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SReferencia).HasColumnName(@"sReferencia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(64);
            Property(x => x.SPedimento).HasColumnName(@"sPedimento").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(7);
            Property(x => x.SDestino).HasColumnName(@"sDestino").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.STransporte).HasColumnName(@"sTransporte").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BEsCargaSuelta).HasColumnName(@"bEsCargaSuelta").HasColumnType("bit").IsRequired();
            Property(x => x.NIdClaveDocto28).HasColumnName(@"nIdClaveDocto28").HasColumnType("int").IsOptional();
            Property(x => x.SBodega).HasColumnName(@"sBodega").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NEstadias).HasColumnName(@"nEstadias").HasColumnType("int").IsOptional();
            Property(x => x.SPlataformaF).HasColumnName(@"sPlataformaF").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SSellosFsrr).HasColumnName(@"sSellosFSRR").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NAlmacenajeTermFfcc).HasColumnName(@"nAlmacenajeTermFFCC").HasColumnType("int").IsOptional();
            Property(x => x.DFechaArriboFfcc).HasColumnName(@"dFechaArriboFFCC").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaEntradaBod).HasColumnName(@"dFechaEntradaBod").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaDescargaFin).HasColumnName(@"dFechaDescargaFin").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.BAplicaFactura).HasColumnName(@"bAplicaFactura").HasColumnType("bit").IsRequired();
            Property(x => x.BAplicaCustodia).HasColumnName(@"bAplicaCustodia").HasColumnType("bit").IsRequired();
            Property(x => x.NCantidad).HasColumnName(@"nCantidad").HasColumnType("int").IsOptional();
            Property(x => x.NIdProveedor42).HasColumnName(@"nIdProveedor42").HasColumnType("int").IsOptional();
            Property(x => x.NIdProveedor).HasColumnName(@"nIdProveedor").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEntraVacio).HasColumnName(@"dFechaEntraVacio").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaSolEquipo).HasColumnName(@"dFechaSolEquipo").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaSalPuerto).HasColumnName(@"dFechaSalPuerto").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaIngresoTerm).HasColumnName(@"dFechaIngresoTerm").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaCarga).HasColumnName(@"dFechaCarga").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaRetImv).HasColumnName(@"dFechaRetIMV").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaProgLlegada).HasColumnName(@"dFechaProgLlegada").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.STipoServicio).HasColumnName(@"sTipoServicio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SLugarIngreso).HasColumnName(@"sLugarIngreso").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SLugarRetVacio).HasColumnName(@"sLugarRetVacio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SNumeroEir).HasColumnName(@"sNumeroEIR").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SNomRcAgeEir).HasColumnName(@"sNomRcAgeEIR").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.DFechaRecAgeEir).HasColumnName(@"dFechaRecAgeEIR").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaEntLineaEir).HasColumnName(@"dFechaEntLineaEIR").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdTerminalSalida42).HasColumnName(@"nIdTerminalSalida42").HasColumnType("int").IsOptional();
            Property(x => x.NIdTerminalSalida).HasColumnName(@"nIdTerminalSalida").HasColumnType("int").IsOptional();
            Property(x => x.NIdPuertoSalida04).HasColumnName(@"nIdPuertoSalida04").HasColumnType("int").IsOptional();
            Property(x => x.SNoEquipo).HasColumnName(@"sNoEquipo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SLEquipo).HasColumnName(@"sLEquipo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NAlmacenajePto).HasColumnName(@"nAlmacenajePto").HasColumnType("int").IsOptional();
            Property(x => x.DModulacion).HasColumnName(@"dModulacion").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DSolicitud).HasColumnName(@"dSolicitud").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DDocumentacionCont).HasColumnName(@"dDocumentacionCont").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DRequeridaEntBodega).HasColumnName(@"dRequeridaEntBodega").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SOrigen).HasColumnName(@"sOrigen").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SEmpresaTransportista).HasColumnName(@"sEmpresaTransportista").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SOperador).HasColumnName(@"sOperador").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SPlaca).HasColumnName(@"sPlaca").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DCargaCont).HasColumnName(@"dCargaCont").HasColumnType("smalldatetime").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc42Proveedore_NIdProveedor42).WithMany(b => b.SIRAdmin_Sira51BookingContenedor_NIdProveedor42).HasForeignKey(c => c.NIdProveedor42).WillCascadeOnDelete(false); // FK_SIRA_51_BOOKING_CONTENEDOR_ADMINC_42_PROVEEDORES
            HasOptional(a => a.Admin_Adminc42Proveedore_NIdTerminalSalida42).WithMany(b => b.SIRAdmin_Sira51BookingContenedor_NIdTerminalSalida42).HasForeignKey(c => c.NIdTerminalSalida42).WillCascadeOnDelete(false); // FK_SIRA_51_BOOKING_CONTENEDOR_ADMINC_42_PROVEEDORES_TerminalSalida
            HasOptional(a => a.CatProv_NIdProveedor).WithMany(b => b.SIRAdmin_Sira51BookingContenedor_NIdProveedor).HasForeignKey(c => c.NIdProveedor).WillCascadeOnDelete(false); // FK_SIRA_51_BOOKING_CONTENEDOR_cat_prov
            HasOptional(a => a.CatProv_NIdTerminalSalida).WithMany(b => b.SIRAdmin_Sira51BookingContenedor_NIdTerminalSalida).HasForeignKey(c => c.NIdTerminalSalida).WillCascadeOnDelete(false); // FK_SIRA_51_BOOKING_CONTENEDOR_cat_prov_TerminalSalida
            HasOptional(a => a.SIR_Sir04Puerto).WithMany(b => b.SIRAdmin_Sira51BookingContenedor).HasForeignKey(c => c.NIdPuertoSalida04).WillCascadeOnDelete(false); // FK_SIRA_51_BOOKING_CONTENEDOR_SIR_04_PUERTOS
            HasOptional(a => a.SIR_Sir28ClavesDocto).WithMany(b => b.SIRAdmin_Sira51BookingContenedor).HasForeignKey(c => c.NIdClaveDocto28).WillCascadeOnDelete(false); // FK_SIRA_51_BOOKING_CONTENEDOR_SIR_28_CLAVES_DOCTOS
            HasRequired(a => a.SIR_Sir76Contenedore).WithMany(b => b.SIRAdmin_Sira51BookingContenedor).HasForeignKey(c => c.NIdContenedor76); // FK_SIRA_51_BOOKING_CONTENEDOR_SIR_76_CONTENEDORES
            HasRequired(a => a.SIRAdmin_Sira50Booking).WithMany(b => b.SIRAdmin_Sira51BookingContenedor).HasForeignKey(c => c.NIdBooking50).WillCascadeOnDelete(false); // FK_SIRA_51_BOOKING_CONTENEDOR_SIRA_50_BOOKING
        }
    }

}
// </auto-generated>
