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

    // SIR_67_MTRA_SELEC_ALEATORIA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir67MtraSelecAleatoriaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir67MtraSelecAleatoria>
    {
        public SIR_Sir67MtraSelecAleatoriaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir67MtraSelecAleatoriaConfiguration(string schema)
        {
            ToTable("SIR_67_MTRA_SELEC_ALEATORIA", schema);
            HasKey(x => x.NIdMtraSelAle67);

            Property(x => x.NIdMtraSelAle67).HasColumnName(@"nIdMtraSelAle67").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NPrimeraSel).HasColumnName(@"nPrimeraSel").HasColumnType("tinyint").IsOptional();
            Property(x => x.NSegundaSel).HasColumnName(@"nSegundaSel").HasColumnType("tinyint").IsOptional();
            Property(x => x.BMultasPrimSel).HasColumnName(@"bMultasPrimSel").HasColumnType("bit").IsOptional();
            Property(x => x.DFechaPrimSel).HasColumnName(@"dFechaPrimSel").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaSegSel).HasColumnName(@"dFechaSegSel").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaActaMuestreo).HasColumnName(@"dFechaActaMuestreo").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SMotivoPrimSel).HasColumnName(@"sMotivoPrimSel").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SNumMuestreo).HasColumnName(@"sNumMuestreo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NImportePrimSel).HasColumnName(@"nImportePrimSel").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NTerceraSel).HasColumnName(@"nTerceraSel").HasColumnType("tinyint").IsOptional();
            Property(x => x.DFechaTerSel).HasColumnName(@"dFechaTerSel").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SArchivoPrimSel).HasColumnName(@"sArchivoPrimSel").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SArchivoSegSel).HasColumnName(@"sArchivoSegSel").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SArchivoTerSel).HasColumnName(@"sArchivoTerSel").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SMotivoSegSel).HasColumnName(@"sMotivoSegSel").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NImporteSegSel).HasColumnName(@"nImporteSegSel").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.BMultasSegSel).HasColumnName(@"bMultasSegSel").HasColumnType("bit").IsRequired();
            Property(x => x.SMotivoTerSel).HasColumnName(@"sMotivoTerSel").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NImporteTerSel).HasColumnName(@"nImporteTerSel").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.BMultasTerSel).HasColumnName(@"bMultasTerSel").HasColumnType("bit").IsRequired();
            Property(x => x.DFechaFinPrimSel).HasColumnName(@"dFechaFinPrimSel").HasColumnType("datetime").IsOptional();
            Property(x => x.DFinRevisionTransporte).HasColumnName(@"dFinRevisionTransporte").HasColumnType("datetime").IsOptional();
            Property(x => x.BEsPama).HasColumnName(@"bEsPAMA").HasColumnType("bit").IsOptional();
            Property(x => x.NArea).HasColumnName(@"nArea").HasColumnType("tinyint").IsOptional();
            Property(x => x.SAreaResponsable).HasColumnName(@"sAreaResponsable").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(800);
            Property(x => x.SResponsable).HasColumnName(@"sResponsable").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(800);
            Property(x => x.NIdUsuarioTramitador01).HasColumnName(@"nIdUsuarioTramitador01").HasColumnType("int").IsOptional();
            Property(x => x.BRojoPrimerSelec).HasColumnName(@"bRojoPrimerSelec").HasColumnType("bit").IsOptional();
            Property(x => x.BVerdePrimerSelec).HasColumnName(@"bVerdePrimerSelec").HasColumnType("bit").IsOptional();
            Property(x => x.BDesaduanado).HasColumnName(@"bDesaduanado").HasColumnType("bit").IsOptional();
            Property(x => x.BCumplido).HasColumnName(@"bCumplido").HasColumnType("bit").IsOptional();
            Property(x => x.DFeRojoSelecAuto).HasColumnName(@"dFeRojoSelecAuto").HasColumnType("datetime").IsOptional();
            Property(x => x.DFeVerdeSelecAuto).HasColumnName(@"dFeVerdeSelecAuto").HasColumnType("datetime").IsOptional();
            Property(x => x.DFeDesaduanadoSelecAuto).HasColumnName(@"dFeDesaduanadoSelecAuto").HasColumnType("datetime").IsOptional();
            Property(x => x.DFeCumplidoSelecAuto).HasColumnName(@"dFeCumplidoSelecAuto").HasColumnType("datetime").IsOptional();
            Property(x => x.NIdUsuarioTramitadorReco01).HasColumnName(@"nIdUsuarioTramitadorReco01").HasColumnType("int").IsOptional();
            Property(x => x.NIdCausaIncidencia702).HasColumnName(@"nIdCausaIncidencia702").HasColumnType("int").IsOptional();
            Property(x => x.DInicioRni).HasColumnName(@"dInicioRNI").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DResultadoRni).HasColumnName(@"dResultadoRNI").HasColumnType("smalldatetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir67MtraSelecAleatoria).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_67_MTRA_SELEC_ALEATORIA_cat_usr_ed
        }
    }

}
// </auto-generated>
