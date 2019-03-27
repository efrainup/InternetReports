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

    // SIR_431_ACTIVIDAD_OBSERVACION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir431ActividadObservacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir431ActividadObservacion>
    {
        public SIR_Sir431ActividadObservacionConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir431ActividadObservacionConfiguration(string schema)
        {
            ToTable("SIR_431_ACTIVIDAD_OBSERVACION", schema);
            HasKey(x => x.NIdActividadObservacion431);

            Property(x => x.NIdActividadObservacion431).HasColumnName(@"nIdActividadObservacion431").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdActividadEtapa405).HasColumnName(@"nIdActividadEtapa405").HasColumnType("int").IsRequired();
            Property(x => x.SObservacion).HasColumnName(@"sObservacion").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsuario01).HasColumnName(@"nIdUsuario01").HasColumnType("int").IsOptional();
            Property(x => x.DObservacion).HasColumnName(@"dObservacion").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasOptional(a => a.Admin_Admina01Usuario).WithMany(b => b.SIR_Sir431ActividadObservacion).HasForeignKey(c => c.NIdUsuario01).WillCascadeOnDelete(false); // FK_SIR_431_ACTIVIDAD_OBSERVACION_ADMINA_01_USUARIOS
            HasRequired(a => a.SIR_Sir405ActividadesDeEtapa).WithMany(b => b.SIR_Sir431ActividadObservacion).HasForeignKey(c => c.NIdActividadEtapa405).WillCascadeOnDelete(false); // FK_SIR_431_ACTIVIDAD_OBSERVACION_SIR_405_ACTIVIDADES_DE_ETAPA
        }
    }

}
// </auto-generated>
