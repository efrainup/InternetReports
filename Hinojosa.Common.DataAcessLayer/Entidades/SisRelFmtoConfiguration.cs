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

    // sis_rel_fmto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRelFmtoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisRelFmto>
    {
        public SisRelFmtoConfiguration()
            : this("dbo")
        {
        }

        public SisRelFmtoConfiguration(string schema)
        {
            ToTable("sis_rel_fmto", schema);
            HasKey(x => new { x.IdRelFmto, x.IdFmto });

            Property(x => x.IdRelFmto).HasColumnName(@"id_rel_fmto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdFmto).HasColumnName(@"id_fmto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CDef).HasColumnName(@"c_def").HasColumnType("bit").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Cfd).HasColumnName(@"cfd").HasColumnType("tinyint").IsRequired();
            Property(x => x.CExpXls).HasColumnName(@"c_exp_xls").HasColumnType("tinyint").IsRequired();
            Property(x => x.CExpHtml).HasColumnName(@"c_exp_html").HasColumnType("tinyint").IsRequired();
            Property(x => x.CExpPdf).HasColumnName(@"c_exp_pdf").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cfdi).HasColumnName(@"cfdi").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
