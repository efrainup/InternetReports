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

    // imp_com_doc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ImpComDocConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ImpComDoc>
    {
        public ImpComDocConfiguration()
            : this("dbo")
        {
        }

        public ImpComDocConfiguration(string schema)
        {
            ToTable("imp_com_doc", schema);
            HasKey(x => x.ImpIdCom);

            Property(x => x.ImpIdCom).HasColumnName(@"imp_id_com").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ImpRfcProv).HasColumnName(@"imp_rfc_prov").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.ImpOtrSisProv).HasColumnName(@"imp_otr_sis_prov").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.ImpIdTipDoc).HasColumnName(@"imp_id_tip_doc").HasColumnType("int").IsOptional();
            Property(x => x.ImpIdUsr).HasColumnName(@"imp_id_usr").HasColumnType("int").IsOptional();
            Property(x => x.ImpIdSuc).HasColumnName(@"imp_id_suc").HasColumnType("int").IsOptional();
            Property(x => x.ImpIdSucOtrSis).HasColumnName(@"imp_id_suc_otr_sis").HasColumnType("int").IsOptional();
            Property(x => x.ImpNumDoc).HasColumnName(@"imp_num_doc").HasColumnType("int").IsOptional();
            Property(x => x.ImpReferencia).HasColumnName(@"imp_referencia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.ImpFecDoc).HasColumnName(@"imp_fec_doc").HasColumnType("datetime").IsOptional();
            Property(x => x.ImpFecVenc).HasColumnName(@"imp_fec_venc").HasColumnType("datetime").IsOptional();
            Property(x => x.ImpFecReg).HasColumnName(@"imp_fec_reg").HasColumnType("datetime").IsOptional();
            Property(x => x.ImpFecEstPag).HasColumnName(@"imp_fec_est_pag").HasColumnType("datetime").IsOptional();
            Property(x => x.ImpDctoPtg).HasColumnName(@"imp_dcto_ptg").HasColumnType("float").IsOptional();
            Property(x => x.ImpMtoDcto).HasColumnName(@"imp_mto_dcto").HasColumnType("float").IsOptional();
            Property(x => x.ImpImporteSdcto).HasColumnName(@"imp_importe_sdcto").HasColumnType("float").IsOptional();
            Property(x => x.ImpImporteSimptos).HasColumnName(@"imp_importe_simptos").HasColumnType("float").IsOptional();
            Property(x => x.ImpImpto).HasColumnName(@"imp_impto").HasColumnType("float").IsOptional();
            Property(x => x.ImpTotal).HasColumnName(@"imp_total").HasColumnType("float").IsOptional();
            Property(x => x.ImpSaldo).HasColumnName(@"imp_saldo").HasColumnType("float").IsOptional();
            Property(x => x.ImpSaldoSimptos).HasColumnName(@"imp_saldo_simptos").HasColumnType("float").IsOptional();
            Property(x => x.ImpCargosMisc).HasColumnName(@"imp_cargos_misc").HasColumnType("float").IsOptional();
            Property(x => x.ImpTotalDev).HasColumnName(@"imp_total_dev").HasColumnType("float").IsOptional();
            Property(x => x.ImpStatus).HasColumnName(@"imp_status").HasColumnType("float").IsOptional();
            Property(x => x.ImpCodsatMda).HasColumnName(@"imp_codsat_mda").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.ImpTc).HasColumnName(@"imp_tc").HasColumnType("float").IsOptional();
            Property(x => x.ImpOper).HasColumnName(@"imp_oper").HasColumnType("tinyint").IsOptional();
            Property(x => x.ImpMtoDctoBse).HasColumnName(@"imp_mto_dcto_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpImporteSdctoBse).HasColumnName(@"imp_importe_sdcto_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpImporteSimptosBse).HasColumnName(@"imp_importe_simptos_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpImptoBse).HasColumnName(@"imp_impto_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpTotalBse).HasColumnName(@"imp_total_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpSaldoBse).HasColumnName(@"imp_saldo_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpSaldoSimptosBse).HasColumnName(@"imp_saldo_simptos_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpCargosMiscBse).HasColumnName(@"imp_cargos_misc_bse").HasColumnType("float").IsOptional();
            Property(x => x.ImpNumDocRec).HasColumnName(@"imp_num_doc_rec").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.ImpIdCpt).HasColumnName(@"imp_id_cpt").HasColumnType("int").IsOptional();
            Property(x => x.ImpIdCnd).HasColumnName(@"imp_id_cnd").HasColumnType("int").IsOptional();
            Property(x => x.ImpDocRecTip).HasColumnName(@"imp_doc_rec_tip").HasColumnType("tinyint").IsOptional();
            Property(x => x.ImpTipCom).HasColumnName(@"imp_tip_com").HasColumnType("tinyint").IsOptional();
            Property(x => x.ImpIdOtrSis).HasColumnName(@"imp_id_otr_sis").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.ImpRfcEmp).HasColumnName(@"imp_rfc_emp").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.ImpIdCmp).HasColumnName(@"imp_id_cmp").HasColumnType("int").IsOptional();
            Property(x => x.ImpCmtImp).HasColumnName(@"imp_cmt_imp").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(750);
            Property(x => x.ImpStatusImp).HasColumnName(@"imp_status_imp").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
