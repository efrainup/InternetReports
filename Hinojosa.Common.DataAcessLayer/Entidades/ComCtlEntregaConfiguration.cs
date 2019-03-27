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

    // com_ctl_entregas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ComCtlEntregaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ComCtlEntrega>
    {
        public ComCtlEntregaConfiguration()
            : this("dbo")
        {
        }

        public ComCtlEntregaConfiguration(string schema)
        {
            ToTable("com_ctl_entregas", schema);
            HasKey(x => x.IdEntrega);

            Property(x => x.IdEntrega).HasColumnName(@"id_entrega").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NoPart).HasColumnName(@"no_part").HasColumnType("int").IsRequired();
            Property(x => x.IdEmbarque).HasColumnName(@"id_embarque").HasColumnType("int").IsRequired();
            Property(x => x.NoEmbarque).HasColumnName(@"no_embarque").HasColumnType("int").IsRequired();
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.CveCli).HasColumnName(@"cve_cli").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.FecRecoleccion).HasColumnName(@"fec_recoleccion").HasColumnType("datetime").IsRequired();
            Property(x => x.FecPrometida).HasColumnName(@"fec_prometida").HasColumnType("datetime").IsRequired();
            Property(x => x.FecEntReal).HasColumnName(@"fec_ent_real").HasColumnType("datetime").IsRequired();
            Property(x => x.Direccion).HasColumnName(@"direccion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.ReqEspecificos).HasColumnName(@"req_especificos").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.SerieDoc).HasColumnName(@"serie_doc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdRelDir).HasColumnName(@"id_rel_dir").HasColumnType("int").IsRequired();
            Property(x => x.CostoBse).HasColumnName(@"costo_bse").HasColumnType("float").IsRequired();
        }
    }

}
// </auto-generated>
