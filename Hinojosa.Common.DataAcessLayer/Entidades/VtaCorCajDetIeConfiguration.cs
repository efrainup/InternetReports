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

    // vta_cor_caj_det_ie
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaCorCajDetIeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VtaCorCajDetIe>
    {
        public VtaCorCajDetIeConfiguration()
            : this("dbo")
        {
        }

        public VtaCorCajDetIeConfiguration(string schema)
        {
            ToTable("vta_cor_caj_det_ie", schema);
            HasKey(x => new { x.IdCorDetIe, x.IdCorCaj, x.IdTipIe, x.Des, x.Cant, x.IdFolDep, x.IdDoc });

            Property(x => x.IdCorDetIe).HasColumnName(@"id_cor_det_ie").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCorCaj).HasColumnName(@"id_cor_caj").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipIe).HasColumnName(@"id_tip_ie").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("nvarchar(max)").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsOptional();
            Property(x => x.IdTip).HasColumnName(@"ID_TIP").HasColumnType("int").IsOptional();
            Property(x => x.IdDeudor).HasColumnName(@"id_deudor").HasColumnType("int").IsOptional();
            Property(x => x.NumFac).HasColumnName(@"num_fac").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.EmpProv).HasColumnName(@"emp_prov").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdVale).HasColumnName(@"ID_VALE").HasColumnType("int").IsOptional();
            Property(x => x.IdFolDep).HasColumnName(@"id_fol_dep").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
