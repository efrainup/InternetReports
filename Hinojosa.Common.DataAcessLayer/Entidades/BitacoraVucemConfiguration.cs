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

    // bitacora_vucem
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BitacoraVucemConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BitacoraVucem>
    {
        public BitacoraVucemConfiguration()
            : this("dbo")
        {
        }

        public BitacoraVucemConfiguration(string schema)
        {
            ToTable("bitacora_vucem", schema);
            HasKey(x => x.IdBitacoravucem);

            Property(x => x.IdBitacoravucem).HasColumnName(@"id_bitacoravucem").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Error).HasColumnName(@"error").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Fecharegistro).HasColumnName(@"fecharegistro").HasColumnType("datetime").IsOptional();
            Property(x => x.Leyenda).HasColumnName(@"leyenda").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Numeroperacion).HasColumnName(@"numeroperacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Horarecepcion).HasColumnName(@"horarecepcion").HasColumnType("datetime").IsOptional();
            Property(x => x.Idvucem1G).HasColumnName(@"idvucem1g").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
