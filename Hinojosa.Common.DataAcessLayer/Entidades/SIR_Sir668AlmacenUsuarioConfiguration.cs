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

    // SIR_668_ALMACEN_USUARIO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir668AlmacenUsuarioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir668AlmacenUsuario>
    {
        public SIR_Sir668AlmacenUsuarioConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir668AlmacenUsuarioConfiguration(string schema)
        {
            ToTable("SIR_668_ALMACEN_USUARIO", schema);
            HasKey(x => x.NIdAlmacenUsuario668);

            Property(x => x.NIdAlmacenUsuario668).HasColumnName(@"nIdAlmacenUsuario668").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdAlmacen).HasColumnName(@"nIdAlmacen").HasColumnType("int").IsRequired();
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
