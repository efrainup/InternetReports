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

    // com_mov_doc_dir
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ComMovDocDirConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ComMovDocDir>
    {
        public ComMovDocDirConfiguration()
            : this("dbo")
        {
        }

        public ComMovDocDirConfiguration(string schema)
        {
            ToTable("com_mov_doc_dir", schema);
            HasKey(x => x.IdComMovDocDir);

            Property(x => x.IdComMovDocDir).HasColumnName(@"id_com_mov_doc_dir").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Direccion).HasColumnName(@"direccion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Calle).HasColumnName(@"calle").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Noext).HasColumnName(@"noext").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Noint).HasColumnName(@"noint").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Entrecalles).HasColumnName(@"entrecalles").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Colonia).HasColumnName(@"colonia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Delegacion).HasColumnName(@"delegacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ciudad).HasColumnName(@"ciudad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Cp).HasColumnName(@"cp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdPais).HasColumnName(@"id_pais").HasColumnType("int").IsRequired();
            Property(x => x.IdEdo).HasColumnName(@"id_edo").HasColumnType("int").IsRequired();
            Property(x => x.Tel1).HasColumnName(@"tel1").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Tel2).HasColumnName(@"tel2").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.IdDirA).HasColumnName(@"id_dir_a").HasColumnType("int").IsRequired();
            Property(x => x.CDirCli).HasColumnName(@"c_dir_cli").HasColumnType("tinyint").IsRequired();
            Property(x => x.DireccionDoc).HasColumnName(@"direccion_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.CalleDoc).HasColumnName(@"calle_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.NoextDoc).HasColumnName(@"noext_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.NointDoc).HasColumnName(@"noint_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.EntrecallesDoc).HasColumnName(@"entrecalles_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.ColoniaDoc).HasColumnName(@"colonia_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.DelegacionDoc).HasColumnName(@"delegacion_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CiudadDoc).HasColumnName(@"ciudad_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.CpDoc).HasColumnName(@"cp_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdPaisDoc).HasColumnName(@"id_pais_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdEdoDoc).HasColumnName(@"id_edo_doc").HasColumnType("int").IsRequired();
            Property(x => x.Tel1Doc).HasColumnName(@"tel1_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Tel2Doc).HasColumnName(@"tel2_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.IdDirADoc).HasColumnName(@"id_dir_a_doc").HasColumnType("int").IsRequired();
            Property(x => x.CDirCliDoc).HasColumnName(@"c_dir_cli_doc").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
