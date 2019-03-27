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

    // SIR_596_PLANTASSQD
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir596PlantassqdConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir596Plantassqd>
    {
        public SIR_Sir596PlantassqdConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir596PlantassqdConfiguration(string schema)
        {
            ToTable("SIR_596_PLANTASSQD", schema);
            HasKey(x => x.NIdPlantaSqd596);

            Property(x => x.NIdPlantaSqd596).HasColumnName(@"nIdPlantaSQD596").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SPlantaSqd).HasColumnName(@"sPlantaSQD").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(350);
            Property(x => x.BEstatus).HasColumnName(@"bEstatus").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
