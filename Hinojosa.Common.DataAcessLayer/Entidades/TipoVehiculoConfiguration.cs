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

    // tipoVehiculo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TipoVehiculoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TipoVehiculo>
    {
        public TipoVehiculoConfiguration()
            : this("dbo")
        {
        }

        public TipoVehiculoConfiguration(string schema)
        {
            ToTable("tipoVehiculo", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdTipo).HasColumnName(@"id_tipo").HasColumnType("int").IsOptional();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Ejes).HasColumnName(@"ejes").HasColumnType("int").IsOptional();
            Property(x => x.Llantas).HasColumnName(@"llantas").HasColumnType("int").IsOptional();
            Property(x => x.Arrastre).HasColumnName(@"arrastre").HasColumnType("int").IsOptional();
            Property(x => x.Traccion).HasColumnName(@"traccion").HasColumnType("int").IsOptional();
            Property(x => x.Direccion).HasColumnName(@"direccion").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
