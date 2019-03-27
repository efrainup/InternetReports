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

    // sis_ref_contenedores
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRefContenedoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisRefContenedore>
    {
        public SisRefContenedoreConfiguration()
            : this("dbo")
        {
        }

        public SisRefContenedoreConfiguration(string schema)
        {
            ToTable("sis_ref_contenedores", schema);
            HasKey(x => new { x.IdFac, x.IdRef, x.Numero });

            Property(x => x.IdFac).HasColumnName(@"id_fac").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Numero).HasColumnName(@"numero").HasColumnType("nvarchar").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Candado).HasColumnName(@"candado").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
        }
    }

}
// </auto-generated>
