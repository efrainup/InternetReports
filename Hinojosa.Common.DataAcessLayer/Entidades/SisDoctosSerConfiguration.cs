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

    // sis_doctos_ser
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisDoctosSerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisDoctosSer>
    {
        public SisDoctosSerConfiguration()
            : this("dbo")
        {
        }

        public SisDoctosSerConfiguration(string schema)
        {
            ToTable("sis_doctos_ser", schema);
            HasKey(x => new { x.IdSerie, x.IdTipDoc, x.Serie, x.IdCaj, x.IdCierre, x.IdCmp });

            Property(x => x.IdSerie).HasColumnName(@"id_serie").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCaj).HasColumnName(@"id_caj").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCierre).HasColumnName(@"id_cierre").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.Def).HasColumnName(@"def").HasColumnType("tinyint").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.CCfol).HasColumnName(@"c_cfol").HasColumnType("tinyint").IsRequired();
            Property(x => x.CSell).HasColumnName(@"c_sell").HasColumnType("tinyint").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("nvarchar").IsRequired().HasMaxLength(90);
            Property(x => x.FolioIni).HasColumnName(@"folio_ini").HasColumnType("int").IsRequired();
            Property(x => x.FolioFin).HasColumnName(@"folio_fin").HasColumnType("int").IsRequired();
            Property(x => x.IdFmto).HasColumnName(@"id_fmto").HasColumnType("int").IsRequired();
            Property(x => x.CImpAut).HasColumnName(@"c_imp_aut").HasColumnType("tinyint").IsRequired();
            Property(x => x.TipValFol).HasColumnName(@"tip_val_fol").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dias).HasColumnName(@"dias").HasColumnType("int").IsRequired();
            Property(x => x.Ptg).HasColumnName(@"ptg").HasColumnType("int").IsRequired();
            Property(x => x.CAct).HasColumnName(@"c_act").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTipCfd).HasColumnName(@"id_tip_cfd").HasColumnType("int").IsRequired();
            Property(x => x.FecLock).HasColumnName(@"fec_lock").HasColumnType("tinyint").IsRequired();
            Property(x => x.CTras).HasColumnName(@"c_tras").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCmp).HasColumnName(@"id_cmp").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CTimMsv).HasColumnName(@"c_tim_msv").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
