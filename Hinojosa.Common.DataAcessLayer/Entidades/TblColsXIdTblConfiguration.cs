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

    // tbl_cols_x_id_tbl
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblColsXIdTblConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TblColsXIdTbl>
    {
        public TblColsXIdTblConfiguration()
            : this("dbo")
        {
        }

        public TblColsXIdTblConfiguration(string schema)
        {
            ToTable("tbl_cols_x_id_tbl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdTbl).HasColumnName(@"id_tbl").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.Tbl).HasColumnName(@"tbl").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
            Property(x => x.NomCol).HasColumnName(@"nom_col").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.IsKey).HasColumnName(@"is_key").HasColumnType("bit").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IsSubquery).HasColumnName(@"is_subquery").HasColumnType("bit").IsRequired();
            Property(x => x.IdMod).HasColumnName(@"id_mod").HasColumnType("int").IsRequired();
            Property(x => x.IdVtCd).HasColumnName(@"id_vt_cd").HasColumnType("int").IsRequired();
            Property(x => x.ColFecFilt).HasColumnName(@"col_fec_filt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IsFti).HasColumnName(@"is_fti").HasColumnType("bit").IsRequired();
            Property(x => x.IsVisible).HasColumnName(@"is_visible").HasColumnType("bit").IsRequired();
            Property(x => x.Caption).HasColumnName(@"caption").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.IsFieldDisplay).HasColumnName(@"is_field_display").HasColumnType("bit").IsRequired();
            Property(x => x.Orden).HasColumnName(@"orden").HasColumnType("int").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Longitud).HasColumnName(@"longitud").HasColumnType("int").IsRequired();
            Property(x => x.EsClave).HasColumnName(@"es_clave").HasColumnType("bit").IsRequired();
            Property(x => x.IsCar).HasColumnName(@"is_car").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
