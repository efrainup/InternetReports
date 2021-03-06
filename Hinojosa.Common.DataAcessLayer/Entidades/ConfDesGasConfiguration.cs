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

    // conf_des_gas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ConfDesGasConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ConfDesGas>
    {
        public ConfDesGasConfiguration()
            : this("dbo")
        {
        }

        public ConfDesGasConfiguration(string schema)
        {
            ToTable("conf_des_gas", schema);
            HasKey(x => new { x.Id, x.Estacionest, x.Estacionesn, x.Recurrencia, x.Activa, x.Status, x.Fchreg, x.Fchmod, x.IdUsr, x.UltEje });

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Estacionest).HasColumnName(@"estacionest").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Estacionesn).HasColumnName(@"estacionesn").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Recurrencia).HasColumnName(@"recurrencia").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Activa).HasColumnName(@"activa").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fchreg).HasColumnName(@"fchreg").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fchmod).HasColumnName(@"fchmod").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UltEje).HasColumnName(@"ult_eje").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
