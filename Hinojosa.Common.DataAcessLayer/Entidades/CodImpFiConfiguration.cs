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

    // cod_imp_fis
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CodImpFiConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CodImpFi>
    {
        public CodImpFiConfiguration()
            : this("dbo")
        {
        }

        public CodImpFiConfiguration(string schema)
        {
            ToTable("cod_imp_fis", schema);
            HasKey(x => x.IdImpFis);

            Property(x => x.IdImpFis).HasColumnName(@"id_imp_fis").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CRango).HasColumnName(@"c_rango").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTipImp).HasColumnName(@"id_tip_imp").HasColumnType("int").IsRequired();
            Property(x => x.IdTipFactor).HasColumnName(@"id_tip_factor").HasColumnType("int").IsRequired();
            Property(x => x.CTras).HasColumnName(@"c_tras").HasColumnType("tinyint").IsRequired();
            Property(x => x.CRet).HasColumnName(@"c_ret").HasColumnType("tinyint").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.VMin).HasColumnName(@"v_min").HasColumnType("float").IsRequired();
            Property(x => x.VMax).HasColumnName(@"v_max").HasColumnType("float").IsRequired();
        }
    }

}
// </auto-generated>
