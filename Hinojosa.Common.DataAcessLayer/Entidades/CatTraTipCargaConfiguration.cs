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

    // cat_tra_tip_carga
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatTraTipCargaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatTraTipCarga>
    {
        public CatTraTipCargaConfiguration()
            : this("dbo")
        {
        }

        public CatTraTipCargaConfiguration(string schema)
        {
            ToTable("cat_tra_tip_carga", schema);
            HasKey(x => x.ClaCar);

            Property(x => x.IdTipCar).HasColumnName(@"id_tip_car").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ClaCar).HasColumnName(@"cla_car").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Peso).HasColumnName(@"peso").HasColumnType("float").IsRequired();
            Property(x => x.Longitud).HasColumnName(@"longitud").HasColumnType("float").IsRequired();
            Property(x => x.Altura).HasColumnName(@"altura").HasColumnType("float").IsRequired();
            Property(x => x.Ancho).HasColumnName(@"ancho").HasColumnType("float").IsRequired();
            Property(x => x.Almacenaje).HasColumnName(@"almacenaje").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
