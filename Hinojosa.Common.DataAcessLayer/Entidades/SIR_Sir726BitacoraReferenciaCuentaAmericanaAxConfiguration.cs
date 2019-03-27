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

    // SIR_726_BITACORA_REFERENCIA_CUENTA_AMERICANA_AX
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir726BitacoraReferenciaCuentaAmericanaAxConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir726BitacoraReferenciaCuentaAmericanaAx>
    {
        public SIR_Sir726BitacoraReferenciaCuentaAmericanaAxConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir726BitacoraReferenciaCuentaAmericanaAxConfiguration(string schema)
        {
            ToTable("SIR_726_BITACORA_REFERENCIA_CUENTA_AMERICANA_AX", schema);
            HasKey(x => x.NIdBitacoraRefAx726);

            Property(x => x.NIdBitacoraRefAx726).HasColumnName(@"nIdBitacoraRefAx726").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsOptional();
            Property(x => x.NEstatus).HasColumnName(@"nEstatus").HasColumnType("tinyint").IsOptional();
            Property(x => x.DFechaBloqueo).HasColumnName(@"dFechaBloqueo").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdUsuarioBloqueo01).HasColumnName(@"nIdUsuarioBloqueo01").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsuarioDesbloqueo01).HasColumnName(@"nIdUsuarioDesbloqueo01").HasColumnType("int").IsOptional();
            Property(x => x.DFechaDesbloqueo).HasColumnName(@"dFechaDesbloqueo").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);

            // Foreign keys
            HasOptional(a => a.Admin_Admina01Usuario_NIdUsuarioBloqueo01).WithMany(b => b.SIR_Sir726BitacoraReferenciaCuentaAmericanaAx_NIdUsuarioBloqueo01).HasForeignKey(c => c.NIdUsuarioBloqueo01).WillCascadeOnDelete(false); // FK_SIR_726_BITACORA_CUENTA_AMERICANA_ADMINA_01_USUARIOS_BLOQUEO
            HasOptional(a => a.Admin_Admina01Usuario_NIdUsuarioDesbloqueo01).WithMany(b => b.SIR_Sir726BitacoraReferenciaCuentaAmericanaAx_NIdUsuarioDesbloqueo01).HasForeignKey(c => c.NIdUsuarioDesbloqueo01).WillCascadeOnDelete(false); // FK_SIR_726_BITACORA_CUENTA_AMERICANA_ADMINA_01_USUARIOS_DESBLOQUEO
            HasOptional(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir726BitacoraReferenciaCuentaAmericanaAx).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_726_BITACORA_CUENTA_AMERICANA_SIR_60_REFERENCIAS
        }
    }

}
// </auto-generated>