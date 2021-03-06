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

    // SIR_28_CLAVES_DOCTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir28ClavesDoctoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir28ClavesDocto>
    {
        public SIR_Sir28ClavesDoctoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir28ClavesDoctoConfiguration(string schema)
        {
            ToTable("SIR_28_CLAVES_DOCTOS", schema);
            HasKey(x => x.NIdClaveDocto28);

            Property(x => x.NIdClaveDocto28).HasColumnName(@"nIdClaveDocto28").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.SSupuestoApp).HasColumnName(@"sSupuestoApp").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.BRetornoImpo).HasColumnName(@"bRetornoImpo").HasColumnType("bit").IsOptional();
            Property(x => x.BRetornoExpo).HasColumnName(@"bRetornoExpo").HasColumnType("bit").IsOptional();
            Property(x => x.SPlazoMaximo).HasColumnName(@"sPlazoMaximo").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SBaseLegal).HasColumnName(@"sBaseLegal").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.BAlmacenDeposito).HasColumnName(@"bAlmacenDeposito").HasColumnType("bit").IsRequired();
            Property(x => x.NTasaDtaImpo).HasColumnName(@"nTasaDTAImpo").HasColumnType("tinyint").IsOptional();
            Property(x => x.NTasaDtaExpo).HasColumnName(@"nTasaDTAExpo").HasColumnType("tinyint").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.SParticularidad).HasColumnName(@"sParticularidad").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();
            Property(x => x.BDerogado).HasColumnName(@"bDerogado").HasColumnType("bit").IsRequired();
            Property(x => x.DFechaDerogacion).HasColumnName(@"dFechaDerogacion").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SClaveAnterior).HasColumnName(@"sClaveAnterior").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.BExtraccionImpo).HasColumnName(@"bExtraccionImpo").HasColumnType("bit").IsRequired();
            Property(x => x.BExtraccionExpo).HasColumnName(@"bExtraccionExpo").HasColumnType("bit").IsRequired();
            Property(x => x.BReexpImpo).HasColumnName(@"bReexpImpo").HasColumnType("bit").IsRequired();
            Property(x => x.BReexpExpo).HasColumnName(@"bReexpExpo").HasColumnType("bit").IsRequired();
            Property(x => x.BCambioRegimenImpo).HasColumnName(@"bCambioRegimenImpo").HasColumnType("bit").IsRequired();
            Property(x => x.BCambioRegimenExpo).HasColumnName(@"bCambioRegimenExpo").HasColumnType("bit").IsRequired();
            Property(x => x.BTransito).HasColumnName(@"bTransito").HasColumnType("bit").IsRequired();
            Property(x => x.BPagoPrevImpo).HasColumnName(@"bPagoPrevImpo").HasColumnType("bit").IsRequired();
            Property(x => x.BPagoPrevExpo).HasColumnName(@"bPagoPrevExpo").HasColumnType("bit").IsRequired();
            Property(x => x.BSinIvaExpo).HasColumnName(@"bSinIvaExpo").HasColumnType("bit").IsRequired();
            Property(x => x.BSinIvaImpo).HasColumnName(@"bSinIvaImpo").HasColumnType("bit").IsRequired();
            Property(x => x.BSinNomImpo).HasColumnName(@"bSinNomImpo").HasColumnType("bit").IsRequired();
            Property(x => x.BSinNomExpo).HasColumnName(@"bSinNomExpo").HasColumnType("bit").IsRequired();
            Property(x => x.NIdConfig318).HasColumnName(@"nIdConfig318").HasColumnType("int").IsOptional();
            Property(x => x.BCerIvaieps).HasColumnName(@"bCerIVAIEPS").HasColumnType("bit").IsOptional();
            Property(x => x.BAplicaPreciosEst).HasColumnName(@"bAplicaPreciosEst").HasColumnType("bit").IsOptional();
            Property(x => x.SMetValImpo).HasColumnName(@"sMetValImpo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.SMetValExpo).HasColumnName(@"sMetValExpo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.BNoAplicaRecargo).HasColumnName(@"bNoAplicaRecargo").HasColumnType("int").IsOptional();
            Property(x => x.BAplicaFechaEntradaA4Exp).HasColumnName(@"bAplicaFechaEntradaA4Exp").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir318ConfigCvedoctoFracc).WithMany(b => b.SIR_Sir28ClavesDocto).HasForeignKey(c => c.NIdConfig318).WillCascadeOnDelete(false); // FK_SIR_28_CLAVES_DOCTOS_SIR_318_CONFIG_CVEDOCTO_FRACC
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir28ClavesDocto).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_28_CLAVES_DOCTOS_cat_usr_ed
        }
    }

}
// </auto-generated>
