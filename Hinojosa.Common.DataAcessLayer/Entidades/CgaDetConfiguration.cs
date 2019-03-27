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

    // cga_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CgaDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CgaDet>
    {
        public CgaDetConfiguration()
            : this("dbo")
        {
        }

        public CgaDetConfiguration(string schema)
        {
            ToTable("cga_det", schema);
            HasKey(x => x.IdCgaDet);

            Property(x => x.IdCgaDet).HasColumnName(@"id_cga_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.IdProPad).HasColumnName(@"id_pro_pad").HasColumnType("int").IsRequired();
            Property(x => x.IdProPaq).HasColumnName(@"id_pro_paq").HasColumnType("int").IsRequired();
            Property(x => x.Sec).HasColumnName(@"sec").HasColumnType("int").IsRequired();
            Property(x => x.PtgKit).HasColumnName(@"ptg_kit").HasColumnType("float").IsRequired();
            Property(x => x.CPaq).HasColumnName(@"c_paq").HasColumnType("int").IsRequired();
            Property(x => x.CExt).HasColumnName(@"c_ext").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdFac).HasColumnName(@"id_fac").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.IdFacDet).HasColumnName(@"id_fac_det").HasColumnType("int").IsRequired();
            Property(x => x.IdRefDetDoc).HasColumnName(@"id_ref_det_doc").HasColumnType("int").IsRequired();
            Property(x => x.CantAplRefDet).HasColumnName(@"cant_apl_ref_det").HasColumnType("float").IsRequired();
            Property(x => x.IdCliFa).HasColumnName(@"id_cli_fa").HasColumnType("int").IsRequired();
            Property(x => x.IdCliCtaDe).HasColumnName(@"id_cli_cta_de").HasColumnType("int").IsRequired();
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired();
            Property(x => x.CantRealGtoApl).HasColumnName(@"cant_real_gto_apl").HasColumnType("float").IsRequired();
            Property(x => x.NumPart).HasColumnName(@"num_part").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdRefDet).HasColumnName(@"id_ref_det").HasColumnType("int").IsRequired();
            Property(x => x.IdSisLisPre).HasColumnName(@"id_sis_lis_pre").HasColumnType("int").IsRequired();
            Property(x => x.Precio).HasColumnName(@"precio").HasColumnType("float").IsRequired();
            Property(x => x.DctoPtg).HasColumnName(@"dcto_ptg").HasColumnType("float").IsRequired();
            Property(x => x.Dcto).HasColumnName(@"dcto").HasColumnType("float").IsRequired();
            Property(x => x.IdImpto).HasColumnName(@"id_impto").HasColumnType("int").IsRequired();
            Property(x => x.Imptos).HasColumnName(@"imptos").HasColumnType("float").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.BaseGrav).HasColumnName(@"base_grav").HasColumnType("float").IsRequired();
            Property(x => x.TipHon).HasColumnName(@"tip_hon").HasColumnType("int").IsRequired();
            Property(x => x.PtgHon).HasColumnName(@"ptg_hon").HasColumnType("float").IsRequired();
            Property(x => x.IdTarHon).HasColumnName(@"id_tar_hon").HasColumnType("int").IsRequired();
            Property(x => x.DesTarHon).HasColumnName(@"des_tar_hon").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ModImpto).HasColumnName(@"mod_impto").HasColumnType("tinyint").IsRequired();
            Property(x => x.TipCom).HasColumnName(@"tip_com").HasColumnType("tinyint").IsRequired();
            Property(x => x.PtgCom).HasColumnName(@"ptg_com").HasColumnType("float").IsRequired();
            Property(x => x.MtoCom).HasColumnName(@"mto_com").HasColumnType("float").IsRequired();
            Property(x => x.IdInt).HasColumnName(@"id_int").HasColumnType("int").IsRequired();
            Property(x => x.IdOpeExt).HasColumnName(@"id_ope_ext").HasColumnType("int").IsRequired();
            Property(x => x.IdUdm).HasColumnName(@"id_udm").HasColumnType("int").IsRequired();
            Property(x => x.IdAlm).HasColumnName(@"id_alm").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdSesion).HasColumnName(@"id_sesion").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.CMayor).HasColumnName(@"c_mayor").HasColumnType("tinyint").IsRequired();
            Property(x => x.CMnl).HasColumnName(@"c_mnl").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
