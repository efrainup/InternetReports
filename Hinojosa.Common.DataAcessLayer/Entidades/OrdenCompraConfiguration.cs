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

    // Orden_Compra
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class OrdenCompraConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OrdenCompra>
    {
        public OrdenCompraConfiguration()
            : this("dbo")
        {
        }

        public OrdenCompraConfiguration(string schema)
        {
            ToTable("Orden_Compra", schema);
            HasKey(x => x.NIdOrdenCompra);

            Property(x => x.NIdOrdenCompra).HasColumnName(@"nIdOrdenCompra").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SSerie).HasColumnName(@"sSerie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.NNumero).HasColumnName(@"nNumero").HasColumnType("int").IsRequired();
            Property(x => x.SReferencia).HasColumnName(@"sReferencia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SOrdenCompra).HasColumnName(@"sOrdenCompra").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.STipo).HasColumnName(@"sTipo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsRequired();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsRequired();
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("datetime").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>