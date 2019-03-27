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

    // sis_interv
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisIntervConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<crm_SisInterv>
    {
        public crm_SisIntervConfiguration()
            : this("crm")
        {
        }

        public crm_SisIntervConfiguration(string schema)
        {
            ToTable("sis_interv", schema);
            HasKey(x => x.IdInterv);

            Property(x => x.IdInterv).HasColumnName(@"id_interv").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Interv).HasColumnName(@"interv").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Abrv).HasColumnName(@"abrv").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CantInterv).HasColumnName(@"cant_interv").HasColumnType("int").IsRequired();
            Property(x => x.Orden).HasColumnName(@"orden").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>