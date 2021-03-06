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

    // mcp_cfg_pro
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class McpCfgProConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<McpCfgPro>
    {
        public McpCfgProConfiguration()
            : this("dbo")
        {
        }

        public McpCfgProConfiguration(string schema)
        {
            ToTable("mcp_cfg_pro", schema);
            HasKey(x => x.IdCmpOri);

            Property(x => x.IdCmpOri).HasColumnName(@"id_cmp_ori").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdProOri).HasColumnName(@"id_pro_ori").HasColumnType("int").IsRequired();
            Property(x => x.IdCmpDes).HasColumnName(@"id_cmp_des").HasColumnType("int").IsRequired();
            Property(x => x.IdProDes).HasColumnName(@"id_pro_des").HasColumnType("int").IsRequired();
            Property(x => x.IdAlmDes).HasColumnName(@"id_alm_des").HasColumnType("int").IsRequired();
            Property(x => x.IdCenCtoDes).HasColumnName(@"id_cen_cto_des").HasColumnType("int").IsRequired();
            Property(x => x.IdCodSrvDes).HasColumnName(@"id_cod_srv_des").HasColumnType("int").IsRequired();
            Property(x => x.IdRefDes).HasColumnName(@"id_ref_des").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
