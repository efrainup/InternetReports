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

    // vta_fac_enc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaFacEncConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VtaFacEnc>
    {
        public VtaFacEncConfiguration()
            : this("dbo")
        {
        }

        public VtaFacEncConfiguration(string schema)
        {
            ToTable("vta_fac_enc", schema);
            HasKey(x => x.IdFac);

            Property(x => x.IdFac).HasColumnName(@"id_fac").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdTipoDoc).HasColumnName(@"id_tipo_doc").HasColumnType("int").IsRequired();
            Property(x => x.Numero).HasColumnName(@"numero").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Sub).HasColumnName(@"sub").HasColumnType("float").IsRequired();
            Property(x => x.Imptos).HasColumnName(@"imptos").HasColumnType("float").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("float").IsRequired();
            Property(x => x.Saldo).HasColumnName(@"saldo").HasColumnType("float").IsRequired();
            Property(x => x.Dcto).HasColumnName(@"dcto").HasColumnType("float").IsRequired();
            Property(x => x.DctoMto).HasColumnName(@"dcto_mto").HasColumnType("float").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dias).HasColumnName(@"dias").HasColumnType("int").IsOptional();
            Property(x => x.FechaVenc).HasColumnName(@"fecha_venc").HasColumnType("datetime").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdProy).HasColumnName(@"id_proy").HasColumnType("int").IsRequired();
            Property(x => x.@Ref).HasColumnName(@"ref").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdVend).HasColumnName(@"id_vend").HasColumnType("int").IsRequired();
            Property(x => x.PtgCom).HasColumnName(@"ptg_com").HasColumnType("float").IsRequired();
            Property(x => x.ComMonto).HasColumnName(@"com_monto").HasColumnType("float").IsRequired();
            Property(x => x.ComPagMto).HasColumnName(@"com_pag_mto").HasColumnType("float").IsRequired();
            Property(x => x.TipoCom).HasColumnName(@"tipo_com").HasColumnType("tinyint").IsRequired();
            Property(x => x.TipoFac).HasColumnName(@"tipo_fac").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.TipCam).HasColumnName(@"tip_cam").HasColumnType("float").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.SubBse).HasColumnName(@"sub_bse").HasColumnType("float").IsRequired();
            Property(x => x.ImptosBse).HasColumnName(@"imptos_bse").HasColumnType("float").IsRequired();
            Property(x => x.TotalBse).HasColumnName(@"total_bse").HasColumnType("float").IsRequired();
            Property(x => x.SaldoBse).HasColumnName(@"saldo_bse").HasColumnType("float").IsRequired();
            Property(x => x.DctoMtoBse).HasColumnName(@"dcto_mto_bse").HasColumnType("float").IsRequired();
            Property(x => x.IdLab).HasColumnName(@"id_lab").HasColumnType("int").IsRequired();
            Property(x => x.IdMedEnv1).HasColumnName(@"id_med_env1").HasColumnType("int").IsRequired();
            Property(x => x.NoGuia1).HasColumnName(@"no_guia1").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.FecGuia1).HasColumnName(@"fec_guia1").HasColumnType("datetime").IsRequired();
            Property(x => x.IdMedEnv2).HasColumnName(@"id_med_env2").HasColumnType("int").IsRequired();
            Property(x => x.NoGuia2).HasColumnName(@"no_guia2").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.FecGuia2).HasColumnName(@"fec_guia2").HasColumnType("datetime").IsRequired();
            Property(x => x.FecEnt).HasColumnName(@"fec_ent").HasColumnType("datetime").IsRequired();
            Property(x => x.IdEmpRealizo).HasColumnName(@"id_emp_realizo").HasColumnType("int").IsRequired();
            Property(x => x.IdEmpAut).HasColumnName(@"id_emp_aut").HasColumnType("int").IsRequired();
            Property(x => x.CSurt).HasColumnName(@"c_surt").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prioridad).HasColumnName(@"prioridad").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdSisEdoAct).HasColumnName(@"id_sis_edo_act").HasColumnType("int").IsRequired();
            Property(x => x.Falla).HasColumnName(@"falla").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(512);
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.IdCnd).HasColumnName(@"id_cnd").HasColumnType("int").IsRequired();
            Property(x => x.IdCliPad).HasColumnName(@"id_cli_pad").HasColumnType("int").IsRequired();
            Property(x => x.IdClasCli).HasColumnName(@"id_clas_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdCliFa).HasColumnName(@"id_cli_fa").HasColumnType("int").IsRequired();
            Property(x => x.IdCliDa).HasColumnName(@"id_cli_da").HasColumnType("int").IsRequired();
            Property(x => x.IdCto).HasColumnName(@"id_cto").HasColumnType("int").IsRequired();
            Property(x => x.IdRelImpDoc).HasColumnName(@"id_rel_imp_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdPol).HasColumnName(@"id_pol").HasColumnType("int").IsRequired();
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.CDis).HasColumnName(@"c_dis").HasColumnType("tinyint").IsRequired();
            Property(x => x.Dis).HasColumnName(@"dis").HasColumnType("int").IsRequired();
            Property(x => x.PtgDis).HasColumnName(@"ptg_dis").HasColumnType("float").IsRequired();
            Property(x => x.IdFacSust).HasColumnName(@"id_fac_sust").HasColumnType("int").IsRequired();
            Property(x => x.IdNotaSust).HasColumnName(@"id_nota_sust").HasColumnType("int").IsRequired();
            Property(x => x.IdTipVta).HasColumnName(@"Id_Tip_Vta").HasColumnType("int").IsRequired();
            Property(x => x.MtoAnt).HasColumnName(@"mto_ant").HasColumnType("float").IsRequired();
            Property(x => x.SdoAnt).HasColumnName(@"sdo_ant").HasColumnType("float").IsRequired();
            Property(x => x.MtoApl).HasColumnName(@"mto_apl").HasColumnType("float").IsRequired();
            Property(x => x.SdoApl).HasColumnName(@"sdo_apl").HasColumnType("float").IsRequired();
            Property(x => x.FecEstCob).HasColumnName(@"fec_est_cob").HasColumnType("datetime").IsRequired();
            Property(x => x.FecRev).HasColumnName(@"fec_rev").HasColumnType("datetime").IsRequired();
            Property(x => x.StatusPrc).HasColumnName(@"status_prc").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCliDaMer).HasColumnName(@"id_cli_da_mer").HasColumnType("int").IsRequired();
            Property(x => x.TipNc).HasColumnName(@"tip_nc").HasColumnType("tinyint").IsRequired();
            Property(x => x.CComp).HasColumnName(@"c_comp").HasColumnType("tinyint").IsRequired();
            Property(x => x.StatusSurt).HasColumnName(@"status_surt").HasColumnType("tinyint").IsRequired();
            Property(x => x.FecUltMod).HasColumnName(@"fec_ult_mod").HasColumnType("datetime").IsRequired();
            Property(x => x.CImpLey).HasColumnName(@"c_imp_ley").HasColumnType("tinyint").IsRequired();
            Property(x => x.Leyenda).HasColumnName(@"leyenda").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdAut).HasColumnName(@"id_aut").HasColumnType("int").IsRequired();
            Property(x => x.Deducible).HasColumnName(@"deducible").HasColumnType("float").IsRequired();
            Property(x => x.Coaseguro).HasColumnName(@"coaseguro").HasColumnType("float").IsRequired();
            Property(x => x.CargosNoCub).HasColumnName(@"cargos_no_cub").HasColumnType("float").IsRequired();
            Property(x => x.Descuento1).HasColumnName(@"descuento1").HasColumnType("float").IsRequired();
            Property(x => x.Descuento2).HasColumnName(@"descuento2").HasColumnType("float").IsRequired();
            Property(x => x.HonorariosMedicos).HasColumnName(@"honorarios_medicos").HasColumnType("float").IsRequired();
            Property(x => x.NcAfeDocPad).HasColumnName(@"nc_afe_doc_pad").HasColumnType("int").IsRequired();
            Property(x => x.IdTipUso).HasColumnName(@"id_tip_uso").HasColumnType("int").IsRequired();
            Property(x => x.IdOperador).HasColumnName(@"id_operador").HasColumnType("int").IsRequired();
            Property(x => x.IdEquipo).HasColumnName(@"id_equipo").HasColumnType("int").IsRequired();
            Property(x => x.IdPorteador).HasColumnName(@"id_porteador").HasColumnType("int").IsRequired();
            Property(x => x.FecRecoleccion).HasColumnName(@"fec_recoleccion").HasColumnType("datetime").IsRequired();
            Property(x => x.FecPrometida).HasColumnName(@"fec_prometida").HasColumnType("datetime").IsRequired();
            Property(x => x.FecEntReal).HasColumnName(@"fec_ent_real").HasColumnType("datetime").IsRequired();
            Property(x => x.IdCaja).HasColumnName(@"id_caja").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatCliente).WithMany(b => b.VtaFacEncs).HasForeignKey(c => c.IdCli).WillCascadeOnDelete(false); // FK_vta_fac_enc_cat_clientes
            HasRequired(a => a.CatUsr).WithMany(b => b.VtaFacEncs).HasForeignKey(c => c.IdUsr).WillCascadeOnDelete(false); // FK_vta_fac_enc_cat_usr
            HasRequired(a => a.SisCto).WithMany(b => b.VtaFacEncs).HasForeignKey(c => c.IdCto).WillCascadeOnDelete(false); // FK_vta_fac_enc_sis_cto
        }
    }

}
// </auto-generated>
