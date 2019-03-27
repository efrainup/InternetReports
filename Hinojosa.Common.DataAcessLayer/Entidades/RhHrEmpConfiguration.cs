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

    // rh_hr_emp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RhHrEmpConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RhHrEmp>
    {
        public RhHrEmpConfiguration()
            : this("dbo")
        {
        }

        public RhHrEmpConfiguration(string schema)
        {
            ToTable("rh_hr_emp", schema);
            HasKey(x => x.IdHrEmp);

            Property(x => x.IdHrEmp).HasColumnName(@"id_hr_emp").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdEmp).HasColumnName(@"id_emp").HasColumnType("int").IsRequired();
            Property(x => x.IdHor).HasColumnName(@"id_hor").HasColumnType("int").IsRequired();
            Property(x => x.Dia).HasColumnName(@"dia").HasColumnType("tinyint").IsRequired();
            Property(x => x.HrIniLab).HasColumnName(@"hr_ini_lab").HasColumnType("datetime").IsRequired();
            Property(x => x.HrFinLab).HasColumnName(@"hr_fin_lab").HasColumnType("datetime").IsRequired();
            Property(x => x.HrIniCom).HasColumnName(@"hr_ini_com").HasColumnType("datetime").IsRequired();
            Property(x => x.HrFinCom).HasColumnName(@"hr_fin_com").HasColumnType("datetime").IsRequired();
            Property(x => x.TotHrs).HasColumnName(@"tot_hrs").HasColumnType("datetime").IsRequired();
            Property(x => x.CRun).HasColumnName(@"c_run").HasColumnType("tinyint").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.CDes).HasColumnName(@"c_des").HasColumnType("tinyint").IsRequired();
            Property(x => x.CDos).HasColumnName(@"c_dos").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTurno).HasColumnName(@"id_turno").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
