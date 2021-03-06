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

    // cat_gastos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatGastoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatGasto>
    {
        public CatGastoConfiguration()
            : this("dbo")
        {
        }

        public CatGastoConfiguration(string schema)
        {
            ToTable("cat_gastos", schema);
            HasKey(x => x.IdGto);

            Property(x => x.IdGto).HasColumnName(@"id_gto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Clave).HasColumnName(@"clave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.IdClaGto).HasColumnName(@"id_cla_gto").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acum).HasColumnName(@"acum").HasColumnType("float").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.TipEnt).HasColumnName(@"tip_ent").HasColumnType("tinyint").IsRequired();
            Property(x => x.TipUtiPer).HasColumnName(@"tip_uti_per").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTipCto).HasColumnName(@"id_tip_cto").HasColumnType("int").IsRequired();
            Property(x => x.CFijo).HasColumnName(@"c_fijo").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCta).HasColumnName(@"id_cta").HasColumnType("int").IsRequired();
            Property(x => x.IdCta2).HasColumnName(@"id_cta2").HasColumnType("int").IsRequired();
            Property(x => x.CDepnoid).HasColumnName(@"c_depnoid").HasColumnType("tinyint").IsRequired();
            Property(x => x.CEditImpto).HasColumnName(@"c_edit_impto").HasColumnType("tinyint").IsRequired();
            Property(x => x.CAjuCxc).HasColumnName(@"c_aju_cxc").HasColumnType("tinyint").IsRequired();
            Property(x => x.CAjuCxp).HasColumnName(@"c_aju_cxp").HasColumnType("tinyint").IsRequired();
            Property(x => x.CPagRetIsr).HasColumnName(@"c_pag_ret_isr").HasColumnType("tinyint").IsRequired();
            Property(x => x.CPagRetIva).HasColumnName(@"c_pag_ret_iva").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCtaNoDed).HasColumnName(@"id_cta_no_ded").HasColumnType("int").IsRequired();
            Property(x => x.IdOtrSis).HasColumnName(@"id_otr_sis").HasColumnType("int").IsRequired();
            Property(x => x.CAplNom).HasColumnName(@"c_apl_nom").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdImp).HasColumnName(@"id_imp").HasColumnType("int").IsRequired();
            Property(x => x.CIde).HasColumnName(@"c_ide").HasColumnType("tinyint").IsRequired();
            Property(x => x.CIsrPm).HasColumnName(@"c_ISR_pm").HasColumnType("tinyint").IsRequired();
            Property(x => x.CIsrArr).HasColumnName(@"c_ISR_arr").HasColumnType("tinyint").IsRequired();
            Property(x => x.CIsrHon).HasColumnName(@"c_ISR_hon").HasColumnType("tinyint").IsRequired();
            Property(x => x.CIsrSal).HasColumnName(@"c_ISR_sal").HasColumnType("tinyint").IsRequired();
            Property(x => x.CIsrAsi).HasColumnName(@"c_ISR_asi").HasColumnType("tinyint").IsRequired();
            Property(x => x.CIva).HasColumnName(@"c_IVA").HasColumnType("tinyint").IsRequired();
            Property(x => x.CRetIva).HasColumnName(@"c_RET_IVA").HasColumnType("tinyint").IsRequired();
            Property(x => x.CIetu).HasColumnName(@"c_IETU").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTipOpeSrv).HasColumnName(@"id_tip_ope_srv").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.CAplCom).HasColumnName(@"c_apl_com").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
