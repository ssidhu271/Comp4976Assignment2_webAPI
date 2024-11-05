using System;
using Microsoft.EntityFrameworkCore;
using ExoticCarsAPI.Models;
using ExoticCarsAPI.Utility;

namespace ExoticCarsAPI.Data;

public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public static void SeedData(IServiceProvider serviceProvider)
        {
            using (var context = serviceProvider.GetRequiredService<ApplicationDbContext>())
            {
                // Ensure the database is created
                context.Database.EnsureCreated();

                // Seed data only if no data exists
                if (!context.Cars.Any())
                {
                    
                    context.Cars.AddRange(
                        new Car
                        {
                            Name = "Ferrari LaFerrari",
                            Description = "A hybrid sports car with high performance.",
                            Countries = new List<string> { "Italy", "USA" },
                            Image = ImageHelper.ConvertImageToBase64("wwwroot/Images/Ferrari_LaFerrari.png"),
                            Cost = 1400000m
                        },
                        new Car
                        {
                            Name = "Lamborghini Aventador",
                            Description = "A flagship V12-powered sports car.",
                            Countries = new List<string> { "Italy" },
                            Image = ImageHelper.ConvertImageToBase64("wwwroot/Images/Lamborghini_Aventador.png"),
                            Cost = 393695m
                        },
                            new Car
                        {
                            Name = "Bugatti Chiron",
                            Description = "An engineering masterpiece with a top speed over 300 mph.",
                            Countries = new List<string> { "France", "Germany" },
                            Image = ImageHelper.ConvertImageToBase64("wwwroot/Images/Bugatti_Chiron.png"),
                            Cost = 3000000m
                        },
                        new Car
                        {
                            Name = "Porsche 918 Spyder",
                            Description = "A plug-in hybrid supercar with impressive electric power.",
                            Countries = new List<string> { "Germany", "USA" },
                            Image = ImageHelper.ConvertImageToBase64("wwwroot/Images/Porsche_918_Spyder.png"),
                            Cost = 845000m
                        },
                        new Car
                        {
                            Name = "McLaren P1",
                            Description = "A rare and innovative hybrid hypercar from McLaren.",
                            Countries = new List<string> { "UK" },
                            Image = ImageHelper.ConvertImageToBase64("wwwroot/Images/McLaren_P1.png"),
                            Cost = 1150000m
                        },
                        new Car
                        {
                            Name = "Pagani Huayra",
                            Description = "An artistic blend of speed and luxury, known for its bespoke design.",
                            Countries = new List<string> { "Italy" },
                            Image = ImageHelper.ConvertImageToBase64("wwwroot/Images/Pagani_Huayra.png"),
                            Cost = 2600000m
                        },
                        new Car
                        {
                            Name = "Aston Martin Valkyrie",
                            Description = "A cutting-edge hypercar with F1-inspired design and performance.",
                            Countries = new List<string> { "UK" },
                            Image = ImageHelper.ConvertImageToBase64("wwwroot/Images/Aston_Martin_Valkyrie.png"),
                            Cost = 3000000m
                        },
                        new Car
                        {
                            Name = "Koenigsegg Jesko",
                            Description = "A Swedish hypercar designed for high-speed stability and power.",
                            Countries = new List<string> { "Sweden" },
                            Image = ImageHelper.ConvertImageToBase64("wwwroot/Images/Koenigsegg_Jesko.png"),
                            Cost = 3000000m
                        },
                        new Car
                        {
                            Name = "Rimac C_Two",
                            Description = "An all-electric hypercar with cutting-edge technology and performance.",
                            Countries = new List<string> { "Croatia" },
                            Image = ImageHelper.ConvertImageToBase64("wwwroot/Images/Rimac_C_Two.png"),
                            Cost = 2000000m
                        },
                        new Car
                        {
                            Name = "Mercedes-AMG One",
                            Description = "A high-performance car with F1-derived technology for the road.",
                            Countries = new List<string> { "Germany" },
                            Image = ImageHelper.ConvertImageToBase64("wwwroot/Images/Mercedes_AMG_One.png"),
                            Cost = 2700000m
                        }
                    );

                    context.SaveChanges();
                }
            }
        }
    }
