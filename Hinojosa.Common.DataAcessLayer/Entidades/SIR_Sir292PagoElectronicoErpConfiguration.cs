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

    // SIR_292_PAGO_ELECTRONICO_ERP
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir292PagoElectronicoErpConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir292PagoElectronicoErp>
    {
        public SIR_Sir292PagoElectronicoErpConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir292PagoElectronicoErpConfiguration(string schema)
        {
            ToTable("SIR_292_PAGO_ELECTRONICO_ERP", schema);
            HasKey(x => x.NIdPagoPend292);

            Property(x => x.NIdPagoPend292).HasColumnName(@"nIdPagoPend292").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NCuentaBanco).HasColumnName(@"nCuentaBanco").HasColumnType("int").IsRequired();
            Property(x => x.DPago).HasColumnName(@"dPago").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.SPedimento).HasColumnName(@"sPedimento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(7);
            Property(x => x.NImporte).HasColumnName(@"nImporte").HasColumnType("float").IsRequired();
            Property(x => x.SReferencia).HasColumnName(@"sReferencia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsRequired();
            Property(x => x.SScript).HasColumnName(@"sScript").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.BPagado).HasColumnName(@"bPagado").HasColumnType("bit").IsRequired();
            Property(x => x.SComentario).HasColumnName(@"sComentario").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatCliente).WithMany(b => b.SIR_Sir292PagoElectronicoErp).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_292_PAGO_ELECTRONICO_ERP_cat_clientes
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir292PagoElectronicoErp).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_292_PAGO_ELECTRONICO_ERP_cat_usr
        }
    }

}
// </auto-generated>
