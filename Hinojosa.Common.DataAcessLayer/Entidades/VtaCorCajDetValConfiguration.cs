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

    // vta_cor_caj_det_val
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaCorCajDetValConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VtaCorCajDetVal>
    {
        public VtaCorCajDetValConfiguration()
            : this("dbo")
        {
        }

        public VtaCorCajDetValConfiguration(string schema)
        {
            ToTable("vta_cor_caj_det_val", schema);
            HasKey(x => new { x.IdCorDet, x.IdCorCaj, x.IdValor, x.Cant });

            Property(x => x.IdCorDet).HasColumnName(@"id_cor_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCorCaj).HasColumnName(@"id_cor_caj").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdValor).HasColumnName(@"id_valor").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsOptional();
            Property(x => x.Cant2).HasColumnName(@"cant2").HasColumnType("float").IsOptional();
        }
    }

}
// </auto-generated>
