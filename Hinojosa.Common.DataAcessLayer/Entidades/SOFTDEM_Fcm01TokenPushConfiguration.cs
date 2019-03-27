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

    // FCM_01_TOKEN_PUSH
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SOFTDEM_Fcm01TokenPushConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SOFTDEM_Fcm01TokenPush>
    {
        public SOFTDEM_Fcm01TokenPushConfiguration()
            : this("SOFTDEM")
        {
        }

        public SOFTDEM_Fcm01TokenPushConfiguration(string schema)
        {
            ToTable("FCM_01_TOKEN_PUSH", schema);
            HasKey(x => x.NIdTokenPush01);

            Property(x => x.NIdTokenPush01).HasColumnName(@"nIdTokenPush01").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SToken).HasColumnName(@"sToken").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.NTipoTecnologia).HasColumnName(@"nTipoTecnologia").HasColumnType("int").IsRequired();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsRequired();
            HasMany(t => t.SIRWEB_Sw06UsuarioWebaccess).WithMany(t => t.SOFTDEM_Fcm01TokenPush).Map(m =>
            {
                m.ToTable("SIR_796_USUARIO_APP_TOKEN_PUSH", "SIR");
                m.MapLeftKey("nIdTokenPush01");
                m.MapRightKey("nIdUsuarioWA06");
            });
        }
    }

}
// </auto-generated>
