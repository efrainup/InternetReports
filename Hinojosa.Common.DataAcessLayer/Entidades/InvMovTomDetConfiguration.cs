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

    // inv_mov_tom_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvMovTomDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvMovTomDet>
    {
        public InvMovTomDetConfiguration()
            : this("dbo")
        {
        }

        public InvMovTomDetConfiguration(string schema)
        {
            ToTable("inv_mov_tom_det", schema);
            HasKey(x => x.IdInvTomPart);

            Property(x => x.IdInvTomPart).HasColumnName(@"id_inv_tom_part").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdInv).HasColumnName(@"id_inv").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.ExAlmac).HasColumnName(@"ex_almac").HasColumnType("real").IsRequired();
            Property(x => x.ExFis).HasColumnName(@"ex_fis").HasColumnType("real").IsRequired();
            Property(x => x.CostoProm).HasColumnName(@"costo_prom").HasColumnType("real").IsRequired();
            Property(x => x.CostoTotal).HasColumnName(@"costo_total").HasColumnType("real").IsRequired();
            Property(x => x.PrecioPub).HasColumnName(@"precio_pub").HasColumnType("real").IsRequired();
            Property(x => x.ImporteTotal).HasColumnName(@"importe_total").HasColumnType("real").IsRequired();
            Property(x => x.CantAju).HasColumnName(@"cant_aju").HasColumnType("real").IsRequired();
            Property(x => x.ImporteAju).HasColumnName(@"importe_aju").HasColumnType("real").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdKardex).HasColumnName(@"id_kardex").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.InvMovTom).WithMany(b => b.InvMovTomDets).HasForeignKey(c => c.IdInv).WillCascadeOnDelete(false); // FK_inv_mov_tom_det_inv_mov_tom
        }
    }

}
// </auto-generated>