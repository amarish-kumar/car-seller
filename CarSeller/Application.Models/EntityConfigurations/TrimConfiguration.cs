using Application.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.EntityConfigurations
{
    public class TrimConfiguration : EntityTypeConfiguration<Trim>
    {
        public TrimConfiguration()
        {
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasMany(m => m.Models)
                .WithRequired(t => t.Trim)
                .HasForeignKey(t => t.TrimId);
        }
    }
}
