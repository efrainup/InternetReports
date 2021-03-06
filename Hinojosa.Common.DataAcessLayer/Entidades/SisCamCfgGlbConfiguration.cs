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

    // sis_cam_cfg_glb
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisCamCfgGlbConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisCamCfgGlb>
    {
        public SisCamCfgGlbConfiguration()
            : this("dbo")
        {
        }

        public SisCamCfgGlbConfiguration(string schema)
        {
            ToTable("sis_cam_cfg_glb", schema);
            HasKey(x => x.IdCamCfgGlb);

            Property(x => x.IdCamCfgGlb).HasColumnName(@"id_cam_cfg_glb").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdCfgGlb).HasColumnName(@"id_cfg_glb").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.ValorAnt).HasColumnName(@"valor_ant").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(150);
            Property(x => x.ValorNvo).HasColumnName(@"valor_nvo").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(150);
        }
    }

}
// </auto-generated>
