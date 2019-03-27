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

    // sis_tsk_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisTskDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisTskDet>
    {
        public SisTskDetConfiguration()
            : this("dbo")
        {
        }

        public SisTskDetConfiguration(string schema)
        {
            ToTable("sis_tsk_det", schema);
            HasKey(x => x.IdTskDet);

            Property(x => x.IdTskDet).HasColumnName(@"id_tsk_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTsk).HasColumnName(@"id_tsk").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.IdTipDocApl).HasColumnName(@"id_tip_doc_apl").HasColumnType("int").IsRequired();
            Property(x => x.SerieApl).HasColumnName(@"serie_apl").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.FolioEje).HasColumnName(@"folio_eje").HasColumnType("int").IsRequired();
            Property(x => x.FecAlta).HasColumnName(@"fec_alta").HasColumnType("datetime").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.Orden).HasColumnName(@"orden").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.EnvA).HasColumnName(@"env_a").HasColumnType("tinyint").IsRequired();
            Property(x => x.TipSalEnv).HasColumnName(@"tip_sal_env").HasColumnType("tinyint").IsRequired();
            Property(x => x.TipFec).HasColumnName(@"tip_fec").HasColumnType("tinyint").IsRequired();
            Property(x => x.EnvSinSal).HasColumnName(@"env_sin_sal").HasColumnType("tinyint").IsRequired();
            Property(x => x.Email).HasColumnName(@"email").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdCto).HasColumnName(@"id_cto").HasColumnType("int").IsRequired();
            Property(x => x.IdTipAvi).HasColumnName(@"id_tip_avi").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
