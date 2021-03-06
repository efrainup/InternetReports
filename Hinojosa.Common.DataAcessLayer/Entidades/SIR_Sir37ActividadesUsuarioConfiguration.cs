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

    // SIR_37_ACTIVIDADES_USUARIO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir37ActividadesUsuarioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir37ActividadesUsuario>
    {
        public SIR_Sir37ActividadesUsuarioConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir37ActividadesUsuarioConfiguration(string schema)
        {
            ToTable("SIR_37_ACTIVIDADES_USUARIO", schema);
            HasKey(x => x.NIdActividad37);

            Property(x => x.NIdActividad37).HasColumnName(@"nIdActividad37").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.NColor).HasColumnName(@"nColor").HasColumnType("int").IsRequired();
            Property(x => x.BConfirmado).HasColumnName(@"bConfirmado").HasColumnType("bit").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NIdConcepto).HasColumnName(@"nIdConcepto").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.CatPro).WithMany(b => b.SIR_Sir37ActividadesUsuario).HasForeignKey(c => c.NIdConcepto).WillCascadeOnDelete(false); // FK_SIR_37_ACTIVIDADES_USUARIO_cat_pro
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir37ActividadesUsuario).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_37_ACTIVIDADES_USUARIO_cat_usr_ed
        }
    }

}
// </auto-generated>
