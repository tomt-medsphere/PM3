using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class InterfaceConfiguration : EntityTypeConfiguration<Interface>
    {
        public InterfaceConfiguration()
        {
            ToTable("Interface");
            HasKey(p => p.InterfaceId);
            Property(p => p.InterfaceId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.Protocol).IsRequired().HasMaxLength(30);
            Property(p => p.Version).IsOptional().HasMaxLength(30);
            Property(p => p.SendingApplication).IsOptional().HasMaxLength(180);
            Property(p => p.SendintFacility).IsOptional().HasMaxLength(180);
            Property(p => p.ReceivingApplication).IsRequired().HasMaxLength(180);
            Property(p => p.ReceivingFacility).IsOptional().HasMaxLength(180);
            Property(p => p.MessageType).IsRequired().HasMaxLength(30);
            Property(p => p.EventType).IsOptional().HasMaxLength(30);
            Property(p => p.FieldSeperator).IsOptional().HasMaxLength(1);
            Property(p => p.ComponentSeperator).IsOptional().HasMaxLength(1);
            Property(p => p.SubComponentSeperator).IsOptional().HasMaxLength(1);
            Property(p => p.EscapeCharacter).IsOptional().HasMaxLength(1);
        }
    }
}
