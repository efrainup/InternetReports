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

    // SIR_161_PROG_PREVIOS_REF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir161ProgPreviosRefConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir161ProgPreviosRef>
    {
        public SIR_Sir161ProgPreviosRefConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir161ProgPreviosRefConfiguration(string schema)
        {
            ToTable("SIR_161_PROG_PREVIOS_REF", schema);
            HasKey(x => x.NIdPrevRef161);

            Property(x => x.NIdPrevRef161).HasColumnName(@"nIdPrevRef161").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsOptional();
            Property(x => x.NIdResponsable).HasColumnName(@"nIdResponsable").HasColumnType("int").IsOptional();
            Property(x => x.NPrioridad).HasColumnName(@"nPrioridad").HasColumnType("tinyint").IsOptional();
            Property(x => x.NIdTipoPrevio132).HasColumnName(@"nIdTipoPrevio132").HasColumnType("int").IsOptional();
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NCantidad).HasColumnName(@"nCantidad").HasColumnType("tinyint").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsOptional();
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsRequired();
            Property(x => x.NIdBl74).HasColumnName(@"nIdBL74").HasColumnType("int").IsOptional();
            Property(x => x.DFechaRev).HasColumnName(@"dFechaRev").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DRecInicio).HasColumnName(@"dRecInicio").HasColumnType("datetime").IsOptional();
            Property(x => x.DRecFin).HasColumnName(@"dRecFin").HasColumnType("datetime").IsOptional();
            Property(x => x.SRevisa).HasColumnName(@"sRevisa").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.NNumPrevio).HasColumnName(@"nNumPrevio").HasColumnType("int").IsOptional();
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("tinyint").IsOptional();
            Property(x => x.BDeProgramacion).HasColumnName(@"bDeProgramacion").HasColumnType("bit").IsOptional();
            Property(x => x.NIdTerminal).HasColumnName(@"nIdTerminal").HasColumnType("int").IsOptional();
            Property(x => x.NNumRevisores).HasColumnName(@"nNumRevisores").HasColumnType("int").IsOptional();
            Property(x => x.SRutaArchivo).HasColumnName(@"sRutaArchivo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NIdEntrada156).HasColumnName(@"nIdEntrada156").HasColumnType("int").IsOptional();
            Property(x => x.NIdTerminal42).HasColumnName(@"nIdTerminal42").HasColumnType("int").IsOptional();
            Property(x => x.NIdResponsable02).HasColumnName(@"nIdResponsable02").HasColumnType("int").IsOptional();
            Property(x => x.NTipoCarga).HasColumnName(@"nTipoCarga").HasColumnType("int").IsOptional();
            Property(x => x.NIdSeccion158).HasColumnName(@"nIdSeccion158").HasColumnType("int").IsOptional();
            Property(x => x.NIdEjecutivo).HasColumnName(@"nIdEjecutivo").HasColumnType("int").IsOptional();
            Property(x => x.NIdEjecutivo02).HasColumnName(@"nIdEjecutivo02").HasColumnType("int").IsOptional();
            Property(x => x.DRecepcionExpediente).HasColumnName(@"dRecepcionExpediente").HasColumnType("datetime").IsOptional();
            Property(x => x.DAsignacion).HasColumnName(@"dAsignacion").HasColumnType("datetime").IsOptional();
            Property(x => x.DAsignacionDocumentos).HasColumnName(@"dAsignacionDocumentos").HasColumnType("datetime").IsOptional();
            Property(x => x.DReasignacion).HasColumnName(@"dReasignacion").HasColumnType("datetime").IsOptional();
            Property(x => x.SMotivoReasignacion).HasColumnName(@"sMotivoReasignacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NIdTipoDocto62).HasColumnName(@"nIdTipoDocto62").HasColumnType("int").IsOptional();
            Property(x => x.NIdSeccion158Ap).HasColumnName(@"nIdSeccion158AP").HasColumnType("int").IsOptional();
            Property(x => x.DFechaCreacion).HasColumnName(@"dFechaCreacion").HasColumnType("datetime").IsOptional();
            Property(x => x.BConfirmarPrevio).HasColumnName(@"bConfirmarPrevio").HasColumnType("bit").IsOptional();
            Property(x => x.NIdUsuConfirmo).HasColumnName(@"nIdUsuConfirmo").HasColumnType("int").IsOptional();
            Property(x => x.DFechaConfirmacion).HasColumnName(@"dFechaConfirmacion").HasColumnType("datetime").IsOptional();
            Property(x => x.SObservacionConfirmacion).HasColumnName(@"sObservacionConfirmacion").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);

            // Foreign keys
            HasOptional(a => a.Admin_Admina02Personal).WithMany(b => b.SIR_Sir161ProgPreviosRef).HasForeignKey(c => c.NIdEjecutivo02).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_ADMINA_02_PERSONAL
            HasOptional(a => a.Admin_Adminc42Proveedore).WithMany(b => b.SIR_Sir161ProgPreviosRef).HasForeignKey(c => c.NIdTerminal42).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_ADMINC_42_PROVEEDORES
            HasOptional(a => a.CatEmp).WithMany(b => b.SIR_Sir161ProgPreviosRef).HasForeignKey(c => c.NIdResponsable).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_cat_emp
            HasOptional(a => a.CatProv).WithMany(b => b.SIR_Sir161ProgPreviosRef).HasForeignKey(c => c.NIdTerminal).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_cat_prov
            HasOptional(a => a.CatUsr).WithMany(b => b.SIR_Sir161ProgPreviosRef).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_cat_usr_ed
            HasOptional(a => a.SIR_Sir132TipoPrevio).WithMany(b => b.SIR_Sir161ProgPreviosRef).HasForeignKey(c => c.NIdTipoPrevio132).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_SIR_132_TIPO_PREVIO
            HasOptional(a => a.SIR_Sir158SeccionesNave_NIdSeccion158).WithMany(b => b.SIR_Sir161ProgPreviosRef_NIdSeccion158).HasForeignKey(c => c.NIdSeccion158).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_SIR_158_SECCIONES_NAVES
            HasOptional(a => a.SIR_Sir158SeccionesNave_NIdSeccion158Ap).WithMany(b => b.SIR_Sir161ProgPreviosRef_NIdSeccion158Ap).HasForeignKey(c => c.NIdSeccion158Ap).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_SIR_158_SECCIONES_NAVES_AP
            HasOptional(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir161ProgPreviosRef).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_SIR_60_REFERENCIAS
            HasOptional(a => a.SIR_Sir62TiposDocumento).WithMany(b => b.SIR_Sir161ProgPreviosRef).HasForeignKey(c => c.NIdTipoDocto62).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_SIR_62_TIPOS_DOCUMENTOS
            HasOptional(a => a.SIR_Sir74ConocimientosMaritimo).WithMany(b => b.SIR_Sir161ProgPreviosRef).HasForeignKey(c => c.NIdBl74).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_SIR_74_CONOCIMIENTOS_MARITIMOS
            HasRequired(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir161ProgPreviosRef).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_161_PROG_PREVIOS_REF_SIR_71_SUCURSAL_PATENTE_ADUANA
        }
    }

}
// </auto-generated>