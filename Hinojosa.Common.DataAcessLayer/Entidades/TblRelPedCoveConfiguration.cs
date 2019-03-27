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

    // Tbl_Rel_Ped_Cove
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblRelPedCoveConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TblRelPedCove>
    {
        public TblRelPedCoveConfiguration()
            : this("dbo")
        {
        }

        public TblRelPedCoveConfiguration(string schema)
        {
            ToTable("Tbl_Rel_Ped_Cove", schema);
            HasKey(x => x.IdCoveDig);

            Property(x => x.IdRelPedCov).HasColumnName(@"id_rel_ped_cov").HasColumnType("int").IsOptional();
            Property(x => x.IdPed1G).HasColumnName(@"id_ped1g").HasColumnType("int").IsOptional();
            Property(x => x.IdPedproc).HasColumnName(@"id_pedproc").HasColumnType("int").IsOptional();
            Property(x => x.IdCove).HasColumnName(@"id_cove").HasColumnType("int").IsOptional();
            Property(x => x.IdCoveDig).HasColumnName(@"id_cove_dig").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsOptional();
            Property(x => x.IdSesion).HasColumnName(@"id_sesion").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>