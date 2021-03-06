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

    // sis_alerta_usr
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisAlertaUsrConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisAlertaUsr>
    {
        public SisAlertaUsrConfiguration()
            : this("dbo")
        {
        }

        public SisAlertaUsrConfiguration(string schema)
        {
            ToTable("sis_alerta_usr", schema);
            HasKey(x => x.IdAlertaUsr);

            Property(x => x.IdAlertaUsr).HasColumnName(@"id_alerta_usr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdAlerta).HasColumnName(@"id_alerta").HasColumnType("int").IsRequired();
            Property(x => x.IdUsrReg).HasColumnName(@"id_usr_reg").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.VerEnt).HasColumnName(@"ver_ent").HasColumnType("tinyint").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
