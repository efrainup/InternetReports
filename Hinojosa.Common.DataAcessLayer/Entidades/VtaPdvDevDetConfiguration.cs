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

    // vta_pdv_dev_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaPdvDevDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VtaPdvDevDet>
    {
        public VtaPdvDevDetConfiguration()
            : this("dbo")
        {
        }

        public VtaPdvDevDetConfiguration(string schema)
        {
            ToTable("vta_pdv_dev_det", schema);
            HasKey(x => x.IdPdvDevDet);

            Property(x => x.IdPdvDevDet).HasColumnName(@"id_pdv_dev_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdVtaAuxDev).HasColumnName(@"id_vta_aux_dev").HasColumnType("int").IsRequired();
            Property(x => x.IdPdvDev).HasColumnName(@"id_pdv_dev").HasColumnType("int").IsRequired();
            Property(x => x.IdVtaAuxTik).HasColumnName(@"id_vta_aux_tik").HasColumnType("int").IsRequired();
            Property(x => x.IdPdvTik).HasColumnName(@"id_pdv_tik").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired();
            Property(x => x.IdAlmac).HasColumnName(@"id_almac").HasColumnType("int").IsRequired();
            Property(x => x.Costo).HasColumnName(@"costo").HasColumnType("float").IsRequired();
            Property(x => x.IdRelEmbPed).HasColumnName(@"id_rel_emb_ped").HasColumnType("int").IsRequired();
            Property(x => x.StatusEnv).HasColumnName(@"status_env").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>