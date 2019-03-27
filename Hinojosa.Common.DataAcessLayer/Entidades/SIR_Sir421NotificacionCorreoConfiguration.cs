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

    // SIR_421_NOTIFICACION_CORREO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir421NotificacionCorreoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir421NotificacionCorreo>
    {
        public SIR_Sir421NotificacionCorreoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir421NotificacionCorreoConfiguration(string schema)
        {
            ToTable("SIR_421_NOTIFICACION_CORREO", schema);
            HasKey(x => x.NIdNotificacionCorreo421);

            Property(x => x.NIdNotificacionCorreo421).HasColumnName(@"nIdNotificacionCorreo421").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdNotificacionProg418).HasColumnName(@"nIdNotificacionProg418").HasColumnType("int").IsOptional();
            Property(x => x.NIdNotificacionEvento420).HasColumnName(@"nIdNotificacionEvento420").HasColumnType("int").IsOptional();
            Property(x => x.SContactos).HasColumnName(@"sContactos").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8000);
            Property(x => x.SCuerpoMensaje).HasColumnName(@"sCuerpoMensaje").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.SAsunto).HasColumnName(@"sAsunto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.SRemitente).HasColumnName(@"sRemitente").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.NIdFirma451).HasColumnName(@"nIdFirma451").HasColumnType("int").IsOptional();
            Property(x => x.SHtmlMensaje).HasColumnName(@"sHTMLMensaje").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsOptional();
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsOptional();
            Property(x => x.NIdCliente07).HasColumnName(@"nIdCliente07").HasColumnType("int").IsOptional();
            Property(x => x.NIdNotificacionEfile479).HasColumnName(@"nIdNotificacionEFILE479").HasColumnType("int").IsOptional();
            Property(x => x.BImex).HasColumnName(@"bImex").HasColumnType("bit").IsOptional();
            Property(x => x.NTipoOper).HasColumnName(@"nTipoOper").HasColumnType("int").IsOptional();
            Property(x => x.BAplicaPdfAdminOper).HasColumnName(@"bAplicaPDFAdminOper").HasColumnType("bit").IsOptional();
            Property(x => x.BIncluirDocsEfile).HasColumnName(@"bIncluirDocsEfile").HasColumnType("bit").IsOptional();
            Property(x => x.NIdProveedor42).HasColumnName(@"nIdProveedor42").HasColumnType("int").IsOptional();
            Property(x => x.NIdGrupoProv830).HasColumnName(@"nIdGrupoProv830").HasColumnType("int").IsOptional();
            Property(x => x.NIdTipoMerc80).HasColumnName(@"nIdTipoMerc80").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc07Cliente).WithMany(b => b.SIR_Sir421NotificacionCorreo).HasForeignKey(c => c.NIdCliente07).WillCascadeOnDelete(false); // FK_SIR_421_NOTIFICACION_CORREO_ADMINC_07_CLIENTES
            HasOptional(a => a.CatCliente).WithMany(b => b.SIR_Sir421NotificacionCorreo).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_421_NOTIFICACION_CORREO_cat_clientes
            HasOptional(a => a.SIR_Sir418NotificacionProgramacion).WithMany(b => b.SIR_Sir421NotificacionCorreo).HasForeignKey(c => c.NIdNotificacionProg418).WillCascadeOnDelete(false); // FK_SIR_421_NOTIFICACION_CORREO_SIR_409_CONFIG_VUCEM
            HasOptional(a => a.SIR_Sir420NotificacionEvento).WithMany(b => b.SIR_Sir421NotificacionCorreo).HasForeignKey(c => c.NIdNotificacionEvento420).WillCascadeOnDelete(false); // FK_SIR_421_NOTIFICACION_CORREO_SIR_420_NOTIFICACION_EVENTOS
            HasOptional(a => a.SIR_Sir42Proveedore).WithMany(b => b.SIR_Sir421NotificacionCorreo).HasForeignKey(c => c.NIdProveedor42).WillCascadeOnDelete(false); // FK_SIR_421_NOTIFICACION_CORREO_SIR_42_PROVEEDORES
            HasOptional(a => a.SIR_Sir451FirmasCorreo).WithMany(b => b.SIR_Sir421NotificacionCorreo).HasForeignKey(c => c.NIdFirma451).WillCascadeOnDelete(false); // FK_SIR_421_NOTIFICACION_CORREO_SIR_451_FIRMAS_CORREO
            HasOptional(a => a.SIR_Sir479NotificacionEfile).WithMany(b => b.SIR_Sir421NotificacionCorreo).HasForeignKey(c => c.NIdNotificacionEfile479).WillCascadeOnDelete(false); // FK_SIR_421_NOTIFICACION_CORREO_SIR_479_NOTIFICACION_EFILE
            HasOptional(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir421NotificacionCorreo).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_421_NOTIFICACION_CORREO_SIR_71_SUCURSAL_PATENTE_ADUANA
            HasOptional(a => a.SIR_Sir80TiposMercancia).WithMany(b => b.SIR_Sir421NotificacionCorreo).HasForeignKey(c => c.NIdTipoMerc80).WillCascadeOnDelete(false); // FK_SIR_421_NOTIFICACION_CORREO_SIR_80_TIPOS_MERCANCIA
            HasOptional(a => a.SIR_Sir830GrupoProveedore).WithMany(b => b.SIR_Sir421NotificacionCorreo).HasForeignKey(c => c.NIdGrupoProv830).WillCascadeOnDelete(false); // FK_SIR_421_NOTIFICACION_CORREO_SIR_830_GRUPO_PROVEEDORES
        }
    }

}
// </auto-generated>