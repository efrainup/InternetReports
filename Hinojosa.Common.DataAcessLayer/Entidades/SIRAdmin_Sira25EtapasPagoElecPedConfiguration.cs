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

    // SIRA_25_ETAPAS_PAGO_ELEC_PED
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira25EtapasPagoElecPedConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira25EtapasPagoElecPed>
    {
        public SIRAdmin_Sira25EtapasPagoElecPedConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira25EtapasPagoElecPedConfiguration(string schema)
        {
            ToTable("SIRA_25_ETAPAS_PAGO_ELEC_PED", schema);
            HasKey(x => x.IdEtpe25);

            Property(x => x.IdEtpe25).HasColumnName(@"IdETPE25").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
// </auto-generated>
