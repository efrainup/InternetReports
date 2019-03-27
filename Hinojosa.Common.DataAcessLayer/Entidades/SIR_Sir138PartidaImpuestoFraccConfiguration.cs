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

    // SIR_138_PARTIDA_IMPUESTO_FRACC
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir138PartidaImpuestoFraccConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir138PartidaImpuestoFracc>
    {
        public SIR_Sir138PartidaImpuestoFraccConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir138PartidaImpuestoFraccConfiguration(string schema)
        {
            ToTable("SIR_138_PARTIDA_IMPUESTO_FRACC", schema);
            HasKey(x => x.NIdImpFracc138);

            Property(x => x.NIdImpFracc138).HasColumnName(@"nIdImpFracc138").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdTiposImp30).HasColumnName(@"nIdTiposImp30").HasColumnType("int").IsRequired();
            Property(x => x.NIdTipoTasa113).HasColumnName(@"nIdTipoTasa113").HasColumnType("int").IsRequired();
            Property(x => x.NTasa).HasColumnName(@"nTasa").HasColumnType("decimal").IsRequired().HasPrecision(10,5);
            Property(x => x.NIdFormaPago32).HasColumnName(@"nIdFormaPago32").HasColumnType("int").IsRequired();
            Property(x => x.NImporte).HasColumnName(@"nImporte").HasColumnType("decimal").IsOptional().HasPrecision(15,3);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NNumPago).HasColumnName(@"nNumPago").HasColumnType("tinyint").IsRequired();
            Property(x => x.NIdFacPartAgrupada100).HasColumnName(@"nIdFacPartAgrupada100").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir138PartidaImpuestoFracc).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_138_PARTIDA_IMPUESTO_FRACC_cat_usr_ed
            HasRequired(a => a.SIR_Sir100FacPartAgrupada).WithMany(b => b.SIR_Sir138PartidaImpuestoFracc).HasForeignKey(c => c.NIdFacPartAgrupada100).WillCascadeOnDelete(false); // FK_SIR_138_PARTIDA_IMPUESTO_FRACC_SIR_100_FAC_PART_AGRUPADAS
            HasRequired(a => a.SIR_Sir113TiposTasa).WithMany(b => b.SIR_Sir138PartidaImpuestoFracc).HasForeignKey(c => c.NIdTipoTasa113).WillCascadeOnDelete(false); // FK_SIR_138_PARTIDA_IMPUESTO_FRACC_SIR_113_TIPOS_TASAS
            HasRequired(a => a.SIR_Sir30TiposImpuesto).WithMany(b => b.SIR_Sir138PartidaImpuestoFracc).HasForeignKey(c => c.NIdTiposImp30).WillCascadeOnDelete(false); // FK_SIR_138_PARTIDA_IMPUESTO_FRACC_SIR_30_TIPOS_IMPUESTOS
            HasRequired(a => a.SIR_Sir32FormasPago).WithMany(b => b.SIR_Sir138PartidaImpuestoFracc).HasForeignKey(c => c.NIdFormaPago32).WillCascadeOnDelete(false); // FK_SIR_138_PARTIDA_IMPUESTO_FRACC_SIR_32_FORMAS_PAGO
        }
    }

}
// </auto-generated>
