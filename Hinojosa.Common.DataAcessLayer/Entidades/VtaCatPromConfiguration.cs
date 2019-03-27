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

    // vta_cat_prom
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaCatPromConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VtaCatProm>
    {
        public VtaCatPromConfiguration()
            : this("dbo")
        {
        }

        public VtaCatPromConfiguration(string schema)
        {
            ToTable("vta_cat_prom", schema);
            HasKey(x => x.IdProm);

            Property(x => x.IdProm).HasColumnName(@"id_prom").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CveProm).HasColumnName(@"cve_prom").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.CodProm).HasColumnName(@"cod_prom").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.DesProm).HasColumnName(@"des_prom").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.FechaIniVig).HasColumnName(@"fecha_ini_vig").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaFinVig).HasColumnName(@"fecha_fin_vig").HasColumnType("datetime").IsRequired();
            Property(x => x.Acumulable).HasColumnName(@"acumulable").HasColumnType("bit").IsRequired();
            Property(x => x.IdTipRetrib).HasColumnName(@"id_tip_retrib").HasColumnType("tinyint").IsRequired();
            Property(x => x.DesTipRetrib).HasColumnName(@"des_tip_retrib").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Param1Ret).HasColumnName(@"param1_ret").HasColumnType("float").IsOptional();
            Property(x => x.Param2Ret).HasColumnName(@"param2_ret").HasColumnType("float").IsOptional();
            Property(x => x.Porc).HasColumnName(@"porc").HasColumnType("float").IsOptional();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status2).HasColumnName(@"status2").HasColumnType("tinyint").IsRequired();
            Property(x => x.CPromUni).HasColumnName(@"c_prom_uni").HasColumnType("bit").IsRequired();
            Property(x => x.CTodos).HasColumnName(@"c_todos").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.VtaCatProms).HasForeignKey(c => c.IdUsr).WillCascadeOnDelete(false); // FK_vta_cat_prom_cat_usr
        }
    }

}
// </auto-generated>