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

    // SIR_527_PERMISOS_RRNA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir527PermisosRrnaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir527PermisosRrna>
    {
        public SIR_Sir527PermisosRrnaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir527PermisosRrnaConfiguration(string schema)
        {
            ToTable("SIR_527_PERMISOS_RRNA", schema);
            HasKey(x => x.NIdPermisoRrna527);

            Property(x => x.NIdPermisoRrna527).HasColumnName(@"nIdPermisoRRNA527").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdClie07).HasColumnName(@"nIdClie07").HasColumnType("int").IsOptional();
            Property(x => x.SPermiso).HasColumnName(@"sPermiso").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.DInicioVigencia).HasColumnName(@"dInicioVigencia").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFinVigencia).HasColumnName(@"dFinVigencia").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdPaisOrigen01).HasColumnName(@"nIdPaisOrigen01").HasColumnType("int").IsOptional();
            Property(x => x.NIdPaisProcedencia01).HasColumnName(@"nIdPaisProcedencia01").HasColumnType("int").IsOptional();
            Property(x => x.NIdProveedor42).HasColumnName(@"nIdProveedor42").HasColumnType("int").IsOptional();
            Property(x => x.NIdUMed10).HasColumnName(@"nIdUMed10").HasColumnType("int").IsOptional();
            Property(x => x.BAplicaCantidad).HasColumnName(@"bAplicaCantidad").HasColumnType("bit").IsOptional();
            Property(x => x.NCantidadAutorizada).HasColumnName(@"nCantidadAutorizada").HasColumnType("decimal").IsOptional().HasPrecision(15,3);
            Property(x => x.BProrroga).HasColumnName(@"bProrroga").HasColumnType("bit").IsOptional();
            Property(x => x.DInicioProrroga).HasColumnName(@"dInicioProrroga").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFinProrroga).HasColumnName(@"dFinProrroga").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SRegistro).HasColumnName(@"sRegistro").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.BSubdividir).HasColumnName(@"bSubdividir").HasColumnType("bit").IsOptional();
            Property(x => x.BTomarFotografia).HasColumnName(@"bTomarFotografia").HasColumnType("bit").IsOptional();
            Property(x => x.BVigencia).HasColumnName(@"bVigencia").HasColumnType("bit").IsOptional();
            Property(x => x.BPapeleta).HasColumnName(@"bPapeleta").HasColumnType("bit").IsOptional();
            Property(x => x.SPapeleta).HasColumnName(@"sPapeleta").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.DIngresoPapeleta).HasColumnName(@"dIngresoPapeleta").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SNorma).HasColumnName(@"sNorma").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NTipoAmpliacion).HasColumnName(@"nTipoAmpliacion").HasColumnType("tinyint").IsOptional();
            Property(x => x.NValorPesos).HasColumnName(@"nValorPesos").HasColumnType("decimal").IsOptional().HasPrecision(15,3);
            Property(x => x.NValorDolares).HasColumnName(@"nValorDolares").HasColumnType("decimal").IsOptional().HasPrecision(15,3);
            Property(x => x.NTipoAplicacion).HasColumnName(@"nTipoAplicacion").HasColumnType("tinyint").IsOptional();
            Property(x => x.SOficio).HasColumnName(@"sOficio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.SAutorizacion).HasColumnName(@"sAutorizacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NIdPermisoCofepris527).HasColumnName(@"nIdPermisoCOFEPRIS527").HasColumnType("int").IsOptional();
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsOptional();
            Property(x => x.NIdIdenPerm69).HasColumnName(@"nIdIdenPerm69").HasColumnType("int").IsOptional();
            Property(x => x.NTipoPermisoRrna).HasColumnName(@"nTipoPermisoRRNA").HasColumnType("tinyint").IsOptional();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SObservacion).HasColumnName(@"sObservacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.BAplicaSagarpa).HasColumnName(@"bAplicaSagarpa").HasColumnType("bit").IsOptional();
            Property(x => x.NIdPaisDestino01).HasColumnName(@"nIdPaisDestino01").HasColumnType("int").IsOptional();
            Property(x => x.SDescripcionMercancia).HasColumnName(@"sDescripcionMercancia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NIdPermisoPadreAmpliacion527).HasColumnName(@"nIdPermisoPadreAmpliacion527").HasColumnType("int").IsOptional();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsOptional();
            Property(x => x.BLote).HasColumnName(@"bLote").HasColumnType("bit").IsOptional();
            Property(x => x.BFechaEmbase).HasColumnName(@"bFechaEmbase").HasColumnType("bit").IsOptional();
            Property(x => x.BFechaCaducidad).HasColumnName(@"bFechaCaducidad").HasColumnType("bit").IsOptional();
            Property(x => x.BFechaElaboracion).HasColumnName(@"bFechaElaboracion").HasColumnType("bit").IsOptional();
            Property(x => x.BFechaSacrificio).HasColumnName(@"bFechaSacrificio").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc07Cliente).WithMany(b => b.SIR_Sir527PermisosRrna).HasForeignKey(c => c.NIdClie07).WillCascadeOnDelete(false); // FK_SIR_527_PERMISOS_RRNA_ADMINC_07_CLIENTES
            HasOptional(a => a.SIR_Sir01Pais_NIdPaisDestino01).WithMany(b => b.SIR_Sir527PermisosRrna_NIdPaisDestino01).HasForeignKey(c => c.NIdPaisDestino01).WillCascadeOnDelete(false); // FK_SIR_527_PERMISOS_RRNA_SIR_01_PAISES_Destino
            HasOptional(a => a.SIR_Sir01Pais_NIdPaisOrigen01).WithMany(b => b.SIR_Sir527PermisosRrna_NIdPaisOrigen01).HasForeignKey(c => c.NIdPaisOrigen01).WillCascadeOnDelete(false); // FK_SIR_527_PERMISOS_RRNA_SIR_01_PAISES
            HasOptional(a => a.SIR_Sir01Pais_NIdPaisProcedencia01).WithMany(b => b.SIR_Sir527PermisosRrna_NIdPaisProcedencia01).HasForeignKey(c => c.NIdPaisProcedencia01).WillCascadeOnDelete(false); // FK_SIR_527_PERMISOS_RRNA_SIR_01_PAISES_Procedencia
            HasOptional(a => a.SIR_Sir10UnidadesMedida).WithMany(b => b.SIR_Sir527PermisosRrna).HasForeignKey(c => c.NIdUMed10).WillCascadeOnDelete(false); // FK_SIR_527_PERMISOS_RRNA_SIR_10_UNIDADES_MEDIDA
            HasOptional(a => a.SIR_Sir42Proveedore).WithMany(b => b.SIR_Sir527PermisosRrna).HasForeignKey(c => c.NIdProveedor42).WillCascadeOnDelete(false); // FK_SIR_527_PERMISOS_RRNA_SIR_42_PROVEEDORES
            HasOptional(a => a.SIR_Sir527PermisosRrna1).WithMany(b => b.SIR_Sir527PermisosRrna2).HasForeignKey(c => c.NIdPermisoCofepris527).WillCascadeOnDelete(false); // FK_SIR_527_PERMISOS_RRNA_SIR_527_PERMISOS_RRNA
            HasOptional(a => a.SIR_Sir527PermisosRrna3).WithMany(b => b.SIR_Sir527PermisosRrna4).HasForeignKey(c => c.NIdPermisoPadreAmpliacion527).WillCascadeOnDelete(false); // FK_SIR_527_PERMISOS_RRNA_SIR_527_PERMISOS_RRNA_Ampliacion
            HasOptional(a => a.SIR_Sir69IdentificadorPermiso).WithMany(b => b.SIR_Sir527PermisosRrna).HasForeignKey(c => c.NIdIdenPerm69).WillCascadeOnDelete(false); // FK_SIR_527_PERMISOS_RRNA_SIR_69_IDENTIFICADOR_PERMISOS
            HasMany(t => t.SIR_Sir71SucursalPatenteAduana).WithMany(t => t.SIR_Sir527PermisosRrna).Map(m =>
            {
                m.ToTable("SIR_529_SUCURSALES_PERMISOS_RRNA", "SIR");
                m.MapLeftKey("nIdPermisoRRNA527");
                m.MapRightKey("nIdSucPatAdu71");
            });
        }
    }

}
// </auto-generated>
