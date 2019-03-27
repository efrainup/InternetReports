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

    // SIR_370_LIBERACION_ELECTRONICA_GUIAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir370LiberacionElectronicaGuiaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir370LiberacionElectronicaGuia>
    {
        public SIR_Sir370LiberacionElectronicaGuiaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir370LiberacionElectronicaGuiaConfiguration(string schema)
        {
            ToTable("SIR_370_LIBERACION_ELECTRONICA_GUIAS", schema);
            HasKey(x => x.NIdLiberacionGuias370);

            Property(x => x.NIdLiberacionGuias370).HasColumnName(@"nIdLiberacionGuias370").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NNumeroOperacion).HasColumnName(@"nNumeroOperacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(7);
            Property(x => x.NIdTrasmisora369).HasColumnName(@"nIdTrasmisora369").HasColumnType("int").IsRequired();
            Property(x => x.NIdPuertoCarga04).HasColumnName(@"nIdPuertoCarga04").HasColumnType("int").IsOptional();
            Property(x => x.NIdPaisCarga01).HasColumnName(@"nIdPaisCarga01").HasColumnType("int").IsOptional();
            Property(x => x.NIdPuertoOrigen04).HasColumnName(@"nIdPuertoOrigen04").HasColumnType("int").IsOptional();
            Property(x => x.NIdPaisOrigen01).HasColumnName(@"nIdPaisOrigen01").HasColumnType("int").IsOptional();
            Property(x => x.NMovimiento).HasColumnName(@"nMovimiento").HasColumnType("int").IsRequired();
            Property(x => x.SNumeroManifiesto).HasColumnName(@"sNumeroManifiesto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(14);
            Property(x => x.NIdRegTrans41).HasColumnName(@"nIdRegTrans41").HasColumnType("int").IsOptional();
            Property(x => x.NTipoSolicitante).HasColumnName(@"nTipoSolicitante").HasColumnType("int").IsRequired();
            Property(x => x.SNombreSolicitante).HasColumnName(@"sNombreSolicitante").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.SRfc).HasColumnName(@"sRFC").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(13);
            Property(x => x.SCurp).HasColumnName(@"sCURP").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.NTipoPersona).HasColumnName(@"nTipoPersona").HasColumnType("int").IsRequired();
            Property(x => x.SReferenciaBancaria).HasColumnName(@"sReferenciaBancaria").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.NMontoPago).HasColumnName(@"nMontoPago").HasColumnType("decimal").IsOptional().HasPrecision(6,2);
            Property(x => x.NFacturarA).HasColumnName(@"nFacturarA").HasColumnType("int").IsRequired();
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsOptional();
            Property(x => x.NIdClie07).HasColumnName(@"nIdClie07").HasColumnType("int").IsOptional();
            Property(x => x.NIdServPre247).HasColumnName(@"nIdServPre247").HasColumnType("int").IsRequired();
            Property(x => x.BBloqueado).HasColumnName(@"bBloqueado").HasColumnType("bit").IsRequired();
            Property(x => x.SFolioFirma).HasColumnName(@"sFolioFirma").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8);
            Property(x => x.NIdCaatNavieras372).HasColumnName(@"nIdCaatNavieras372").HasColumnType("int").IsOptional();
            Property(x => x.SCorreoElectronico).HasColumnName(@"sCorreoElectronico").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasOptional(a => a.Admin_Adminc07Cliente).WithMany(b => b.SIR_Sir370LiberacionElectronicaGuia).HasForeignKey(c => c.NIdClie07).WillCascadeOnDelete(false); // FK_SIR_370_LIB_ELECTRONICA_GUIAS_ADMINC_07_CLIENTES
            HasOptional(a => a.CatCliente).WithMany(b => b.SIR_Sir370LiberacionElectronicaGuia).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_370_LIB_ELECTRONICA_GUIAS_cat_clientes
            HasOptional(a => a.SIR_Sir01Pais_NIdPaisCarga01).WithMany(b => b.SIR_Sir370LiberacionElectronicaGuia_NIdPaisCarga01).HasForeignKey(c => c.NIdPaisCarga01).WillCascadeOnDelete(false); // FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_01_PAISES
            HasOptional(a => a.SIR_Sir01Pais_NIdPaisOrigen01).WithMany(b => b.SIR_Sir370LiberacionElectronicaGuia_NIdPaisOrigen01).HasForeignKey(c => c.NIdPaisOrigen01).WillCascadeOnDelete(false); // FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_01_PAISES_ORIGEN
            HasOptional(a => a.SIR_Sir04Puerto_NIdPuertoCarga04).WithMany(b => b.SIR_Sir370LiberacionElectronicaGuia_NIdPuertoCarga04).HasForeignKey(c => c.NIdPuertoCarga04).WillCascadeOnDelete(false); // FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_04_PUERTOS
            HasOptional(a => a.SIR_Sir04Puerto_NIdPuertoOrigen04).WithMany(b => b.SIR_Sir370LiberacionElectronicaGuia_NIdPuertoOrigen04).HasForeignKey(c => c.NIdPuertoOrigen04).WillCascadeOnDelete(false); // FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_04_PUERTOS_ORIGEN
            HasOptional(a => a.SIR_Sir372CaatNaviera).WithMany(b => b.SIR_Sir370LiberacionElectronicaGuia).HasForeignKey(c => c.NIdCaatNavieras372).WillCascadeOnDelete(false); // FK_SIR_370_LIB_ELECT_GUIAS_SIR_372_CAAT_NAVIERAS
            HasOptional(a => a.SIR_Sir41RegTransporte).WithMany(b => b.SIR_Sir370LiberacionElectronicaGuia).HasForeignKey(c => c.NIdRegTrans41).WillCascadeOnDelete(false); // FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_41_REG_TRANSPORTES
            HasRequired(a => a.SIR_Sir247ServicioPrevalidacion).WithMany(b => b.SIR_Sir370LiberacionElectronicaGuia).HasForeignKey(c => c.NIdServPre247).WillCascadeOnDelete(false); // FK_SIR_370_LIB_ELECT_GUIAS_SIR_247_SERVICIO_PREVAL
            HasRequired(a => a.SIR_Sir369EntidadTrasmisora).WithMany(b => b.SIR_Sir370LiberacionElectronicaGuia).HasForeignKey(c => c.NIdTrasmisora369).WillCascadeOnDelete(false); // FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_369_ENTIDAD_TRASMISORA
        }
    }

}
// </auto-generated>
