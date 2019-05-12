using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebDictionary.Models
{
    //better to do if models changed
    public class DBInitializer : DropCreateDatabaseIfModelChanges<DriverContext>
    {
        protected override void Seed(DriverContext context)
        {
            context.Drivers.Add(new Driver() { Name = "Alex", LastName = "Smith", ExperienceDriveYear = 2 });
            context.Drivers.Add(new Driver() { Name = "Booker", LastName = "Johnson", ExperienceDriveYear = 3 });
            context.Drivers.Add(new Driver() { Name = "Byrd", LastName = "Williams", ExperienceDriveYear = 1 });
            context.Drivers.Add(new Driver() { Name = "Dolly", LastName = "Brown", ExperienceDriveYear = 2 });
            context.Drivers.Add(new Driver() { Name = "Elmer", LastName = "Davis", ExperienceDriveYear = 5 });

            context.Cars.Add(new Car() { Name = "Mitsubishi RVR", EngineLiter = 2.0f, Power = 160, Transmission = "mechanics", Color = "black" });
            context.Cars.Add(new Car() { Name = "Mercedes-Benz S-Class", EngineLiter = 4.7f, Power = 455, Transmission = "automatic", Color = "black" });
            context.Cars.Add(new Car() { Name = "Subaru OutbackR", EngineLiter = 2.5f, Power = 175, Transmission = "automatic", Color = "green" });
            context.Cars.Add(new Car() { Name = "Lexus LX570", EngineLiter = 5.7f, Power = 367, Transmission = "automatic", Color = "silver" });
            context.Cars.Add(new Car() { Name = "Land Rover Range Rover,", EngineLiter = 4.4f, Power = 340, Transmission = "automatic", Color = "black" });

            base.Seed(context);
        }
    }
}