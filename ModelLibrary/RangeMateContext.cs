using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
	
  //  class RangeMateContext : DbContext
  //  {
  //      public DbSet<User> User { get; set; }
  //      public DbSet<Manufacturer> Manufacturer { get; set; }
  //      public DbSet<Model> Models { get; set; }
  //      public DbSet<Engine> Engine { get; set; }
  //      public DbSet<ElectricMotor> ElectricMotor { get; set; }
  //      public DbSet<EconomyReportElectric> EconomyReportElectric { get; set; }
  //      public DbSet<EconomyReportICE> EconomyReportICE { get; set; }
  //      public DbSet<Comment> Comment { get; set; }

  //      public RangeMateContext(DbContextOptions<RangeMateContext> options) : base(options)
  //      {

		//}

		/**
		 * Create Initial database
		 * 
		 dotnet ef migrations add InitialCreate
		 dotnet ef database update
		 **/
		/*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User()
            {
                FirstName = "Admin",
                LastName = "Adminson",
                Email = "Admin@live.dk",
                Password = BCrypt.Net.BCrypt.HashPassword("password"),
                AccountCreation = DateTime.Now,
                Is_Active = true,
                Is_Administrator = true
            },
                new User()
            {
                FirstName = "Hans",
                LastName = "Hansen",
                Email = "HH@live.dk",
                Password = BCrypt.Net.BCrypt.HashPassword("password"),
                AccountCreation = DateTime.Now,
                Is_Active = true,
                Is_Administrator = false
            }
                );

            modelBuilder.Entity<Manufacturer>().HasData(
			 new Manufacturer()
			 {
				 Id = 1,
				 Name = "Acura",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 2,
				 Name = "Alfa Romeo",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 3,
				 Name = "Aston Martin",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 4,
				 Name = "Audi",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 5,
				 Name = "Bentley",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 6,
				 Name = "BMW",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 7,
				 Name = "Brilliance",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 8,
				 Name = "Bugatti",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 9,
				 Name = "Buick",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 10,
				 Name = "BYD",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 11,
				 Name = "Cadillac",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 12,
				 Name = "Changan",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 13,
				 Name = "Chery",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 14,
				 Name = "Chevrolet",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 15,
				 Name = "Chrysler",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 16,
				 Name = "Citroen",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 17,
				 Name = "Daewoo",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 18,
				 Name = "Daihatsu",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 19,
				 Name = "Datsun",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 20,
				 Name = "Dodge",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 21,
				 Name = "Dongfeng",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 22,
				 Name = "FAW",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 23,
				 Name = "Ferrari",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 24,
				 Name = "Fiat",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 25,
				 Name = "Fisker",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 26,
				 Name = "Ford",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 27,
				 Name = "GAZ",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 28,
				 Name = "Geely",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 29,
				 Name = "Genesis",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 30,
				 Name = "GMC",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 31,
				 Name = "Great Wall",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 32,
				 Name = "Haval",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 33,
				 Name = "Holden",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 34,
				 Name = "Honda",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 35,
				 Name = "Hummer",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 36,
				 Name = "Hyundai",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 37,
				 Name = "Infiniti",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 38,
				 Name = "Isuzu",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 39,
				 Name = "Iveco",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 40,
				 Name = "Jaguar",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 41,
				 Name = "Jeep",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 42,
				 Name = "Kia",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 43,
				 Name = "Lamborghini",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 44,
				 Name = "Lancia",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 45,
				 Name = "Land Rover",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 46,
				 Name = "Lexus",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 47,
				 Name = "Lifan",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 48,
				 Name = "Lincoln",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 49,
				 Name = "Lotus",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 50,
				 Name = "Marussia",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 51,
				 Name = "Maserati",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 52,
				 Name = "Maybach",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 53,
				 Name = "Mazda",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 54,
				 Name = "McLaren",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 55,
				 Name = "Mercedes",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 56,
				 Name = "Mercury",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 57,
				 Name = "MG",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 58,
				 Name = "Mini",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 59,
				 Name = "Mitsubishi",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 60,
				 Name = "Nissan",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 61,
				 Name = "Noble",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 62,
				 Name = "Opel",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 63,
				 Name = "Peugeot",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 64,
				 Name = "Plymouth",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 65,
				 Name = "Pontiac",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 66,
				 Name = "Porsche",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 67,
				 Name = "Ravon",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 68,
				 Name = "Renault",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 69,
				 Name = "Rolls-Royce",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 70,
				 Name = "Rover",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 71,
				 Name = "Saab",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 72,
				 Name = "Saturn",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 73,
				 Name = "Scion",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 74,
				 Name = "Seat",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 75,
				 Name = "Skoda",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 76,
				 Name = "Smart",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 77,
				 Name = "Ssang Yong",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 78,
				 Name = "Subaru",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 79,
				 Name = "Suzuki",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 80,
				 Name = "Tesla",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 81,
				 Name = "Toyota",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 82,
				 Name = "UAZ",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 83,
				 Name = "VAZ",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 84,
				 Name = "Volkswagen",
				 Is_Active = true
			 },
			 new Manufacturer()
			 {
				 Id = 85,
				 Name = "Volvo",
				 Is_Active = true
			 }
				);

			modelBuilder.Entity<Model>().HasData(
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "EL",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "ILX",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "Integra",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "MDX",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "NSX",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "RDX",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "RL",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "RLX",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "RSX",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "TL",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "TLX",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "TSX",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 1,
				ModelName = "ZDX",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "146",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "147",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "147 GTA",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "156",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "156 GTA",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "159",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "166",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "4C",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "8C Competizione",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "Brera",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "Giulia",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "Giulietta",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "GT",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "GTV",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "MiTo",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "Spider",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 2,
				ModelName = "Stelvio",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "Cygnet",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "DB11",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "DB9",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "DBS",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "DBS Violante",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "DBX",
				Year = 2020,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "Rapide",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "V12 Vantage",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "V8 Vantage",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "Valkyrie",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "Vanquish",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "Virage",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 3,
				ModelName = "Zagato Coupe",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "A1",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "A2",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "A3",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "A4",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "A4 Allroad Quattro",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "A5",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "A6",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "A7",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "A8",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "Allroad",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "E-Tron",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "Q2",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "Q3",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "Q5",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "Q7",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "Q8",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "R8",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "RS Q3",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "RS3",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "RS4",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "RS5",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "RS6",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "RS7",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "S3",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "S4",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "S5",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "S6",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "S7",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "S8",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "SQ2",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "SQ5",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "SQ7",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "SQ8",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "TT",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "TT RS",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 4,
				ModelName = "TTS",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 5,
				ModelName = "Arnage",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 5,
				ModelName = "Azure",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 5,
				ModelName = "Bentayga",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 5,
				ModelName = "Brooklands",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 5,
				ModelName = "Continental",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 5,
				ModelName = "Continental Flying Spur",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 5,
				ModelName = "Continental GT",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 5,
				ModelName = "Flying Spur",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 5,
				ModelName = "Mulsanne",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "1 series",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "2 series",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "3 series",
				Year = 1982,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "4 series",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "5 series",
				Year = 1988,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "6 series",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "7 series",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "8 series",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "i3",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "i8",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "M2",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "M3",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "M4",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "M5",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "M6",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "X1",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "X2",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "X3",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "X3 M",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "X4",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "X4 M",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "X5",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "X5 M",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "X6",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "X6 M",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "X7",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "Z3",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "Z4",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 6,
				ModelName = "Z8",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 7,
				ModelName = "H230",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 7,
				ModelName = "V3",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 7,
				ModelName = "V5",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 8,
				ModelName = "Veyron",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "Century",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "Enclave",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "Envision",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "La Crosse",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "Le Sabre",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "Lucerne",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "Park Avenue",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "Rainier",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "Regal",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "Rendezvouz",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "Terraza",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 9,
				ModelName = "Verano",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 10,
				ModelName = "Qin",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "ATS",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "ATS-V",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "BLS",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "CT6",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "CTS",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "De Ville",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "DTS",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "Eldorado",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "ELR",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "Escalade",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "Seville",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "SRX",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "STS",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "XLR",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "XT4",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "XT5",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "XT6",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 11,
				ModelName = "XTS",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 12,
				ModelName = "CS35",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 12,
				ModelName = "CS35 Plus",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 12,
				ModelName = "CS55",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 12,
				ModelName = "CS75",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 12,
				ModelName = "CS95",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 12,
				ModelName = "Eado",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 12,
				ModelName = "Raeton",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Amulet",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Arrizo 7",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Bonus",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Bonus 3",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "CrossEastar",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Eastar",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Fora",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "IndiS",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Kimo",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "M11",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "QQ",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "QQ6",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Tiggo",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Tiggo 3",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Tiggo 4",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Tiggo 5",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Tiggo 7",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Tiggo 8",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 13,
				ModelName = "Very",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Astro",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Avalanche",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Aveo",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Blazer",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Camaro",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Captiva",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Cavalier",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Cobalt",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Colorado",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Corvette",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Cruze",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Epica",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Equinox",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Express",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "HHR",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Impala",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Lacetti",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Lanos",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Malibu",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Monte Carlo",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Niva",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Orlando",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Rezzo",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Silverado",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Silverado 2500 HD",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Spark",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "SSR",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Suburban",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Tahoe",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "TrailBlazer",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Traverse",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Trax",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Uplander",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 14,
				ModelName = "Venture",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "200",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "300",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "300M",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "Aspen",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "Concorde",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "Crossfire",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "Grand Voyager",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "Pacifica",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "PT Cruiser",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "Sebring",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "Town & Country",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 15,
				ModelName = "Voyager",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "Berlingo",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C-Crosser",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C-Elysee",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C1",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C2",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C3",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C3 Aircross",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C3 Picasso",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C3 Pluriel",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C4",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C4 Aircross",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C4 Cactus",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C4 Picasso",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C5",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C6",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "C8",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "DS 7 Crossback",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "DS3",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "DS4",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "DS5",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "Grand C4 Picasso",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "Jumpy",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "Nemo",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "Saxo",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "Spacetourer",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "Xsara",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 16,
				ModelName = "Xsara Picasso",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 17,
				ModelName = "Evanda",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 17,
				ModelName = "Kalos",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 17,
				ModelName = "Leganza",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 17,
				ModelName = "Magnus",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 17,
				ModelName = "Matiz",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 17,
				ModelName = "Nexia",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 17,
				ModelName = "Nubira",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Applause",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Cast",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Copen",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Cuore",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Gran Move",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Luxio",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Materia",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Mebius",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Move",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Rocky",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Sirion",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Terios",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "Trevis",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 18,
				ModelName = "YRV",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 19,
				ModelName = "mi-DO",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 19,
				ModelName = "on-DO",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Avenger",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Caliber",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Caliber SRT4",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Caravan",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Challenger",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Charger",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Dakota",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Dart",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Durango",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Intrepid",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Journey",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Magnum",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Neon",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Nitro",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Ram 1500",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Ram 2500",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Ram 3500",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Ram SRT10",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Stratus",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 20,
				ModelName = "Viper",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 21,
				ModelName = "580",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 21,
				ModelName = "A30",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 21,
				ModelName = "AX7",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 21,
				ModelName = "H30 Cross",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 22,
				ModelName = "Besturn B30",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 22,
				ModelName = "Besturn B50",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 22,
				ModelName = "Besturn X40",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 22,
				ModelName = "Besturn X80",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 22,
				ModelName = "Oley",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 22,
				ModelName = "Vita",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "348",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "360",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "456",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "458",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "488",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "512",
				Year = 1991,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "550",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "575 M",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "599 GTB Fiorano",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "599 GTO",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "612",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "812",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "California",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "California T",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "Challenge Stradale",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "Enzo",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "F12",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "F355",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "F430",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "F50",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "F512 M",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "FF",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "GTC4 Lusso",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 23,
				ModelName = "LaFerrari",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "124 Spider",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "500",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "500L",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "500X",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Albea",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Brava",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Bravo",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Coupe",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Croma",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Doblo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Ducato",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Freemont",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Grande Punto",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Idea",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Linea",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Marea",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Multipla",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Palio",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Panda",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Panda 4x4",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Punto",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Qubo",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Sedici",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Siena",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Stilo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Strada",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Tipo",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 24,
				ModelName = "Ulysse",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 25,
				ModelName = "Karma",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "B-Max",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "C-Max",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Cougar",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Crown Victoria",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "EcoSport",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Edge",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Escape",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Excursion",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Expedition",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Explorer",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Explorer Sport Trac",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "F-150",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "F-250",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "F-350",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Falcon",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Fiesta",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Five Hundred",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Flex",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Focus",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Focus Active",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Freestar",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Freestyle",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Fusion",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Galaxy",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Ka",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Kuga",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Maverick",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Mondeo",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Mustang",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Mustang Shelby GT350",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Mustang Shelby GT500",
				Year = 2020,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Puma",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Ranger",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "S-Max",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Taurus",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Taurus X",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Thunderbird",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Tourneo Connect",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Transit",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 26,
				ModelName = "Transit Connect",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 27,
				ModelName = "3102",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 27,
				ModelName = "31105",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 27,
				ModelName = "Siber",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 27,
				ModelName = "Sobol",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 28,
				ModelName = "Atlas",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 28,
				ModelName = "Coolray",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 28,
				ModelName = "Emgrand 7",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 28,
				ModelName = "Emgrand EC7",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 28,
				ModelName = "Emgrand GS",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 28,
				ModelName = "Emgrand X7",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 28,
				ModelName = "GC9",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 28,
				ModelName = "GС6",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 28,
				ModelName = "MK",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 28,
				ModelName = "Otaka",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 28,
				ModelName = "Vision",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 29,
				ModelName = "G70",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 29,
				ModelName = "G80",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 29,
				ModelName = "G90",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 30,
				ModelName = "Acadia",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 30,
				ModelName = "Canyon",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 30,
				ModelName = "Envoy",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 30,
				ModelName = "Sierra 1500",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 30,
				ModelName = "Sierra 2500",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 30,
				ModelName = "Terrain",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 30,
				ModelName = "Yukon",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 31,
				ModelName = "Cowry",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 31,
				ModelName = "Deer",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 31,
				ModelName = "Hover",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 31,
				ModelName = "Hover M2",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 31,
				ModelName = "Pegasus",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 31,
				ModelName = "Peri",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 31,
				ModelName = "Safe",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 31,
				ModelName = "Sailor",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 31,
				ModelName = "Sing",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 31,
				ModelName = "Socool",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 31,
				ModelName = "Wingle",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 32,
				ModelName = "F7",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 32,
				ModelName = "H4",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 32,
				ModelName = "H6",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 32,
				ModelName = "H9",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 33,
				ModelName = "Commodore",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Accord",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Amaze",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "City",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Civic",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "CR-V",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "CR-Z",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Crosstour",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Element",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Fit",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "FR-V",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "HR-V",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "HR-V II (GJ)",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Insight",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Jade",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Jazz",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Legend",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Odyssey",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Pilot",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Prelude",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Ridgeline",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "S2000",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Shuttle",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Stream",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 34,
				ModelName = "Vezel",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 35,
				ModelName = "H1",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 35,
				ModelName = "H2",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 35,
				ModelName = "H3",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Accent",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Atos Prime",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Azera",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Centennial",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Creta",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Elantra",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Entourage",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Eon",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Equus",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Galloper",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Genesis",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Genesis Coupe",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Getz",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Grandeur",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "H-1",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "i10",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "i20",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "i30",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "i30 N",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "i40",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Ioniq",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "ix20",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "ix35",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Kona",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Matrix",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Palisade",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Porter",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Santa Fe",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Solaris",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Sonata",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Terracan",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Trajet",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Tucson",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Veloster",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Veracruz",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Verna",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "Xcent",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 36,
				ModelName = "XG",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "EX",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "FX",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "G",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "I35",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "JX",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "M",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "Q30",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "Q40",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "Q45",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "Q50",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "Q60",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "Q70",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "QX30",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "QX4",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "QX50",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "QX56",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "QX60",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "QX70",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 37,
				ModelName = "QX80",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 38,
				ModelName = "Ascender",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 38,
				ModelName = "Axiom",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 38,
				ModelName = "D-Max",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 38,
				ModelName = "D-Max Rodeo",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 38,
				ModelName = "I280",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 38,
				ModelName = "I290",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 38,
				ModelName = "I350",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 38,
				ModelName = "I370",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 38,
				ModelName = "Rodeo",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 38,
				ModelName = "Trooper",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 38,
				ModelName = "VehiCross",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 39,
				ModelName = "Daily",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 40,
				ModelName = "E-Pace",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 40,
				ModelName = "F-Pace",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 40,
				ModelName = "F-Type",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 40,
				ModelName = "I-Pace",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 40,
				ModelName = "S-Type",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 40,
				ModelName = "X-Type",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 40,
				ModelName = "XE",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 40,
				ModelName = "XF",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 40,
				ModelName = "XJ",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 40,
				ModelName = "XK/XKR",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 41,
				ModelName = "Cherokee",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 41,
				ModelName = "Commander",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 41,
				ModelName = "Compass",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 41,
				ModelName = "Gladiator",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 41,
				ModelName = "Grand Cherokee",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 41,
				ModelName = "Liberty",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 41,
				ModelName = "Patriot",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 41,
				ModelName = "Renegade",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 41,
				ModelName = "Wrangler",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Carens",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Carnival",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Ceed",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Cerato",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Clarus",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Forte",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "K900",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Magentis",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Mohave",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Niro",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Opirus",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Optima",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Picanto",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "ProCeed",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Quoris",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Ray",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Rio",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Rio X-Line",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Seltos",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Shuma",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Sorento",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Sorento Prime",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Soul",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Spectra",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Sportage",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Stinger",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Stonic",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Telluride",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 42,
				ModelName = "Venga",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 43,
				ModelName = "Aventador",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 43,
				ModelName = "Centenario",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 43,
				ModelName = "Diablo",
				Year = 1991,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 43,
				ModelName = "Gallardo",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 43,
				ModelName = "Huracan",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 43,
				ModelName = "Murcielago",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 43,
				ModelName = "Reventon",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 43,
				ModelName = "Urus",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 44,
				ModelName = "Delta",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 44,
				ModelName = "Lybra",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 44,
				ModelName = "Musa",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 44,
				ModelName = "Phedra",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 44,
				ModelName = "Thema",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 44,
				ModelName = "Thesis",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 44,
				ModelName = "Ypsilon",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 45,
				ModelName = "Defender",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 45,
				ModelName = "Discovery",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 45,
				ModelName = "Discovery Sport",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 45,
				ModelName = "Evoque",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 45,
				ModelName = "Freelander",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 45,
				ModelName = "Range Rover",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 45,
				ModelName = "Range Rover Sport",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 45,
				ModelName = "Range Rover Velar",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "CT",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "ES",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "GS",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "GX",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "HS",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "IS",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "LC",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "LFA",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "LS",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "LX",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "NX",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "RC",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "RX",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "SC",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 46,
				ModelName = "UX",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 47,
				ModelName = "Breez",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 47,
				ModelName = "Cebrium",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 47,
				ModelName = "Celliya",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 47,
				ModelName = "Smily",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 47,
				ModelName = "Solano",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 47,
				ModelName = "X50",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 47,
				ModelName = "X60",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 48,
				ModelName = "Aviator",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 48,
				ModelName = "Corsair",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 48,
				ModelName = "Mark LT",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 48,
				ModelName = "MKC",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 48,
				ModelName = "MKS",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 48,
				ModelName = "MKT",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 48,
				ModelName = "MKX",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 48,
				ModelName = "MKZ",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 48,
				ModelName = "Navigator",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 48,
				ModelName = "Town Car",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 48,
				ModelName = "Zephyr",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 49,
				ModelName = "Elise",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 49,
				ModelName = "Europa S",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 49,
				ModelName = "Evora",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 49,
				ModelName = "Exige",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 50,
				ModelName = "B1",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 50,
				ModelName = "B2",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 51,
				ModelName = "3200 GT",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 51,
				ModelName = "Ghibli",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 51,
				ModelName = "Gran Cabrio",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 51,
				ModelName = "Gran Turismo",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 51,
				ModelName = "Gran Turismo S",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 51,
				ModelName = "Levante",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 51,
				ModelName = "Quattroporte",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 51,
				ModelName = "Quattroporte S",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 52,
				ModelName = "57",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 52,
				ModelName = "57 S",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 52,
				ModelName = "62",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 52,
				ModelName = "62 S",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 52,
				ModelName = "Landaulet",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "2",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "3",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "323",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "5",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "6",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "626",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "B-Series",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "BT-50",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "CX-3",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "CX-5",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "CX-7",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "CX-9",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "MPV",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "MX-5",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "Premacy",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "RX-7",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "RX-8",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 53,
				ModelName = "Tribute",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 54,
				ModelName = "540C",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 54,
				ModelName = "570S",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 54,
				ModelName = "600LT",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 54,
				ModelName = "650S",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 54,
				ModelName = "675LT",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 54,
				ModelName = "720S",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 54,
				ModelName = "MP4-12C",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 54,
				ModelName = "P1",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "A-class",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "AMG GT",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "AMG GT 4-Door",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "B-class",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "C-class",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "C-class Sport Coupe",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "CL-class",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "CLA-class",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "CLC-class",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "CLK-class",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "CLS-class",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "E-class",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "E-class Coupe",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "EQC",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "G-class",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "GL-class",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "GLA-class",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "GLB-class",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "GLC-class",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "GLC-class Coupe",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "GLE-class",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "GLE-class Coupe",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "GLK-class",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "GLS-class",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "M-class",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "R-class",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "S-class",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "S-class Cabrio",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "S-class Coupe",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "SL-class",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "SLK-class",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "SLR-class",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "SLS AMG",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "Sprinter",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "Vaneo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "Viano",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "Vito",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 55,
				ModelName = "X-class",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 56,
				ModelName = "Grand Marquis",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 56,
				ModelName = "Mariner",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 56,
				ModelName = "Milan",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 56,
				ModelName = "Montego",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 56,
				ModelName = "Monterey",
				Year = 1991,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 56,
				ModelName = "Mountaineer",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 56,
				ModelName = "Sable",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 57,
				ModelName = "TF",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 57,
				ModelName = "XPower SV",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 57,
				ModelName = "ZR",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 57,
				ModelName = "ZS",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 57,
				ModelName = "ZT",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 57,
				ModelName = "ZT-T",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 58,
				ModelName = "Clubman",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 58,
				ModelName = "Clubman S",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 58,
				ModelName = "Clubvan",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 58,
				ModelName = "Cooper",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 58,
				ModelName = "Cooper Cabrio",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 58,
				ModelName = "Cooper S",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 58,
				ModelName = "Cooper S Cabrio",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 58,
				ModelName = "Cooper S Countryman All4",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 58,
				ModelName = "Countryman",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 58,
				ModelName = "One",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "3000 GT",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "ASX",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Carisma",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Colt",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Dignity",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Eclipse",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Eclipse Cross",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Endeavor",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Galant",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Grandis",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "i-MiEV",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "L200",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Lancer",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Lancer Evo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Mirage",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Outlander",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Outlander XL",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Pajero",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Pajero Pinin",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Pajero Sport",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Raider",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Space Gear",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Space Runner",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 59,
				ModelName = "Space Star",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "350Z",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "370Z",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Almera",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Almera Classic",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Almera Tino",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Altima",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Armada",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Bluebird Sylphy",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "GT-R",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Juke",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Leaf",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Maxima",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Micra",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Murano",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Navara",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Note",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "NP300",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Pathfinder",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Patrol",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Primera",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Qashqai",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Qashqai+2",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Quest",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Rogue",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Sentra",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Skyline",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Sylphy",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Teana",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Terrano",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Tiida",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Titan",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Titan XD",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "X-Trail",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "XTerra",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 60,
				ModelName = "Z",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 61,
				ModelName = "M600",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Adam",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Agila",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Antara",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Astra",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Astra GTS",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Cascada",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Combo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Corsa",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Corsa OPC",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Crossland X",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Frontera",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Grandland X",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Insignia",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Insignia OPC",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Karl",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Meriva",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Mokka",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Omega",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Signum",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Speedster",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Tigra",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Vectra",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Vivaro",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Zafira",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 62,
				ModelName = "Zafira Tourer",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "1007",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "107",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "108",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "2008",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "206",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "207",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "208",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "3008",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "301",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "307",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "308",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "4007",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "4008",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "406",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "407",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "408",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "5008",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "508",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "607",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "807",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "Boxer",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "Partner",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 63,
				ModelName = "RCZ Sport",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 64,
				ModelName = "Road Runner",
				Year = 1968,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "Aztec",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "Bonneville",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "Firebird",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "G5 Pursuit",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "G6",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "G8",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "Grand AM",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "Grand Prix",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "GTO",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "Montana",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "Solstice",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "Sunfire",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "Torrent",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 65,
				ModelName = "Vibe",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 66,
				ModelName = "718 Boxster",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 66,
				ModelName = "718 Cayman",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 66,
				ModelName = "911",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 66,
				ModelName = "Boxster",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 66,
				ModelName = "Cayenne",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 66,
				ModelName = "Cayman",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 66,
				ModelName = "Macan",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 66,
				ModelName = "Panamera",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 66,
				ModelName = "Taycan",
				Year = 2020,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 67,
				ModelName = "Gentra",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Arkana",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Avantime",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Captur",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Clio",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Duster",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Duster Oroch",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Espace",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Fluence",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Grand Scenic",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Kadjar",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Kangoo",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Kaptur",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Koleos",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Laguna",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Latitude",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Logan",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Master",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Megane",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Modus",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Sandero",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Sandero Stepway",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Scenic",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Symbol",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Talisman",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Trafic",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Twingo",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Twizy",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Vel Satis",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Wind",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 68,
				ModelName = "Zoe",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 69,
				ModelName = "Cullinan",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 69,
				ModelName = "Dawn",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 69,
				ModelName = "Ghost",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 69,
				ModelName = "Phantom",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 69,
				ModelName = "Wraith",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 70,
				ModelName = "25",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 70,
				ModelName = "400",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 70,
				ModelName = "45",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 70,
				ModelName = "600",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 70,
				ModelName = "75",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 70,
				ModelName = "Streetwise",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 71,
				ModelName = "9-2x",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 71,
				ModelName = "9-3",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 71,
				ModelName = "9-4x",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 71,
				ModelName = "9-5",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 71,
				ModelName = "9-7x",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 72,
				ModelName = "Aura",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 72,
				ModelName = "Ion",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 72,
				ModelName = "LW",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 72,
				ModelName = "Outlook",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 72,
				ModelName = "Sky",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 72,
				ModelName = "Vue",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 73,
				ModelName = "FR-S",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 73,
				ModelName = "tC",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 73,
				ModelName = "xA",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 73,
				ModelName = "xB",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 73,
				ModelName = "xD",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Alhambra",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Altea",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Altea Freetrack",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Altea XL",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Arosa",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Ateca",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Cordoba",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Exeo",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Ibiza",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Leon",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Mii",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 74,
				ModelName = "Toledo",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Citigo",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Fabia",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Felicia",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Kamiq",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Karoq",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Kodiaq",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Octavia",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Octavia Scout",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Octavia Tour",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Praktik",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Rapid",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Rapid Spaceback (NH1)",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Roomster",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Superb",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 75,
				ModelName = "Yeti",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 76,
				ModelName = "Forfour",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 76,
				ModelName = "Fortwo",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 76,
				ModelName = "Roadster",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "Actyon",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "Actyon Sports",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "Chairman",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "Korando",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "Kyron",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "Musso",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "Musso Sport",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "Rexton",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "Rodius",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "Stavic",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "Tivoli",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 77,
				ModelName = "XLV",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Ascent",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Baja",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Crosstrack",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Exiga",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Forester",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Impreza",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Justy",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Legacy",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Levorg",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Outback",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Traviq",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "Tribeca",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "WRX",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 78,
				ModelName = "XV",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Alto",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Baleno",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Celerio",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Ciaz",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Grand Vitara",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Grand Vitara XL7",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Ignis",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Jimny",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Kizashi",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Liana",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Splash",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Swift",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "SX4",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Vitara",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Wagon R",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 79,
				ModelName = "Wagon R+",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 80,
				ModelName = "Model 3",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 80,
				ModelName = "Model S",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 80,
				ModelName = "Model X",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 80,
				ModelName = "Model Y",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "4Runner",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Alphard",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Auris",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Avalon",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Avensis",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Avensis Verso",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Aygo",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "C-HR",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Caldina",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Camry",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Celica",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Corolla",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Corolla Verso",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "FJ Cruiser",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Fortuner",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "GT 86",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Hiace",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Highlander",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Hilux",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "iQ",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "ist",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Land Cruiser",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Land Cruiser Prado",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Mark II",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Mirai",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "MR2",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Picnic",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Previa",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Prius",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "RAV4",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Sequoia",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Sienna",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Supra",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Tacoma",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Tundra",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Venza",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Verso",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Vitz",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Yaris",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 81,
				ModelName = "Yaris Verso",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 82,
				ModelName = "Pickup",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 82,
				ModelName = "Патриот",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 82,
				ModelName = "Хантер",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "2101-2107",
				Year = 1976,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "2108, 2109, 21099",
				Year = 1984,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "2110, 2111, 2112",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "2113, 2114, 2115",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "4x4 Urban",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "Granta",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "Largus",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "Largus Cross",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "Vesta Cross",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "Vesta Sport",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "Vesta SW",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "XRay",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "XRay Cross",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "Веста",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "Калина",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "Нива 4X4",
				Year = 1977,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "Ока",
				Year = 1988,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 83,
				ModelName = "Приора",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Amarok",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Arteon",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Beetle",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Bora",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Caddy",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "CC",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Crafter",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "CrossGolf",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "CrossPolo",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "CrossTouran",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Eos",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Fox",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Golf",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Jetta",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Lupo",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Multivan",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "New Beetle",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Passat",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Passat CC",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Phaeton",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Pointer",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Polo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Routan",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Scirocco",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Sharan",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "T-Roc",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Teramont",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Tiguan",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Touareg",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Touran",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Transporter",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 84,
				ModelName = "Up",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "C30",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "C70",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "C70 Convertible",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "C70 Coupe",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "S40",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "S60",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "S70",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "S80",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "S90",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "V40",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "V50",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "V60",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "V70",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "V90",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "XC40",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "XC60",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "XC70",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				ManufacturerId = 85,
				ModelName = "XC90",
				Year = 2002,
				Is_Active = true
			}

				);

		}

    }*/
}
