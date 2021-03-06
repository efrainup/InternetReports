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

    // cxc_doc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxcDocConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CxcDoc>
    {
        public CxcDocConfiguration()
            : this("dbo")
        {
        }

        public CxcDocConfiguration(string schema)
        {
            ToTable("cxc_doc", schema);
            HasKey(x => x.IdCxcDoc);

            Property(x => x.IdCxcDoc).HasColumnName(@"id_cxc_doc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.@Ref).HasColumnName(@"ref").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.FecDoc).HasColumnName(@"fec_doc").HasColumnType("datetime").IsRequired();
            Property(x => x.Dias).HasColumnName(@"dias").HasColumnType("int").IsRequired();
            Property(x => x.FecVenc).HasColumnName(@"fec_venc").HasColumnType("datetime").IsRequired();
            Property(x => x.DctoPtg).HasColumnName(@"dcto_ptg").HasColumnType("float").IsRequired();
            Property(x => x.MtoDcto).HasColumnName(@"mto_dcto").HasColumnType("float").IsRequired();
            Property(x => x.ImpDoc).HasColumnName(@"imp_doc").HasColumnType("float").IsRequired();
            Property(x => x.Imptos).HasColumnName(@"imptos").HasColumnType("float").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("float").IsRequired();
            Property(x => x.Saldo).HasColumnName(@"saldo").HasColumnType("float").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdProy).HasColumnName(@"id_proy").HasColumnType("int").IsRequired();
            Property(x => x.IdEnt).HasColumnName(@"id_ent").HasColumnType("int").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.MtoDctoBse).HasColumnName(@"mto_dcto_bse").HasColumnType("float").IsRequired();
            Property(x => x.ImpDocBse).HasColumnName(@"imp_doc_bse").HasColumnType("float").IsRequired();
            Property(x => x.ImptosBse).HasColumnName(@"imptos_bse").HasColumnType("float").IsRequired();
            Property(x => x.TotalBse).HasColumnName(@"total_bse").HasColumnType("float").IsRequired();
            Property(x => x.SaldoBse).HasColumnName(@"saldo_bse").HasColumnType("float").IsRequired();
            Property(x => x.NoFact).HasColumnName(@"no_fact").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.IdCnd).HasColumnName(@"id_cnd").HasColumnType("int").IsRequired();
            Property(x => x.IdCliPad).HasColumnName(@"id_cli_pad").HasColumnType("int").IsRequired();
            Property(x => x.IdPol).HasColumnName(@"id_pol").HasColumnType("int").IsRequired();
            Property(x => x.IdClasCli).HasColumnName(@"id_clas_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdRelImpDoc).HasColumnName(@"id_rel_imp_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdCliFa).HasColumnName(@"id_cli_fa").HasColumnType("int").IsRequired();
            Property(x => x.FecRec).HasColumnName(@"fec_rec").HasColumnType("datetime").IsRequired();
            Property(x => x.TipVenc).HasColumnName(@"tip_venc").HasColumnType("int").IsRequired();
            Property(x => x.FecEstCob).HasColumnName(@"fec_est_cob").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
