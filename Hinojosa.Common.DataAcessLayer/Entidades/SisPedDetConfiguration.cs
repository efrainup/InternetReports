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

    // sis_ped_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisPedDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisPedDet>
    {
        public SisPedDetConfiguration()
            : this("dbo")
        {
        }

        public SisPedDetConfiguration(string schema)
        {
            ToTable("sis_ped_det", schema);
            HasKey(x => x.IdDet);

            Property(x => x.IdDet).HasColumnName(@"id_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdPed).HasColumnName(@"id_ped").HasColumnType("int").IsRequired();
            Property(x => x.FracAran).HasColumnName(@"frac_aran").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.ImprtUnitario).HasColumnName(@"imprt_unitario").HasColumnType("decimal").IsRequired().HasPrecision(18,0);
            Property(x => x.ImprtAduana).HasColumnName(@"imprt_aduana").HasColumnType("decimal").IsRequired().HasPrecision(18,0);
            Property(x => x.ImprtPagado).HasColumnName(@"imprt_pagado").HasColumnType("float").IsOptional();
            Property(x => x.FacPreDls).HasColumnName(@"fac_pre_dls").HasColumnType("decimal").IsRequired().HasPrecision(18,0);
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsOptional();
            Property(x => x.CveUdm).HasColumnName(@"cve_udm").HasColumnType("int").IsRequired();
            Property(x => x.TipInf).HasColumnName(@"tip_inf").HasColumnType("int").IsRequired();
            Property(x => x.CveMtdValMerc).HasColumnName(@"cve_mtd_val_merc").HasColumnType("int").IsRequired();
            Property(x => x.CveImprtPais).HasColumnName(@"cve_imprt_pais").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.CveOrgPais).HasColumnName(@"cve_org_pais").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdPedimento).HasColumnName(@"id_pedimento").HasColumnType("int").IsRequired();
            Property(x => x.CveUmt).HasColumnName(@"cve_umt").HasColumnType("int").IsRequired();
            Property(x => x.CantUmt).HasColumnName(@"cant_umt").HasColumnType("float").IsOptional();
        }
    }

}
// </auto-generated>
