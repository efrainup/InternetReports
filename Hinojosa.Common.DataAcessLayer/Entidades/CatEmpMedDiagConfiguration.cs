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

    // cat_emp_med_diag
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpMedDiagConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatEmpMedDiag>
    {
        public CatEmpMedDiagConfiguration()
            : this("dbo")
        {
        }

        public CatEmpMedDiagConfiguration(string schema)
        {
            ToTable("cat_emp_med_diag", schema);
            HasKey(x => x.IdDiag);

            Property(x => x.IdDiag).HasColumnName(@"id_diag").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRelDiag).HasColumnName(@"id_rel_diag").HasColumnType("int").IsRequired();
            Property(x => x.IdMedico).HasColumnName(@"id_medico").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.FecDiag).HasColumnName(@"fec_diag").HasColumnType("datetime").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>