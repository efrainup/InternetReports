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

    // SIR_343_PROPIEDADES_CLIENTES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir343PropiedadesClienteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir343PropiedadesCliente>
    {
        public SIR_Sir343PropiedadesClienteConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir343PropiedadesClienteConfiguration(string schema)
        {
            ToTable("SIR_343_PROPIEDADES_CLIENTES", schema);
            HasKey(x => x.NIdPropCliente);

            Property(x => x.NIdPropCliente).HasColumnName(@"nIdPropCliente").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsOptional();
            Property(x => x.SPrefijo).HasColumnName(@"sPrefijo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.NIdClie07).HasColumnName(@"nIdClie07").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc07Cliente).WithMany(b => b.SIR_Sir343PropiedadesCliente).HasForeignKey(c => c.NIdClie07).WillCascadeOnDelete(false); // FK_SIR_343_PROPIEDADES_CLIENTES_ADMINC_07_CLIENTES
            HasOptional(a => a.CatCliente).WithMany(b => b.SIR_Sir343PropiedadesCliente).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_343_PROPIEDADES_CLIENTES_cat_clientes
        }
    }

}
// </auto-generated>
