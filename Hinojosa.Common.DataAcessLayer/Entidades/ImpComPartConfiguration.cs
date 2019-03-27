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

    // imp_com_part
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ImpComPartConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ImpComPart>
    {
        public ImpComPartConfiguration()
            : this("dbo")
        {
        }

        public ImpComPartConfiguration(string schema)
        {
            ToTable("imp_com_part", schema);
            HasKey(x => x.ImpIdPart);

            Property(x => x.ImpIdPart).HasColumnName(@"imp_id_part").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ImpIdCom).HasColumnName(@"imp_id_com").HasColumnType("int").IsOptional();
            Property(x => x.ImpIdSuc).HasColumnName(@"imp_id_suc").HasColumnType("int").IsOptional();
            Property(x => x.ImpFecReq).HasColumnName(@"imp_fec_req").HasColumnType("datetime").IsOptional();
            Property(x => x.ImpIdPro).HasColumnName(@"imp_id_pro").HasColumnType("int").IsOptional();
            Property(x => x.ImpIdOtrSisPro).HasColumnName(@"imp_id_otr_sis_pro").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.ImpDesPro).HasColumnName(@"imp_des_pro").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.ImpCodsatUdm).HasColumnName(@"imp_codsat_udm").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.ImpFtr).HasColumnName(@"imp_ftr").HasColumnType("float").IsOptional();
            Property(x => x.ImpCant).HasColumnName(@"imp_cant").HasColumnType("float").IsOptional();
            Property(x => x.ImpUltCto).HasColumnName(@"imp_ult_cto").HasColumnType("float").IsOptional();
            Property(x => x.ImpDctoPtgo).HasColumnName(@"imp_dcto_ptgo").HasColumnType("float").IsOptional();
            Property(x => x.ImpMtoPtgo).HasColumnName(@"imp_mto_ptgo").HasColumnType("float").IsOptional();
            Property(x => x.ImpCtoDcto).HasColumnName(@"imp_cto_dcto").HasColumnType("float").IsOptional();
            Property(x => x.ImpImporteSdcto).HasColumnName(@"imp_importe_sdcto").HasColumnType("float").IsOptional();
            Property(x => x.ImpImporte).HasColumnName(@"imp_importe").HasColumnType("float").IsOptional();
            Property(x => x.ImpImptos).HasColumnName(@"imp_imptos").HasColumnType("float").IsOptional();
            Property(x => x.ImpTotal).HasColumnName(@"imp_total").HasColumnType("float").IsOptional();
            Property(x => x.ImpMtoIeps).HasColumnName(@"imp_mto_ieps").HasColumnType("float").IsOptional();
            Property(x => x.ImpImporteAlm).HasColumnName(@"imp_importe_alm").HasColumnType("float").IsOptional();
            Property(x => x.ImpCInv).HasColumnName(@"imp_c_inv").HasColumnType("tinyint").IsOptional();
            Property(x => x.ImpPorComprar).HasColumnName(@"imp_por_comprar").HasColumnType("float").IsOptional();
            Property(x => x.ImpCantDev).HasColumnName(@"imp_cant_dev").HasColumnType("float").IsOptional();
            Property(x => x.ImpGastos).HasColumnName(@"imp_gastos").HasColumnType("float").IsOptional();
            Property(x => x.ImpCodsatMda).HasColumnName(@"imp_codsat_mda").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.ImpTc).HasColumnName(@"imp_tc").HasColumnType("float").IsOptional();
            Property(x => x.ImpOper).HasColumnName(@"imp_oper").HasColumnType("tinyint").IsOptional();
            Property(x => x.ImpUltCtoBse).HasColumnName(@"imp_ult_cto_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpDctoPtgoBse).HasColumnName(@"imp_dcto_ptgo_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpMtoPtgoBse).HasColumnName(@"imp_mto_ptgo_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpCtoDctoBse).HasColumnName(@"imp_cto_dcto_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpImporteSdctoBse).HasColumnName(@"imp_importe_sdcto_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpImporteBse).HasColumnName(@"imp_importe_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpImptosBse).HasColumnName(@"imp_imptos_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpTotalBse).HasColumnName(@"imp_total_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpPorRecibir).HasColumnName(@"imp_por_recibir").HasColumnType("float").IsOptional();
            Property(x => x.ImpIdAlm).HasColumnName(@"imp_id_alm").HasColumnType("int").IsOptional();
            Property(x => x.ImpIdOtrSisAlm).HasColumnName(@"imp_id_otr_sis_alm").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.ImpIdCodSrv).HasColumnName(@"imp_id_cod_srv").HasColumnType("int").IsOptional();
            Property(x => x.ImpIdCenCto).HasColumnName(@"imp_id_cen_cto").HasColumnType("int").IsOptional();
            Property(x => x.ImpIdRef).HasColumnName(@"imp_id_ref").HasColumnType("int").IsOptional();
            Property(x => x.ImpIdClassPro).HasColumnName(@"imp_id_class_pro").HasColumnType("int").IsOptional();
            Property(x => x.ImpRfcProv).HasColumnName(@"imp_rfc_prov").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.ImpOtrSisProv).HasColumnName(@"imp_otr_sis_prov").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.ImpCMisDoc).HasColumnName(@"imp_c_mis_doc").HasColumnType("tinyint").IsOptional();
            Property(x => x.ImpCInd).HasColumnName(@"imp_c_ind").HasColumnType("tinyint").IsOptional();
            Property(x => x.ImpCModImpto).HasColumnName(@"imp_c_mod_impto").HasColumnType("tinyint").IsOptional();
            Property(x => x.ImpNumPart).HasColumnName(@"imp_num_part").HasColumnType("int").IsOptional();
            Property(x => x.ImpCantCanc).HasColumnName(@"imp_cant_canc").HasColumnType("float").IsOptional();
            Property(x => x.ImpCantVta).HasColumnName(@"imp_cant_vta").HasColumnType("float").IsOptional();
            Property(x => x.ImpCmt).HasColumnName(@"imp_cmt").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.ImpCmtImp).HasColumnName(@"imp_cmt_imp").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.ImpStatusImp).HasColumnName(@"imp_status_imp").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
