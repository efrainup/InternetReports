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

    // SIR_815_CATALOGO_NAFTA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir815CatalogoNaftaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir815CatalogoNafta>
    {
        public SIR_Sir815CatalogoNaftaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir815CatalogoNaftaConfiguration(string schema)
        {
            ToTable("SIR_815_CATALOGO_NAFTA", schema);
            HasKey(x => new { x.NIdCatalogoNafta815, x.SParte, x.SFraccionAmericana, x.NIdPaisOrigen01, x.NIdProveedor42 });

            Property(x => x.NIdCatalogoNafta815).HasColumnName(@"nIdCatalogoNafta815").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SParte).HasColumnName(@"sParte").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SFraccionAmericana).HasColumnName(@"sFraccionAmericana").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdPaisOrigen01).HasColumnName(@"nIdPaisOrigen01").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdProveedor42).HasColumnName(@"nIdProveedor42").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir01Pais).WithMany(b => b.SIR_Sir815CatalogoNafta).HasForeignKey(c => c.NIdPaisOrigen01).WillCascadeOnDelete(false); // FK_SIR_815_CATALOGO_NAFTA_SIR_01_PAISES
            HasRequired(a => a.SIR_Sir42Proveedore).WithMany(b => b.SIR_Sir815CatalogoNafta).HasForeignKey(c => c.NIdProveedor42).WillCascadeOnDelete(false); // FK_SIR_815_CATALOGO_NAFTA_SIR_42_PROVEEDORES
        }
    }

}
// </auto-generated>
