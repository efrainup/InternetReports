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

    // sis_grup_tip
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisGrupTipConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<crm_SisGrupTip>
    {
        public crm_SisGrupTipConfiguration()
            : this("crm")
        {
        }

        public crm_SisGrupTipConfiguration(string schema)
        {
            ToTable("sis_grup_tip", schema);
            HasKey(x => x.IdGrupTip);

            Property(x => x.IdGrupTip).HasColumnName(@"id_grup_tip").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdGrup).HasColumnName(@"id_grup").HasColumnType("int").IsRequired();
            Property(x => x.IdTip).HasColumnName(@"id_tip").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
