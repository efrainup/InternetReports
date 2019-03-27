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

    // sis_sociales
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisSocialeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisSociale>
    {
        public SisSocialeConfiguration()
            : this("dbo")
        {
        }

        public SisSocialeConfiguration(string schema)
        {
            ToTable("sis_sociales", schema);
            HasKey(x => x.IdSisSociales);

            Property(x => x.IdSisSociales).HasColumnName(@"id_sis_sociales").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Usuario).HasColumnName(@"usuario").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.Contrasena).HasColumnName(@"contrasena").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.FecUltMod).HasColumnName(@"fec_ult_mod").HasColumnType("datetime").IsRequired();
            Property(x => x.UsrMod).HasColumnName(@"usr_mod").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>