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

    // sis_rel_clas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRelClaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisRelCla>
    {
        public SisRelClaConfiguration()
            : this("dbo")
        {
        }

        public SisRelClaConfiguration(string schema)
        {
            ToTable("sis_rel_clas", schema);
            HasKey(x => new { x.IdRelClas, x.IdClas });

            Property(x => x.IdRelClas).HasColumnName(@"id_rel_clas").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdClas).HasColumnName(@"id_clas").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tipoobj).HasColumnName(@"tipoobj").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatCla).WithMany(b => b.SisRelClas).HasForeignKey(c => c.IdClas).WillCascadeOnDelete(false); // FK_relclas_cat_clas
        }
    }

}
// </auto-generated>
