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

    // ADMINA_01_USUARIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Admina01UsuarioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Admin_Admina01Usuario>
    {
        public Admin_Admina01UsuarioConfiguration()
            : this("Admin")
        {
        }

        public Admin_Admina01UsuarioConfiguration(string schema)
        {
            ToTable("ADMINA_01_USUARIOS", schema);
            HasKey(x => x.NIdUsu01);

            Property(x => x.NIdUsu01).HasColumnName(@"nIdUsu01").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SUsuario).HasColumnName(@"sUsuario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.VPassword).HasColumnName(@"vPassword").HasColumnType("varbinary").IsRequired().HasMaxLength(50);
            Property(x => x.NIdPers02).HasColumnName(@"nIdPers02").HasColumnType("int").IsOptional();
            Property(x => x.BStatus).HasColumnName(@"bStatus").HasColumnType("bit").IsRequired();
            Property(x => x.NIdGrupo03).HasColumnName(@"nIdGrupo03").HasColumnType("int").IsOptional();
            Property(x => x.SZonaHoraria).HasColumnName(@"sZonaHoraria").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SOffsetZh).HasColumnName(@"sOffsetZH").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NIdEmprInicial11).HasColumnName(@"nIdEmprInicial11").HasColumnType("int").IsOptional();
            Property(x => x.NTipoUsuario).HasColumnName(@"nTipoUsuario").HasColumnType("tinyint").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Admina02Personal).WithMany(b => b.Admin_Admina01Usuario).HasForeignKey(c => c.NIdPers02).WillCascadeOnDelete(false); // FK_ADMINA_01_USUARIOS_ADMINA_02_PERSONAL
            HasOptional(a => a.Admin_Admina03Grupos).WithMany(b => b.Admin_Admina01Usuario).HasForeignKey(c => c.NIdGrupo03).WillCascadeOnDelete(false); // FK_ADMINA_01_USUARIOS_ADMINA_03_GRUPOS
            HasOptional(a => a.Admin_Admina11Empresa).WithMany(b => b.Admin_Admina01Usuario).HasForeignKey(c => c.NIdEmprInicial11).WillCascadeOnDelete(false); // FK_ADMINA_01_USUARIOS_ADMINA_11_EMPRESAS
        }
    }

}
// </auto-generated>