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

    // sis_accesos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisAccesoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisAcceso>
    {
        public SisAccesoConfiguration()
            : this("dbo")
        {
        }

        public SisAccesoConfiguration(string schema)
        {
            ToTable("sis_accesos", schema);
            HasKey(x => x.IdAcceso);

            Property(x => x.IdAcceso).HasColumnName(@"id_acceso").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdGrp).HasColumnName(@"id_grp").HasColumnType("int").IsRequired();
            Property(x => x.IdRec).HasColumnName(@"id_rec").HasColumnType("int").IsRequired();
            Property(x => x.Permiso).HasColumnName(@"permiso").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdGrpPad).HasColumnName(@"id_grp_pad").HasColumnType("int").IsRequired();
            Property(x => x.IdGrpAcc).HasColumnName(@"id_grp_acc").HasColumnType("int").IsRequired();
            Property(x => x.Cond).HasColumnName(@"cond").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);

            // Foreign keys
            HasRequired(a => a.SisRecurso).WithMany(b => b.SisAccesoes).HasForeignKey(c => c.IdRec).WillCascadeOnDelete(false); // FK_sis_accesos_sis_recursos
        }
    }

}
// </auto-generated>
