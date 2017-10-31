using Application.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.EntityConfigurations
{
    public class MakeConfiguration : EntityTypeConfiguration<Make>
    {
        public MakeConfiguration()
        {
            Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasMany(m => m.Models)
                .WithRequired(t => t.Make)
                .HasForeignKey(t => t.MakeId);
        }
    }
}
