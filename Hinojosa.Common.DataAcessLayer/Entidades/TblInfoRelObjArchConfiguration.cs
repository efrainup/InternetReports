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

    // tbl_info_rel_obj_arch
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblInfoRelObjArchConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TblInfoRelObjArch>
    {
        public TblInfoRelObjArchConfiguration()
            : this("dbo")
        {
        }

        public TblInfoRelObjArchConfiguration(string schema)
        {
            ToTable("tbl_info_rel_obj_arch", schema);
            HasKey(x => x.IdInfo);

            Property(x => x.IdInfo).HasColumnName(@"id_info").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdRelObjArch).HasColumnName(@"id_rel_obj_arch").HasColumnType("int").IsRequired();
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.IdCtaCar).HasColumnName(@"id_cta_car").HasColumnType("int").IsRequired();
            Property(x => x.IdCtaAbo).HasColumnName(@"id_cta_abo").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdEnt).HasColumnName(@"id_ent").HasColumnType("int").IsRequired();
            Property(x => x.IdCodSrv).HasColumnName(@"id_cod_srv").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.FecDoc).HasColumnName(@"fec_doc").HasColumnType("datetime").IsRequired();
            Property(x => x.NumDocCli).HasColumnName(@"num_doc_cli").HasColumnType("int").IsRequired();
            Property(x => x.@Ref).HasColumnName(@"ref").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.Monto).HasColumnName(@"monto").HasColumnType("float").IsRequired();
            Property(x => x.NumChq).HasColumnName(@"num_chq").HasColumnType("int").IsRequired();
            Property(x => x.RefBen).HasColumnName(@"ref_ben").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("float").IsRequired();
            Property(x => x.NumDocRec).HasColumnName(@"num_doc_rec").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.NoFact).HasColumnName(@"no_fact").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.Cmt).HasColumnName(@"cmt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);

            // Foreign keys
            HasRequired(a => a.crm_SisRelObjArch).WithMany(b => b.TblInfoRelObjArches).HasForeignKey(c => c.IdRelObjArch).WillCascadeOnDelete(false); // FK_tbl_info_rel_obj_arch_id_rel_obj_arch
        }
    }

}
// </auto-generated>
