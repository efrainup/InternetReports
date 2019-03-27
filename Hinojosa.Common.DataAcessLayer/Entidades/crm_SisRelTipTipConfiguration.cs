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

    // sis_rel_tip_tip
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisRelTipTipConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<crm_SisRelTipTip>
    {
        public crm_SisRelTipTipConfiguration()
            : this("crm")
        {
        }

        public crm_SisRelTipTipConfiguration(string schema)
        {
            ToTable("sis_rel_tip_tip", schema);
            HasKey(x => x.IdRelTipTip);

            Property(x => x.IdRelTipTip).HasColumnName(@"id_rel_tip_tip").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdTip1).HasColumnName(@"id_tip1").HasColumnType("int").IsRequired();
            Property(x => x.IdTip2).HasColumnName(@"id_tip2").HasColumnType("int").IsRequired();
            Property(x => x.IdTbl).HasColumnName(@"id_tbl").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>