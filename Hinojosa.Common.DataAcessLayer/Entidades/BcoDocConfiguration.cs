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

    // bco_doc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoDocConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BcoDoc>
    {
        public BcoDocConfiguration()
            : this("dbo")
        {
        }

        public BcoDocConfiguration(string schema)
        {
            ToTable("bco_doc", schema);
            HasKey(x => x.IdBcoDoc);

            Property(x => x.IdBcoDoc).HasColumnName(@"id_bco_doc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdTipTrn).HasColumnName(@"id_tip_trn").HasColumnType("int").IsRequired();
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.IdCta).HasColumnName(@"id_cta").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.FecDoc).HasColumnName(@"fec_doc").HasColumnType("datetime").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.NumChq).HasColumnName(@"num_chq").HasColumnType("int").IsRequired();
            Property(x => x.NumDocCli).HasColumnName(@"num_doc_cli").HasColumnType("int").IsRequired();
            Property(x => x.RefBen).HasColumnName(@"ref_ben").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Monto).HasColumnName(@"monto").HasColumnType("float").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.MontoBse).HasColumnName(@"monto_bse").HasColumnType("float").IsRequired();
            Property(x => x.CChq).HasColumnName(@"c_chq").HasColumnType("tinyint").IsRequired();
            Property(x => x.CApl).HasColumnName(@"c_apl").HasColumnType("tinyint").IsRequired();
            Property(x => x.CAboCta).HasColumnName(@"c_abo_cta").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdPol).HasColumnName(@"id_pol").HasColumnType("int").IsRequired();
            Property(x => x.IdRelBcoIva).HasColumnName(@"id_rel_bco_iva").HasColumnType("int").IsRequired();
            Property(x => x.IdRelImpDoc).HasColumnName(@"id_rel_imp_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdBcoAux).HasColumnName(@"id_bco_aux").HasColumnType("int").IsRequired();
            Property(x => x.IdCliPrv).HasColumnName(@"id_cli_prv").HasColumnType("int").IsRequired();
            Property(x => x.IdOri).HasColumnName(@"id_ori").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.Saldo).HasColumnName(@"Saldo").HasColumnType("float").IsRequired();
            Property(x => x.IdSesion).HasColumnName(@"id_sesion").HasColumnType("int").IsRequired();
            Property(x => x.Ped).HasColumnName(@"ped").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.IdRegNom).HasColumnName(@"id_reg_nom").HasColumnType("int").IsRequired();
            Property(x => x.CPln).HasColumnName(@"c_pln").HasColumnType("tinyint").IsRequired();
            Property(x => x.DesPln).HasColumnName(@"des_pln").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CPagDif).HasColumnName(@"c_pag_dif").HasColumnType("tinyint").IsRequired();
            Property(x => x.PerAplIde).HasColumnName(@"per_apl_ide").HasColumnType("int").IsRequired();
            Property(x => x.CACtaDe).HasColumnName(@"c_a_cta_de").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCtaBcoCtaDest).HasColumnName(@"id_cta_bco_cta_dest").HasColumnType("int").IsRequired();
            Property(x => x.CtaDest).HasColumnName(@"cta_dest").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.ClabeDest).HasColumnName(@"clabe_dest").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.BcoCodDest).HasColumnName(@"bco_cod_dest").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.DesBcoDest).HasColumnName(@"des_bco_dest").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.StatusSat).HasColumnName(@"statusSAT").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.IdBcoDocDni).HasColumnName(@"id_bco_doc_dni").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.BcoCuenta).WithMany(b => b.BcoDocs).HasForeignKey(c => c.IdCta).WillCascadeOnDelete(false); // FK_bco_doc_bco_cuentas
            HasRequired(a => a.BcoTipTrn).WithMany(b => b.BcoDocs).HasForeignKey(c => c.IdTipTrn).WillCascadeOnDelete(false); // FK_bco_doc_bco_tip_trn
            HasRequired(a => a.MonMoneda).WithMany(b => b.BcoDocs).HasForeignKey(c => c.IdMda).WillCascadeOnDelete(false); // FK_bco_doc_mon_monedas
            HasRequired(a => a.SisConcepto).WithMany(b => b.BcoDocs).HasForeignKey(c => c.IdCpt).WillCascadeOnDelete(false); // FK_bco_doc_bco_conceptos
            HasRequired(a => a.SisNota).WithMany(b => b.BcoDocs).HasForeignKey(c => c.IdNota).WillCascadeOnDelete(false); // FK_bco_doc_sis_notas
        }
    }

}
// </auto-generated>