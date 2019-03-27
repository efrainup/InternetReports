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

    // SIR_84_TIPOS_FECHAS_VALORES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir84TiposFechasValoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir84TiposFechasValore>
    {
        public SIR_Sir84TiposFechasValoreConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir84TiposFechasValoreConfiguration(string schema)
        {
            ToTable("SIR_84_TIPOS_FECHAS_VALORES", schema);
            HasKey(x => x.NIdTipoFecVal84);

            Property(x => x.NIdTipoFecVal84).HasColumnName(@"nIdTipoFecVal84").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdLlaveAsociada).HasColumnName(@"nIdLlaveAsociada").HasColumnType("int").IsRequired();
            Property(x => x.NIdTipoFecha83).HasColumnName(@"nIdTipoFecha83").HasColumnType("int").IsRequired();
            Property(x => x.DValorFecha).HasColumnName(@"dValorFecha").HasColumnType("datetime").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir84TiposFechasValore).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_84_TIPOS_FECHAS_VALORES_cat_usr_ed
            HasRequired(a => a.SIR_Sir83TiposFecha).WithMany(b => b.SIR_Sir84TiposFechasValore).HasForeignKey(c => c.NIdTipoFecha83).WillCascadeOnDelete(false); // FK_SIR_84_TIPOS_FECHAS_VALORES_SIR_83_TIPOS_FECHAS
        }
    }

}
// </auto-generated>