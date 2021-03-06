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

    // inv_mov_ser_lot
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvMovSerLotConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvMovSerLot>
    {
        public InvMovSerLotConfiguration()
            : this("dbo")
        {
        }

        public InvMovSerLotConfiguration(string schema)
        {
            ToTable("inv_mov_ser_lot", schema);
            HasKey(x => x.IdMovSerLot);

            Property(x => x.IdMovSerLot).HasColumnName(@"id_mov_ser_lot").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdSerLot).HasColumnName(@"id_ser_lot").HasColumnType("int").IsRequired();
            Property(x => x.IdAlmac).HasColumnName(@"id_almac").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.FecElab).HasColumnName(@"fec_elab").HasColumnType("datetime").IsRequired();
            Property(x => x.FecCad).HasColumnName(@"fec_cad").HasColumnType("datetime").IsRequired();
            Property(x => x.IdSisCnl).HasColumnName(@"id_sis_cnl").HasColumnType("int").IsRequired();
            Property(x => x.IdUdm).HasColumnName(@"id_udm").HasColumnType("int").IsRequired();
            Property(x => x.Ftr).HasColumnName(@"ftr").HasColumnType("float").IsRequired();
            Property(x => x.CantInv).HasColumnName(@"cant_inv").HasColumnType("float").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdCenCto).HasColumnName(@"id_cen_cto").HasColumnType("int").IsRequired();
            Property(x => x.IdCodSrv).HasColumnName(@"id_cod_srv").HasColumnType("int").IsRequired();
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.IdCliFaDa).HasColumnName(@"id_cli_fa_da").HasColumnType("int").IsRequired();
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdVer).HasColumnName(@"id_ver").HasColumnType("int").IsRequired();
            Property(x => x.CAfeSerLot).HasColumnName(@"c_afe_ser_lot").HasColumnType("int").IsRequired();
            Property(x => x.Costo).HasColumnName(@"costo").HasColumnType("float").IsRequired();
            Property(x => x.CostoTotal).HasColumnName(@"costo_total").HasColumnType("float").IsRequired();
            Property(x => x.Precio).HasColumnName(@"precio").HasColumnType("float").IsRequired();
            Property(x => x.Importe).HasColumnName(@"importe").HasColumnType("float").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.PrecioBse).HasColumnName(@"precio_bse").HasColumnType("float").IsRequired();
            Property(x => x.ImporteBse).HasColumnName(@"importe_bse").HasColumnType("float").IsRequired();
            Property(x => x.CImp).HasColumnName(@"c_imp").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdPed).HasColumnName(@"id_ped").HasColumnType("int").IsRequired();
            Property(x => x.CantSurt).HasColumnName(@"cant_surt").HasColumnType("float").IsRequired();
            Property(x => x.CantSurtAut).HasColumnName(@"cant_surt_aut").HasColumnType("float").IsRequired();
            Property(x => x.NumSer).HasColumnName(@"num_ser").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.NumSerFin).HasColumnName(@"num_ser_fin").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.Nlargo).HasColumnName(@"nlargo").HasColumnType("float").IsRequired();
            Property(x => x.Nancho).HasColumnName(@"nancho").HasColumnType("float").IsRequired();
            Property(x => x.Nespesor).HasColumnName(@"nespesor").HasColumnType("float").IsRequired();
            Property(x => x.Nvolumen).HasColumnName(@"nvolumen").HasColumnType("float").IsRequired();
            Property(x => x.Narea).HasColumnName(@"narea").HasColumnType("float").IsRequired();
            Property(x => x.Npeso).HasColumnName(@"npeso").HasColumnType("float").IsRequired();
            Property(x => x.CostoBse).HasColumnName(@"costo_bse").HasColumnType("float").IsRequired();
            Property(x => x.CostoTotalBse).HasColumnName(@"costo_total_bse").HasColumnType("float").IsRequired();
            Property(x => x.CostoInd).HasColumnName(@"costo_ind").HasColumnType("float").IsRequired();
            Property(x => x.IdMdaInd).HasColumnName(@"id_mda_ind").HasColumnType("int").IsRequired();
            Property(x => x.OperInd).HasColumnName(@"oper_ind").HasColumnType("tinyint").IsRequired();
            Property(x => x.TcInd).HasColumnName(@"tc_ind").HasColumnType("float").IsRequired();
            Property(x => x.CostoIndBse).HasColumnName(@"costo_ind_bse").HasColumnType("float").IsRequired();
            Property(x => x.SMarca).HasColumnName(@"sMarca").HasColumnType("nvarchar").IsRequired().HasMaxLength(80);
            Property(x => x.SSerieProv).HasColumnName(@"sSerieProv").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.TipoMov).HasColumnName(@"tipo_mov").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatAlmac).WithMany(b => b.InvMovSerLots).HasForeignKey(c => c.IdAlmac).WillCascadeOnDelete(false); // FK_inv_mov_ser_lot_cat_almac
            HasRequired(a => a.CatDocto).WithMany(b => b.InvMovSerLots).HasForeignKey(c => c.IdTipDoc).WillCascadeOnDelete(false); // FK_inv_mov_ser_lot_cat_doctos
            HasRequired(a => a.CatUsr).WithMany(b => b.InvMovSerLots).HasForeignKey(c => c.IdUsr).WillCascadeOnDelete(false); // FK_inv_mov_ser_lot_cat_usr
            HasRequired(a => a.InvSerLot).WithMany(b => b.InvMovSerLots).HasForeignKey(c => c.IdSerLot).WillCascadeOnDelete(false); // FK_inv_mov_ser_lot_inv_ser_lot
        }
    }

}
// </auto-generated>
