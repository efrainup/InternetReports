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

    // req_cot
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ReqCotConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ReqCot>
    {
        public ReqCotConfiguration()
            : this("dbo")
        {
        }

        public ReqCotConfiguration(string schema)
        {
            ToTable("req_cot", schema);
            HasKey(x => x.IdReqCot);

            Property(x => x.IdReqCot).HasColumnName(@"id_req_cot").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRelCot).HasColumnName(@"id_rel_cot").HasColumnType("int").IsRequired();
            Property(x => x.Part).HasColumnName(@"part").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.FecCot).HasColumnName(@"fec_cot").HasColumnType("datetime").IsRequired();
            Property(x => x.IdCnd).HasColumnName(@"id_cnd").HasColumnType("int").IsRequired();
            Property(x => x.Dias).HasColumnName(@"dias").HasColumnType("int").IsRequired();
            Property(x => x.Costo).HasColumnName(@"costo").HasColumnType("float").IsRequired();
            Property(x => x.CostoTotal).HasColumnName(@"costo_total").HasColumnType("float").IsRequired();
            Property(x => x.IdNotaCot).HasColumnName(@"id_nota_cot").HasColumnType("int").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.CRecom).HasColumnName(@"c_recom").HasColumnType("tinyint").IsRequired();
            Property(x => x.NoCot).HasColumnName(@"no_cot").HasColumnType("int").IsRequired();
            Property(x => x.IdProvPad).HasColumnName(@"id_prov_pad").HasColumnType("int").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
