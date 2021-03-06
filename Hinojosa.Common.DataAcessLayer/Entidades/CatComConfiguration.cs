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

    // cat_com
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatComConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatCom>
    {
        public CatComConfiguration()
            : this("dbo")
        {
        }

        public CatComConfiguration(string schema)
        {
            ToTable("cat_com", schema);
            HasKey(x => x.IdCom);

            Property(x => x.IdCom).HasColumnName(@"id_com").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Codigo).HasColumnName(@"codigo").HasColumnType("nvarchar").IsRequired().HasMaxLength(30);
            Property(x => x.Nom).HasColumnName(@"nom").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired();
            Property(x => x.IdTbl).HasColumnName(@"id_tbl").HasColumnType("int").IsRequired();
            Property(x => x.IdTip).HasColumnName(@"id_tip").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.TipCom).HasColumnName(@"tip_com").HasColumnType("tinyint").IsRequired();
            Property(x => x.PtgCom).HasColumnName(@"ptg_com").HasColumnType("float").IsRequired();
        }
    }

}
// </auto-generated>
