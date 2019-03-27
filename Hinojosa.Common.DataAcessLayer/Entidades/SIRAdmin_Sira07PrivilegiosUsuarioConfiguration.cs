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

    // SIRA_07_PRIVILEGIOS_USUARIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira07PrivilegiosUsuarioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira07PrivilegiosUsuario>
    {
        public SIRAdmin_Sira07PrivilegiosUsuarioConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira07PrivilegiosUsuarioConfiguration(string schema)
        {
            ToTable("SIRA_07_PRIVILEGIOS_USUARIOS", schema);
            HasKey(x => x.NIdPuSis07);

            Property(x => x.NIdPuSis07).HasColumnName(@"nIdPUSis07").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsRequired();
            Property(x => x.NIdNodo).HasColumnName(@"nIdNodo").HasColumnType("int").IsRequired();
            Property(x => x.BLeer).HasColumnName(@"bLeer").HasColumnType("bit").IsRequired();
            Property(x => x.BEditar).HasColumnName(@"bEditar").HasColumnType("bit").IsRequired();
            Property(x => x.BBorrar).HasColumnName(@"bBorrar").HasColumnType("bit").IsRequired();
            Property(x => x.BAgregar).HasColumnName(@"bAgregar").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIRAdmin_Sira07PrivilegiosUsuario).HasForeignKey(c => c.NIdUsuario).WillCascadeOnDelete(false); // FK_SIRA_07_PRIVILEGIOS_USUARIOS_cat_usr
            HasRequired(a => a.SisRecurso).WithMany(b => b.SIRAdmin_Sira07PrivilegiosUsuario).HasForeignKey(c => c.NIdNodo).WillCascadeOnDelete(false); // FK_SIRA_07_PRIVILEGIOS_USUARIOS_sis_recursos
        }
    }

}
// </auto-generated>
