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

    // SIRA_38_CAMPOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira38CamposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira38Campos>
    {
        public SIRAdmin_Sira38CamposConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira38CamposConfiguration(string schema)
        {
            ToTable("SIRA_38_CAMPOS", schema);
            HasKey(x => x.NIdCampo38);

            Property(x => x.NIdCampo38).HasColumnName(@"nIdCampo38").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SNombreCorto).HasColumnName(@"sNombreCorto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(800);
            Property(x => x.NTipo).HasColumnName(@"nTipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.NLongitud).HasColumnName(@"nLongitud").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(60);
        }
    }

}
// </auto-generated>
