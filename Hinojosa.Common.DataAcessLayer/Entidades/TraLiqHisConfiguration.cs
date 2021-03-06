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

    // tra_liq_his
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TraLiqHisConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TraLiqHis>
    {
        public TraLiqHisConfiguration()
            : this("dbo")
        {
        }

        public TraLiqHisConfiguration(string schema)
        {
            ToTable("tra_liq_his", schema);
            HasKey(x => x.IdLiqHis);

            Property(x => x.IdLiqHis).HasColumnName(@"id_liq_his").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdOri).HasColumnName(@"id_ori").HasColumnType("int").IsOptional();
            Property(x => x.IdLiqOri).HasColumnName(@"id_liq_ori").HasColumnType("int").IsOptional();
            Property(x => x.IdLiqPag).HasColumnName(@"id_liq_pag").HasColumnType("int").IsOptional();
            Property(x => x.IdOperador).HasColumnName(@"id_operador").HasColumnType("int").IsOptional();
            Property(x => x.Anticipo).HasColumnName(@"anticipo").HasColumnType("float").IsOptional();
            Property(x => x.SdoPen).HasColumnName(@"sdo_pen").HasColumnType("float").IsOptional();
            Property(x => x.Pago).HasColumnName(@"pago").HasColumnType("float").IsOptional();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsOptional();
            Property(x => x.CPrincipal).HasColumnName(@"c_principal").HasColumnType("tinyint").IsOptional();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsOptional();
        }
    }

}
// </auto-generated>
