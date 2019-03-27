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

    // SIR_289_MTRA_CLIENTES_IDENT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir289MtraClientesIdentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir289MtraClientesIdent>
    {
        public SIR_Sir289MtraClientesIdentConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir289MtraClientesIdentConfiguration(string schema)
        {
            ToTable("SIR_289_MTRA_CLIENTES_IDENT", schema);
            HasKey(x => x.NIdCliIden289);

            Property(x => x.NIdCliIden289).HasColumnName(@"nIdCliIden289").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsOptional();
            Property(x => x.NIdClaveDocto28).HasColumnName(@"nIdClaveDocto28").HasColumnType("int").IsOptional();
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NFolio).HasColumnName(@"nFolio").HasColumnType("int").IsOptional();
            Property(x => x.NIdClie07).HasColumnName(@"nIdClie07").HasColumnType("int").IsOptional();
            Property(x => x.BAplicaSoloRt).HasColumnName(@"bAplicaSoloRT").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc07Cliente).WithMany(b => b.SIR_Sir289MtraClientesIdent).HasForeignKey(c => c.NIdClie07).WillCascadeOnDelete(false); // FK_SIR_289_MTRA_CLIENTES_IDENT_ADMINC_07_CLIENTES
            HasOptional(a => a.CatCliente).WithMany(b => b.SIR_Sir289MtraClientesIdent).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_289_MTRA_CLIENTES_IDENT_cat_clientes
            HasOptional(a => a.SIR_Sir28ClavesDocto).WithMany(b => b.SIR_Sir289MtraClientesIdent).HasForeignKey(c => c.NIdClaveDocto28).WillCascadeOnDelete(false); // FK_SIR_289_MTRA_CLIENTES_IDENT_SIR_28_CLAVES_DOCTOS
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir289MtraClientesIdent).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_289_MTRA_CLIENTES_IDENT_cat_usr_ed
        }
    }

}
// </auto-generated>
