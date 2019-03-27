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

    // vta_fac_rap
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaFacRapConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VtaFacRap>
    {
        public VtaFacRapConfiguration()
            : this("dbo")
        {
        }

        public VtaFacRapConfiguration(string schema)
        {
            ToTable("vta_fac_rap", schema);
            HasKey(x => x.Numero);

            Property(x => x.Numero).HasColumnName(@"numero").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orden).HasColumnName(@"orden").HasColumnType("int").IsRequired();
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdFac).HasColumnName(@"id_fac").HasColumnType("int").IsRequired();
            Property(x => x.IdFacDet).HasColumnName(@"id_fac_det").HasColumnType("int").IsRequired();
            Property(x => x.IdCliFa).HasColumnName(@"id_cli_fa").HasColumnType("int").IsOptional();
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("int").IsRequired();
            Property(x => x.PorDocto).HasColumnName(@"PorDocto").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.Ip).HasColumnName(@"ip").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(16);
            Property(x => x.Equipo).HasColumnName(@"equipo").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(25);
            Property(x => x.IdInt).HasColumnName(@"id_int").HasColumnType("int").IsRequired();
            Property(x => x.IdRefDet).HasColumnName(@"id_ref_det").HasColumnType("int").IsRequired();
            Property(x => x.IdFacDetTmp).HasColumnName(@"id_fac_det_tmp").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.IdCnd).HasColumnName(@"id_cnd").HasColumnType("int").IsRequired();
            Property(x => x.IdVend).HasColumnName(@"id_vend").HasColumnType("int").IsRequired();
            Property(x => x.RefExt).HasColumnName(@"Ref_Ext").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.Nota).HasColumnName(@"Nota").HasColumnType("ntext").IsRequired().IsMaxLength();
            Property(x => x.BaseGrav).HasColumnName(@"base_grav").HasColumnType("float").IsRequired();
            Property(x => x.TipHon).HasColumnName(@"tip_hon").HasColumnType("int").IsRequired();
            Property(x => x.PtgHon).HasColumnName(@"ptg_hon").HasColumnType("float").IsRequired();
            Property(x => x.Sec).HasColumnName(@"sec").HasColumnType("int").IsRequired();
            Property(x => x.IdImpto).HasColumnName(@"id_impto").HasColumnType("int").IsRequired();
            Property(x => x.Costo).HasColumnName(@"costo").HasColumnType("float").IsRequired();
            Property(x => x.DctoPtg).HasColumnName(@"dcto_ptg").HasColumnType("float").IsRequired();
            Property(x => x.DctoMto).HasColumnName(@"dcto_mto").HasColumnType("float").IsRequired();
            Property(x => x.CIepsDesg).HasColumnName(@"c_ieps_desg").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.TipCam).HasColumnName(@"tip_cam").HasColumnType("float").IsRequired();
            Property(x => x.MtoAnt).HasColumnName(@"mto_ant").HasColumnType("float").IsRequired();
            Property(x => x.SdoApl).HasColumnName(@"sdo_apl").HasColumnType("float").IsRequired();
            Property(x => x.IdisCta).HasColumnName(@"idis_cta").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.TipPagCta).HasColumnName(@"tip_pag_cta").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.BcoCta).HasColumnName(@"bco_cta").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.IdTipUso).HasColumnName(@"id_tip_uso").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
