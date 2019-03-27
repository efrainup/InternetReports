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

    // Disponible
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class DisponibleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Disponible>
    {
        public DisponibleConfiguration()
            : this("dbo")
        {
        }

        public DisponibleConfiguration(string schema)
        {
            ToTable("Disponible", schema);
            HasKey(x => x.IdDisponibilidad);

            Property(x => x.IdDisponibilidad).HasColumnName(@"id_disponibilidad").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdEquipo).HasColumnName(@"id_equipo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Inicio).HasColumnName(@"inicio").HasColumnType("datetime").IsRequired();
            Property(x => x.Fin).HasColumnName(@"fin").HasColumnType("datetime").IsRequired();
            Property(x => x.Modo).HasColumnName(@"modo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CAutorizado).HasColumnName(@"c_autorizado").HasColumnType("bit").IsRequired();
            Property(x => x.IdEmp).HasColumnName(@"id_emp").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
