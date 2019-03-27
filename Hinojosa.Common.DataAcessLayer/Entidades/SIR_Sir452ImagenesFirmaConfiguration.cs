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

    // SIR_452_IMAGENES_FIRMA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir452ImagenesFirmaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir452ImagenesFirma>
    {
        public SIR_Sir452ImagenesFirmaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir452ImagenesFirmaConfiguration(string schema)
        {
            ToTable("SIR_452_IMAGENES_FIRMA", schema);
            HasKey(x => x.NIdImagen452);

            Property(x => x.NIdImagen452).HasColumnName(@"nIdImagen452").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdFirma451).HasColumnName(@"nIdFirma451").HasColumnType("int").IsRequired();
            Property(x => x.IImagen).HasColumnName(@"iImagen").HasColumnType("image").IsRequired().HasMaxLength(2147483647);
            Property(x => x.SRtfImagen).HasColumnName(@"sRtfImagen").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.SNombreImagen).HasColumnName(@"sNombreImagen").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.SIR_Sir451FirmasCorreo).WithMany(b => b.SIR_Sir452ImagenesFirma).HasForeignKey(c => c.NIdFirma451).WillCascadeOnDelete(false); // FK_SIR_452_IMAGENES_FIRMA_SIR_451_FIRMAS_CORREO
        }
    }

}
// </auto-generated>