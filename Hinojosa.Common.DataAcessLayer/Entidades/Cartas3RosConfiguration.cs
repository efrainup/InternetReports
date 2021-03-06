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

    // Cartas3ros
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Cartas3RosConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cartas3Ros>
    {
        public Cartas3RosConfiguration()
            : this("dbo")
        {
        }

        public Cartas3RosConfiguration(string schema)
        {
            ToTable("Cartas3ros", schema);
            HasKey(x => x.NIdCarta);

            Property(x => x.NIdCarta).HasColumnName(@"nIdCarta").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired();
            Property(x => x.BAnexo).HasColumnName(@"bAnexo").HasColumnType("bit").IsRequired();
            Property(x => x.DFechaAnexo).HasColumnName(@"dFechaAnexo").HasColumnType("datetime").IsOptional();
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("datetime").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
