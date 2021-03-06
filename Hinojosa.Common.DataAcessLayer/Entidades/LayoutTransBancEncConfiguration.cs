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

    // layout_trans_banc_enc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class LayoutTransBancEncConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LayoutTransBancEnc>
    {
        public LayoutTransBancEncConfiguration()
            : this("dbo")
        {
        }

        public LayoutTransBancEncConfiguration(string schema)
        {
            ToTable("layout_trans_banc_enc", schema);
            HasKey(x => x.IdLayout);

            Property(x => x.IdLayout).HasColumnName(@"id_layout").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.FecDoc).HasColumnName(@"fec_doc").HasColumnType("datetime").IsRequired();
            Property(x => x.IdMoneda).HasColumnName(@"id_moneda").HasColumnType("int").IsRequired();
            Property(x => x.ImporteTotal).HasColumnName(@"importe_total").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
            Property(x => x.CantTrans).HasColumnName(@"cant_trans").HasColumnType("int").IsRequired();
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CodSatBco).HasColumnName(@"cod_sat_bco").HasColumnType("int").IsRequired();
            Property(x => x.IdLayoutBco).HasColumnName(@"id_layout_bco").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
