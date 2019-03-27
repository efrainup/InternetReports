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

    // Cat_Importes_Prev
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatImportesPrevConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatImportesPrev>
    {
        public CatImportesPrevConfiguration()
            : this("dbo")
        {
        }

        public CatImportesPrevConfiguration(string schema)
        {
            ToTable("Cat_Importes_Prev", schema);
            HasKey(x => x.NIdImporte);

            Property(x => x.NIdImporte).HasColumnName(@"nIdImporte").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdPrevalidador155).HasColumnName(@"nIdPrevalidador155").HasColumnType("int").IsRequired();
            Property(x => x.DImporte).HasColumnName(@"dImporte").HasColumnType("decimal").IsRequired().HasPrecision(7,2);
            Property(x => x.NActivo).HasColumnName(@"nActivo").HasColumnType("int").IsRequired();
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("datetime").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>