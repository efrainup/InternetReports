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

    // SIR_175_TRANSPORTES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir175TransporteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir175Transporte>
    {
        public SIR_Sir175TransporteConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir175TransporteConfiguration(string schema)
        {
            ToTable("SIR_175_TRANSPORTES", schema);
            HasKey(x => x.NIdTrans175);

            Property(x => x.NIdTrans175).HasColumnName(@"nIdTrans175").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdPais01).HasColumnName(@"nIdPais01").HasColumnType("int").IsRequired();
            Property(x => x.SIdentificador).HasColumnName(@"sIdentificador").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.NIdTransportista).HasColumnName(@"nIdTransportista").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsOptional();
            Property(x => x.NIdTipoTrafico25).HasColumnName(@"nIdTipoTrafico25").HasColumnType("int").IsRequired();
            Property(x => x.SNumEconomico).HasColumnName(@"sNumEconomico").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.NIdTransportista42).HasColumnName(@"nIdTransportista42").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc42Proveedore).WithMany(b => b.SIR_Sir175Transporte).HasForeignKey(c => c.NIdTransportista42).WillCascadeOnDelete(false); // FK_SIR_175_TRANSPORTES_ADMINC_42_PROVEEDORES
            HasOptional(a => a.CatProv).WithMany(b => b.SIR_Sir175Transporte).HasForeignKey(c => c.NIdTransportista).WillCascadeOnDelete(false); // FK_SIR_175_TRANSPORTES_cat_prov
            HasOptional(a => a.CatUsr).WithMany(b => b.SIR_Sir175Transporte).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_175_TRANSPORTES_cat_usr_ed
            HasRequired(a => a.SIR_Sir01Pais).WithMany(b => b.SIR_Sir175Transporte).HasForeignKey(c => c.NIdPais01).WillCascadeOnDelete(false); // FK_SIR_175_TRANSPORTES_SIR_01_PAISES
            HasRequired(a => a.SIR_Sir25TiposTrafico).WithMany(b => b.SIR_Sir175Transporte).HasForeignKey(c => c.NIdTipoTrafico25).WillCascadeOnDelete(false); // FK_SIR_175_TRANSPORTES_SIR_25_TIPOS_TRAFICO
        }
    }

}
// </auto-generated>
