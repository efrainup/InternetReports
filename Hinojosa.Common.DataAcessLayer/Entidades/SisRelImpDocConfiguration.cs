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

    // sis_rel_imp_doc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRelImpDocConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisRelImpDoc>
    {
        public SisRelImpDocConfiguration()
            : this("dbo")
        {
        }

        public SisRelImpDocConfiguration(string schema)
        {
            ToTable("sis_rel_imp_doc", schema);
            HasKey(x => x.IdRelImpDoc);

            Property(x => x.IdRelImpDoc).HasColumnName(@"id_rel_imp_doc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
// </auto-generated>