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

    // SIR_639_HORARIOS_ENVIO_PWC
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir639HorariosEnvioPwcConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir639HorariosEnvioPwc>
    {
        public SIR_Sir639HorariosEnvioPwcConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir639HorariosEnvioPwcConfiguration(string schema)
        {
            ToTable("SIR_639_HORARIOS_ENVIO_PWC", schema);
            HasKey(x => x.NIdConfigPwc638);

            Property(x => x.NIdConfigPwc638).HasColumnName(@"nIdConfigPWC638").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NHora).HasColumnName(@"nHora").HasColumnType("smallint").IsOptional();
            Property(x => x.NMinuto).HasColumnName(@"nMinuto").HasColumnType("smallint").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir638ConfiguracionPwc).WithOptional(b => b.SIR_Sir639HorariosEnvioPwc).WillCascadeOnDelete(false); // FK_SIR_639_HORARIOS_ENVIO_PWC_SIR_638_CONFIGURACION_PWC
        }
    }

}
// </auto-generated>
