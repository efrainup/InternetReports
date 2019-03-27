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

    // SIR_01_PAISES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir01PaisConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir01Pais>
    {
        public SIR_Sir01PaisConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir01PaisConfiguration(string schema)
        {
            ToTable("SIR_01_PAISES", schema);
            HasKey(x => x.NIdPais01);

            Property(x => x.NIdPais01).HasColumnName(@"nIdPais01").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SClavePais).HasColumnName(@"sClavePais").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.SNombrePais).HasColumnName(@"sNombrePais").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.NIdMoneda03).HasColumnName(@"nIdMoneda03").HasColumnType("int").IsOptional();
            Property(x => x.NCodigoPais).HasColumnName(@"nCodigoPais").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.SClaveDos).HasColumnName(@"sClaveDos").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.SNacionalidad).HasColumnName(@"sNacionalidad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NTratado).HasColumnName(@"nTratado").HasColumnType("tinyint").IsRequired();
            Property(x => x.SClaveCaracter).HasColumnName(@"sClaveCaracter").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);

            // Foreign keys
            HasOptional(a => a.SIR_Sir03Moneda).WithMany(b => b.SIR_Sir01Pais).HasForeignKey(c => c.NIdMoneda03).WillCascadeOnDelete(false); // FK_SIR_01_PAISES_SIR_03_MONEDAS
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir01Pais).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_01_PAISES_cat_usr_ed
        }
    }

}
// </auto-generated>