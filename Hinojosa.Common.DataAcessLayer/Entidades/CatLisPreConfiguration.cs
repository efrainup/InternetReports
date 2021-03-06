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

    // cat_lis_pre
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatLisPreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatLisPre>
    {
        public CatLisPreConfiguration()
            : this("dbo")
        {
        }

        public CatLisPreConfiguration(string schema)
        {
            ToTable("cat_lis_pre", schema);
            HasKey(x => x.IdLisPre);

            Property(x => x.IdLisPre).HasColumnName(@"id_lis_pre").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.NumLis).HasColumnName(@"num_lis").HasColumnType("int").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Factor1).HasColumnName(@"factor1").HasColumnType("float").IsRequired();
            Property(x => x.Factor2).HasColumnName(@"factor2").HasColumnType("float").IsRequired();
            Property(x => x.Factor3).HasColumnName(@"factor3").HasColumnType("float").IsRequired();
            Property(x => x.Factor4).HasColumnName(@"factor4").HasColumnType("float").IsRequired();
            Property(x => x.Factor5).HasColumnName(@"factor5").HasColumnType("float").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
