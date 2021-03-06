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

    // SIRA_43_CONF_PROG_SERV_CONTENEDOR
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira43ConfProgServContenedorConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira43ConfProgServContenedor>
    {
        public SIRAdmin_Sira43ConfProgServContenedorConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira43ConfProgServContenedorConfiguration(string schema)
        {
            ToTable("SIRA_43_CONF_PROG_SERV_CONTENEDOR", schema);
            HasKey(x => x.NIdServCont43);

            Property(x => x.NIdServCont43).HasColumnName(@"nIdServCont43").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdServSuc44).HasColumnName(@"nIdServSuc44").HasColumnType("int").IsRequired();
            Property(x => x.NIdTipoCont09).HasColumnName(@"nIdTipoCont09").HasColumnType("int").IsRequired();
            Property(x => x.BAplicaProgServicios).HasColumnName(@"bAplicaProgServicios").HasColumnType("bit").IsRequired();
            Property(x => x.BAplicaImportacion).HasColumnName(@"bAplicaImportacion").HasColumnType("bit").IsRequired();
            Property(x => x.BAplicaExportacion).HasColumnName(@"bAplicaExportacion").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.SIR_Sir09TiposContenedor).WithMany(b => b.SIRAdmin_Sira43ConfProgServContenedor).HasForeignKey(c => c.NIdTipoCont09).WillCascadeOnDelete(false); // FK_SIRA_43_CONF_PROG_SERV_CONTENEDOR_SIR_09_TIPOS_CONTENEDOR
            HasRequired(a => a.SIRAdmin_Sira44ConfProgServSucursal).WithMany(b => b.SIRAdmin_Sira43ConfProgServContenedor).HasForeignKey(c => c.NIdServSuc44).WillCascadeOnDelete(false); // FK_SIRA_43_CONF_PROG_SERV_CONTENEDOR_SIRA_44_CONF_PROG_SERV_SUCURSAL
        }
    }

}
// </auto-generated>
