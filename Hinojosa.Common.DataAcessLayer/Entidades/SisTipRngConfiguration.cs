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

    // sis_tip_rng
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisTipRngConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisTipRng>
    {
        public SisTipRngConfiguration()
            : this("dbo")
        {
        }

        public SisTipRngConfiguration(string schema)
        {
            ToTable("sis_tip_rng", schema);
            HasKey(x => x.Tipo);

            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DesTipo).HasColumnName(@"des_tipo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Rango1).HasColumnName(@"rango1").HasColumnType("int").IsRequired();
            Property(x => x.Rango2).HasColumnName(@"rango2").HasColumnType("int").IsRequired();
            Property(x => x.CMantto).HasColumnName(@"c_mantto").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
