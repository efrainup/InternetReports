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

    // SIR_210_OPERACIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir210OperacioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir210Operacione>
    {
        public SIR_Sir210OperacioneConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir210OperacioneConfiguration(string schema)
        {
            ToTable("SIR_210_OPERACIONES", schema);
            HasKey(x => x.NIdOper210);

            Property(x => x.NIdOper210).HasColumnName(@"nIdOper210").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SPrimerValor).HasColumnName(@"sPrimerValor").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NTipoPrimValor).HasColumnName(@"nTipoPrimValor").HasColumnType("tinyint").IsOptional();
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsOptional();
            Property(x => x.SSegValor).HasColumnName(@"sSegValor").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NTipoSegValor).HasColumnName(@"nTipoSegValor").HasColumnType("tinyint").IsOptional();
            Property(x => x.NIdPrimOperacion210).HasColumnName(@"nIdPrimOperacion210").HasColumnType("int").IsOptional();
            Property(x => x.NIdSegOperacion210).HasColumnName(@"nIdSegOperacion210").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NIdConcepto).HasColumnName(@"nIdConcepto").HasColumnType("int").IsOptional();
            Property(x => x.NIdCriterio212).HasColumnName(@"nIdCriterio212").HasColumnType("int").IsOptional();
            Property(x => x.NTipoCondicion).HasColumnName(@"nTipoCondicion").HasColumnType("tinyint").IsOptional();

            // Foreign keys
            HasOptional(a => a.CatPro).WithMany(b => b.SIR_Sir210Operacione).HasForeignKey(c => c.NIdConcepto).WillCascadeOnDelete(false); // FK_SIR_210_OPERACIONES_cat_pro
            HasOptional(a => a.SIR_Sir210Operacione1).WithMany(b => b.SIR_Sir210Operacione2).HasForeignKey(c => c.NIdPrimOperacion210).WillCascadeOnDelete(false); // FK_SIR_210_OPERACIONES_SIR_210_OPERACIONES_PRIMERA
            HasOptional(a => a.SIR_Sir210Operacione3).WithMany(b => b.SIR_Sir210Operacione4).HasForeignKey(c => c.NIdSegOperacion210).WillCascadeOnDelete(false); // FK_SIR_210_OPERACIONES_SIR_210_OPERACIONES_SEGUNDA
            HasOptional(a => a.SIR_Sir212CriteriosCobro).WithMany(b => b.SIR_Sir210Operacione).HasForeignKey(c => c.NIdCriterio212).WillCascadeOnDelete(false); // FK_SIR_210_OPERACIONES_SIR_212_CRITERIOS_COBRO
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir210Operacione).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_210_OPERACIONES_cat_usr
        }
    }

}
// </auto-generated>