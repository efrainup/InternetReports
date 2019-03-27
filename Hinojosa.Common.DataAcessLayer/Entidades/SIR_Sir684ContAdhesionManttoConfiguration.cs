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

    // SIR_684_CONT_ADHESION_MANTTO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir684ContAdhesionManttoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir684ContAdhesionMantto>
    {
        public SIR_Sir684ContAdhesionManttoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir684ContAdhesionManttoConfiguration(string schema)
        {
            ToTable("SIR_684_CONT_ADHESION_MANTTO", schema);
            HasKey(x => x.NIdContAdhesion684);

            Property(x => x.NIdContAdhesion684).HasColumnName(@"nIdContAdhesion684").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdUsu01).HasColumnName(@"nIdUsu01").HasColumnType("int").IsOptional();
            Property(x => x.SNombreUsu).HasColumnName(@"sNombreUsu").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.BAcepta).HasColumnName(@"bAcepta").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.IArchivoCont).HasColumnName(@"iArchivoCont").HasColumnType("image").IsRequired().HasMaxLength(2147483647);
            Property(x => x.SNombreArchivo).HasColumnName(@"sNombreArchivo").HasColumnType("varbinary(max)").IsRequired();
            Property(x => x.SFechaLib).HasColumnName(@"sFechaLib").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.DFechaInicia).HasColumnName(@"dFechaInicia").HasColumnType("varbinary(max)").IsOptional();
        }
    }

}
// </auto-generated>
