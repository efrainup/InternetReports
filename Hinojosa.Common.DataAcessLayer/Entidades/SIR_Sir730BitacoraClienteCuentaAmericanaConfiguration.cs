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

    // SIR_730_BITACORA_CLIENTE_CUENTA_AMERICANA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir730BitacoraClienteCuentaAmericanaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir730BitacoraClienteCuentaAmericana>
    {
        public SIR_Sir730BitacoraClienteCuentaAmericanaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir730BitacoraClienteCuentaAmericanaConfiguration(string schema)
        {
            ToTable("SIR_730_BITACORA_CLIENTE_CUENTA_AMERICANA", schema);
            HasKey(x => x.NIdBitacoraClienteCa730);

            Property(x => x.NIdBitacoraClienteCa730).HasColumnName(@"nIdBitacoraClienteCA730").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdClie07).HasColumnName(@"nIdClie07").HasColumnType("int").IsOptional();
            Property(x => x.BDeshabilitaValidacionCa).HasColumnName(@"bDeshabilitaValidacionCA").HasColumnType("bit").IsOptional();
            Property(x => x.NIdUsuarioEdicion).HasColumnName(@"nIdUsuarioEdicion").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
        }
    }

}
// </auto-generated>