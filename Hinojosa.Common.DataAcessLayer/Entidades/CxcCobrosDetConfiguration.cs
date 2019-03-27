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

    // cxc_cobros_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxcCobrosDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CxcCobrosDet>
    {
        public CxcCobrosDetConfiguration()
            : this("dbo")
        {
        }

        public CxcCobrosDetConfiguration(string schema)
        {
            ToTable("cxc_cobros_det", schema);
            HasKey(x => x.IdCobroDet);

            Property(x => x.IdCobroDet).HasColumnName(@"id_cobro_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCobro).HasColumnName(@"id_cobro").HasColumnType("int").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.IdAux).HasColumnName(@"id_aux").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Vence).HasColumnName(@"vence").HasColumnType("datetime").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.@Ref).HasColumnName(@"ref").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Importe).HasColumnName(@"importe").HasColumnType("float").IsRequired();
            Property(x => x.Saldo).HasColumnName(@"saldo").HasColumnType("float").IsRequired();
            Property(x => x.Aplicado).HasColumnName(@"aplicado").HasColumnType("float").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.AplicadoBse).HasColumnName(@"aplicado_bse").HasColumnType("float").IsRequired();
            Property(x => x.IdMdaCta).HasColumnName(@"id_mda_cta").HasColumnType("int").IsRequired();
            Property(x => x.TcMdaCta).HasColumnName(@"tc_mda_cta").HasColumnType("float").IsRequired();
            Property(x => x.OperCta).HasColumnName(@"oper_cta").HasColumnType("tinyint").IsRequired();
            Property(x => x.AplicadoCta).HasColumnName(@"aplicado_cta").HasColumnType("float").IsRequired();
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.IdAlm).HasColumnName(@"id_alm").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdInt).HasColumnName(@"id_int").HasColumnType("int").IsRequired();
            Property(x => x.IdCliCtaDe).HasColumnName(@"id_cli_cta_de").HasColumnType("int").IsRequired();
            Property(x => x.IdClasPro).HasColumnName(@"id_clas_pro").HasColumnType("int").IsRequired();
            Property(x => x.IdClasProv).HasColumnName(@"id_clas_prov").HasColumnType("int").IsRequired();
            Property(x => x.IdRefDet).HasColumnName(@"id_ref_det").HasColumnType("int").IsRequired();
            Property(x => x.Serie).HasColumnName(@"Serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdCtaUtiPer).HasColumnName(@"id_cta_uti_per").HasColumnType("int").IsRequired();
            Property(x => x.MtoUtiPer).HasColumnName(@"mto_uti_per").HasColumnType("float").IsRequired();
            Property(x => x.RefExt).HasColumnName(@"ref_ext").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.SaldoDet).HasColumnName(@"Saldo_det").HasColumnType("float").IsRequired();
            Property(x => x.Cmt).HasColumnName(@"cmt").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.RegNumLayout).HasColumnName(@"Reg_Num_Layout").HasColumnType("int").IsRequired();
            Property(x => x.TcDr).HasColumnName(@"tc_dr").HasColumnType("float").IsRequired();
            Property(x => x.TcParidad).HasColumnName(@"tc_paridad").HasColumnType("float").IsRequired();

            // Foreign keys
            HasRequired(a => a.CxcCobro).WithMany(b => b.CxcCobrosDets).HasForeignKey(c => c.IdCobro).WillCascadeOnDelete(false); // FK_cxc_cobros_det_cxc_cobros
        }
    }

}
// </auto-generated>
