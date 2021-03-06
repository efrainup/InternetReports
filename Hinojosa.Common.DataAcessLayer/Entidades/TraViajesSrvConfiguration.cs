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

    // tra_viajes_srv
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TraViajesSrvConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TraViajesSrv>
    {
        public TraViajesSrvConfiguration()
            : this("dbo")
        {
        }

        public TraViajesSrvConfiguration(string schema)
        {
            ToTable("tra_viajes_srv", schema);
            HasKey(x => x.IdViajeSrv);

            Property(x => x.IdViajeSrv).HasColumnName(@"id_viaje_srv").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdViaje).HasColumnName(@"id_viaje").HasColumnType("int").IsRequired();
            Property(x => x.NoEntrega).HasColumnName(@"no_entrega").HasColumnType("int").IsRequired();
            Property(x => x.NoPart).HasColumnName(@"no_part").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.DesPro).HasColumnName(@"des_pro").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(160);
            Property(x => x.IdCenCto).HasColumnName(@"id_cen_cto").HasColumnType("int").IsRequired();
            Property(x => x.IdAlm).HasColumnName(@"id_alm").HasColumnType("int").IsRequired();
            Property(x => x.IdImpto).HasColumnName(@"id_impto").HasColumnType("int").IsRequired();
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("int").IsRequired();
            Property(x => x.Precio).HasColumnName(@"precio").HasColumnType("float").IsRequired();
            Property(x => x.ImporteSimptos).HasColumnName(@"importe_simptos").HasColumnType("float").IsRequired();
            Property(x => x.Imptos).HasColumnName(@"imptos").HasColumnType("float").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("float").IsRequired();
            Property(x => x.PrecioBse).HasColumnName(@"precio_bse").HasColumnType("float").IsRequired();
            Property(x => x.ImporteSimptosBse).HasColumnName(@"importe_simptos_bse").HasColumnType("float").IsRequired();
            Property(x => x.ImptosBse).HasColumnName(@"imptos_bse").HasColumnType("float").IsRequired();
            Property(x => x.TotalBse).HasColumnName(@"total_bse").HasColumnType("float").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDocDet).HasColumnName(@"id_doc_det").HasColumnType("int").IsRequired();
            Property(x => x.IdCodTra).HasColumnName(@"id_cod_tra").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
