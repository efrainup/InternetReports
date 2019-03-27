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

    // act_enc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ActEncConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ActEnc>
    {
        public ActEncConfiguration()
            : this("dbo")
        {
        }

        public ActEncConfiguration(string schema)
        {
            ToTable("act_enc", schema);
            HasKey(x => x.IdActEnc);

            Property(x => x.IdActEnc).HasColumnName(@"id_act_enc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdPer).HasColumnName(@"id_per").HasColumnType("int").IsRequired();
            Property(x => x.IdPol).HasColumnName(@"id_pol").HasColumnType("int").IsRequired();
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.Cmt).HasColumnName(@"cmt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.ValorBase).HasColumnName(@"valor_base").HasColumnType("float").IsRequired();
            Property(x => x.DepAcu).HasColumnName(@"dep_acu").HasColumnType("float").IsRequired();
            Property(x => x.DepCalc).HasColumnName(@"dep_calc").HasColumnType("float").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>