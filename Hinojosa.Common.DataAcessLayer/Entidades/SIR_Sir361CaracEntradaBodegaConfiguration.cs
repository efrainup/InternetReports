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

    // SIR_361_CARAC_ENTRADA_BODEGA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir361CaracEntradaBodegaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir361CaracEntradaBodega>
    {
        public SIR_Sir361CaracEntradaBodegaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir361CaracEntradaBodegaConfiguration(string schema)
        {
            ToTable("SIR_361_CARAC_ENTRADA_BODEGA", schema);
            HasKey(x => x.NIdCaracEb361);

            Property(x => x.NIdCaracEb361).HasColumnName(@"nIdCaracEB361").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdCarac130).HasColumnName(@"nIdCarac130").HasColumnType("int").IsRequired();
            Property(x => x.SValor).HasColumnName(@"sValor").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NIdEntrada156).HasColumnName(@"nIdEntrada156").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.SIR_Sir130Caracteristica).WithMany(b => b.SIR_Sir361CaracEntradaBodega).HasForeignKey(c => c.NIdCarac130).WillCascadeOnDelete(false); // FK_SIR_361_CARAC_ENTRADA_BODEGA_SIR_130_CARACTERISTICAS
            HasRequired(a => a.SIR_Sir156EntradasBodega).WithMany(b => b.SIR_Sir361CaracEntradaBodega).HasForeignKey(c => c.NIdEntrada156).WillCascadeOnDelete(false); // FK_SIR_361_CARAC_ENTRADA_BODEGA_SIR_156_ENTRADAS_BODEGAS
        }
    }

}
// </auto-generated>
