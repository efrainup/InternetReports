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

    // cat_pro_pre_cga
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatProPreCgaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatProPreCga>
    {
        public CatProPreCgaConfiguration()
            : this("dbo")
        {
        }

        public CatProPreCgaConfiguration(string schema)
        {
            ToTable("cat_pro_pre_cga", schema);
            HasKey(x => x.IdProPreCga);

            Property(x => x.IdProPreCga).HasColumnName(@"id_pro_pre_cga").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRelProPreCga).HasColumnName(@"id_rel_pro_pre_cga").HasColumnType("int").IsRequired();
            Property(x => x.IdCliPrv).HasColumnName(@"id_cli_prv").HasColumnType("int").IsRequired();
            Property(x => x.IdCliPrvPad).HasColumnName(@"id_cli_prv_pad").HasColumnType("int").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Pre).HasColumnName(@"pre").HasColumnType("float").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Tip).HasColumnName(@"tip").HasColumnType("tinyint").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.CCostoTrsld).HasColumnName(@"c_costo_trsld").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
