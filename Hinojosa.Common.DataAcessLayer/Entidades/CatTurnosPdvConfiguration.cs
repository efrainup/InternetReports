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

    // cat_Turnos_PDV
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatTurnosPdvConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatTurnosPdv>
    {
        public CatTurnosPdvConfiguration()
            : this("dbo")
        {
        }

        public CatTurnosPdvConfiguration(string schema)
        {
            ToTable("cat_Turnos_PDV", schema);
            HasKey(x => x.IdTurno);

            Property(x => x.IdTurno).HasColumnName(@"idTurno").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Numero).HasColumnName(@"numero").HasColumnType("int").IsRequired();
            Property(x => x.Dehora).HasColumnName(@"dehora").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Ahora).HasColumnName(@"ahora").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.FchReg).HasColumnName(@"fch_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsOptional();
            Property(x => x.Estatus).HasColumnName(@"ESTATUS").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
