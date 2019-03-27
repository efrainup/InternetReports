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

    // SIR_76_CONTENEDORES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir76ContenedoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir76Contenedore>
    {
        public SIR_Sir76ContenedoreConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir76ContenedoreConfiguration(string schema)
        {
            ToTable("SIR_76_CONTENEDORES", schema);
            HasKey(x => x.NIdContenedor76);

            Property(x => x.NIdContenedor76).HasColumnName(@"nIdContenedor76").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SNumero).HasColumnName(@"sNumero").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(14);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsOptional();
            Property(x => x.NIdBl74).HasColumnName(@"nIdBL74").HasColumnType("int").IsOptional();
            Property(x => x.NPeso).HasColumnName(@"nPeso").HasColumnType("decimal").IsRequired().HasPrecision(15,3);
            Property(x => x.NIdTipoCont09).HasColumnName(@"nIdTipoCont09").HasColumnType("int").IsRequired();
            Property(x => x.NIdArticulo106).HasColumnName(@"nIdArticulo106").HasColumnType("int").IsOptional();
            Property(x => x.NEstado).HasColumnName(@"nEstado").HasColumnType("tinyint").IsRequired();
            Property(x => x.NCondicionArribo).HasColumnName(@"nCondicionArribo").HasColumnType("tinyint").IsRequired();
            Property(x => x.SNumeroEir).HasColumnName(@"sNumeroEIR").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.BEsMatPeligroso).HasColumnName(@"bEsMatPeligroso").HasColumnType("bit").IsRequired();
            Property(x => x.DFechaPrevio).HasColumnName(@"dFechaPrevio").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaDespacho).HasColumnName(@"dFechaDespacho").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaDescarga).HasColumnName(@"dFechaDescarga").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaEntregaCont).HasColumnName(@"dFechaEntregaCont").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdUsuarioPrevio).HasColumnName(@"nIdUsuarioPrevio").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsuarioDespacho).HasColumnName(@"nIdUsuarioDespacho").HasColumnType("int").IsOptional();
            Property(x => x.NIdMedioSalida05).HasColumnName(@"nIdMedioSalida05").HasColumnType("int").IsOptional();
            Property(x => x.NIdTransportistaSalida).HasColumnName(@"nIdTransportistaSalida").HasColumnType("int").IsOptional();
            Property(x => x.SMatriculaTransS).HasColumnName(@"sMatriculaTransS").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.DFechaEntregaMerc).HasColumnName(@"dFechaEntregaMerc").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NDiasLibresDemoras).HasColumnName(@"nDiasLibresDemoras").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEir).HasColumnName(@"dFechaEIR").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NTemperatura).HasColumnName(@"nTemperatura").HasColumnType("smallint").IsOptional();
            Property(x => x.NUnidadTemp).HasColumnName(@"nUnidadTemp").HasColumnType("tinyint").IsOptional();
            Property(x => x.NTara).HasColumnName(@"nTara").HasColumnType("decimal").IsOptional().HasPrecision(12,2);
            Property(x => x.NIdDetSelAle89).HasColumnName(@"nIdDetSelAle89").HasColumnType("int").IsOptional();
            Property(x => x.DFechaIngreso).HasColumnName(@"dFechaIngreso").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NFolioIngreso).HasColumnName(@"nFolioIngreso").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();
            Property(x => x.NIdParteDos150).HasColumnName(@"nIdParteDos150").HasColumnType("int").IsOptional();
            Property(x => x.NHClaveTipoCont).HasColumnName(@"nHClaveTipoCont").HasColumnType("smallint").IsOptional();
            Property(x => x.SSelloEntrega).HasColumnName(@"sSelloEntrega").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.DSelloEntrega).HasColumnName(@"dSelloEntrega").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DRecibidoCalculo).HasColumnName(@"dRecibidoCalculo").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DPagoDemoras).HasColumnName(@"dPagoDemoras").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFacturaDemoras).HasColumnName(@"dFacturaDemoras").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NDepositoGarantia).HasColumnName(@"nDepositoGarantia").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.SSelloRemesa).HasColumnName(@"sSelloRemesa").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NIdUsuPrevio01).HasColumnName(@"nIdUsuPrevio01").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsuDespacho01).HasColumnName(@"nIdUsuDespacho01").HasColumnType("int").IsOptional();
            Property(x => x.NIdTransSalida42).HasColumnName(@"nIdTransSalida42").HasColumnType("int").IsOptional();
            Property(x => x.BArticulo3).HasColumnName(@"bArticulo3").HasColumnType("bit").IsOptional();
            Property(x => x.NPesoDeContenedor).HasColumnName(@"nPesoDeContenedor").HasColumnType("decimal").IsOptional().HasPrecision(15,3);
            Property(x => x.NIzadas).HasColumnName(@"nIzadas").HasColumnType("decimal").IsOptional().HasPrecision(15,3);
            Property(x => x.SImOs).HasColumnName(@"sIMOs").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.SUNs).HasColumnName(@"sUNs").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.NIdNaviera).HasColumnName(@"nIdNaviera").HasColumnType("int").IsOptional();
            Property(x => x.NImporteDemoras).HasColumnName(@"nImporteDemoras").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.BDesconsolidar).HasColumnName(@"bDesconsolidar").HasColumnType("decimal").IsOptional().HasPrecision(12,2);
            Property(x => x.BParteDos).HasColumnName(@"bParteDos").HasColumnType("bit").IsOptional();
            Property(x => x.DDocFerrocarril).HasColumnName(@"dDocFerrocarril").HasColumnType("datetime").IsOptional();
            Property(x => x.DCargaFerrocarril).HasColumnName(@"dCargaFerrocarril").HasColumnType("datetime").IsOptional();
            Property(x => x.DMercanciaFerrocarril).HasColumnName(@"dMercanciaFerrocarril").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Admina01Usuario_NIdUsuDespacho01).WithMany(b => b.SIR_Sir76Contenedore_NIdUsuDespacho01).HasForeignKey(c => c.NIdUsuDespacho01).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_ADMINA_01_USUARIOS_nIdUsuDespacho01
            HasOptional(a => a.Admin_Admina01Usuario_NIdUsuPrevio01).WithMany(b => b.SIR_Sir76Contenedore_NIdUsuPrevio01).HasForeignKey(c => c.NIdUsuPrevio01).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_ADMINA_01_USUARIOS_nIdUsuPrevio01
            HasOptional(a => a.Admin_Adminc42Proveedore).WithMany(b => b.SIR_Sir76Contenedore).HasForeignKey(c => c.NIdTransSalida42).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_ADMINC_42_PROVEEDORES
            HasOptional(a => a.CatProv).WithMany(b => b.SIR_Sir76Contenedore).HasForeignKey(c => c.NIdNaviera).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_cat_prov
            HasOptional(a => a.CatUsr_NIdUsuarioDespacho).WithMany(b => b.SIR_Sir76Contenedore_NIdUsuarioDespacho).HasForeignKey(c => c.NIdUsuarioDespacho).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_cat_usr_despacho
            HasOptional(a => a.CatUsr_NIdUsuarioPrevio).WithMany(b => b.SIR_Sir76Contenedore_NIdUsuarioPrevio).HasForeignKey(c => c.NIdUsuarioPrevio).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_cat_usr_previo
            HasOptional(a => a.SIR_Sir05MediosTransporte).WithMany(b => b.SIR_Sir76Contenedore).HasForeignKey(c => c.NIdMedioSalida05).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_SIR_05_MEDIOS_TRANSPORTE
            HasOptional(a => a.SIR_Sir106Articulo23).WithMany(b => b.SIR_Sir76Contenedore).HasForeignKey(c => c.NIdArticulo106).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_SIR_106_ARTICULO_23
            HasOptional(a => a.SIR_Sir150PartesDo).WithMany(b => b.SIR_Sir76Contenedore).HasForeignKey(c => c.NIdParteDos150).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_SIR_150_PARTES_DOS
            HasOptional(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir76Contenedore).HasForeignKey(c => c.NIdReferencia60); // FK_SIR_76_CONTENEDORES_SIR_60_REFERENCIAS
            HasOptional(a => a.SIR_Sir74ConocimientosMaritimo).WithMany(b => b.SIR_Sir76Contenedore).HasForeignKey(c => c.NIdBl74).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_SIR_74_CONOCIMIENTOS_MARITIMOS
            HasOptional(a => a.SIR_Sir89DetSelecAleatoria).WithMany(b => b.SIR_Sir76Contenedore).HasForeignKey(c => c.NIdDetSelAle89).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_SIR_89_DET_SELEC_ALEATORIA
            HasRequired(a => a.SIR_Sir09TiposContenedor).WithMany(b => b.SIR_Sir76Contenedore).HasForeignKey(c => c.NIdTipoCont09).WillCascadeOnDelete(false); // FK_SIR_76_CONTENEDORES_SIR_09_TIPOS_CONTENEDOR
            HasMany(t => t.SIR_Sir206Remesa_NIdRem206).WithMany(t => t.SIR_Sir76Contenedore1).Map(m =>
            {
                m.ToTable("SIR_208_REMESA_CONTENEDOR", "SIR");
                m.MapLeftKey("nIdContenedor76");
                m.MapRightKey("nIdRem206");
            });
        }
    }

}
// </auto-generated>