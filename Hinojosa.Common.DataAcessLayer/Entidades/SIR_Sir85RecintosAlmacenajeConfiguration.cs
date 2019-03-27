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

    // SIR_85_RECINTOS_ALMACENAJES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir85RecintosAlmacenajeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir85RecintosAlmacenaje>
    {
        public SIR_Sir85RecintosAlmacenajeConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir85RecintosAlmacenajeConfiguration(string schema)
        {
            ToTable("SIR_85_RECINTOS_ALMACENAJES", schema);
            HasKey(x => x.NIdTarAlmacenaje85);

            Property(x => x.NIdTarAlmacenaje85).HasColumnName(@"nIdTarAlmacenaje85").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdRecinto).HasColumnName(@"nIdRecinto").HasColumnType("int").IsRequired();
            Property(x => x.DFechaPublicacion).HasColumnName(@"dFechaPublicacion").HasColumnType("datetime").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NPrimPlazoCs).HasColumnName(@"nPrimPlazoCS").HasColumnType("decimal").IsOptional().HasPrecision(5,2);
            Property(x => x.NSegPlazoCs).HasColumnName(@"nSegPlazoCS").HasColumnType("decimal").IsOptional().HasPrecision(5,2);
            Property(x => x.NTercPlazoCs).HasColumnName(@"nTercPlazoCS").HasColumnType("decimal").IsOptional().HasPrecision(5,2);
            Property(x => x.NPrimPlazoCont).HasColumnName(@"nPrimPlazoCont").HasColumnType("decimal").IsOptional().HasPrecision(5,2);
            Property(x => x.NSegPlazoCont).HasColumnName(@"nSegPlazoCont").HasColumnType("decimal").IsOptional().HasPrecision(5,2);
            Property(x => x.NTercPlazoCont).HasColumnName(@"nTercPlazoCont").HasColumnType("decimal").IsOptional().HasPrecision(5,2);

            // Foreign keys
            HasRequired(a => a.CatProv).WithMany(b => b.SIR_Sir85RecintosAlmacenaje).HasForeignKey(c => c.NIdRecinto).WillCascadeOnDelete(false); // FK_SIR_85_RECINTOS_ALMACENAJES_cat_prov
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir85RecintosAlmacenaje).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_85_RECINTOS_ALMACENAJES_cat_usr_ed
        }
    }

}
// </auto-generated>