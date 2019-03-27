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

    // uti_bitacora
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class UtiBitacoraConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UtiBitacora>
    {
        public UtiBitacoraConfiguration()
            : this("dbo")
        {
        }

        public UtiBitacoraConfiguration(string schema)
        {
            ToTable("uti_bitacora", schema);
            HasKey(x => x.IdBit);

            Property(x => x.IdBit).HasColumnName(@"id_bit").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr2).HasColumnName(@"id_usr2").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Concepto).HasColumnName(@"concepto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.Importe).HasColumnName(@"importe").HasColumnType("float").IsRequired();
        }
    }

}
// </auto-generated>