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

    // vta_dep_gar_pdv_det_apl
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaDepGarPdvDetAplConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VtaDepGarPdvDetApl>
    {
        public VtaDepGarPdvDetAplConfiguration()
            : this("dbo")
        {
        }

        public VtaDepGarPdvDetAplConfiguration(string schema)
        {
            ToTable("vta_dep_gar_pdv_det_apl", schema);
            HasKey(x => x.IdDepAntCli);

            Property(x => x.IdDepAntCli).HasColumnName(@"Id_dep_ant_cli").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdFolio).HasColumnName(@"Id_folio").HasColumnType("int").IsRequired();
            Property(x => x.IdVtaAux).HasColumnName(@"id_vta_aux").HasColumnType("int").IsRequired();
            Property(x => x.IdFac).HasColumnName(@"id_fac").HasColumnType("int").IsRequired();
            Property(x => x.Total).HasColumnName(@"Total").HasColumnType("float").IsRequired();
            Property(x => x.Saldo).HasColumnName(@"Saldo").HasColumnType("float").IsRequired();
            Property(x => x.Aplicado).HasColumnName(@"Aplicado").HasColumnType("float").IsRequired();
            Property(x => x.NumCta).HasColumnName(@"num_cta").HasColumnType("int").IsRequired();
            Property(x => x.TipTrn).HasColumnName(@"tip_trn").HasColumnType("int").IsRequired();
            Property(x => x.IdCto).HasColumnName(@"id_cto").HasColumnType("int").IsRequired();
            Property(x => x.TipMov).HasColumnName(@"tip_mov").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
