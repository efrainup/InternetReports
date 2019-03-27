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

    // act_aux
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ActAuxConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ActAux>
    {
        public ActAuxConfiguration()
            : this("dbo")
        {
        }

        public ActAuxConfiguration(string schema)
        {
            ToTable("act_aux", schema);
            HasKey(x => x.IdActAux);

            Property(x => x.IdActAux).HasColumnName(@"id_act_aux").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdActEnc).HasColumnName(@"id_act_enc").HasColumnType("int").IsRequired();
            Property(x => x.IdAct).HasColumnName(@"id_act").HasColumnType("int").IsRequired();
            Property(x => x.IdPol).HasColumnName(@"id_pol").HasColumnType("int").IsRequired();
            Property(x => x.IdCenCto).HasColumnName(@"id_cen_cto").HasColumnType("int").IsRequired();
            Property(x => x.IdCodSrv).HasColumnName(@"id_cod_srv").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdClasCtb).HasColumnName(@"id_clas_ctb").HasColumnType("int").IsRequired();
            Property(x => x.IdAlm).HasColumnName(@"id_alm").HasColumnType("int").IsRequired();
            Property(x => x.IdDocApl).HasColumnName(@"id_doc_apl").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDocApl).HasColumnName(@"id_tip_doc_apl").HasColumnType("int").IsRequired();
            Property(x => x.IdPartApl).HasColumnName(@"id_part_apl").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.Cmt).HasColumnName(@"cmt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.ValorBase).HasColumnName(@"valor_base").HasColumnType("float").IsRequired();
            Property(x => x.DepAcuAnt).HasColumnName(@"dep_acu_ant").HasColumnType("float").IsRequired();
            Property(x => x.ValorRemAnt).HasColumnName(@"valor_rem_ant").HasColumnType("float").IsRequired();
            Property(x => x.DepAcu).HasColumnName(@"dep_acu").HasColumnType("float").IsRequired();
            Property(x => x.DepCalc).HasColumnName(@"dep_calc").HasColumnType("float").IsRequired();
            Property(x => x.ValorRem).HasColumnName(@"valor_rem").HasColumnType("float").IsRequired();
            Property(x => x.Vida).HasColumnName(@"vida").HasColumnType("float").IsOptional();
            Property(x => x.VidaDep).HasColumnName(@"vida_dep").HasColumnType("float").IsOptional();
            Property(x => x.VidaRem).HasColumnName(@"vida_rem").HasColumnType("float").IsOptional();
            Property(x => x.MetDep).HasColumnName(@"met_dep").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.TipDep).HasColumnName(@"tip_dep").HasColumnType("tinyint").IsRequired();
            Property(x => x.Precio).HasColumnName(@"precio").HasColumnType("float").IsRequired();
            Property(x => x.Costo).HasColumnName(@"costo").HasColumnType("float").IsRequired();
            Property(x => x.Imptos).HasColumnName(@"imptos").HasColumnType("float").IsRequired();
            Property(x => x.IdImpto).HasColumnName(@"id_impto").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdSisCnl).HasColumnName(@"id_sis_cnl").HasColumnType("int").IsRequired();
            Property(x => x.Intervalo).HasColumnName(@"intervalo").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
