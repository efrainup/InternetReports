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

    // cmp_mcp_docs
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CmpMcpDocConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CmpMcpDoc>
    {
        public CmpMcpDocConfiguration()
            : this("dbo")
        {
        }

        public CmpMcpDocConfiguration(string schema)
        {
            ToTable("cmp_mcp_docs", schema);
            HasKey(x => x.IdCmpMcpDocs);

            Property(x => x.IdCmpMcpDocs).HasColumnName(@"id_cmp_mcp_docs").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdCliTabAr).HasColumnName(@"id_cli_tab_ar").HasColumnType("int").IsRequired();
            Property(x => x.Server).HasColumnName(@"server").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Db).HasColumnName(@"db").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.ActaCons).HasColumnName(@"acta_cons").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.PodLeg).HasColumnName(@"pod_leg").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.FecMod).HasColumnName(@"fec_mod").HasColumnType("datetime").IsRequired();
            Property(x => x.Anexo1).HasColumnName(@"Anexo1").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.Anexo2).HasColumnName(@"Anexo2").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.Anexo3).HasColumnName(@"Anexo3").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.CttLic).HasColumnName(@"ctt_lic").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.CttImp).HasColumnName(@"ctt_imp").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.CttMtto).HasColumnName(@"ctt_mtto").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.Cedula).HasColumnName(@"cedula").HasColumnType("varbinary(max)").IsOptional();
        }
    }

}
// </auto-generated>