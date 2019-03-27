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

    // SW_06_USUARIO_WEBACCESS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRWEB_Sw06UsuarioWebaccessConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRWEB_Sw06UsuarioWebaccess>
    {
        public SIRWEB_Sw06UsuarioWebaccessConfiguration()
            : this("SIRWEB")
        {
        }

        public SIRWEB_Sw06UsuarioWebaccessConfiguration(string schema)
        {
            ToTable("SW_06_USUARIO_WEBACCESS", schema);
            HasKey(x => x.NIdUsuarioWa06);

            Property(x => x.NIdUsuarioWa06).HasColumnName(@"nIdUsuarioWA06").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SUsuario).HasColumnName(@"sUsuario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.SPassword).HasColumnName(@"sPassword").HasColumnType("varbinary").IsRequired().HasMaxLength(50);
            Property(x => x.SNombre).HasColumnName(@"sNombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.SApellidoPaterno).HasColumnName(@"sApellidoPaterno").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.SApellidoMaterno).HasColumnName(@"sApellidoMaterno").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.SRfc).HasColumnName(@"sRFC").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.SCiudad).HasColumnName(@"sCiudad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(300);
            Property(x => x.NIdEntFed02).HasColumnName(@"nIdEntFed02").HasColumnType("int").IsOptional();
            Property(x => x.STelefono).HasColumnName(@"sTelefono").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SCorreoElectronico).HasColumnName(@"sCorreoElectronico").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.NIdUsuarioSir).HasColumnName(@"nIdUsuarioSIR").HasColumnType("int").IsOptional();
            Property(x => x.NTipoDeUsuario).HasColumnName(@"nTipoDeUsuario").HasColumnType("int").IsOptional();
            Property(x => x.NVistaMonitorEjecutivo).HasColumnName(@"nVistaMonitorEjecutivo").HasColumnType("tinyint").IsOptional();
        }
    }

}
// </auto-generated>
