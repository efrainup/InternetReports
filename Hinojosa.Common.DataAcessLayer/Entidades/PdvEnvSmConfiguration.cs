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

    // pdv_env_sms
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PdvEnvSmConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PdvEnvSm>
    {
        public PdvEnvSmConfiguration()
            : this("dbo")
        {
        }

        public PdvEnvSmConfiguration(string schema)
        {
            ToTable("pdv_env_sms", schema);
            HasKey(x => x.IdSmsEnv);

            Property(x => x.IdSmsEnv).HasColumnName(@"IdSmsEnv").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdMonedero).HasColumnName(@"IdMonedero").HasColumnType("int").IsRequired();
            Property(x => x.Telefono).HasColumnName(@"Telefono").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Ticket).HasColumnName(@"Ticket").HasColumnType("int").IsRequired();
            Property(x => x.FechaReg).HasColumnName(@"FechaReg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.DescripError).HasColumnName(@"DescripError").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(160);
            Property(x => x.Tipo).HasColumnName(@"Tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.FechaEnv).HasColumnName(@"FechaEnv").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"IdUsr").HasColumnType("int").IsRequired();
            Property(x => x.DescripSms).HasColumnName(@"DescripSMS").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(320);
            Property(x => x.IdVtaAux).HasColumnName(@"id_vta_aux").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>