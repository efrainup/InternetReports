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

    // rel_bco_cta_emp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RelBcoCtaEmpConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelBcoCtaEmp>
    {
        public RelBcoCtaEmpConfiguration()
            : this("dbo")
        {
        }

        public RelBcoCtaEmpConfiguration(string schema)
        {
            ToTable("rel_bco_cta_emp", schema);
            HasKey(x => x.IdCta);

            Property(x => x.IdCta).HasColumnName(@"id_cta").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Emp).HasColumnName(@"emp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Depto).HasColumnName(@"depto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.Puesto).HasColumnName(@"puesto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Curp).HasColumnName(@"CURP").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nss).HasColumnName(@"NSS").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(18);
            Property(x => x.FecAltaImss).HasColumnName(@"fec_alta_imss").HasColumnType("datetime").IsRequired();
            Property(x => x.Antig).HasColumnName(@"Antig").HasColumnType("int").IsRequired();
            Property(x => x.IdSin).HasColumnName(@"id_sin").HasColumnType("int").IsRequired();
            Property(x => x.TipCon).HasColumnName(@"TipCon").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.TipReg).HasColumnName(@"TipReg").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Per).HasColumnName(@"Per").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.TipRiesgo).HasColumnName(@"TipRiesgo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.TipJor).HasColumnName(@"TipJor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.RegPat).HasColumnName(@"RegPat").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Email).HasColumnName(@"email").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
        }
    }

}
// </auto-generated>
