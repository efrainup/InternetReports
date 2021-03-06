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

    // Cat_UbicaLatLng
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatUbicaLatLngConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatUbicaLatLng>
    {
        public CatUbicaLatLngConfiguration()
            : this("dbo")
        {
        }

        public CatUbicaLatLngConfiguration(string schema)
        {
            ToTable("Cat_UbicaLatLng", schema);
            HasKey(x => x.IdGelocaliza);

            Property(x => x.IdGelocaliza).HasColumnName(@"id_gelocaliza").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdObj).HasColumnName(@"id_obj").HasColumnType("numeric").IsOptional().HasPrecision(18,0);
            Property(x => x.TipCto).HasColumnName(@"TipCto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdTbl).HasColumnName(@"id_tbl").HasColumnType("numeric").IsOptional().HasPrecision(18,0);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("numeric").IsOptional().HasPrecision(18,0);
            Property(x => x.IdUsuario).HasColumnName(@"Id_usuario").HasColumnType("numeric").IsOptional().HasPrecision(18,0);
            Property(x => x.Latitud).HasColumnName(@"latitud").HasColumnType("float").IsOptional();
            Property(x => x.Longitud).HasColumnName(@"longitud").HasColumnType("float").IsOptional();
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsOptional();
            Property(x => x.Estado).HasColumnName(@"Estado").HasColumnType("bit").IsOptional();
        }
    }

}
// </auto-generated>
