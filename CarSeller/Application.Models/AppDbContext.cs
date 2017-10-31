using Application.Models.Entities;
using Application.Models.EntityConfigurations;
using System.Data.Entity;

namespace Application.Models
{
    class AppDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Trim> Trims { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<DriveTrain> DriveTrains { get; set; }

        public AppDbContext() 
            : base ("name=DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("");
            modelBuilder.Configurations.Add(new DriveTrainConfiguration());
            modelBuilder.Configurations.Add(new EngineConfiguration());
            modelBuilder.Configurations.Add(new FeatureConfiguration());
            modelBuilder.Configurations.Add(new FuelTypeConfiguration());
            modelBuilder.Configurations.Add(new MakeConfiguration());
            modelBuilder.Configurations.Add(new ModelConfiguration());
            modelBuilder.Configurations.Add(new TransmissionConfiguration());
            modelBuilder.Configurations.Add(new TrimConfiguration());
        }
    }
}
