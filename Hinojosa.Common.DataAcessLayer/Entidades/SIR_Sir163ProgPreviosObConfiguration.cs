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

    // SIR_163_PROG_PREVIOS_OBS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir163ProgPreviosObConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir163ProgPreviosOb>
    {
        public SIR_Sir163ProgPreviosObConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir163ProgPreviosObConfiguration(string schema)
        {
            ToTable("SIR_163_PROG_PREVIOS_OBS", schema);
            HasKey(x => x.NIdPrevObs163);

            Property(x => x.NIdPrevObs163).HasColumnName(@"nIdPrevObs163").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdPrevRef161).HasColumnName(@"nIdPrevRef161").HasColumnType("int").IsRequired();
            Property(x => x.SObservacion).HasColumnName(@"sObservacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsOptional();
            Property(x => x.DAlta).HasColumnName(@"dAlta").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdUsuario01).HasColumnName(@"nIdUsuario01").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Admina01Usuario).WithMany(b => b.SIR_Sir163ProgPreviosOb).HasForeignKey(c => c.NIdUsuario01).WillCascadeOnDelete(false); // FK_SIR_163_PROG_PREVIOS_OBS_ADMINA_01_USUARIOS
            HasOptional(a => a.CatUsr).WithMany(b => b.SIR_Sir163ProgPreviosOb).HasForeignKey(c => c.NIdUsuario).WillCascadeOnDelete(false); // FK_SIR_163_PROG_PREVIOS_OBS_cat_usr_ed
            HasRequired(a => a.SIR_Sir161ProgPreviosRef).WithMany(b => b.SIR_Sir163ProgPreviosOb).HasForeignKey(c => c.NIdPrevRef161).WillCascadeOnDelete(false); // FK_SIR_163_PROG_PREVIOS_OBS_SIR_161_PROG_PREVIOS_REF
        }
    }

}
// </auto-generated>