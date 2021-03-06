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

    // SIR_251_MANIFESTACIONES_VALOR
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir251ManifestacionesValorConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir251ManifestacionesValor>
    {
        public SIR_Sir251ManifestacionesValorConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir251ManifestacionesValorConfiguration(string schema)
        {
            ToTable("SIR_251_MANIFESTACIONES_VALOR", schema);
            HasKey(x => x.NIdManValor251);

            Property(x => x.NIdManValor251).HasColumnName(@"nIdManValor251").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired();
            Property(x => x.NTransaccion).HasColumnName(@"nTransaccion").HasColumnType("tinyint").IsOptional();
            Property(x => x.NValidoPor).HasColumnName(@"nValidoPor").HasColumnType("tinyint").IsOptional();
            Property(x => x.BCompraVenta).HasColumnName(@"bCompraVenta").HasColumnType("bit").IsOptional();
            Property(x => x.BRestricciones).HasColumnName(@"bRestricciones").HasColumnType("bit").IsOptional();
            Property(x => x.BContraPrestaciones).HasColumnName(@"bContraPrestaciones").HasColumnType("bit").IsOptional();
            Property(x => x.BRegaliasReversiones).HasColumnName(@"bRegaliasReversiones").HasColumnType("bit").IsOptional();
            Property(x => x.BMasPedimentos).HasColumnName(@"bMasPedimentos").HasColumnType("bit").IsOptional();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NOtrosPedDes).HasColumnName(@"nOtrosPedDes").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NComisionesDes).HasColumnName(@"nComisionesDes").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NFlestesDes).HasColumnName(@"nFlestesDes").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NCargaDescargaDes).HasColumnName(@"nCargaDescargaDes").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NMaterial).HasColumnName(@"nMaterial").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NTecnologiaDes).HasColumnName(@"nTecnologiaDes").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NRegaliasDes).HasColumnName(@"nRegaliasDes").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NReversionesDes).HasColumnName(@"nReversionesDes").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NTotalDesglose).HasColumnName(@"nTotalDesglose").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NNoRelacionadosDiv).HasColumnName(@"nNoRelacionadosDiv").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NFletesDiv).HasColumnName(@"nFletesDiv").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NConstDiv).HasColumnName(@"nConstDiv").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NArmadoDiv).HasColumnName(@"nArmadoDiv").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NDividendoDiv).HasColumnName(@"nDividendoDiv").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.NTotalDiversos).HasColumnName(@"nTotalDiversos").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NContribuciones).HasColumnName(@"nContribuciones").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NIdCliRep309).HasColumnName(@"nIdCliRep309").HasColumnType("int").IsOptional();
            Property(x => x.SCiudadTetraPak).HasColumnName(@"sCiudadTetraPak").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NIdIncoterm53).HasColumnName(@"nIdIncoterm53").HasColumnType("int").IsOptional();
            Property(x => x.NTratado).HasColumnName(@"nTratado").HasColumnType("tinyint").IsRequired();
            Property(x => x.BAplicaTetraPak).HasColumnName(@"bAplicaTetraPak").HasColumnType("bit").IsRequired();
            Property(x => x.BEsPrecioPrevistoFac).HasColumnName(@"bEsPrecioPrevistoFac").HasColumnType("bit").IsOptional();
            Property(x => x.BEsPrecioOtrosDoctos).HasColumnName(@"bEsPrecioOtrosDoctos").HasColumnType("bit").IsOptional();
            Property(x => x.BExistenConNoValorTrans).HasColumnName(@"bExistenConNoValorTrans").HasColumnType("bit").IsOptional();
            Property(x => x.BConceptosDesglosados).HasColumnName(@"bConceptosDesglosados").HasColumnType("bit").IsOptional();
            Property(x => x.BAnexaDocumentacionMv).HasColumnName(@"bAnexaDocumentacionMV").HasColumnType("bit").IsOptional();
            Property(x => x.BNoAnexaDocumentacionMv).HasColumnName(@"bNoAnexaDocumentacionMV").HasColumnType("bit").IsOptional();
            Property(x => x.NImportePrecPagado).HasColumnName(@"nImportePrecPagado").HasColumnType("tinyint").IsOptional();
            Property(x => x.NOptaFacturas).HasColumnName(@"nOptaFacturas").HasColumnType("tinyint").IsOptional();
            Property(x => x.NOptaDoctosValorAduana).HasColumnName(@"nOptaDoctosValorAduana").HasColumnType("tinyint").IsOptional();
            Property(x => x.NMercRegimenImpoTemporal).HasColumnName(@"nMercRegimenImpoTemporal").HasColumnType("tinyint").IsOptional();
            Property(x => x.NValorMciasProvicional).HasColumnName(@"nValorMciasProvicional").HasColumnType("tinyint").IsOptional();
            Property(x => x.NDocConstaValorMcia).HasColumnName(@"nDocConstaValorMcia").HasColumnType("tinyint").IsOptional();
            Property(x => x.BHcusd).HasColumnName(@"bHCUSD").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir309ClientesRepresentante).WithMany(b => b.SIR_Sir251ManifestacionesValor).HasForeignKey(c => c.NIdCliRep309).WillCascadeOnDelete(false); // FK_SIR_251_MANIFESTACIONES_VALOR_SIR_309_CLIENTES_REPRESENTANTES
            HasOptional(a => a.SIR_Sir53Incoterm).WithMany(b => b.SIR_Sir251ManifestacionesValor).HasForeignKey(c => c.NIdIncoterm53).WillCascadeOnDelete(false); // FK_SIR_251_MANIFESTACIONES_VALOR_SIR_53_INCOTERMS
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir251ManifestacionesValor).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_251_MANIFESTACIONES_VALOR_cat_usr_ed
            HasRequired(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir251ManifestacionesValor).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_251_MANIFESTACIONES_VALOR_SIR_60_REFERENCIAS
        }
    }

}
// </auto-generated>
