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

    // rel_prom_vta_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RelPromVtaDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelPromVtaDet>
    {
        public RelPromVtaDetConfiguration()
            : this("dbo")
        {
        }

        public RelPromVtaDetConfiguration(string schema)
        {
            ToTable("rel_prom_vta_det", schema);
            HasKey(x => x.IdRelPromVtaDet);

            Property(x => x.IdRelPromVtaDet).HasColumnName(@"id_rel_prom_vta_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdRelPromVta).HasColumnName(@"id_rel_prom_vta").HasColumnType("int").IsRequired();
            Property(x => x.IdProm).HasColumnName(@"id_prom").HasColumnType("int").IsRequired();
            Property(x => x.CProm).HasColumnName(@"c_prom").HasColumnType("bit").IsRequired();
            Property(x => x.Tip).HasColumnName(@"tip").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
