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

    // cfg_version
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CfgVersionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CfgVersion>
    {
        public CfgVersionConfiguration()
            : this("dbo")
        {
        }

        public CfgVersionConfiguration(string schema)
        {
            ToTable("cfg_version", schema);
            HasKey(x => new { x.Mcp, x.Post, x.ErvVersion, x.FecReg, x.IdVer, x.VersionPdv });

            Property(x => x.Versión).HasColumnName(@"Versión").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Mcp).HasColumnName(@"mcp").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Post).HasColumnName(@"post").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ErvVersion).HasColumnName(@"erv_version").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdVer).HasColumnName(@"id_ver").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdSis).HasColumnName(@"id_sis").HasColumnType("bigint").IsOptional();
            Property(x => x.Hst).HasColumnName(@"hst").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.CtrtLic).HasColumnName(@"ctrt_lic").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.CtrtImp).HasColumnName(@"ctrt_imp").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.CtrtMtto).HasColumnName(@"ctrt_mtto").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.VersionPdv).HasColumnName(@"version_pdv").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>