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

    // cca_plan
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CcaPlanConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CcaPlan>
    {
        public CcaPlanConfiguration()
            : this("dbo")
        {
        }

        public CcaPlanConfiguration(string schema)
        {
            ToTable("cca_plan", schema);
            HasKey(x => x.IdPlan);

            Property(x => x.IdPlan).HasColumnName(@"id_plan").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdEmpElab).HasColumnName(@"id_emp_elab").HasColumnType("int").IsRequired();
            Property(x => x.IdEmpRev).HasColumnName(@"id_emp_rev").HasColumnType("int").IsRequired();
            Property(x => x.IdEmpAut).HasColumnName(@"id_emp_aut").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.NoRev).HasColumnName(@"no_rev").HasColumnType("int").IsRequired();
            Property(x => x.Clave).HasColumnName(@"clave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.FecElab).HasColumnName(@"fec_elab").HasColumnType("datetime").IsRequired();
            Property(x => x.FecRev).HasColumnName(@"fec_rev").HasColumnType("datetime").IsRequired();
            Property(x => x.FecAut).HasColumnName(@"fec_aut").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>