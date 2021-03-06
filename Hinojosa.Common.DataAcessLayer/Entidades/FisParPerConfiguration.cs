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

    // fis_par_per
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class FisParPerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<FisParPer>
    {
        public FisParPerConfiguration()
            : this("dbo")
        {
        }

        public FisParPerConfiguration(string schema)
        {
            ToTable("fis_par_per", schema);
            HasKey(x => x.IdPar);

            Property(x => x.IdPar).HasColumnName(@"id_par").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPer).HasColumnName(@"id_per").HasColumnType("int").IsRequired();
            Property(x => x.IdTipPar).HasColumnName(@"id_tip_par").HasColumnType("int").IsRequired();
            Property(x => x.Valor).HasColumnName(@"valor").HasColumnType("float").IsOptional();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsOptional();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.CtbPerEje).WithMany(b => b.FisParPers).HasForeignKey(c => c.IdPer).WillCascadeOnDelete(false); // FK__fis_par_p__id_pe__5160863F
            HasRequired(a => a.SisTip).WithMany(b => b.FisParPers).HasForeignKey(c => c.IdTipPar).WillCascadeOnDelete(false); // FK__fis_par_p__id_ti__5254AA78
        }
    }

}
// </auto-generated>
