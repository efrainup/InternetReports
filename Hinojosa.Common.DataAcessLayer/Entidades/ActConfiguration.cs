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

    // act
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ActConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Act>
    {
        public ActConfiguration()
            : this("dbo")
        {
        }

        public ActConfiguration(string schema)
        {
            ToTable("act", schema);
            HasKey(x => x.IdAct);

            Property(x => x.IdAct).HasColumnName(@"id_act").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Codigo).HasColumnName(@"codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Marca).HasColumnName(@"marca").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.Modelo).HasColumnName(@"modelo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.IdTip).HasColumnName(@"id_tip").HasColumnType("int").IsRequired();
            Property(x => x.IdClasCtb).HasColumnName(@"id_clas_ctb").HasColumnType("int").IsRequired();
            Property(x => x.IdClas1).HasColumnName(@"id_clas1").HasColumnType("int").IsRequired();
            Property(x => x.IdClas2).HasColumnName(@"id_clas2").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdPart).HasColumnName(@"id_part").HasColumnType("int").IsRequired();
            Property(x => x.IdMtoSerLot).HasColumnName(@"id_mto_ser_lot").HasColumnType("int").IsRequired();
            Property(x => x.FecCom).HasColumnName(@"fec_com").HasColumnType("datetime").IsRequired();
            Property(x => x.FolioCom).HasColumnName(@"folio_com").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.ValorCom).HasColumnName(@"valor_com").HasColumnType("float").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.FecIniDep).HasColumnName(@"fec_ini_dep").HasColumnType("datetime").IsRequired();
            Property(x => x.FecUltDep).HasColumnName(@"fec_ult_dep").HasColumnType("datetime").IsRequired();
            Property(x => x.MetDep).HasColumnName(@"met_dep").HasColumnType("tinyint").IsRequired();
            Property(x => x.PtgDep).HasColumnName(@"ptg_dep").HasColumnType("float").IsRequired();
            Property(x => x.DepAcu).HasColumnName(@"dep_acu").HasColumnType("float").IsRequired();
            Property(x => x.DepMax).HasColumnName(@"dep_max").HasColumnType("float").IsRequired();
            Property(x => x.StatusDep).HasColumnName(@"status_dep").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTipBaj).HasColumnName(@"id_tip_baj").HasColumnType("int").IsRequired();
            Property(x => x.FecAlta).HasColumnName(@"fec_alta").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdDepto).HasColumnName(@"id_depto").HasColumnType("int").IsRequired();
            Property(x => x.IdEmp).HasColumnName(@"id_emp").HasColumnType("int").IsRequired();
            Property(x => x.Vida).HasColumnName(@"vida").HasColumnType("float").IsOptional();
            Property(x => x.FecIniDepErp).HasColumnName(@"fec_ini_dep_ERP").HasColumnType("datetime").IsRequired();
            Property(x => x.VidaDep).HasColumnName(@"vida_dep").HasColumnType("float").IsOptional();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.ValorComBase).HasColumnName(@"valor_com_base").HasColumnType("float").IsRequired();
            Property(x => x.MetDepFis).HasColumnName(@"met_dep_fis").HasColumnType("tinyint").IsRequired();
            Property(x => x.ValorGa).HasColumnName(@"valor_ga").HasColumnType("float").IsRequired();
            Property(x => x.IdMdaGa).HasColumnName(@"id_mda_ga").HasColumnType("int").IsRequired();
            Property(x => x.OperGa).HasColumnName(@"oper_ga").HasColumnType("tinyint").IsRequired();
            Property(x => x.TcGa).HasColumnName(@"tc_ga").HasColumnType("float").IsRequired();
            Property(x => x.ValorGaBase).HasColumnName(@"valor_ga_base").HasColumnType("float").IsRequired();
            Property(x => x.IdNotaGa).HasColumnName(@"id_nota_ga").HasColumnType("int").IsRequired();
            Property(x => x.CAfe).HasColumnName(@"c_afe").HasColumnType("tinyint").IsRequired();
            Property(x => x.DepAcuFis).HasColumnName(@"dep_acu_fis").HasColumnType("float").IsRequired();
            Property(x => x.StatusDepFis).HasColumnName(@"status_dep_fis").HasColumnType("tinyint").IsRequired();
            Property(x => x.PtgDepMax).HasColumnName(@"ptg_dep_max").HasColumnType("float").IsRequired();
            Property(x => x.VidaDepFis).HasColumnName(@"vida_dep_fis").HasColumnType("float").IsOptional();
            Property(x => x.FecIniDepFis).HasColumnName(@"fec_ini_dep_fis").HasColumnType("datetime").IsRequired();
            Property(x => x.FecIniDepFisErp).HasColumnName(@"fec_ini_dep_fis_ERP").HasColumnType("datetime").IsRequired();
            Property(x => x.FecUltDepFis).HasColumnName(@"fec_ult_dep_fis").HasColumnType("datetime").IsRequired();
            Property(x => x.CAfeFis).HasColumnName(@"c_afe_fis").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCenCto).HasColumnName(@"id_cen_cto").HasColumnType("int").IsRequired();
            Property(x => x.IdCodSrv).HasColumnName(@"id_cod_srv").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdUltPol).HasColumnName(@"id_ult_pol").HasColumnType("int").IsRequired();
            Property(x => x.Intervalo).HasColumnName(@"intervalo").HasColumnType("int").IsRequired();
            Property(x => x.ValorBase).HasColumnName(@"valor_base").HasColumnType("float").IsRequired();
            Property(x => x.IdAlm).HasColumnName(@"id_alm").HasColumnType("int").IsRequired();
            Property(x => x.IdPerUltDep).HasColumnName(@"id_per_ult_dep").HasColumnType("int").IsRequired();
            Property(x => x.IdPerUltDepFis).HasColumnName(@"id_per_ult_dep_fis").HasColumnType("int").IsRequired();
            Property(x => x.IdRelCar).HasColumnName(@"id_rel_car").HasColumnType("int").IsRequired();
            Property(x => x.CMultAsig).HasColumnName(@"c_mult_asig").HasColumnType("int").IsRequired();
            Property(x => x.IdRelEmp).HasColumnName(@"id_rel_emp").HasColumnType("int").IsRequired();
            Property(x => x.CValorAsig).HasColumnName(@"c_valor_asig").HasColumnType("tinyint").IsRequired();
            Property(x => x.ValorAsig).HasColumnName(@"valor_asig").HasColumnType("float").IsRequired();
            Property(x => x.VidaFis).HasColumnName(@"vida_fis").HasColumnType("float").IsOptional();
            Property(x => x.TipAct).HasColumnName(@"tip_act").HasColumnType("tinyint").IsRequired();
            Property(x => x.CSegPagAnt).HasColumnName(@"c_seg_pag_ant").HasColumnType("tinyint").IsRequired();
            Property(x => x.InpcCom).HasColumnName(@"inpc_com").HasColumnType("float").IsRequired();
            Property(x => x.FecVig).HasColumnName(@"fec_vig").HasColumnType("datetime").IsRequired();
            Property(x => x.IdCmp).HasColumnName(@"id_cmp").HasColumnType("int").IsRequired();
            Property(x => x.CIntangible).HasColumnName(@"c_intangible").HasColumnType("tinyint").IsRequired();
            Property(x => x.FecGar).HasColumnName(@"fec_gar").HasColumnType("datetime").IsRequired();
            Property(x => x.FecGarExt).HasColumnName(@"fec_gar_ext").HasColumnType("datetime").IsRequired();
            Property(x => x.Cantidad).HasColumnName(@"cantidad").HasColumnType("int").IsRequired();
            Property(x => x.Asegurable).HasColumnName(@"asegurable").HasColumnType("tinyint").IsRequired();
            Property(x => x.Compañia).HasColumnName(@"compañia").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Numpol).HasColumnName(@"numpol").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
        }
    }

}
// </auto-generated>
