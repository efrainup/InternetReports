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

    // inv_kardex
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvKardexConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvKardex>
    {
        public InvKardexConfiguration()
            : this("dbo")
        {
        }

        public InvKardexConfiguration(string schema)
        {
            ToTable("inv_kardex", schema);
            HasKey(x => x.IdKardex);

            Property(x => x.IdKardex).HasColumnName(@"id_kardex").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipoDoc).HasColumnName(@"id_tipo_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.IdAlmac).HasColumnName(@"id_almac").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.TipoMov).HasColumnName(@"tipo_mov").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.Udm).HasColumnName(@"udm").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired();
            Property(x => x.Costo).HasColumnName(@"costo").HasColumnType("float").IsRequired();
            Property(x => x.Precio).HasColumnName(@"precio").HasColumnType("float").IsRequired();
            Property(x => x.CostoProm).HasColumnName(@"costo_prom").HasColumnType("float").IsRequired();
            Property(x => x.CostoTotal).HasColumnName(@"costo_total").HasColumnType("float").IsRequired();
            Property(x => x.ImporteTotal).HasColumnName(@"importe_total").HasColumnType("float").IsRequired();
            Property(x => x.Existencia).HasColumnName(@"existencia").HasColumnType("float").IsRequired();
            Property(x => x.IdSub).HasColumnName(@"id_sub").HasColumnType("int").IsRequired();
            Property(x => x.IdKit).HasColumnName(@"id_kit").HasColumnType("int").IsRequired();
            Property(x => x.CantSub).HasColumnName(@"cant_sub").HasColumnType("float").IsRequired();
            Property(x => x.CantKit).HasColumnName(@"cant_kit").HasColumnType("float").IsRequired();
            Property(x => x.PreSub).HasColumnName(@"pre_sub").HasColumnType("float").IsRequired();
            Property(x => x.Factor).HasColumnName(@"factor").HasColumnType("float").IsRequired();
            Property(x => x.Operacion).HasColumnName(@"operacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdSer).HasColumnName(@"id_ser").HasColumnType("int").IsRequired();
            Property(x => x.NumSer).HasColumnName(@"num_ser").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.IdComSerLot).HasColumnName(@"id_com_ser_lot").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDocCnl).HasColumnName(@"id_tip_doc_cnl").HasColumnType("int").IsRequired();
            Property(x => x.NumDocCnl).HasColumnName(@"num_doc_cnl").HasColumnType("int").IsRequired();
            Property(x => x.IdDocCnl).HasColumnName(@"id_doc_cnl").HasColumnType("int").IsRequired();
            Property(x => x.IdPartCnl).HasColumnName(@"id_part_cnl").HasColumnType("int").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.CostoExt).HasColumnName(@"costo_ext").HasColumnType("float").IsRequired();
            Property(x => x.CostoTotalExt).HasColumnName(@"costo_total_ext").HasColumnType("float").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdSisCnl).HasColumnName(@"id_sis_cnl").HasColumnType("int").IsRequired();
            Property(x => x.IdPart).HasColumnName(@"id_part").HasColumnType("int").IsRequired();
            Property(x => x.CCnl).HasColumnName(@"c_cnl").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUdm).HasColumnName(@"id_udm").HasColumnType("int").IsRequired();
            Property(x => x.CantMov).HasColumnName(@"cant_mov").HasColumnType("float").IsRequired();
            Property(x => x.UdmMov).HasColumnName(@"udm_mov").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdUdmMov).HasColumnName(@"id_udm_mov").HasColumnType("int").IsRequired();
            Property(x => x.Ftr).HasColumnName(@"ftr").HasColumnType("float").IsRequired();
            Property(x => x.CostoMov).HasColumnName(@"costo_mov").HasColumnType("float").IsRequired();
            Property(x => x.CostoTotalMov).HasColumnName(@"costo_total_mov").HasColumnType("float").IsRequired();
            Property(x => x.ExistenciaAlm).HasColumnName(@"existencia_alm").HasColumnType("float").IsRequired();
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.IdCenCto).HasColumnName(@"id_cen_cto").HasColumnType("int").IsRequired();
            Property(x => x.IdCodSrv).HasColumnName(@"id_cod_srv").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdClasPro).HasColumnName(@"id_clas_pro").HasColumnType("int").IsRequired();
            Property(x => x.Cmt).HasColumnName(@"cmt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdPol).HasColumnName(@"id_pol").HasColumnType("int").IsRequired();
            Property(x => x.CostoInd).HasColumnName(@"costo_ind").HasColumnType("float").IsRequired();
            Property(x => x.CostoUnit).HasColumnName(@"costo_unit").HasColumnType("float").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatAlmac).WithMany(b => b.InvKardexes).HasForeignKey(c => c.IdAlmac).WillCascadeOnDelete(false); // FK_inv_kardex_cat_almac
            HasRequired(a => a.CatDocto).WithMany(b => b.InvKardexes).HasForeignKey(c => c.IdTipoDoc).WillCascadeOnDelete(false); // FK_inv_kardex_cat_doctos
            HasRequired(a => a.CatPro).WithMany(b => b.InvKardexes).HasForeignKey(c => c.IdPro).WillCascadeOnDelete(false); // FK_inv_kardex_cat_pro
            HasRequired(a => a.CatUsr).WithMany(b => b.InvKardexes).HasForeignKey(c => c.IdUsr).WillCascadeOnDelete(false); // FK_inv_kardex_cat_usr
        }
    }

}
// </auto-generated>