using Application.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.EntityConfigurations
{
    public class DriveTrainConfiguration : EntityTypeConfiguration<DriveTrain>
    {
        public DriveTrainConfiguration()
        {
            Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
