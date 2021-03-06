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

    // SIR_120_SOLICITUD_CHEQUES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir120SolicitudChequeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir120SolicitudCheque>
    {
        public SIR_Sir120SolicitudChequeConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir120SolicitudChequeConfiguration(string schema)
        {
            ToTable("SIR_120_SOLICITUD_CHEQUES", schema);
            HasKey(x => x.NIdSolCheque120);

            Property(x => x.NIdSolCheque120).HasColumnName(@"nIdSolCheque120").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NFolio).HasColumnName(@"nFolio").HasColumnType("int").IsRequired();
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NTipo).HasColumnName(@"nTipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.NIdEmpleado).HasColumnName(@"nIdEmpleado").HasColumnType("int").IsOptional();
            Property(x => x.NIdProveedor).HasColumnName(@"nIdProveedor").HasColumnType("int").IsOptional();
            Property(x => x.NIdMonedaProv).HasColumnName(@"nIdMonedaProv").HasColumnType("int").IsOptional();
            Property(x => x.NIdEjecutivo).HasColumnName(@"nIdEjecutivo").HasColumnType("int").IsOptional();
            Property(x => x.NIdProvGiro).HasColumnName(@"nIdProvGiro").HasColumnType("int").IsOptional();
            Property(x => x.NIdAutoriza).HasColumnName(@"nIdAutoriza").HasColumnType("int").IsOptional();
            Property(x => x.DFechaAutoriza).HasColumnName(@"dFechaAutoriza").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdAutorizaExtra).HasColumnName(@"nIdAutorizaExtra").HasColumnType("int").IsOptional();
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("tinyint").IsRequired();
            Property(x => x.DFechaSolicitud).HasColumnName(@"dFechaSolicitud").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaRechazo).HasColumnName(@"dFechaRechazo").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SMotivoRechazo).HasColumnName(@"sMotivoRechazo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NIdSolicita).HasColumnName(@"nIdSolicita").HasColumnType("int").IsOptional();
            Property(x => x.NIdRechaza).HasColumnName(@"nIdRechaza").HasColumnType("int").IsOptional();
            Property(x => x.NIdCancela).HasColumnName(@"nIdCancela").HasColumnType("int").IsOptional();
            Property(x => x.DFechaCancela).HasColumnName(@"dFechaCancela").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.BPermiteCarta).HasColumnName(@"bPermiteCarta").HasColumnType("bit").IsRequired();
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsOptional();
            Property(x => x.BPorComprobar).HasColumnName(@"bPorComprobar").HasColumnType("bit").IsRequired();
            Property(x => x.BEsDeposito).HasColumnName(@"bEsDeposito").HasColumnType("bit").IsRequired();
            Property(x => x.NIdDeudor).HasColumnName(@"nIdDeudor").HasColumnType("int").IsOptional();
            Property(x => x.NIdEmpleadoAdm).HasColumnName(@"nIdEmpleadoAdm").HasColumnType("int").IsOptional();
            Property(x => x.NIdProveedorAdm).HasColumnName(@"nIdProveedorAdm").HasColumnType("int").IsOptional();
            Property(x => x.NIdMonedaProvAdm).HasColumnName(@"nIdMonedaProvAdm").HasColumnType("int").IsOptional();
            Property(x => x.NIdEjecutivoAdm).HasColumnName(@"nIdEjecutivoAdm").HasColumnType("int").IsOptional();
            Property(x => x.NIdAutorizaAdm).HasColumnName(@"nIdAutorizaAdm").HasColumnType("int").IsOptional();
            Property(x => x.NIdProvGiroAdm).HasColumnName(@"nIdProvGiroAdm").HasColumnType("int").IsOptional();
            Property(x => x.NIdAutorizaExtraAdm).HasColumnName(@"nIdAutorizaExtraAdm").HasColumnType("int").IsOptional();
            Property(x => x.NIdSolicitaAdm).HasColumnName(@"nIdSolicitaAdm").HasColumnType("int").IsOptional();
            Property(x => x.NIdRechazaAdm).HasColumnName(@"nIdRechazaAdm").HasColumnType("int").IsOptional();
            Property(x => x.NIdCancelaAdm).HasColumnName(@"nIdCancelaAdm").HasColumnType("int").IsOptional();
            Property(x => x.NIdElaboraAdm).HasColumnName(@"nIdElaboraAdm").HasColumnType("int").IsOptional();
            Property(x => x.SFormadePago).HasColumnName(@"sFormadePago").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SIdForaneo).HasColumnName(@"sIdForaneo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.DFechaElaboracion).HasColumnName(@"dFechaElaboracion").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Admina02Personal_NIdAutorizaAdm).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdAutorizaAdm).HasForeignKey(c => c.NIdAutorizaAdm).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_ADMINA_02_PERSONAL_Autoriza
            HasOptional(a => a.Admin_Admina02Personal_NIdAutorizaExtraAdm).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdAutorizaExtraAdm).HasForeignKey(c => c.NIdAutorizaExtraAdm).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_ADMINA_02_PERSONAL_AutorizaExtra
            HasOptional(a => a.Admin_Admina02Personal_NIdCancelaAdm).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdCancelaAdm).HasForeignKey(c => c.NIdCancelaAdm).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_ADMINA_02_PERSONAL_Cancela
            HasOptional(a => a.Admin_Admina02Personal_NIdEjecutivoAdm).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdEjecutivoAdm).HasForeignKey(c => c.NIdEjecutivoAdm).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_ADMINA_02_PERSONAL_Ejecutivo
            HasOptional(a => a.Admin_Admina02Personal_NIdElaboraAdm).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdElaboraAdm).HasForeignKey(c => c.NIdElaboraAdm).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_ADMINA_02_PERSONAL_Elabora
            HasOptional(a => a.Admin_Admina02Personal_NIdEmpleadoAdm).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdEmpleadoAdm).HasForeignKey(c => c.NIdEmpleadoAdm).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_ADMINA_02_PERSONAL_Empleado
            HasOptional(a => a.Admin_Admina02Personal_NIdRechazaAdm).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdRechazaAdm).HasForeignKey(c => c.NIdRechazaAdm).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_ADMINA_02_PERSONAL_Rechaza
            HasOptional(a => a.Admin_Admina02Personal_NIdSolicitaAdm).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdSolicitaAdm).HasForeignKey(c => c.NIdSolicitaAdm).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_ADMINA_02_PERSONAL_Solicita
            HasOptional(a => a.Admin_Adminc03Moneda).WithMany(b => b.SIR_Sir120SolicitudCheque).HasForeignKey(c => c.NIdMonedaProvAdm).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_ADMINC_03_MONEDAS
            HasOptional(a => a.Admin_Adminc42Proveedore_NIdProveedorAdm).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdProveedorAdm).HasForeignKey(c => c.NIdProveedorAdm).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_ADMINC_42_PROVEEDORES_Prov
            HasOptional(a => a.Admin_Adminc42Proveedore_NIdProvGiroAdm).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdProvGiroAdm).HasForeignKey(c => c.NIdProvGiroAdm).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_ADMINC_42_PROVEEDORES_ProvGiro
            HasOptional(a => a.BcoCuenta).WithMany(b => b.SIR_Sir120SolicitudCheque).HasForeignKey(c => c.NIdDeudor).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_bco_cuentas
            HasOptional(a => a.CatEmp_NIdAutoriza).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdAutoriza).HasForeignKey(c => c.NIdAutoriza).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_cat_emp1
            HasOptional(a => a.CatEmp_NIdAutorizaExtra).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdAutorizaExtra).HasForeignKey(c => c.NIdAutorizaExtra).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_cat_emp2
            HasOptional(a => a.CatEmp_NIdCancela).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdCancela).HasForeignKey(c => c.NIdCancela).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_cat_emp6
            HasOptional(a => a.CatEmp_NIdEjecutivo).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdEjecutivo).HasForeignKey(c => c.NIdEjecutivo).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_cat_emp3
            HasOptional(a => a.CatEmp_NIdEmpleado).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdEmpleado).HasForeignKey(c => c.NIdEmpleado).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_cat_emp
            HasOptional(a => a.CatEmp_NIdRechaza).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdRechaza).HasForeignKey(c => c.NIdRechaza).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_cat_emp5
            HasOptional(a => a.CatEmp_NIdSolicita).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdSolicita).HasForeignKey(c => c.NIdSolicita).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_cat_emp4
            HasOptional(a => a.CatProv_NIdEjecutivo).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdEjecutivo).HasForeignKey(c => c.NIdEjecutivo).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_cat_prov1
            HasOptional(a => a.CatProv_NIdProveedor).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdProveedor).HasForeignKey(c => c.NIdProveedor).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_cat_prov
            HasOptional(a => a.CatProv_NIdProvGiro).WithMany(b => b.SIR_Sir120SolicitudCheque_NIdProvGiro).HasForeignKey(c => c.NIdProvGiro).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_cat_prov2
            HasOptional(a => a.MonMoneda).WithMany(b => b.SIR_Sir120SolicitudCheque).HasForeignKey(c => c.NIdMonedaProv).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_mon_monedas
            HasOptional(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir120SolicitudCheque).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_120_SOLICITUD_CHEQUES_SIR_71_SUCURSAL_PATENTE_ADUANA
        }
    }

}
// </auto-generated>
