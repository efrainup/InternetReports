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

    // SIR_224_CORDONES_CLASIF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir224CordonesClasifConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir224CordonesClasif>
    {
        public SIR_Sir224CordonesClasifConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir224CordonesClasifConfiguration(string schema)
        {
            ToTable("SIR_224_CORDONES_CLASIF", schema);
            HasKey(x => x.NIdCordClasif224);

            Property(x => x.NIdCordClasif224).HasColumnName(@"nIdCordClasif224").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("int").IsRequired();
            Property(x => x.SPuntoVerif).HasColumnName(@"sPuntoVerif").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.NIdCordon223).HasColumnName(@"nIdCordon223").HasColumnType("int").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir224CordonesClasif).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_224_CORDONES_CLASIF_cat_usr_ed
            HasRequired(a => a.SIR_Sir223CordonesCarretero).WithMany(b => b.SIR_Sir224CordonesClasif).HasForeignKey(c => c.NIdCordon223).WillCascadeOnDelete(false); // FK_SIR_224_CORDONES_CLASIF_SIR_223_CORDONES_CARRETEROS
        }
    }

}
// </auto-generated>