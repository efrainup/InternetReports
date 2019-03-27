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

    // sis_cfg_usr
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisCfgUsrConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<crm_SisCfgUsr>
    {
        public crm_SisCfgUsrConfiguration()
            : this("crm")
        {
        }

        public crm_SisCfgUsrConfiguration(string schema)
        {
            ToTable("sis_cfg_usr", schema);
            HasKey(x => x.IdCfgUsr);

            Property(x => x.IdCfgUsr).HasColumnName(@"id_cfg_usr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdRec).HasColumnName(@"id_rec").HasColumnType("int").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.CDef).HasColumnName(@"c_def").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
