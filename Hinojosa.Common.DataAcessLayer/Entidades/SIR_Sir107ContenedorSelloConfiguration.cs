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

    // SIR_107_CONTENEDOR_SELLOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir107ContenedorSelloConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir107ContenedorSello>
    {
        public SIR_Sir107ContenedorSelloConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir107ContenedorSelloConfiguration(string schema)
        {
            ToTable("SIR_107_CONTENEDOR_SELLOS", schema);
            HasKey(x => x.NIdSello107);

            Property(x => x.NIdSello107).HasColumnName(@"nIdSello107").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SSellos).HasColumnName(@"sSellos").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.DFechaColocacion).HasColumnName(@"dFechaColocacion").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NIdContenedor76).HasColumnName(@"nIdContenedor76").HasColumnType("int").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();
            Property(x => x.NIdRem206).HasColumnName(@"nIdRem206").HasColumnType("int").IsOptional();
            Property(x => x.BEsOperativo).HasColumnName(@"bEsOperativo").HasColumnType("bit").IsRequired();
            Property(x => x.NIdUsu01).HasColumnName(@"nIdUsu01").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Admina01Usuario).WithMany(b => b.SIR_Sir107ContenedorSello).HasForeignKey(c => c.NIdUsu01).WillCascadeOnDelete(false); // FK_SIR_107_CONT_SELLOS_ADMINA_01_USUARIOS
            HasOptional(a => a.SIR_Sir206Remesa).WithMany(b => b.SIR_Sir107ContenedorSello).HasForeignKey(c => c.NIdRem206); // FK_SIR_107_CONTENEDOR_SELLOS_SIR_206_REMESAS
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir107ContenedorSello).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_107_CONTENEDOR_SELLOS_cat_usr_ed
            HasRequired(a => a.SIR_Sir76Contenedore).WithMany(b => b.SIR_Sir107ContenedorSello).HasForeignKey(c => c.NIdContenedor76); // FK_SIR_107_CONTENEDOR_SELLOS_SIR_76_CONTENEDORES
        }
    }

}
// </auto-generated>
