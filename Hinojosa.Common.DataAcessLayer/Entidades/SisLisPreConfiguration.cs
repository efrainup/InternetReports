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

    // sis_lis_pre
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisLisPreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisLisPre>
    {
        public SisLisPreConfiguration()
            : this("dbo")
        {
        }

        public SisLisPreConfiguration(string schema)
        {
            ToTable("sis_lis_pre", schema);
            HasKey(x => x.IdSisLisPre);

            Property(x => x.IdSisLisPre).HasColumnName(@"id_sis_lis_pre").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdProLis).HasColumnName(@"id_pro_lis").HasColumnType("int").IsRequired();
            Property(x => x.IdLisPre).HasColumnName(@"id_lis_pre").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Precio).HasColumnName(@"precio").HasColumnType("float").IsRequired();
            Property(x => x.Factor1).HasColumnName(@"factor1").HasColumnType("float").IsRequired();
            Property(x => x.Factor2).HasColumnName(@"factor2").HasColumnType("float").IsRequired();
            Property(x => x.Factor3).HasColumnName(@"factor3").HasColumnType("float").IsRequired();
            Property(x => x.Factor4).HasColumnName(@"factor4").HasColumnType("float").IsRequired();
            Property(x => x.Factor5).HasColumnName(@"factor5").HasColumnType("float").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.TipCom).HasColumnName(@"tip_com").HasColumnType("tinyint").IsRequired();
            Property(x => x.PtgCom).HasColumnName(@"ptg_com").HasColumnType("float").IsRequired();
            Property(x => x.MtoCom).HasColumnName(@"mto_com").HasColumnType("float").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.IdCliFa).HasColumnName(@"id_cli_fa").HasColumnType("int").IsRequired();
            Property(x => x.IdCodSrv).HasColumnName(@"id_cod_srv").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdAlm).HasColumnName(@"id_alm").HasColumnType("int").IsRequired();
            Property(x => x.IdUdm).HasColumnName(@"id_udm").HasColumnType("int").IsRequired();
            Property(x => x.CodigoAlt).HasColumnName(@"codigo_alt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.DesAlt).HasColumnName(@"des_alt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.CCostoTrsld).HasColumnName(@"c_costo_trsld").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tip).HasColumnName(@"tip").HasColumnType("tinyint").IsRequired();
            Property(x => x.PtgKit).HasColumnName(@"ptg_kit").HasColumnType("float").IsRequired();
            Property(x => x.IdProKit).HasColumnName(@"id_pro_kit").HasColumnType("int").IsRequired();
            Property(x => x.Sec).HasColumnName(@"sec").HasColumnType("int").IsRequired();
            Property(x => x.CCalcPreCosto).HasColumnName(@"c_calc_pre_costo").HasColumnType("tinyint").IsRequired();
            Property(x => x.MargenMin).HasColumnName(@"margen_min").HasColumnType("float").IsRequired();
            Property(x => x.MargenSug).HasColumnName(@"margen_sug").HasColumnType("float").IsRequired();
            Property(x => x.IdVigPre).HasColumnName(@"id_vig_pre").HasColumnType("int").IsRequired();
            Property(x => x.IdTipCosto).HasColumnName(@"id_tip_costo").HasColumnType("int").IsRequired();
            Property(x => x.CTar).HasColumnName(@"c_tar").HasColumnType("tinyint").IsRequired();
            Property(x => x.PreVtaMin).HasColumnName(@"pre_vta_min").HasColumnType("float").IsRequired();
            Property(x => x.PreVtaMax).HasColumnName(@"pre_vta_max").HasColumnType("float").IsRequired();
            Property(x => x.CantIni).HasColumnName(@"cant_ini").HasColumnType("float").IsRequired();
            Property(x => x.CantFin).HasColumnName(@"cant_fin").HasColumnType("float").IsRequired();
            Property(x => x.DiasEnt).HasColumnName(@"dias_ent").HasColumnType("int").IsRequired();
            Property(x => x.IdCnd).HasColumnName(@"id_cnd").HasColumnType("int").IsRequired();
            Property(x => x.Descto).HasColumnName(@"descto").HasColumnType("float").IsRequired();
            Property(x => x.CAplBon).HasColumnName(@"c_apl_bon").HasColumnType("tinyint").IsRequired();
            Property(x => x.CAutReqAut).HasColumnName(@"c_aut_req_aut").HasColumnType("tinyint").IsRequired();
            Property(x => x.Desc1).HasColumnName(@"desc1").HasColumnType("float").IsRequired();
            Property(x => x.Desc2).HasColumnName(@"desc2").HasColumnType("float").IsRequired();
            Property(x => x.Desc3).HasColumnName(@"desc3").HasColumnType("float").IsRequired();
            Property(x => x.Desc4).HasColumnName(@"desc4").HasColumnType("float").IsRequired();
            Property(x => x.Desc5).HasColumnName(@"desc5").HasColumnType("float").IsRequired();
            Property(x => x.Desc6).HasColumnName(@"desc6").HasColumnType("float").IsRequired();
            Property(x => x.Desc7).HasColumnName(@"desc7").HasColumnType("float").IsRequired();
            Property(x => x.Desc8).HasColumnName(@"desc8").HasColumnType("float").IsRequired();
            Property(x => x.CtoCnl).HasColumnName(@"cto_cnl").HasColumnType("int").IsRequired();
            Property(x => x.DescInd).HasColumnName(@"desc_ind").HasColumnType("float").IsRequired();
            Property(x => x.DescNc).HasColumnName(@"desc_nc").HasColumnType("float").IsRequired();
            Property(x => x.DescBoni).HasColumnName(@"desc_boni").HasColumnType("float").IsRequired();
            Property(x => x.PrecioCostoInd).HasColumnName(@"precio_costo_ind").HasColumnType("float").IsRequired();
            Property(x => x.PrecioCostoNc).HasColumnName(@"precio_costo_nc").HasColumnType("float").IsRequired();
            Property(x => x.PrecioCostoBon).HasColumnName(@"precio_costo_bon").HasColumnType("float").IsRequired();
            Property(x => x.CodigoProv).HasColumnName(@"codigo_prov").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.IdUdmCli).HasColumnName(@"id_udm_cli").HasColumnType("int").IsRequired();
            Property(x => x.FactorUdmCli).HasColumnName(@"factor_udm_cli").HasColumnType("float").IsRequired();
            Property(x => x.NumDiasEntReal).HasColumnName(@"num_dias_ent_real").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
