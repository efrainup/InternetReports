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

    // SIR_766_CONFIGURACION_EMPRESA_1G
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir766ConfiguracionEmpresa1GConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir766ConfiguracionEmpresa1G>
    {
        public SIR_Sir766ConfiguracionEmpresa1GConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir766ConfiguracionEmpresa1GConfiguration(string schema)
        {
            ToTable("SIR_766_CONFIGURACION_EMPRESA_1G", schema);
            HasKey(x => x.NIdEmpresa);

            Property(x => x.NIdEmpresa).HasColumnName(@"nIdEmpresa").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BAplicaDescargaBd).HasColumnName(@"bAplicaDescargaBD").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.CfgEmpresa).WithOptional(b => b.SIR_Sir766ConfiguracionEmpresa1G).WillCascadeOnDelete(false); // FK_SIR_766_CONFIGURACION_EMPRESA_1G_cfg_empresa
        }
    }

}
// </auto-generated>