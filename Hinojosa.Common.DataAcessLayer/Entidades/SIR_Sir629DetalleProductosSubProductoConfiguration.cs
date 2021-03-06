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

    // SIR_629_DETALLE_PRODUCTOS_SUB_PRODUCTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir629DetalleProductosSubProductoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir629DetalleProductosSubProducto>
    {
        public SIR_Sir629DetalleProductosSubProductoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir629DetalleProductosSubProductoConfiguration(string schema)
        {
            ToTable("SIR_629_DETALLE_PRODUCTOS_SUB_PRODUCTOS", schema);
            HasKey(x => x.NIdDetaProdSubProd629);

            Property(x => x.NIdDetaProdSubProd629).HasColumnName(@"nIdDetaProdSubProd629").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdMercancia627).HasColumnName(@"nIdMercancia627").HasColumnType("int").IsRequired();
            Property(x => x.SLote).HasColumnName(@"sLote").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.DElaboracionInicio).HasColumnName(@"dElaboracionInicio").HasColumnType("datetime").IsOptional();
            Property(x => x.DCaducidadInicio).HasColumnName(@"dCaducidadInicio").HasColumnType("datetime").IsOptional();
            Property(x => x.DProduccionSagrificioInicio).HasColumnName(@"dProduccionSagrificioInicio").HasColumnType("datetime").IsOptional();
            Property(x => x.DElaboracionFinal).HasColumnName(@"dElaboracionFinal").HasColumnType("datetime").IsOptional();
            Property(x => x.DCaducidadFinal).HasColumnName(@"dCaducidadFinal").HasColumnType("datetime").IsOptional();
            Property(x => x.DProduccionSagrificioFinal).HasColumnName(@"dProduccionSagrificioFinal").HasColumnType("datetime").IsOptional();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsOptional();
            Property(x => x.DEdicion).HasColumnName(@"dEdicion").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir627MercanciasSagarpa).WithMany(b => b.SIR_Sir629DetalleProductosSubProducto).HasForeignKey(c => c.NIdMercancia627).WillCascadeOnDelete(false); // FK_SIR_629_DETALLE_PRODUCTOS_SUB_PRODUCTOS_SIR_627_MERCANCIAS_SAGARPA
        }
    }

}
// </auto-generated>
