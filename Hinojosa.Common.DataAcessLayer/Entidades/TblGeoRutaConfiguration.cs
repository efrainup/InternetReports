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

    // tbl_GeoRutas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblGeoRutaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TblGeoRuta>
    {
        public TblGeoRutaConfiguration()
            : this("dbo")
        {
        }

        public TblGeoRutaConfiguration(string schema)
        {
            ToTable("tbl_GeoRutas", schema);
            HasKey(x => x.IdRuta);

            Property(x => x.IdRuta).HasColumnName(@"idRuta").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("bit").IsOptional();
        }
    }

}
// </auto-generated>
