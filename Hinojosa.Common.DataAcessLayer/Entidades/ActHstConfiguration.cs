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

    // act_hst
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ActHstConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ActHst>
    {
        public ActHstConfiguration()
            : this("dbo")
        {
        }

        public ActHstConfiguration(string schema)
        {
            ToTable("act_hst", schema);
            HasKey(x => x.IdActHst);

            Property(x => x.IdActHst).HasColumnName(@"id_act_hst").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdAct).HasColumnName(@"id_act").HasColumnType("int").IsRequired();
            Property(x => x.IdEmp).HasColumnName(@"id_emp").HasColumnType("int").IsRequired();
            Property(x => x.FecTrn).HasColumnName(@"fec_trn").HasColumnType("datetime").IsRequired();
            Property(x => x.TipTrn).HasColumnName(@"tip_trn").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUbic).HasColumnName(@"id_ubic").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
