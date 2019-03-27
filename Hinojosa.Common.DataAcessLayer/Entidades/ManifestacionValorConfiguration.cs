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

    // Manifestacion_Valor
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ManifestacionValorConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ManifestacionValor>
    {
        public ManifestacionValorConfiguration()
            : this("dbo")
        {
        }

        public ManifestacionValorConfiguration(string schema)
        {
            ToTable("Manifestacion_Valor", schema);
            HasKey(x => x.NIdManifestacion);

            Property(x => x.NIdManifestacion).HasColumnName(@"nIdManifestacion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired();
            Property(x => x.SProveedor).HasColumnName(@"sProveedor").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SPrCalle).HasColumnName(@"sPrCalle").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SPrNumExterior).HasColumnName(@"sPrNumExterior").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SPrNumInterior).HasColumnName(@"sPrNumInterior").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SPrCiudad).HasColumnName(@"sPrCiudad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SPrEstado).HasColumnName(@"sPrEstado").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SPrPais).HasColumnName(@"sPrPais").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SPrCodigoPostal).HasColumnName(@"sPrCodigoPostal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.SPrTelefono).HasColumnName(@"sPrTelefono").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SPrCorreo).HasColumnName(@"sPrCorreo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.NVinculacionIv).HasColumnName(@"nVinculacionIV").HasColumnType("int").IsOptional();
            Property(x => x.NInfluyoVt).HasColumnName(@"nInfluyoVT").HasColumnType("int").IsOptional();
            Property(x => x.SImportador).HasColumnName(@"sImportador").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SIApellidoP).HasColumnName(@"sIApellidoP").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SIApellidoM).HasColumnName(@"sIApellidoM").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SINombre).HasColumnName(@"sINombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SIRfc).HasColumnName(@"sIRfc").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(13);
            Property(x => x.SICalle).HasColumnName(@"sICalle").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SINumExterior).HasColumnName(@"sINumExterior").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SINumInterior).HasColumnName(@"sINumInterior").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SIColonia).HasColumnName(@"sIColonia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SICodigoPostal).HasColumnName(@"sICodigoPostal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.SIMunicipio).HasColumnName(@"sIMunicipio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SIEntidadFed).HasColumnName(@"sIEntidadFed").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SITelefono).HasColumnName(@"sITelefono").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SICorreo).HasColumnName(@"sICorreo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SAaApellidoP).HasColumnName(@"sAAApellidoP").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SAaApellidoM).HasColumnName(@"sAAApellidoM").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SAaNombre).HasColumnName(@"sAANombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SAaPatente).HasColumnName(@"sAAPatente").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4);
            Property(x => x.NMetodoVal).HasColumnName(@"nMetodoVal").HasColumnType("int").IsOptional();
            Property(x => x.SMetodosUtil).HasColumnName(@"sMetodosUtil").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(6);
            Property(x => x.SDescripcion1).HasColumnName(@"sDescripcion1").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SDescripcion2).HasColumnName(@"sDescripcion2").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SDescripcion3).HasColumnName(@"sDescripcion3").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SDescripcion4).HasColumnName(@"sDescripcion4").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SDescripcion5).HasColumnName(@"sDescripcion5").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SDescripcion6).HasColumnName(@"sDescripcion6").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.N1GAnexaDoc).HasColumnName(@"n1GAnexaDoc").HasColumnType("int").IsOptional();
            Property(x => x.N1GNumHojasAnexo).HasColumnName(@"n1GNumHojasAnexo").HasColumnType("int").IsOptional();
            Property(x => x.SConceptoNoIntegranVt).HasColumnName(@"sConceptoNoIntegranVT").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4);
            Property(x => x.N2CAnexaDocMv).HasColumnName(@"n2CAnexaDocMV").HasColumnType("int").IsOptional();
            Property(x => x.N2DNoAnexaInf).HasColumnName(@"n2DNoAnexaInf").HasColumnType("int").IsOptional();
            Property(x => x.NPrecioMer65).HasColumnName(@"nPrecioMer65").HasColumnType("int").IsOptional();
            Property(x => x.NOptaPorAcompanaroNo).HasColumnName(@"nOptaPorAcompanaroNo").HasColumnType("int").IsOptional();
            Property(x => x.N2DAnexaDoc).HasColumnName(@"n2DAnexaDoc").HasColumnType("int").IsOptional();
            Property(x => x.N2DNoAnexaDoc).HasColumnName(@"n2DNoAnexaDoc").HasColumnType("int").IsOptional();
            Property(x => x.NBaseGravable).HasColumnName(@"nBaseGravable").HasColumnType("int").IsOptional();
            Property(x => x.NAcompanaDocVa).HasColumnName(@"nAcompanaDocVA").HasColumnType("int").IsOptional();
            Property(x => x.NValorMerProvisional).HasColumnName(@"nValorMerProvisional").HasColumnType("int").IsOptional();
            Property(x => x.NAnexaDocVm).HasColumnName(@"nAnexaDocVM").HasColumnType("int").IsOptional();
            Property(x => x.NManifestacionPresentada).HasColumnName(@"nManifestacionPresentada").HasColumnType("int").IsOptional();
            Property(x => x.S5Rfc).HasColumnName(@"s5Rfc").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(13);
            Property(x => x.DFechaPresentacion).HasColumnName(@"dFechaPresentacion").HasColumnType("datetime").IsOptional();
            Property(x => x.NFirma).HasColumnName(@"nFirma").HasColumnType("int").IsOptional();
            Property(x => x.N5NombreFirma).HasColumnName(@"n5NombreFirma").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
        }
    }

}
// </auto-generated>