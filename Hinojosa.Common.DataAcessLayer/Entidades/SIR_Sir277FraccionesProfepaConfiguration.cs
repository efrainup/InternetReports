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

    // SIR_277_FRACCIONES_PROFEPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir277FraccionesProfepaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir277FraccionesProfepa>
    {
        public SIR_Sir277FraccionesProfepaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir277FraccionesProfepaConfiguration(string schema)
        {
            ToTable("SIR_277_FRACCIONES_PROFEPA", schema);
            HasKey(x => x.NIdFraccProfepa277);

            Property(x => x.NIdFraccProfepa277).HasColumnName(@"nIdFraccProfepa277").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdProfepa273).HasColumnName(@"nIdProfepa273").HasColumnType("int").IsRequired();
            Property(x => x.NTipoProd265).HasColumnName(@"nTipoProd265").HasColumnType("int").IsOptional();
            Property(x => x.NIdCondado263).HasColumnName(@"nIdCondado263").HasColumnType("int").IsOptional();
            Property(x => x.NIdTipDocProf264).HasColumnName(@"nIdTipDocProf264").HasColumnType("int").IsOptional();
            Property(x => x.NIdIdComCi267).HasColumnName(@"nIdIdComCi267").HasColumnType("int").IsOptional();
            Property(x => x.NIdEntidadOri).HasColumnName(@"nIdEntidadOri").HasColumnType("int").IsOptional();
            Property(x => x.NIdPaisProc).HasColumnName(@"nIdPaisProc").HasColumnType("int").IsOptional();
            Property(x => x.NIdEntidadProc).HasColumnName(@"nIdEntidadProc").HasColumnType("int").IsOptional();
            Property(x => x.NIdEntidadCert).HasColumnName(@"nIdEntidadCert").HasColumnType("int").IsOptional();
            Property(x => x.NMonto).HasColumnName(@"nMonto").HasColumnType("int").IsOptional();
            Property(x => x.SPlantacion).HasColumnName(@"sPlantacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SCertificado).HasColumnName(@"sCertificado").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(12);
            Property(x => x.SFirmaSemarnat).HasColumnName(@"sFirmaSEMARNAT").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SCertificadoOrigen).HasColumnName(@"sCertificadoOrigen").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(55);
            Property(x => x.DFechaExp).HasColumnName(@"dFechaExp").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaVen).HasColumnName(@"dFechaVen").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.SFraccion).HasColumnName(@"sFraccion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8);
            Property(x => x.NNumero).HasColumnName(@"nNumero").HasColumnType("int").IsOptional();
            Property(x => x.SDescripcionAa).HasColumnName(@"sDescripcionAA").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NCantidadFactura).HasColumnName(@"nCantidadFactura").HasColumnType("int").IsOptional();
            Property(x => x.NIdPais01).HasColumnName(@"nIdPais01").HasColumnType("int").IsOptional();
            Property(x => x.NIdUmc10).HasColumnName(@"nIdUMC10").HasColumnType("int").IsOptional();
            Property(x => x.NIdFacPartAgrupada100).HasColumnName(@"nIdFacPartAgrupada100").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.CatEdo_NIdEntidadCert).WithMany(b => b.SIR_Sir277FraccionesProfepa_NIdEntidadCert).HasForeignKey(c => c.NIdEntidadCert).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_cat_edos
            HasOptional(a => a.CatEdo_NIdEntidadOri).WithMany(b => b.SIR_Sir277FraccionesProfepa_NIdEntidadOri).HasForeignKey(c => c.NIdEntidadOri).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_cat_edos_ori
            HasOptional(a => a.CatEdo_NIdEntidadProc).WithMany(b => b.SIR_Sir277FraccionesProfepa_NIdEntidadProc).HasForeignKey(c => c.NIdEntidadProc).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_cat_edos_proc
            HasOptional(a => a.SIR_Sir01Pais_NIdPais01).WithMany(b => b.SIR_Sir277FraccionesProfepa_NIdPais01).HasForeignKey(c => c.NIdPais01).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_SIR_01_PAISES
            HasOptional(a => a.SIR_Sir01Pais_NIdPaisProc).WithMany(b => b.SIR_Sir277FraccionesProfepa_NIdPaisProc).HasForeignKey(c => c.NIdPaisProc).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_SIR_01_PAISES_proc
            HasOptional(a => a.SIR_Sir100FacPartAgrupada).WithMany(b => b.SIR_Sir277FraccionesProfepa).HasForeignKey(c => c.NIdFacPartAgrupada100).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_SIR_100_FAC_PART_AGRUPADAS
            HasOptional(a => a.SIR_Sir10UnidadesMedida).WithMany(b => b.SIR_Sir277FraccionesProfepa).HasForeignKey(c => c.NIdUmc10).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_SIR_10_UNIDADES_MEDIDA
            HasOptional(a => a.SIR_Sir263Condado).WithMany(b => b.SIR_Sir277FraccionesProfepa).HasForeignKey(c => c.NIdCondado263).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_SIR_263_CONDADOS
            HasOptional(a => a.SIR_Sir264TiposDocProfepa).WithMany(b => b.SIR_Sir277FraccionesProfepa).HasForeignKey(c => c.NIdTipDocProf264).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_SIR_264_TIPOS_DOC_PROFEPA
            HasOptional(a => a.SIR_Sir265TiposProducto).WithMany(b => b.SIR_Sir277FraccionesProfepa).HasForeignKey(c => c.NTipoProd265).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_SIR_265_TIPOS_PRODUCTOS
            HasOptional(a => a.SIR_Sir267IdentComCientifico).WithMany(b => b.SIR_Sir277FraccionesProfepa).HasForeignKey(c => c.NIdIdComCi267).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_SIR_267_IDENT_COM_CIENTIFICOS
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir277FraccionesProfepa).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_cat_usr_ed
            HasRequired(a => a.SIR_Sir273Profepa).WithMany(b => b.SIR_Sir277FraccionesProfepa).HasForeignKey(c => c.NIdProfepa273).WillCascadeOnDelete(false); // FK_SIR_277_FRACCIONES_PROFEPA_SIR_273_PROFEPA
        }
    }

}
// </auto-generated>