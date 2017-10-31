using Application.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.EntityConfigurations
{
    class EngineConfiguration : EntityTypeConfiguration<Engine>
    {
        public EngineConfiguration()
        {
            Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasMany(e => e.Trims)
                .WithRequired(t => t.Engine)
                .HasForeignKey(t => t.EngineId);
        }
    }
}
