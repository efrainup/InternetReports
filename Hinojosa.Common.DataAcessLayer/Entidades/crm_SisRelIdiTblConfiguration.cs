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

    // sis_rel_idi_tbl
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisRelIdiTblConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<crm_SisRelIdiTbl>
    {
        public crm_SisRelIdiTblConfiguration()
            : this("crm")
        {
        }

        public crm_SisRelIdiTblConfiguration(string schema)
        {
            ToTable("sis_rel_idi_tbl", schema);
            HasKey(x => x.IdSisRelIdiTbl);

            Property(x => x.IdSisRelIdiTbl).HasColumnName(@"id_sis_rel_idi_tbl").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTbl).HasColumnName(@"id_tbl").HasColumnType("int").IsRequired();
            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired();
            Property(x => x.IdTipIdi).HasColumnName(@"id_tip_idi").HasColumnType("int").IsRequired();
            Property(x => x.Txt).HasColumnName(@"txt").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdCmp).HasColumnName(@"id_cmp").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
