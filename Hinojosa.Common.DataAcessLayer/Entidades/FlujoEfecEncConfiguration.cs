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

    // Flujo_Efec_Enc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class FlujoEfecEncConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<FlujoEfecEnc>
    {
        public FlujoEfecEncConfiguration()
            : this("dbo")
        {
        }

        public FlujoEfecEncConfiguration(string schema)
        {
            ToTable("Flujo_Efec_Enc", schema);
            HasKey(x => x.IdFlujo);

            Property(x => x.IdFlujo).HasColumnName(@"id_flujo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Version).HasColumnName(@"Version").HasColumnType("int").IsRequired();
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FecIni).HasColumnName(@"Fec_Ini").HasColumnType("datetime").IsRequired();
            Property(x => x.FecFin).HasColumnName(@"Fec_fin").HasColumnType("datetime").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"Fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsOptional();
            Property(x => x.NatuCalen).HasColumnName(@"natu_calen").HasColumnType("tinyint").IsOptional();
            Property(x => x.Cantidad).HasColumnName(@"cantidad").HasColumnType("int").IsOptional();
            Property(x => x.EsOficial).HasColumnName(@"es_oficial").HasColumnType("tinyint").IsRequired();
            Property(x => x.Layout).HasColumnName(@"layout").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.IdUsuario).HasColumnName(@"id_usuario").HasColumnType("int").IsRequired();
            Property(x => x.Saldo).HasColumnName(@"Saldo").HasColumnType("float").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>