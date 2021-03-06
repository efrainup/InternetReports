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

    // fis_cfg_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class FisCfgDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<FisCfgDet>
    {
        public FisCfgDetConfiguration()
            : this("dbo")
        {
        }

        public FisCfgDetConfiguration(string schema)
        {
            ToTable("fis_cfg_det", schema);
            HasKey(x => x.IdFisCfgDet);

            Property(x => x.IdFisCfgDet).HasColumnName(@"id_fis_cfg_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdFisCfg).HasColumnName(@"id_fis_cfg").HasColumnType("int").IsRequired();
            Property(x => x.IdTipImpto).HasColumnName(@"id_tip_impto").HasColumnType("int").IsRequired();
            Property(x => x.AcuVta).HasColumnName(@"acu_vta").HasColumnType("tinyint").IsRequired();
            Property(x => x.PtgAcuVta).HasColumnName(@"ptg_acu_vta").HasColumnType("float").IsRequired();
            Property(x => x.AcuCom).HasColumnName(@"acu_com").HasColumnType("tinyint").IsRequired();
            Property(x => x.PtgAcuCom).HasColumnName(@"ptg_acu_com").HasColumnType("float").IsRequired();
            Property(x => x.IdTipApl).HasColumnName(@"id_tip_apl").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
