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

    // SIR_78_REFERENCIAS_OBSERV
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir78ReferenciasObservConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir78ReferenciasObserv>
    {
        public SIR_Sir78ReferenciasObservConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir78ReferenciasObservConfiguration(string schema)
        {
            ToTable("SIR_78_REFERENCIAS_OBSERV", schema);
            HasKey(x => x.NIdReferenciaObs78);

            Property(x => x.NIdReferenciaObs78).HasColumnName(@"nIdReferenciaObs78").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsOptional();
            Property(x => x.SObservacion).HasColumnName(@"sObservacion").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.DFechaCaptura).HasColumnName(@"dFechaCaptura").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsOptional();
            Property(x => x.NIdModulo).HasColumnName(@"nIdModulo").HasColumnType("int").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NIdUsu01).HasColumnName(@"nIdUsu01").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Admina01Usuario).WithMany(b => b.SIR_Sir78ReferenciasObserv).HasForeignKey(c => c.NIdUsu01).WillCascadeOnDelete(false); // FK_SIR_78_REFERENCIAS_OBSERV_ADMINA_01_USUARIOS
            HasOptional(a => a.CatUsr_NIdUsuario).WithMany(b => b.SIR_Sir78ReferenciasObserv_NIdUsuario).HasForeignKey(c => c.NIdUsuario).WillCascadeOnDelete(false); // FK_SIR_78_REFERENCIAS_OBSERV_cat_usr
            HasOptional(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir78ReferenciasObserv).HasForeignKey(c => c.NIdReferencia60); // FK_SIR_78_REFERENCIAS_OBSERV_SIR_60_REFERENCIAS
            HasRequired(a => a.CatUsr_NIdUsuarioEd).WithMany(b => b.SIR_Sir78ReferenciasObserv_NIdUsuarioEd).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_78_REFERENCIAS_OBSERV_cat_usr_ed
        }
    }

}
// </auto-generated>