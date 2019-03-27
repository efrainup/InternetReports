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

    // cat_emp_pres
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpPreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatEmpPre>
    {
        public CatEmpPreConfiguration()
            : this("dbo")
        {
        }

        public CatEmpPreConfiguration(string schema)
        {
            ToTable("cat_emp_pres", schema);
            HasKey(x => x.IdPres);

            Property(x => x.IdPres).HasColumnName(@"id_pres").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRelPres).HasColumnName(@"id_rel_pres").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Mov).HasColumnName(@"mov").HasColumnType("tinyint").IsRequired();
            Property(x => x.Monto).HasColumnName(@"monto").HasColumnType("float").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.@Ref).HasColumnName(@"ref").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
        }
    }

}
// </auto-generated>