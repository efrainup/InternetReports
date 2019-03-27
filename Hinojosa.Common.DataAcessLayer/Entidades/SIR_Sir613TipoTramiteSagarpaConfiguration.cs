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

    // SIR_613_TIPO_TRAMITE_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir613TipoTramiteSagarpaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir613TipoTramiteSagarpa>
    {
        public SIR_Sir613TipoTramiteSagarpaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir613TipoTramiteSagarpaConfiguration(string schema)
        {
            ToTable("SIR_613_TIPO_TRAMITE_SAGARPA", schema);
            HasKey(x => x.NIdTipoTramite613);

            Property(x => x.NIdTipoTramite613).HasColumnName(@"nIdTipoTramite613").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NClaveServicio).HasColumnName(@"nClaveServicio").HasColumnType("int").IsRequired();
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.SClaveSubServicio).HasColumnName(@"sClaveSubServicio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(3);
            Property(x => x.SDescripcionSubServicio).HasColumnName(@"sDescripcionSubServicio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.SClaveModalidad).HasColumnName(@"sClaveModalidad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(12);
            Property(x => x.SDescripcionModalidad).HasColumnName(@"sDescripcionModalidad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2000);
            Property(x => x.NDependencia).HasColumnName(@"nDependencia").HasColumnType("int").IsOptional();
            Property(x => x.DInicioVigencia).HasColumnName(@"dInicioVigencia").HasColumnType("datetime").IsOptional();
            Property(x => x.DTerminoVigencia).HasColumnName(@"dTerminoVigencia").HasColumnType("datetime").IsOptional();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsOptional();
        }
    }

}
// </auto-generated>