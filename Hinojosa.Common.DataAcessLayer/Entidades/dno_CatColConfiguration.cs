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

    // cat_col
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class dno_CatColConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<dno_CatCol>
    {
        public dno_CatColConfiguration()
            : this("dno")
        {
        }

        public dno_CatColConfiguration(string schema)
        {
            ToTable("cat_col", schema);
            HasKey(x => x.IdCol);

            Property(x => x.IdCol).HasColumnName(@"id_col").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nom).HasColumnName(@"nom").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.ApPat).HasColumnName(@"ap_pat").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.ApMat).HasColumnName(@"ap_mat").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.FecNac).HasColumnName(@"fec_nac").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Rfc).HasColumnName(@"rfc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Curp).HasColumnName(@"curp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Sexo).HasColumnName(@"sexo").HasColumnType("tinyint").IsRequired();
            Property(x => x.Edocivil).HasColumnName(@"edocivil").HasColumnType("tinyint").IsRequired();
            Property(x => x.Col).HasColumnName(@"col").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ciudad).HasColumnName(@"ciudad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdEdo).HasColumnName(@"id_edo").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cp).HasColumnName(@"cp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Calle).HasColumnName(@"calle").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.NoInt).HasColumnName(@"no_int").HasColumnType("nvarchar").IsRequired().HasMaxLength(5);
            Property(x => x.NoExt).HasColumnName(@"no_ext").HasColumnType("nvarchar").IsRequired().HasMaxLength(5);
            Property(x => x.EntreCalles).HasColumnName(@"entre_calles").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Del).HasColumnName(@"del").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.IdEdoNac).HasColumnName(@"id_edo_nac").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCmp).HasColumnName(@"id_cmp").HasColumnType("int").IsRequired();
            Property(x => x.IdPaisNac).HasColumnName(@"id_pais_nac").HasColumnType("int").IsRequired();
            Property(x => x.IdPais).HasColumnName(@"id_pais").HasColumnType("int").IsRequired();
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
