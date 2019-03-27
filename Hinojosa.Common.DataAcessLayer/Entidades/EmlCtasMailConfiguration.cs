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

    // eml_ctas_mail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class EmlCtasMailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmlCtasMail>
    {
        public EmlCtasMailConfiguration()
            : this("dbo")
        {
        }

        public EmlCtasMailConfiguration(string schema)
        {
            ToTable("eml_ctas_mail", schema);
            HasKey(x => x.IdCta);

            Property(x => x.IdCta).HasColumnName(@"id_cta").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NomCta).HasColumnName(@"nom_cta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.DescCta).HasColumnName(@"desc_cta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.CtaMail).HasColumnName(@"cta_mail").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.PswCta).HasColumnName(@"psw_cta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CtaAlt).HasColumnName(@"cta_alt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.IdSrv).HasColumnName(@"id_srv").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr1G).HasColumnName(@"id_usr_1g").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IsDef).HasColumnName(@"is_def").HasColumnType("bit").IsOptional();
            Property(x => x.IdCmp).HasColumnName(@"id_cmp").HasColumnType("int").IsOptional();
            Property(x => x.RutaDesc).HasColumnName(@"ruta_desc").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.RutaDescCrp).HasColumnName(@"ruta_desc_crp").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
        }
    }

}
// </auto-generated>