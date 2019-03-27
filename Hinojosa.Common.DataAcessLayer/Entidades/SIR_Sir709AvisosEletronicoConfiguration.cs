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

    // SIR_709_AVISOS_ELETRONICOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir709AvisosEletronicoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir709AvisosEletronico>
    {
        public SIR_Sir709AvisosEletronicoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir709AvisosEletronicoConfiguration(string schema)
        {
            ToTable("SIR_709_AVISOS_ELETRONICOS", schema);
            HasKey(x => x.NIdAvisoEletronico709);

            Property(x => x.NIdAvisoEletronico709).HasColumnName(@"nIdAvisoEletronico709").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdRem206).HasColumnName(@"nIdRem206").HasColumnType("int").IsRequired();
            Property(x => x.SNumeroAviso).HasColumnName(@"sNumeroAviso").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SPedimento).HasColumnName(@"sPedimento").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BMovimiento).HasColumnName(@"bMovimiento").HasColumnType("bit").IsOptional();
            Property(x => x.NTipo).HasColumnName(@"nTipo").HasColumnType("int").IsOptional();
            Property(x => x.NIdPers02).HasColumnName(@"nIdPers02").HasColumnType("int").IsOptional();
            Property(x => x.SFirma).HasColumnName(@"sFirma").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsOptional();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsOptional();
            Property(x => x.NIdSpaPreVa219).HasColumnName(@"nIdSPAPreVa219").HasColumnType("int").IsOptional();
            Property(x => x.SNombreArchivo).HasColumnName(@"sNombreArchivo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(300);
            Property(x => x.DFirmaAgenteA).HasColumnName(@"dFirmaAgenteA").HasColumnType("bit").IsOptional();
            Property(x => x.SFeaArchivoAviso).HasColumnName(@"sFEAArchivoAviso").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);

            // Foreign keys
            HasOptional(a => a.CatEmp).WithMany(b => b.SIR_Sir709AvisosEletronico).HasForeignKey(c => c.NIdPers02).WillCascadeOnDelete(false); // FK_SIR_709_AVISOS_ELETRONICOS_cat_emp
            HasOptional(a => a.SIR_Sir219SucpataduPrevalidadore).WithMany(b => b.SIR_Sir709AvisosEletronico).HasForeignKey(c => c.NIdSpaPreVa219).WillCascadeOnDelete(false); // FK_SIR_709_AVISOS_ELETRONICOS_SIR_219_SUCPATADU_PREVALIDADORES
            HasOptional(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir709AvisosEletronico).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_709_AVISOS_ELETRONICOS_SIR_60_REFERENCIAS
            HasOptional(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir709AvisosEletronico).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_709_AVISOS_ELETRONICOS_SIR_71_SUCURSALES_PATENTES_ADUANAS
            HasRequired(a => a.SIR_Sir206Remesa).WithMany(b => b.SIR_Sir709AvisosEletronico).HasForeignKey(c => c.NIdRem206).WillCascadeOnDelete(false); // FK_SIR_709_AVISOS_ELETRONICOS_SIR_206_REMESAS
        }
    }

}
// </auto-generated>
