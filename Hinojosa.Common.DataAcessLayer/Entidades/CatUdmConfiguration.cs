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

    // cat_udm
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatUdmConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatUdm>
    {
        public CatUdmConfiguration()
            : this("dbo")
        {
        }

        public CatUdmConfiguration(string schema)
        {
            ToTable("cat_udm", schema);
            HasKey(x => x.IdUdm);

            Property(x => x.IdUdm).HasColumnName(@"id_udm").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Codigo).HasColumnName(@"codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(125);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.CantRel).HasColumnName(@"cant_rel").HasColumnType("int").IsRequired();
            Property(x => x.IdTip).HasColumnName(@"id_tip").HasColumnType("int").IsRequired();
            Property(x => x.IdTipSat).HasColumnName(@"id_tip_sat").HasColumnType("int").IsRequired();
            Property(x => x.IdVucem).HasColumnName(@"id_vucem").HasColumnType("int").IsRequired();
            Property(x => x.IdRelUdm).HasColumnName(@"id_rel_udm").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>