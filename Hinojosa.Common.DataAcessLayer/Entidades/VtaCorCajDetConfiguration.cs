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

    // vta_cor_caj_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaCorCajDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VtaCorCajDet>
    {
        public VtaCorCajDetConfiguration()
            : this("dbo")
        {
        }

        public VtaCorCajDetConfiguration(string schema)
        {
            ToTable("vta_cor_caj_det", schema);
            HasKey(x => new { x.IdCorDet, x.IdCorCaj, x.IdDoc, x.IdNota, x.MonVta });

            Property(x => x.IdCorDet).HasColumnName(@"id_cor_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCorCaj).HasColumnName(@"id_cor_caj").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsOptional();
            Property(x => x.IdTip).HasColumnName(@"id_tip").HasColumnType("int").IsOptional();
            Property(x => x.Mon).HasColumnName(@"mon").HasColumnType("float").IsOptional();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MonVta).HasColumnName(@"mon_vta").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>