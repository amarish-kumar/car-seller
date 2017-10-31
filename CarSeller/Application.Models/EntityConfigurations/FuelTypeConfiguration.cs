using Application.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.EntityConfigurations
{
    class FuelTypeConfiguration : EntityTypeConfiguration<FuelType>
    {
        public FuelTypeConfiguration()
        {
            Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasMany(f => f.Models)
                .WithRequired(m => m.FuelType)
                .HasForeignKey(m => m.FuelTypeId);
        }
    }
}
