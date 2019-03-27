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

    // sis_cat_loc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisCatLocConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisCatLoc>
    {
        public SisCatLocConfiguration()
            : this("dbo")
        {
        }

        public SisCatLocConfiguration(string schema)
        {
            ToTable("sis_cat_loc", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CveEnt).HasColumnName(@"cve_ent").HasColumnType("int").IsRequired();
            Property(x => x.NomEnt).HasColumnName(@"nom_ent").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.NomAbr).HasColumnName(@"nom_abr").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(32);
            Property(x => x.CveMun).HasColumnName(@"cve_mun").HasColumnType("int").IsRequired();
            Property(x => x.NomMun).HasColumnName(@"nom_mun").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CveLoc).HasColumnName(@"cve_loc").HasColumnType("int").IsRequired();
            Property(x => x.NomLoc).HasColumnName(@"nom_loc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(110);
            Property(x => x.Ambito).HasColumnName(@"ambito").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Latitud).HasColumnName(@"latitud").HasColumnType("float").IsRequired();
            Property(x => x.Longitud).HasColumnName(@"longitud").HasColumnType("float").IsRequired();
            Property(x => x.Altitud).HasColumnName(@"altitud").HasColumnType("float").IsRequired();
            Property(x => x.CveCarta).HasColumnName(@"cve_carta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Z1).HasColumnName(@"z1").HasColumnType("float").IsRequired();
            Property(x => x.Z2).HasColumnName(@"z2").HasColumnType("float").IsRequired();
            Property(x => x.Z3).HasColumnName(@"z3").HasColumnType("float").IsRequired();
            Property(x => x.Z119).HasColumnName(@"z119").HasColumnType("float").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.IdPais).HasColumnName(@"id_pais").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>