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

    // fis_cfg_rel
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class FisCfgRelConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<FisCfgRel>
    {
        public FisCfgRelConfiguration()
            : this("dbo")
        {
        }

        public FisCfgRelConfiguration(string schema)
        {
            ToTable("fis_cfg_rel", schema);
            HasKey(x => x.IdFisRel);

            Property(x => x.IdFisRel).HasColumnName(@"id_fis_rel").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdFisCfg).HasColumnName(@"id_fis_cfg").HasColumnType("int").IsRequired();
            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired();
            Property(x => x.IdTbl).HasColumnName(@"id_tbl").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
