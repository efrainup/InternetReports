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

    // ctb_pre
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtbPreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CtbPre>
    {
        public CtbPreConfiguration()
            : this("dbo")
        {
        }

        public CtbPreConfiguration(string schema)
        {
            ToTable("ctb_pre", schema);
            HasKey(x => x.IdPre);

            Property(x => x.IdPre).HasColumnName(@"id_pre").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rev).HasColumnName(@"rev").HasColumnType("int").IsRequired();
            Property(x => x.IdPer).HasColumnName(@"id_per").HasColumnType("int").IsRequired();
            Property(x => x.IdCta).HasColumnName(@"id_cta").HasColumnType("int").IsRequired();
            Property(x => x.IdEmp).HasColumnName(@"id_emp").HasColumnType("int").IsRequired();
            Property(x => x.IdCenCto).HasColumnName(@"id_cen_cto").HasColumnType("int").IsRequired();
            Property(x => x.Mto).HasColumnName(@"mto").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.CAct).HasColumnName(@"c_act").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.MtoEje).HasColumnName(@"mto_eje").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cmt).HasColumnName(@"cmt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.IdTipObj).HasColumnName(@"id_tip_obj").HasColumnType("int").IsRequired();
            Property(x => x.IdObj).HasColumnName(@"id_obj").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>