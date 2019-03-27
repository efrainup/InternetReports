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

    // ctb_req_cfdi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtbReqCfdiConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CtbReqCfdi>
    {
        public CtbReqCfdiConfiguration()
            : this("dbo")
        {
        }

        public CtbReqCfdiConfiguration(string schema)
        {
            ToTable("ctb_req_cfdi", schema);
            HasKey(x => x.IdReqCfdi);

            Property(x => x.IdReqCfdi).HasColumnName(@"Id_req_cfdi").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdTipSolReq).HasColumnName(@"id_tip_sol_req").HasColumnType("int").IsRequired();
            Property(x => x.NumOrdReq).HasColumnName(@"num_ord_req").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.NumTramReq).HasColumnName(@"num_tram_req").HasColumnType("int").IsRequired();
            Property(x => x.PerReqCfdi).HasColumnName(@"per_req_cfdi").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.FecTram).HasColumnName(@"fec_tram").HasColumnType("datetime").IsRequired();
            Property(x => x.StatusTram).HasColumnName(@"status_tram").HasColumnType("int").IsRequired();
            Property(x => x.ComenTram).HasColumnName(@"comen_tram").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
