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

    // sis_rel_cliprov_puestos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisRelCliprovPuestoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<crm_SisRelCliprovPuesto>
    {
        public crm_SisRelCliprovPuestoConfiguration()
            : this("crm")
        {
        }

        public crm_SisRelCliprovPuestoConfiguration(string schema)
        {
            ToTable("sis_rel_cliprov_puestos", schema);
            HasKey(x => x.IdRelCiaPuesto);

            Property(x => x.IdRelCiaPuesto).HasColumnName(@"id_rel_cia_puesto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdPuesto).HasColumnName(@"id_puesto").HasColumnType("int").IsRequired();
            Property(x => x.IdCliprov).HasColumnName(@"id_cliprov").HasColumnType("int").IsRequired();
            Property(x => x.IdTipCliProv).HasColumnName(@"id_tip_cli_prov").HasColumnType("int").IsRequired();
            Property(x => x.IdPuestoPad).HasColumnName(@"id_puesto_pad").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
