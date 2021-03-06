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

    // cat_RutasGral
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatRutasGralConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatRutasGral>
    {
        public CatRutasGralConfiguration()
            : this("dbo")
        {
        }

        public CatRutasGralConfiguration(string schema)
        {
            ToTable("cat_RutasGral", schema);
            HasKey(x => new { x.IdRuta, x.ComisionPorcentaje, x.ComisionRuta, x.ComisionDistancia });

            Property(x => x.IdRuta).HasColumnName(@"idRuta").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CveRuta).HasColumnName(@"Cve_ruta").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Origen).HasColumnName(@"Origen").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(350);
            Property(x => x.Destino).HasColumnName(@"Destino").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(350);
            Property(x => x.Kilometraje).HasColumnName(@"Kilometraje").HasColumnType("float").IsOptional();
            Property(x => x.Tiempo).HasColumnName(@"Tiempo").HasColumnType("float").IsOptional();
            Property(x => x.TiempoMuerto).HasColumnName(@"TiempoMuerto").HasColumnType("float").IsOptional();
            Property(x => x.JsonRuta).HasColumnName(@"JSONRuta").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FecReg).HasColumnName(@"Fec_Reg").HasColumnType("datetime").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsOptional();
            Property(x => x.ComisionPorcentaje).HasColumnName(@"comision_porcentaje").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ComisionRuta).HasColumnName(@"comision_ruta").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ComisionDistancia).HasColumnName(@"comision_distancia").HasColumnType("float").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
