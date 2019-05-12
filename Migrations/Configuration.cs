namespace WebDictionary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebDictionary.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebDictionary.Models.DriverContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DriverContext context)
        {
            context.Drivers.Add(new Driver() { Name = "Alex", LastName = "Smith", ExperienceDriveYear = 2,
                Car = new Car()
                {
                    Name = "Mitsubishi RVR",
                    EngineLiter = 2.0f,
                    Power = 160,
                    Transmission = "mechanics",
                    Color = "black"
                }
            });
            context.Drivers.Add(new Driver() { Name = "Booker", LastName = "Johnson", ExperienceDriveYear = 3,
                Car = new Car()
                {
                    Name = "Mercedes-Benz S-Class",
                    EngineLiter = 4.7f,
                    Power = 455,
                    Transmission = "automatic",
                    Color = "black"
                }
            });
            context.Drivers.Add(new Driver() { Name = "Byrd", LastName = "Williams", ExperienceDriveYear = 1,
                Car = new Car()
                {
                    Name = "Subaru OutbackR",
                    EngineLiter = 2.5f,
                    Power = 175,
                    Transmission = "automatic",
                    Color = "green"
                }
            });
            context.Drivers.Add(new Driver() { Name = "Dolly", LastName = "Brown", ExperienceDriveYear = 2,
                Car = new Car()
                {
                    Name = "Subaru OutbackR",
                    EngineLiter = 2.5f,
                    Power = 175,
                    Transmission = "automatic",
                    Color = "green"
                }
            });
            context.Drivers.Add(new Driver() { Name = "Elmer", LastName = "Davis", ExperienceDriveYear = 5,
                Car = new Car()
                {
                    Name = "Land Rover Range Rover,",
                    EngineLiter = 4.4f,
                    Power = 340,
                    Transmission = "automatic",
                    Color = "black"
                }
            });
        }
    }
}
