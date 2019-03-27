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

    // sis_obj_rel_notas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisObjRelNotaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<crm_SisObjRelNota>
    {
        public crm_SisObjRelNotaConfiguration()
            : this("crm")
        {
        }

        public crm_SisObjRelNotaConfiguration(string schema)
        {
            ToTable("sis_obj_rel_notas", schema);
            HasKey(x => x.IdObjNota);

            Property(x => x.IdObjNota).HasColumnName(@"id_obj_nota").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdObj).HasColumnName(@"id_obj").HasColumnType("int").IsRequired();
            Property(x => x.IdTbl).HasColumnName(@"id_tbl").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.DFecEve).HasColumnName(@"d_fec_eve").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
