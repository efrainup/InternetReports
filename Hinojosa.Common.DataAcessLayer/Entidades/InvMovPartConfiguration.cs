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

    // inv_mov_part
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvMovPartConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvMovPart>
    {
        public InvMovPartConfiguration()
            : this("dbo")
        {
        }

        public InvMovPartConfiguration(string schema)
        {
            ToTable("inv_mov_part", schema);
            HasKey(x => new { x.IdInvMovPart, x.IdSuc });

            Property(x => x.IdInvMovPart).HasColumnName(@"id_inv_mov_part").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdInvMov).HasColumnName(@"id_inv_mov").HasColumnType("int").IsRequired();
            Property(x => x.NoPart).HasColumnName(@"no_part").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired();
            Property(x => x.Costo).HasColumnName(@"costo").HasColumnType("float").IsRequired();
            Property(x => x.CostoProm).HasColumnName(@"costo_prom").HasColumnType("float").IsRequired();
            Property(x => x.CostoTotal).HasColumnName(@"costo_total").HasColumnType("float").IsRequired();
            Property(x => x.IdAlmac).HasColumnName(@"id_almac").HasColumnType("int").IsRequired();
            Property(x => x.IdComSerLot).HasColumnName(@"id_com_ser_lot").HasColumnType("int").IsRequired();
            Property(x => x.IdKardex).HasColumnName(@"id_kardex").HasColumnType("int").IsRequired();
            Property(x => x.IdCenCto).HasColumnName(@"id_cen_cto").HasColumnType("int").IsRequired();
            Property(x => x.IdCodSrv).HasColumnName(@"id_cod_srv").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdClasPro).HasColumnName(@"id_clas_pro").HasColumnType("int").IsRequired();
            Property(x => x.Cmt).HasColumnName(@"cmt").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdUdm).HasColumnName(@"id_udm").HasColumnType("int").IsRequired();
            Property(x => x.IdProvDet).HasColumnName(@"id_prov_det").HasColumnType("int").IsRequired();
            Property(x => x.CInd).HasColumnName(@"c_ind").HasColumnType("int").IsRequired();
            Property(x => x.AcuRec).HasColumnName(@"acu_rec").HasColumnType("float").IsRequired();
            Property(x => x.AcuRecCxp).HasColumnName(@"acu_rec_cxp").HasColumnType("float").IsRequired();
            Property(x => x.IdPartPad).HasColumnName(@"id_part_pad").HasColumnType("int").IsRequired();
            Property(x => x.PorRecibir).HasColumnName(@"por_recibir").HasColumnType("int").IsRequired();
            Property(x => x.IdComSerLot2).HasColumnName(@"id_com_ser_lot2").HasColumnType("int").IsRequired();
            Property(x => x.IdKardex2).HasColumnName(@"id_kardex2").HasColumnType("int").IsRequired();
            Property(x => x.AcuRecCxpInd).HasColumnName(@"acu_rec_cxp_ind").HasColumnType("float").IsRequired();
            Property(x => x.AjuInd).HasColumnName(@"aju_ind").HasColumnType("float").IsRequired();
            Property(x => x.PorCxp).HasColumnName(@"por_cxp").HasColumnType("float").IsRequired();
            Property(x => x.StatusCxp).HasColumnName(@"status_cxp").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("tinyint").IsRequired();
            Property(x => x.GastosBse).HasColumnName(@"gastos_bse").HasColumnType("float").IsRequired();
            Property(x => x.CantSurt).HasColumnName(@"cant_surt").HasColumnType("float").IsRequired();
            Property(x => x.CantSurtAut).HasColumnName(@"cant_surt_aut").HasColumnType("float").IsRequired();
            Property(x => x.TipoTrans).HasColumnName(@"tipo_trans").HasColumnType("tinyint").IsRequired();
            Property(x => x.Sec).HasColumnName(@"sec").HasColumnType("int").IsRequired();
            Property(x => x.PtgKit).HasColumnName(@"ptg_kit").HasColumnType("float").IsRequired();
            Property(x => x.CKit).HasColumnName(@"c_kit").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdInt).HasColumnName(@"id_int").HasColumnType("int").IsRequired();
            Property(x => x.IdFacDet).HasColumnName(@"id_fac_det").HasColumnType("int").IsRequired();
            Property(x => x.NumPed).HasColumnName(@"num_ped").HasColumnType("int").IsRequired();
            Property(x => x.IdProvCsg).HasColumnName(@"id_prov_csg").HasColumnType("int").IsRequired();
            Property(x => x.CostoAlmCsg).HasColumnName(@"costo_alm_csg").HasColumnType("float").IsRequired();
            Property(x => x.CostoLot).HasColumnName(@"costo_lot").HasColumnType("float").IsRequired();
            Property(x => x.CantTrasp).HasColumnName(@"cant_trasp").HasColumnType("float").IsRequired();
            Property(x => x.CAjuCto).HasColumnName(@"c_aju_cto").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.CantPorCxp).HasColumnName(@"cant_por_cxp").HasColumnType("float").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatPro).WithMany(b => b.InvMovParts).HasForeignKey(c => c.IdPro).WillCascadeOnDelete(false); // FK_inv_mov_part_cat_pro
            HasRequired(a => a.InvMovDoc).WithMany(b => b.InvMovParts).HasForeignKey(c => c.IdInvMov).WillCascadeOnDelete(false); // FK_inv_mov_part_inv_mov_doc1
        }
    }

}
// </auto-generated>
