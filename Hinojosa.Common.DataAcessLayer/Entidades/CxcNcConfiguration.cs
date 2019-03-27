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

    // cxc_nc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxcNcConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CxcNc>
    {
        public CxcNcConfiguration()
            : this("dbo")
        {
        }

        public CxcNcConfiguration(string schema)
        {
            ToTable("cxc_nc", schema);
            HasKey(x => x.IdNc);

            Property(x => x.IdNc).HasColumnName(@"id_nc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDocOrig).HasColumnName(@"id_tip_doc_orig").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdDocOrig).HasColumnName(@"id_doc_orig").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.@Ref).HasColumnName(@"ref").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Monto).HasColumnName(@"monto").HasColumnType("float").IsRequired();
            Property(x => x.Saldo).HasColumnName(@"saldo").HasColumnType("float").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdProy).HasColumnName(@"id_proy").HasColumnType("int").IsRequired();
            Property(x => x.IdEnt).HasColumnName(@"id_ent").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatCliente).WithMany(b => b.CxcNcs).HasForeignKey(c => c.IdCli).WillCascadeOnDelete(false); // FK_cxc_nc_cat_clientes
            HasRequired(a => a.CatDocto_IdTipDoc).WithMany(b => b.CxcNcs_IdTipDoc).HasForeignKey(c => c.IdTipDoc).WillCascadeOnDelete(false); // FK_cxc_nc_cat_doctos
            HasRequired(a => a.CatDocto_IdTipDocOrig).WithMany(b => b.CxcNcs_IdTipDocOrig).HasForeignKey(c => c.IdTipDocOrig).WillCascadeOnDelete(false); // FK_cxc_nc_cat_doctos1
            HasRequired(a => a.CatUsr).WithMany(b => b.CxcNcs).HasForeignKey(c => c.IdUsr).WillCascadeOnDelete(false); // FK_cxc_nc_cat_usr
        }
    }

}
// </auto-generated>
