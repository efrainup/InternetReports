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

    // SIR_640_BITACORA_ENVIO_PWC
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir640BitacoraEnvioPwcConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir640BitacoraEnvioPwc>
    {
        public SIR_Sir640BitacoraEnvioPwcConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir640BitacoraEnvioPwcConfiguration(string schema)
        {
            ToTable("SIR_640_BITACORA_ENVIO_PWC", schema);
            HasKey(x => x.NIdBitacoraEnvio640);

            Property(x => x.NIdBitacoraEnvio640).HasColumnName(@"nIdBitacoraEnvio640").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdConfigPwc638).HasColumnName(@"nIdConfigPWC638").HasColumnType("int").IsRequired();
            Property(x => x.DProgamadaDeEnvio).HasColumnName(@"dProgamadaDeEnvio").HasColumnType("datetime").IsRequired();
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
