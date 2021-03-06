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

    // SIRA_49_LIBERACION_CONTENEDOR
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira49LiberacionContenedorConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira49LiberacionContenedor>
    {
        public SIRAdmin_Sira49LiberacionContenedorConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira49LiberacionContenedorConfiguration(string schema)
        {
            ToTable("SIRA_49_LIBERACION_CONTENEDOR", schema);
            HasKey(x => x.NIdLibCont49);

            Property(x => x.NIdLibCont49).HasColumnName(@"nIdLibCont49").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdContenedor76).HasColumnName(@"nIdContenedor76").HasColumnType("int").IsRequired();
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired();
            Property(x => x.NFolio).HasColumnName(@"nFolio").HasColumnType("int").IsOptional();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.DFechaLiberacion).HasColumnName(@"dFechaLiberacion").HasColumnType("datetime").IsOptional();
            Property(x => x.DFechaSolicitud).HasColumnName(@"dFechaSolicitud").HasColumnType("datetime").IsOptional();
            Property(x => x.NIdSolicita02).HasColumnName(@"nIdSolicita02").HasColumnType("int").IsOptional();
            Property(x => x.NIdSolicita).HasColumnName(@"nIdSolicita").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Admina02Personal).WithMany(b => b.SIRAdmin_Sira49LiberacionContenedor).HasForeignKey(c => c.NIdSolicita02).WillCascadeOnDelete(false); // FK_SIRA_49_LIBERACION_CONTENEDOR_ADMINA_02_PERSONAL
            HasOptional(a => a.CatEmp).WithMany(b => b.SIRAdmin_Sira49LiberacionContenedor).HasForeignKey(c => c.NIdSolicita).WillCascadeOnDelete(false); // FK_SIRA_49_LIBERACION_CONTENEDOR_cat_emp
            HasRequired(a => a.SIR_Sir60Referencia).WithMany(b => b.SIRAdmin_Sira49LiberacionContenedor).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIRA_49_LIBERACION_CONTENEDOR_SIR_60_REFERENCIAS
            HasRequired(a => a.SIR_Sir76Contenedore).WithMany(b => b.SIRAdmin_Sira49LiberacionContenedor).HasForeignKey(c => c.NIdContenedor76).WillCascadeOnDelete(false); // FK_SIRA_49_LIBERACION_CONTENEDOR_SIR_76_CONTENEDORES
        }
    }

}
// </auto-generated>
