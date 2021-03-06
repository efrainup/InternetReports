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

    // tbl_exportacion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblExportacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TblExportacion>
    {
        public TblExportacionConfiguration()
            : this("dbo")
        {
        }

        public TblExportacionConfiguration(string schema)
        {
            ToTable("tbl_exportacion", schema);
            HasKey(x => x.IdExportacion);

            Property(x => x.IdExportacion).HasColumnName(@"id_exportacion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdSesion).HasColumnName(@"id_sesion").HasColumnType("int").IsRequired();
            Property(x => x.Ruta).HasColumnName(@"ruta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
