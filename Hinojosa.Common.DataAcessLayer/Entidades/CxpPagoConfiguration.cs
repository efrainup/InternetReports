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

    // cxp_pagos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxpPagoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CxpPago>
    {
        public CxpPagoConfiguration()
            : this("dbo")
        {
        }

        public CxpPagoConfiguration(string schema)
        {
            ToTable("cxp_pagos", schema);
            HasKey(x => x.IdPago);

            Property(x => x.IdPago).HasColumnName(@"id_pago").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.IdCta).HasColumnName(@"id_cta").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdBcoAux).HasColumnName(@"id_bco_aux").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumChq).HasColumnName(@"num_chq").HasColumnType("int").IsRequired();
            Property(x => x.NumDocCli).HasColumnName(@"num_doc_cli").HasColumnType("int").IsRequired();
            Property(x => x.RefBen).HasColumnName(@"ref_ben").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Monto).HasColumnName(@"monto").HasColumnType("float").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCaja).HasColumnName(@"id_caja").HasColumnType("int").IsRequired();
            Property(x => x.IdCorte).HasColumnName(@"id_corte").HasColumnType("int").IsRequired();
            Property(x => x.IdCierre).HasColumnName(@"id_cierre").HasColumnType("int").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.MontoBse).HasColumnName(@"monto_bse").HasColumnType("float").IsRequired();
            Property(x => x.IdTipTrn).HasColumnName(@"id_tip_trn").HasColumnType("int").IsRequired();
            Property(x => x.CChq).HasColumnName(@"c_chq").HasColumnType("tinyint").IsRequired();
            Property(x => x.Saldo).HasColumnName(@"saldo").HasColumnType("float").IsRequired();
            Property(x => x.SaldoBse).HasColumnName(@"saldo_bse").HasColumnType("float").IsRequired();
            Property(x => x.IdAnt).HasColumnName(@"id_ant").HasColumnType("int").IsRequired();
            Property(x => x.IdMdaProv).HasColumnName(@"id_mda_prov").HasColumnType("int").IsRequired();
            Property(x => x.TcProv).HasColumnName(@"tc_prov").HasColumnType("float").IsRequired();
            Property(x => x.OperProv).HasColumnName(@"oper_prov").HasColumnType("tinyint").IsRequired();
            Property(x => x.MontoProv).HasColumnName(@"monto_prov").HasColumnType("float").IsRequired();
            Property(x => x.SaldoProv).HasColumnName(@"saldo_prov").HasColumnType("float").IsRequired();
            Property(x => x.IdPol).HasColumnName(@"id_pol").HasColumnType("int").IsRequired();
            Property(x => x.IdRelBcoIva).HasColumnName(@"id_rel_bco_iva").HasColumnType("int").IsRequired();
            Property(x => x.CAboCta).HasColumnName(@"c_abo_cta").HasColumnType("int").IsRequired();
            Property(x => x.IdClasProv).HasColumnName(@"id_clas_prov").HasColumnType("int").IsRequired();
            Property(x => x.CApl).HasColumnName(@"c_apl").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdNc).HasColumnName(@"id_nc").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.CMisDoc).HasColumnName(@"c_mis_doc").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCenCto).HasColumnName(@"id_cen_cto").HasColumnType("int").IsRequired();
            Property(x => x.TcPago).HasColumnName(@"tc_pago").HasColumnType("float").IsRequired();
            Property(x => x.IdBcoDoc).HasColumnName(@"id_bco_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdEnt).HasColumnName(@"id_ent").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDocSus).HasColumnName(@"id_tip_doc_sus").HasColumnType("int").IsRequired();
            Property(x => x.IdDocSus).HasColumnName(@"id_doc_sus").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.CPagDif).HasColumnName(@"c_pag_dif").HasColumnType("tinyint").IsRequired();
            Property(x => x.CtaDest).HasColumnName(@"cta_dest").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.ClabeDest).HasColumnName(@"clabe_dest").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.BcoCodDest).HasColumnName(@"bco_cod_dest").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.DesBcoDest).HasColumnName(@"des_bco_dest").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.CxpPagoes).HasForeignKey(c => c.IdUsr).WillCascadeOnDelete(false); // FK_cxp_pagos_cat_usr
        }
    }

}
// </auto-generated>
