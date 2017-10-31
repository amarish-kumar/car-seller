using Application.Models.Entities;
using System.Data.Entity.ModelConfiguration;

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
