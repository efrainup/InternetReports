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

    // SIR_762_CONFIG_PAGO_PREVALIDAVOR
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir762ConfigPagoPrevalidavorConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir762ConfigPagoPrevalidavor>
    {
        public SIR_Sir762ConfigPagoPrevalidavorConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir762ConfigPagoPrevalidavorConfiguration(string schema)
        {
            ToTable("SIR_762_CONFIG_PAGO_PREVALIDAVOR", schema);
            HasKey(x => x.NIdConfigPagoPreval762);

            Property(x => x.NIdConfigPagoPreval762).HasColumnName(@"nIdConfigPagoPreval762").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdProveedor).HasColumnName(@"nIdProveedor").HasColumnType("int").IsOptional();
            Property(x => x.NIdproveedor42).HasColumnName(@"nIdproveedor42").HasColumnType("int").IsOptional();
            Property(x => x.NIdMoneda03).HasColumnName(@"nIdMoneda03").HasColumnType("int").IsOptional();
            Property(x => x.NIdConcepto).HasColumnName(@"nIdConcepto").HasColumnType("int").IsOptional();
            Property(x => x.NIdConcepto28).HasColumnName(@"nIdConcepto28").HasColumnType("int").IsOptional();
            Property(x => x.NMonto).HasColumnName(@"nMonto").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NIdPrevalidador155).HasColumnName(@"nIdPrevalidador155").HasColumnType("int").IsOptional();
            Property(x => x.NMontoReval).HasColumnName(@"nMontoReval").HasColumnType("decimal").IsOptional().HasPrecision(15,3);

            // Foreign keys
            HasOptional(a => a.CatPro).WithMany(b => b.SIR_Sir762ConfigPagoPrevalidavor).HasForeignKey(c => c.NIdConcepto).WillCascadeOnDelete(false); // FK_SIR_762_CONFIG_PAGO_PREVALIDAVOR_cat_pro
            HasOptional(a => a.CatProv).WithMany(b => b.SIR_Sir762ConfigPagoPrevalidavor).HasForeignKey(c => c.NIdProveedor).WillCascadeOnDelete(false); // FK_SIR_762_CONFIG_PAGO_PREVALIDAVOR_cat_prov
            HasOptional(a => a.SIR_Sir155Prevalidadore).WithMany(b => b.SIR_Sir762ConfigPagoPrevalidavor).HasForeignKey(c => c.NIdPrevalidador155).WillCascadeOnDelete(false); // FK_SIR_762_CONFIG_PAGO_PREVALIDAVOR_SIR_155_PREVALIDADORES
        }
    }

}
// </auto-generated>