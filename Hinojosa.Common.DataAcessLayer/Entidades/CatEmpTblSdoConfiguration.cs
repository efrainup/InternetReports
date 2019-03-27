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

    // cat_emp_tbl_sdo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpTblSdoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatEmpTblSdo>
    {
        public CatEmpTblSdoConfiguration()
            : this("dbo")
        {
        }

        public CatEmpTblSdoConfiguration(string schema)
        {
            ToTable("cat_emp_tbl_sdo", schema);
            HasKey(x => x.IdTblSdo);

            Property(x => x.IdTblSdo).HasColumnName(@"id_tbl_sdo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nivel).HasColumnName(@"nivel").HasColumnType("int").IsRequired();
            Property(x => x.IdPto).HasColumnName(@"id_pto").HasColumnType("int").IsRequired();
            Property(x => x.R1Min).HasColumnName(@"r1_min").HasColumnType("float").IsRequired();
            Property(x => x.R2Min).HasColumnName(@"r2_min").HasColumnType("float").IsRequired();
            Property(x => x.R1Med).HasColumnName(@"r1_med").HasColumnType("float").IsRequired();
            Property(x => x.R2Med).HasColumnName(@"r2_med").HasColumnType("float").IsRequired();
            Property(x => x.R1Max).HasColumnName(@"r1_max").HasColumnType("float").IsRequired();
            Property(x => x.R2Max).HasColumnName(@"r2_max").HasColumnType("float").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>