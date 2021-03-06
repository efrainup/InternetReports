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

    // Pedimentos_Johnson
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PedimentosJohnsonConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PedimentosJohnson>
    {
        public PedimentosJohnsonConfiguration()
            : this("dbo")
        {
        }

        public PedimentosJohnsonConfiguration(string schema)
        {
            ToTable("Pedimentos_Johnson", schema);
            HasKey(x => x.Solicitado);

            Property(x => x.Referencia).HasColumnName(@"referencia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Pedimento).HasColumnName(@"pedimento").HasColumnType("int").IsOptional();
            Property(x => x.Fechapago).HasColumnName(@"fechapago").HasColumnType("datetime").IsOptional();
            Property(x => x.Movimiento).HasColumnName(@"movimiento").HasColumnType("int").IsOptional();
            Property(x => x.Claveped).HasColumnName(@"claveped").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Idcliente).HasColumnName(@"idcliente").HasColumnType("int").IsOptional();
            Property(x => x.Aduana).HasColumnName(@"aduana").HasColumnType("int").IsOptional();
            Property(x => x.Patente).HasColumnName(@"patente").HasColumnType("int").IsOptional();
            Property(x => x.Enviado).HasColumnName(@"enviado").HasColumnType("int").IsOptional();
            Property(x => x.Envfactura).HasColumnName(@"envfactura").HasColumnType("int").IsOptional();
            Property(x => x.Solicitado).HasColumnName(@"solicitado").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
