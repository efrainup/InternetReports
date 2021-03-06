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

    // SIR_413_HISTORICO_PARTE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir413HistoricoParteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir413HistoricoParte>
    {
        public SIR_Sir413HistoricoParteConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir413HistoricoParteConfiguration(string schema)
        {
            ToTable("SIR_413_HISTORICO_PARTE", schema);
            HasKey(x => x.NIdHistoricoParte413);

            Property(x => x.NIdHistoricoParte413).HasColumnName(@"nIdHistoricoParte413").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdParte99).HasColumnName(@"nIdParte99").HasColumnType("int").IsOptional();
            Property(x => x.SParte).HasColumnName(@"sParte").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.SFraccion).HasColumnName(@"sFraccion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(12);
            Property(x => x.SDescripcionTigie).HasColumnName(@"sDescripcionTIGIE").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SDescripcionFactura).HasColumnName(@"sDescripcionFactura").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SDescripcionAa).HasColumnName(@"sDescripcionAA").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NIdUmc10).HasColumnName(@"nIdUMC10").HasColumnType("int").IsOptional();
            Property(x => x.NIdUmt10).HasColumnName(@"nIdUMT10").HasColumnType("int").IsOptional();
            Property(x => x.NIdPaisOriDest01).HasColumnName(@"nIdPaisOriDest01").HasColumnType("int").IsOptional();
            Property(x => x.NIdPaisCompVend01).HasColumnName(@"nIdPaisCompVend01").HasColumnType("int").IsOptional();
            Property(x => x.NIdProveedor42).HasColumnName(@"nIdProveedor42").HasColumnType("int").IsOptional();
            Property(x => x.SCodigoBarras).HasColumnName(@"sCodigoBarras").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.SControlInterno).HasColumnName(@"sControlInterno").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SFamiliaProducto).HasColumnName(@"sFamiliaProducto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.BActiva).HasColumnName(@"bActiva").HasColumnType("bit").IsOptional();
            Property(x => x.NEstaVinculado).HasColumnName(@"nEstaVinculado").HasColumnType("int").IsRequired();
            Property(x => x.NCPreferencial).HasColumnName(@"nCPreferencial").HasColumnType("decimal").IsOptional().HasPrecision(5,2);
            Property(x => x.NIdMetodoVal101).HasColumnName(@"nIdMetodoVal101").HasColumnType("int").IsRequired();
            Property(x => x.BAplicaTlc).HasColumnName(@"bAplicaTLC").HasColumnType("bit").IsRequired();
            Property(x => x.BAplicaAladi).HasColumnName(@"bAplicaALADI").HasColumnType("bit").IsRequired();
            Property(x => x.NMontoDesgravacion).HasColumnName(@"nMontoDesgravacion").HasColumnType("decimal").IsOptional().HasPrecision(6,3);
            Property(x => x.NTipoArancel).HasColumnName(@"nTipoArancel").HasColumnType("tinyint").IsRequired();
            Property(x => x.NTasaArancel).HasColumnName(@"nTasaArancel").HasColumnType("decimal").IsRequired().HasPrecision(10,5);
            Property(x => x.NTasaMaxAdv).HasColumnName(@"nTasaMaxAdv").HasColumnType("decimal").IsRequired().HasPrecision(10,5);
            Property(x => x.SUm).HasColumnName(@"sUM").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.SEs).HasColumnName(@"sES").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1);
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DConsultaTarifa).HasColumnName(@"dConsultaTarifa").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NPeso).HasColumnName(@"nPeso").HasColumnType("decimal").IsOptional().HasPrecision(17,6);
            Property(x => x.NMt).HasColumnName(@"nMT").HasColumnType("decimal").IsOptional().HasPrecision(15,10);
            Property(x => x.NValorMinimo).HasColumnName(@"nValorMinimo").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsOptional();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NTipoRegistro).HasColumnName(@"nTipoRegistro").HasColumnType("tinyint").IsOptional();
            Property(x => x.SRegistro).HasColumnName(@"sRegistro").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BCertificadoOrigen).HasColumnName(@"bCertificadoOrigen").HasColumnType("bit").IsOptional();
            Property(x => x.DEmision).HasColumnName(@"dEmision").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DVencimiento).HasColumnName(@"dVencimiento").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.BSubModelo).HasColumnName(@"bSubModelo").HasColumnType("bit").IsOptional();
            Property(x => x.BExotico).HasColumnName(@"bExotico").HasColumnType("bit").IsOptional();
            Property(x => x.NIdMotivosPartes412).HasColumnName(@"nIdMotivosPartes412").HasColumnType("int").IsOptional();
            Property(x => x.SMotivosPartesLibre).HasColumnName(@"sMotivosPartesLibre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NIdUmcove410).HasColumnName(@"nIdUMCOVE410").HasColumnType("int").IsOptional();
            Property(x => x.SDescripcionCertificado).HasColumnName(@"sDescripcionCertificado").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SArchivoCarga).HasColumnName(@"sArchivoCarga").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NPuedeRequerirPgr).HasColumnName(@"nPuedeRequerirPGR").HasColumnType("tinyint").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir01Pais_NIdPaisCompVend01).WithMany(b => b.SIR_Sir413HistoricoParte_NIdPaisCompVend01).HasForeignKey(c => c.NIdPaisCompVend01).WillCascadeOnDelete(false); // FK_SIR_413_HISTORICO_PARTE_SIR_01_PAISES1
            HasOptional(a => a.SIR_Sir01Pais_NIdPaisOriDest01).WithMany(b => b.SIR_Sir413HistoricoParte_NIdPaisOriDest01).HasForeignKey(c => c.NIdPaisOriDest01).WillCascadeOnDelete(false); // FK_SIR_413_HISTORICO_PARTE_SIR_01_PAISES
            HasOptional(a => a.SIR_Sir10UnidadesMedida_NIdUmc10).WithMany(b => b.SIR_Sir413HistoricoParte_NIdUmc10).HasForeignKey(c => c.NIdUmc10).WillCascadeOnDelete(false); // FK_SIR_413_HISTORICO_PARTE_SIR_10_UNIDADES_MEDIDA
            HasOptional(a => a.SIR_Sir10UnidadesMedida_NIdUmt10).WithMany(b => b.SIR_Sir413HistoricoParte_NIdUmt10).HasForeignKey(c => c.NIdUmt10).WillCascadeOnDelete(false); // FK_SIR_413_HISTORICO_PARTE_SIR_10_UNIDADES_MEDIDA1
            HasOptional(a => a.SIR_Sir410UnidadesMedidaCove).WithMany(b => b.SIR_Sir413HistoricoParte).HasForeignKey(c => c.NIdUmcove410).WillCascadeOnDelete(false); // FK_SIR_413_HISTORICO_PARTE_SIR_410_UNIDADES_MEDIDA_COVE
            HasOptional(a => a.SIR_Sir412MotivosModificacionParte).WithMany(b => b.SIR_Sir413HistoricoParte).HasForeignKey(c => c.NIdMotivosPartes412).WillCascadeOnDelete(false); // FK_SIR_413_HISTORICO_PARTE_SIR_412_MOTIVOS_MODIFICACION_PARTES
            HasOptional(a => a.SIR_Sir42Proveedore).WithMany(b => b.SIR_Sir413HistoricoParte).HasForeignKey(c => c.NIdProveedor42).WillCascadeOnDelete(false); // FK_SIR_413_HISTORICO_PARTE_SIR_42_PROVEEDORES
            HasOptional(a => a.SIR_Sir99Parte).WithMany(b => b.SIR_Sir413HistoricoParte).HasForeignKey(c => c.NIdParte99).WillCascadeOnDelete(false); // FK_SIR_413_HISTORICO_PARTE_SIR_99_PARTES
            HasRequired(a => a.SIR_Sir101MetodosValoracion).WithMany(b => b.SIR_Sir413HistoricoParte).HasForeignKey(c => c.NIdMetodoVal101).WillCascadeOnDelete(false); // FK_SIR_413_HISTORICO_PARTE_SIR_101_METODOS_VALORACION
        }
    }

}
// </auto-generated>
