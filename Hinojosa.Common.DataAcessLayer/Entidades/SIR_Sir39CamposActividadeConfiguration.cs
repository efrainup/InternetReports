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

    // SIR_39_CAMPOS_ACTIVIDADES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir39CamposActividadeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir39CamposActividade>
    {
        public SIR_Sir39CamposActividadeConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir39CamposActividadeConfiguration(string schema)
        {
            ToTable("SIR_39_CAMPOS_ACTIVIDADES", schema);
            HasKey(x => x.NIdCampo39);

            Property(x => x.NIdCampo39).HasColumnName(@"nIdCampo39").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdActividad37).HasColumnName(@"nIdActividad37").HasColumnType("int").IsRequired();
            Property(x => x.SNombre).HasColumnName(@"sNombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.STamanio).HasColumnName(@"sTamanio").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.NTipoControl).HasColumnName(@"nTipoControl").HasColumnType("tinyint").IsRequired();
            Property(x => x.BRequerido).HasColumnName(@"bRequerido").HasColumnType("bit").IsRequired();
            Property(x => x.BBitacora).HasColumnName(@"bBitacora").HasColumnType("bit").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir39CamposActividade).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_39_CAMPOS_ACTIVIDADES_cat_usr_ed
            HasRequired(a => a.SIR_Sir37ActividadesUsuario).WithMany(b => b.SIR_Sir39CamposActividade).HasForeignKey(c => c.NIdActividad37); // FK_SIR_39_CAMPOS_ACTIVIDADES_SIR_37_ACTIVIDADES_USUARIO
        }
    }

}
// </auto-generated>
