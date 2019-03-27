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

    // SIR_195_PREBLS_CONTACTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir195PreblsContactoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir195PreblsContacto>
    {
        public SIR_Sir195PreblsContactoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir195PreblsContactoConfiguration(string schema)
        {
            ToTable("SIR_195_PREBLS_CONTACTOS", schema);
            HasKey(x => x.NIdPreblCon195);

            Property(x => x.NIdPreblCon195).HasColumnName(@"nIdPreblCon195").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SNombre).HasColumnName(@"sNombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SDireccion).HasColumnName(@"sDireccion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(800);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir195PreblsContacto).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_195_PREBLS_CONTACTOS_cat_usr_ed
        }
    }

}
// </auto-generated>