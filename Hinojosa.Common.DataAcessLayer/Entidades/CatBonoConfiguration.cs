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

    // cat_bonos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatBonoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatBono>
    {
        public CatBonoConfiguration()
            : this("dbo")
        {
        }

        public CatBonoConfiguration(string schema)
        {
            ToTable("cat_bonos", schema);
            HasKey(x => x.IdBono);

            Property(x => x.IdBono).HasColumnName(@"id_bono").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Clave).HasColumnName(@"clave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.IdOtrSis).HasColumnName(@"id_otr_sis").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Monto).HasColumnName(@"monto").HasColumnType("float").IsRequired();
            Property(x => x.Descto).HasColumnName(@"descto").HasColumnType("float").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FegReg).HasColumnName(@"feg_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.CProv).HasColumnName(@"c_prov").HasColumnType("tinyint").IsRequired();
            Property(x => x.CImss).HasColumnName(@"c_imss").HasColumnType("tinyint").IsRequired();
            Property(x => x.CTipo).HasColumnName(@"c_tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.CAplSdi).HasColumnName(@"c_apl_sdi").HasColumnType("tinyint").IsRequired();
            Property(x => x.CPer).HasColumnName(@"c_per").HasColumnType("tinyint").IsRequired();
            Property(x => x.CDed).HasColumnName(@"c_ded").HasColumnType("tinyint").IsRequired();
            Property(x => x.CSdoBto).HasColumnName(@"c_sdo_bto").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTipDd).HasColumnName(@"id_tip_dd").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.IdTipNom).HasColumnName(@"id_tip_nom").HasColumnType("int").IsRequired();
            Property(x => x.CAplDd).HasColumnName(@"c_apl_dd").HasColumnType("int").IsRequired();
            Property(x => x.IdEnt).HasColumnName(@"id_ent").HasColumnType("int").IsRequired();
            Property(x => x.CDef).HasColumnName(@"c_def").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTipEsq).HasColumnName(@"id_tip_esq").HasColumnType("int").IsRequired();
            Property(x => x.CNoAfePerNet).HasColumnName(@"c_no_afe_per_net").HasColumnType("tinyint").IsRequired();
            Property(x => x.CProvEmp).HasColumnName(@"c_prov_emp").HasColumnType("int").IsRequired();
            Property(x => x.CInfo).HasColumnName(@"c_info").HasColumnType("int").IsRequired();
            Property(x => x.CNeg).HasColumnName(@"c_neg").HasColumnType("int").IsRequired();
            Property(x => x.CPfTer).HasColumnName(@"c_PFTer").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCta).HasColumnName(@"id_cta").HasColumnType("int").IsRequired();
            Property(x => x.IdTipSat).HasColumnName(@"id_tip_sat").HasColumnType("int").IsRequired();
            Property(x => x.CExen).HasColumnName(@"c_exen").HasColumnType("tinyint").IsRequired();
            Property(x => x.CGrav).HasColumnName(@"c_grav").HasColumnType("tinyint").IsRequired();
            Property(x => x.CPagEsp).HasColumnName(@"c_pag_esp").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
