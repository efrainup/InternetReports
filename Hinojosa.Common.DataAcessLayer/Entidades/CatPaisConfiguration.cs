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

    // cat_paises
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatPaisConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatPais>
    {
        public CatPaisConfiguration()
            : this("dbo")
        {
        }

        public CatPaisConfiguration(string schema)
        {
            ToTable("cat_paises", schema);
            HasKey(x => x.IdPais);

            Property(x => x.IdPais).HasColumnName(@"Id_Pais").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodNoPais).HasColumnName(@"CodNo_Pais").HasColumnType("int").IsRequired();
            Property(x => x.CodLtaPais).HasColumnName(@"CodLta_Pais").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.DesPais).HasColumnName(@"Des_Pais").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdPaisSir).HasColumnName(@"id_pais_sir").HasColumnType("int").IsOptional();
            Property(x => x.CodPaisSat).HasColumnName(@"cod_pais_sat").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.DesPaisSat).HasColumnName(@"des_pais_sat").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CodPaisDiot).HasColumnName(@"cod_pais_diot").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
        }
    }

}
// </auto-generated>