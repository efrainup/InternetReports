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

    // SIR_247_SERVICIO_PREVALIDACION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir247ServicioPrevalidacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir247ServicioPrevalidacion>
    {
        public SIR_Sir247ServicioPrevalidacionConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir247ServicioPrevalidacionConfiguration(string schema)
        {
            ToTable("SIR_247_SERVICIO_PREVALIDACION", schema);
            HasKey(x => x.NIdServPre247);

            Property(x => x.NIdServPre247).HasColumnName(@"nIdServPre247").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.NTipo).HasColumnName(@"nTipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.NIdPrevalidador155).HasColumnName(@"nIdPrevalidador155").HasColumnType("int").IsRequired();
            Property(x => x.XConexion).HasColumnName(@"xConexion").HasColumnType("xml").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.BOisaSagarpa).HasColumnName(@"bOisaSagarpa").HasColumnType("bit").IsRequired();
            Property(x => x.BgeneraBandera).HasColumnName(@"bgeneraBandera").HasColumnType("bit").IsOptional();
            Property(x => x.BPagoNoPedimento).HasColumnName(@"bPagoNoPedimento").HasColumnType("bit").IsOptional();
            Property(x => x.BPideContraseña).HasColumnName(@"bPideContraseña").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir247ServicioPrevalidacion).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_247_SERVICIO_PREVALIDACION_cat_usr
            HasRequired(a => a.SIR_Sir155Prevalidadore).WithMany(b => b.SIR_Sir247ServicioPrevalidacion).HasForeignKey(c => c.NIdPrevalidador155).WillCascadeOnDelete(false); // FK_SIR_247_SERVICIO_PREVALIDACION_SIR_155_PREVALIDADORES
        }
    }

}
// </auto-generated>
