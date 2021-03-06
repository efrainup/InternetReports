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

    // SIR_725_ERRORES_AVISO_ELECTRONICO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir725ErroresAvisoElectronicoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir725ErroresAvisoElectronico>
    {
        public SIR_Sir725ErroresAvisoElectronicoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir725ErroresAvisoElectronicoConfiguration(string schema)
        {
            ToTable("SIR_725_ERRORES_AVISO_ELECTRONICO", schema);
            HasKey(x => x.NIdErrorAvi725);

            Property(x => x.NIdErrorAvi725).HasColumnName(@"nIdErrorAvi725").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NCodigo).HasColumnName(@"nCodigo").HasColumnType("int").IsRequired();
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
        }
    }

}
// </auto-generated>
