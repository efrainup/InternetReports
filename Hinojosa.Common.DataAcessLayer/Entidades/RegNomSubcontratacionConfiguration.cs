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

    // reg_nom_subcontratacion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RegNomSubcontratacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RegNomSubcontratacion>
    {
        public RegNomSubcontratacionConfiguration()
            : this("dbo")
        {
        }

        public RegNomSubcontratacionConfiguration(string schema)
        {
            ToTable("reg_nom_subcontratacion", schema);
            HasKey(x => x.IdSub);

            Property(x => x.IdSub).HasColumnName(@"id_sub").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdRegNom).HasColumnName(@"id_reg_nom").HasColumnType("int").IsRequired();
            Property(x => x.IdEmp).HasColumnName(@"id_emp").HasColumnType("int").IsRequired();
            Property(x => x.RfcLab).HasColumnName(@"rfc_lab").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PrcjTiempo).HasColumnName(@"prcj_tiempo").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
