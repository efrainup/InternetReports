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

    // inv_mov_tom
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvMovTomConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvMovTom>
    {
        public InvMovTomConfiguration()
            : this("dbo")
        {
        }

        public InvMovTomConfiguration(string schema)
        {
            ToTable("inv_mov_tom", schema);
            HasKey(x => x.IdInv);

            Property(x => x.IdInv).HasColumnName(@"id_inv").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.IdAlmac).HasColumnName(@"id_almac").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Referencia).HasColumnName(@"referencia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Npart).HasColumnName(@"npart").HasColumnType("int").IsRequired();
            Property(x => x.AjuEnt).HasColumnName(@"aju_ent").HasColumnType("real").IsRequired();
            Property(x => x.AjuSal).HasColumnName(@"aju_sal").HasColumnType("real").IsRequired();
            Property(x => x.AjuTot).HasColumnName(@"aju_tot").HasColumnType("real").IsRequired();
            Property(x => x.CostoTotal).HasColumnName(@"costo_total").HasColumnType("real").IsRequired();
            Property(x => x.ImporteTotal).HasColumnName(@"importe_total").HasColumnType("real").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.InvMovToms).HasForeignKey(c => c.IdUsr).WillCascadeOnDelete(false); // FK_inv_mov_tom_cat_usr
        }
    }

}
// </auto-generated>
