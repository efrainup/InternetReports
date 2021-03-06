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

    // sis_tsk_prt
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisTskPrtConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisTskPrt>
    {
        public SisTskPrtConfiguration()
            : this("dbo")
        {
        }

        public SisTskPrtConfiguration(string schema)
        {
            ToTable("sis_tsk_prt", schema);
            HasKey(x => new { x.IdPrmto, x.IdTsk, x.IdTskDet, x.Id, x.Tipo, x.ParNom, x.TipPar, x.Valor, x.IdUsr });

            Property(x => x.IdPrmto).HasColumnName(@"id_prmto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTsk).HasColumnName(@"id_tsk").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTskDet).HasColumnName(@"id_tsk_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ParNom).HasColumnName(@"par_nom").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipPar).HasColumnName(@"tip_par").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipVal).HasColumnName(@"tip_val").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
// </auto-generated>
