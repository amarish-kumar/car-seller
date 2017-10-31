using Application.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.EntityConfigurations
{
    public class TransmissionConfiguration : EntityTypeConfiguration<Transmission>
    {
        public TransmissionConfiguration()
        {
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
