using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class HCPCSRVUConfiguration : EntityTypeConfiguration<HCPCSRVU>
    {
        public HCPCSRVUConfiguration()
        {
            ToTable("HCPCSRVU");
            HasKey(p => p.HCPCSRVUId);
            Property(p => p.HCPCSId).IsRequired().HasMaxLength(5);
            Property(p => p.HCPCSModifierId).IsOptional().HasMaxLength(2);
            Property(p => p.Year).IsRequired();
            Property(p => p.Version).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasColumnType("longtext");
            Property(p => p.Status).IsRequired().HasMaxLength(1);
            Property(p => p.WorkRVU).IsRequired().HasPrecision(18,2);
            Property(p => p.NonFacPracRVU).IsRequired().HasPrecision(18, 2);
            Property(p => p.FacPracRVU).IsRequired().HasPrecision(18, 2);
            Property(p => p.MalpracRVU).IsRequired().HasPrecision(18, 2);
            Property(p => p.PcTc).IsRequired().HasMaxLength(1);
            Property(p => p.GlobalDays).IsRequired().HasMaxLength(3);
            Property(p => p.PreOpPct).IsRequired().HasPrecision(18, 2);
            Property(p => p.IntraOpPct).IsRequired().HasPrecision(18, 2);
            Property(p => p.PostOpPct).IsRequired().HasPrecision(18, 2);
            Property(p => p.MultiProc).IsRequired().HasMaxLength(1);
            Property(p => p.BilatSurg).IsRequired().HasMaxLength(1);
            Property(p => p.AsstSurg).IsRequired().HasMaxLength(1);
            Property(p => p.CoSurg).IsRequired().HasMaxLength(1);
            Property(p => p.TeamSurg).IsRequired().HasMaxLength(1);
            Property(p => p.EndoBase).IsOptional().HasMaxLength(5);
            Property(p => p.CF).IsRequired().HasPrecision(18, 4);
            Property(p => p.Supervision).IsRequired().HasMaxLength(2);
            Property(p => p.CalcFlag).IsRequired().HasMaxLength(1);
            Property(p => p.DxImgFamily).IsRequired().HasMaxLength(2);
            Property(p => p.OPPSNonFacPracExp).IsRequired().HasPrecision(18, 2);
            Property(p => p.OPPSFacPracExp).IsRequired().HasPrecision(18, 2);
            Property(p => p.OPPSMalPracExp).IsRequired().HasPrecision(18, 2);
            Property(p => p.ShortDescription).IsRequired().HasMaxLength(30);
            Property(p => p.MediumDescription).IsRequired().HasMaxLength(60);
            Property(p => p.NOC).IsRequired();

            // parents
            HasRequired(p => p.HCPCS).WithMany(p => p.HCPCSRVUs).HasForeignKey(p => p.HCPCSId).WillCascadeOnDelete(false);
        }
    }
}
