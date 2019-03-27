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

    // SIR_660_PUNTOS_DE_VERIFICACION_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir660PuntosDeVerificacionSagarpaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir660PuntosDeVerificacionSagarpa>
    {
        public SIR_Sir660PuntosDeVerificacionSagarpaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir660PuntosDeVerificacionSagarpaConfiguration(string schema)
        {
            ToTable("SIR_660_PUNTOS_DE_VERIFICACION_SAGARPA", schema);
            HasKey(x => x.NIdPuntoVerificacion660);

            Property(x => x.NIdPuntoVerificacion660).HasColumnName(@"nIdPuntoVerificacion660").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SNombre).HasColumnName(@"sNombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.DInicioVigencia).HasColumnName(@"dInicioVigencia").HasColumnType("datetime").IsOptional();
            Property(x => x.DTerminoVigencia).HasColumnName(@"dTerminoVigencia").HasColumnType("datetime").IsOptional();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsOptional();
        }
    }

}
// </auto-generated>