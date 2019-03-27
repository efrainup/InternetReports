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

    // SIR_273_PROFEPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir273ProfepaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir273Profepa>
    {
        public SIR_Sir273ProfepaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir273ProfepaConfiguration(string schema)
        {
            ToTable("SIR_273_PROFEPA", schema);
            HasKey(x => x.NIdProfepa273);

            Property(x => x.NIdProfepa273).HasColumnName(@"nIdProfepa273").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired();
            Property(x => x.NIdInspec271).HasColumnName(@"nIdInspec271").HasColumnType("int").IsOptional();
            Property(x => x.NIdDel266).HasColumnName(@"nIdDel266").HasColumnType("int").IsOptional();
            Property(x => x.NIdMedioTrans05).HasColumnName(@"nIdMedioTrans05").HasColumnType("int").IsOptional();
            Property(x => x.NIdFraccPago268).HasColumnName(@"nIdFraccPago268").HasColumnType("int").IsOptional();
            Property(x => x.NIdPInspec272).HasColumnName(@"nIdPInspec272").HasColumnType("int").IsOptional();
            Property(x => x.NIdProveedor42).HasColumnName(@"nIdProveedor42").HasColumnType("int").IsOptional();
            Property(x => x.NSecuencia).HasColumnName(@"nSecuencia").HasColumnType("int").IsOptional();
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.NObjImEx).HasColumnName(@"nObjImEx").HasColumnType("tinyint").IsRequired();
            Property(x => x.NComprobanteTrat).HasColumnName(@"nComprobanteTrat").HasColumnType("tinyint").IsRequired();
            Property(x => x.NTipoRv).HasColumnName(@"nTipoRV").HasColumnType("tinyint").IsRequired();
            Property(x => x.NImporte).HasColumnName(@"nImporte").HasColumnType("decimal").IsOptional().HasPrecision(13,3);
            Property(x => x.SPlacas).HasColumnName(@"sPlacas").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.SFirma).HasColumnName(@"sFirma").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SClaveDerecho).HasColumnName(@"sClaveDerecho").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(6);
            Property(x => x.SDictamenTecnico).HasColumnName(@"sDictamenTecnico").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.SNumeroActa).HasColumnName(@"sNumeroActa").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DFehaActa).HasColumnName(@"dFehaActa").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaPago).HasColumnName(@"dFechaPago").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaRegVal).HasColumnName(@"dFechaRegVal").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("int").IsRequired();
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsOptional();
            Property(x => x.NIdPreProf269).HasColumnName(@"nIdPrePROF269").HasColumnType("int").IsOptional();
            Property(x => x.SFolio).HasColumnName(@"sFolio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8);
            Property(x => x.SObservacion).HasColumnName(@"sObservacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasOptional(a => a.SIR_Sir05MediosTransporte).WithMany(b => b.SIR_Sir273Profepa).HasForeignKey(c => c.NIdMedioTrans05).WillCascadeOnDelete(false); // FK_SIR_273_PROFEPA_SIR_05_MEDIOS_TRANSPORTE
            HasOptional(a => a.SIR_Sir266DelegacionesProfepa).WithMany(b => b.SIR_Sir273Profepa).HasForeignKey(c => c.NIdDel266).WillCascadeOnDelete(false); // FK_SIR_273_PROFEPA_SIR_266_DELEGACIONES_PROFEPA
            HasOptional(a => a.SIR_Sir268FraccPagosDerecho).WithMany(b => b.SIR_Sir273Profepa).HasForeignKey(c => c.NIdFraccPago268).WillCascadeOnDelete(false); // FK_SIR_273_PROFEPA_SIR_268_FRACC_PAGOS_DERECHOS
            HasOptional(a => a.SIR_Sir269ClavesPrevProfepa).WithMany(b => b.SIR_Sir273Profepa).HasForeignKey(c => c.NIdPreProf269).WillCascadeOnDelete(false); // FK_SIR_273_PROFEPA_SIR_269_CLAVES_PREV_PROFEPA
            HasOptional(a => a.SIR_Sir271Inspectoria).WithMany(b => b.SIR_Sir273Profepa).HasForeignKey(c => c.NIdInspec271).WillCascadeOnDelete(false); // FK_SIR_273_PROFEPA_SIR_271_INSPECTORIAS
            HasOptional(a => a.SIR_Sir272PuntosInspeccion).WithMany(b => b.SIR_Sir273Profepa).HasForeignKey(c => c.NIdPInspec272).WillCascadeOnDelete(false); // FK_SIR_273_PROFEPA_SIR_272_PUNTOS_INSPECCION
            HasOptional(a => a.SIR_Sir42Proveedore).WithMany(b => b.SIR_Sir273Profepa).HasForeignKey(c => c.NIdProveedor42).WillCascadeOnDelete(false); // FK_SIR_273_PROFEPA_SIR_42_PROVEEDORES
            HasOptional(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir273Profepa).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_273_PROFEPA_SIR_71_SUCURSAL_PATENTE_ADUANA
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir273Profepa).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_273_PROFEPA_cat_usr_ed
            HasRequired(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir273Profepa).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_273_PROFEPA_SIR_60_REFERENCIAS
        }
    }

}
// </auto-generated>