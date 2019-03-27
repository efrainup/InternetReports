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

    // cat_emp_eva
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpEvaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatEmpEva>
    {
        public CatEmpEvaConfiguration()
            : this("dbo")
        {
        }

        public CatEmpEvaConfiguration(string schema)
        {
            ToTable("cat_emp_eva", schema);
            HasKey(x => x.IdEva);

            Property(x => x.IdEva).HasColumnName(@"id_eva").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRelEva).HasColumnName(@"id_rel_eva").HasColumnType("int").IsRequired();
            Property(x => x.FecIni).HasColumnName(@"fec_ini").HasColumnType("datetime").IsRequired();
            Property(x => x.FecTer).HasColumnName(@"fec_ter").HasColumnType("datetime").IsRequired();
            Property(x => x.IdTipTitEva).HasColumnName(@"id_tip_tit_eva").HasColumnType("int").IsRequired();
            Property(x => x.Calif).HasColumnName(@"calif").HasColumnType("float").IsRequired();
            Property(x => x.Cmt).HasColumnName(@"cmt").HasColumnType("text").IsRequired().IsUnicode(false).HasMaxLength(2147483647);
            Property(x => x.IdClas).HasColumnName(@"id_clas").HasColumnType("int").IsRequired();
            Property(x => x.IdPerRh).HasColumnName(@"id_per_rh").HasColumnType("int").IsRequired();
            Property(x => x.IdPerEva).HasColumnName(@"id_per_eva").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.Pond).HasColumnName(@"pond").HasColumnType("float").IsRequired();
            Property(x => x.CalifPond).HasColumnName(@"calif_pond").HasColumnType("float").IsRequired();
        }
    }

}
// </auto-generated>