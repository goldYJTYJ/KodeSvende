using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ModelLibrary;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace API
{
    public class RangeMateContext : DbContext
    {
		public RangeMateContext(DbContextOptions<RangeMateContext> options) : base(options)
        {

		}

        public DbSet<User> User { get; set; }
		public DbSet<Manufacturer> Manufacturer { get; set; }
		public DbSet<Model> Models { get; set; }
		public DbSet<Engine> Engine { get; set; }
		public DbSet<EconomyReportElectric> EconomyReportElectric { get; set; }
		public DbSet<EconomyReportICE> EconomyReportICE { get; set; }
		public DbSet<EconomySummaryICE> EconomySummaryICEs { get; set; }
		public DbSet<EconomySummaryElectric> EconomySummaryElectrics { get; set; }
		public DbSet<Comment> Comment { get; set; }

		/**
		 * Create Initial database
		 * 
		 Add-Migration -Name-
		 Database-Update
		 **/

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			// One time use encryption for dbcontext
			var dataProtectionProvider = DataProtectionProvider.Create("RangeMate");
			var protector = dataProtectionProvider.CreateProtector("552EAABB-1FD9-4A82-B6C7-EB97D3A9D7A2");

			modelBuilder.Entity<User>().HasData(
            new User()
            {
					Id = 1,
					FirstName = protector.Protect("Admin"),
					LastName = protector.Protect("Adminson"),
					Email = "Admin@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = true
            },
                new User()
            {
					Id = 2,
					FirstName = protector.Protect("Hans"),
					LastName = protector.Protect("Hansen"),
					Email = "HH@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
            },
				new User()
				{
					Id = 3,
					FirstName = protector.Protect("Poul"),
					LastName = protector.Protect("Poulsen"),
					Email = "PP@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 4,
					FirstName = protector.Protect("Erik"),
					LastName = protector.Protect("Eriksen"),
					Email = "EE@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 5,
					FirstName = protector.Protect("Anne"),
					LastName = protector.Protect("Annesen"),
					Email = "AA@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 6,
					FirstName = protector.Protect("Bo"),
					LastName = protector.Protect("Boesen"),
					Email = "BB@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 7,
					FirstName = protector.Protect("Caroline"),
					LastName = protector.Protect("Carolinesen"),
					Email = "CC@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 8,
					FirstName = protector.Protect("Dan"),
					LastName = protector.Protect("Dannesen"),
					Email = "DD@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 10,
					FirstName = protector.Protect("Frank"),
					LastName = protector.Protect("Fransen"),
					Email = "FF@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 11,
					FirstName = protector.Protect("Gyrne"),
					LastName = protector.Protect("Gyrnesen"),
					Email = "GG@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 12,
					FirstName = protector.Protect("Helle"),
					LastName = protector.Protect("Hansen"),
					Email = "DD@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 13,
					FirstName = protector.Protect("Ida"),
					LastName = protector.Protect("Idasen"),
					Email = "II@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 14,
					FirstName = protector.Protect("Jon"),
					LastName = protector.Protect("Jonsen"),
					Email = "JJ@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 15,
					FirstName = protector.Protect("Karen"),
					LastName = protector.Protect("karensen"),
					Email = "KK@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 16,
					FirstName = protector.Protect("Lau"),
					LastName = protector.Protect("Lauersen"),
					Email = "LL@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 17,
					FirstName = protector.Protect("Martin"),
					LastName = protector.Protect("Martinsen"),
					Email = "MM@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 18,
					FirstName = protector.Protect("Noel"),
					LastName = protector.Protect("Noelsen"),
					Email = "NN@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 19,
					FirstName = protector.Protect("Ole"),
					LastName = protector.Protect("Olesen"),
					Email = "OO@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 20,
					FirstName = protector.Protect("Ronald"),
					LastName = protector.Protect("Rollesen"),
					Email = "RR@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 21,
					FirstName = protector.Protect("Søren"),
					LastName = protector.Protect("Sørensen"),
					Email = "SS@live.dk",
					Password = BCrypt.Net.BCrypt.HashPassword("password"),
					AccountCreation = DateTime.Now,
					Is_Active = true,
					Is_Administrator = false
				},
				new User()
				{
					Id = 22,
					FirstName = protector.Protect("Thomas"),
					LastName = protector.Protect("Thomsen"),
					Email = "TT@live.dk",
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
				Id = 1,
				ManufacturerId = 1,
				ModelName = "EL",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 2,
				ManufacturerId = 1,
				ModelName = "ILX",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 3,
				ManufacturerId = 1,
				ModelName = "Integra",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 4,
				ManufacturerId = 1,
				ModelName = "MDX",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 5,
				ManufacturerId = 1,
				ModelName = "NSX",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 6,
				ManufacturerId = 1,
				ModelName = "RDX",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 7,
				ManufacturerId = 1,
				ModelName = "RL",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 8,
				ManufacturerId = 1,
				ModelName = "RLX",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 9,
				ManufacturerId = 1,
				ModelName = "RSX",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 10,
				ManufacturerId = 1,
				ModelName = "TL",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 11,
				ManufacturerId = 1,
				ModelName = "TLX",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 12,
				ManufacturerId = 1,
				ModelName = "TSX",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 13,
				ManufacturerId = 1,
				ModelName = "ZDX",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 14,
				ManufacturerId = 2,
				ModelName = "146",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 15,
				ManufacturerId = 2,
				ModelName = "147",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 16,
				ManufacturerId = 2,
				ModelName = "147 GTA",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 17,
				ManufacturerId = 2,
				ModelName = "156",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 18,
				ManufacturerId = 2,
				ModelName = "156 GTA",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 19,
				ManufacturerId = 2,
				ModelName = "159",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 20,
				ManufacturerId = 2,
				ModelName = "166",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 21,
				ManufacturerId = 2,
				ModelName = "4C",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 22,
				ManufacturerId = 2,
				ModelName = "8C Competizione",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 23,
				ManufacturerId = 2,
				ModelName = "Brera",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 24,
				ManufacturerId = 2,
				ModelName = "Giulia",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 25,
				ManufacturerId = 2,
				ModelName = "Giulietta",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 26,
				ManufacturerId = 2,
				ModelName = "GT",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 27,
				ManufacturerId = 2,
				ModelName = "GTV",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 28,
				ManufacturerId = 2,
				ModelName = "MiTo",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 29,
				ManufacturerId = 2,
				ModelName = "Spider",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 30,
				ManufacturerId = 2,
				ModelName = "Stelvio",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 31,
				ManufacturerId = 3,
				ModelName = "Cygnet",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 32,
				ManufacturerId = 3,
				ModelName = "DB11",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 33,
				ManufacturerId = 3,
				ModelName = "DB9",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 34,
				ManufacturerId = 3,
				ModelName = "DBS",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 35,
				ManufacturerId = 3,
				ModelName = "DBS Violante",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 36,
				ManufacturerId = 3,
				ModelName = "DBX",
				Year = 2020,
				Is_Active = true
			},
			new Model()
			{
				Id = 37,
				ManufacturerId = 3,
				ModelName = "Rapide",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 38,
				ManufacturerId = 3,
				ModelName = "V12 Vantage",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 39,
				ManufacturerId = 3,
				ModelName = "V8 Vantage",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 40,
				ManufacturerId = 3,
				ModelName = "Valkyrie",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 41,
				ManufacturerId = 3,
				ModelName = "Vanquish",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 42,
				ManufacturerId = 3,
				ModelName = "Virage",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 43,
				ManufacturerId = 3,
				ModelName = "Zagato Coupe",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 44,
				ManufacturerId = 4,
				ModelName = "A1",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 45,
				ManufacturerId = 4,
				ModelName = "A2",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 46,
				ManufacturerId = 4,
				ModelName = "A3",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 47,
				ManufacturerId = 4,
				ModelName = "A4",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 48,
				ManufacturerId = 4,
				ModelName = "A4 Allroad Quattro",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 49,
				ManufacturerId = 4,
				ModelName = "A5",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 50,
				ManufacturerId = 4,
				ModelName = "A6",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 51,
				ManufacturerId = 4,
				ModelName = "A7",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 52,
				ManufacturerId = 4,
				ModelName = "A8",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 53,
				ManufacturerId = 4,
				ModelName = "Allroad",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 54,
				ManufacturerId = 4,
				ModelName = "E-Tron",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 55,
				ManufacturerId = 4,
				ModelName = "Q2",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 56,
				ManufacturerId = 4,
				ModelName = "Q3",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 57,
				ManufacturerId = 4,
				ModelName = "Q5",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 58,
				ManufacturerId = 4,
				ModelName = "Q7",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 59,
				ManufacturerId = 4,
				ModelName = "Q8",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 60,
				ManufacturerId = 4,
				ModelName = "R8",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 61,
				ManufacturerId = 4,
				ModelName = "RS Q3",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 62,
				ManufacturerId = 4,
				ModelName = "RS3",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 63,
				ManufacturerId = 4,
				ModelName = "RS4",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 64,
				ManufacturerId = 4,
				ModelName = "RS5",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 65,
				ManufacturerId = 4,
				ModelName = "RS6",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 66,
				ManufacturerId = 4,
				ModelName = "RS7",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 67,
				ManufacturerId = 4,
				ModelName = "S3",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 68,
				ManufacturerId = 4,
				ModelName = "S4",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 69,
				ManufacturerId = 4,
				ModelName = "S5",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 70,
				ManufacturerId = 4,
				ModelName = "S6",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 71,
				ManufacturerId = 4,
				ModelName = "S7",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 72,
				ManufacturerId = 4,
				ModelName = "S8",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 73,
				ManufacturerId = 4,
				ModelName = "SQ2",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 74,
				ManufacturerId = 4,
				ModelName = "SQ5",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 75,
				ManufacturerId = 4,
				ModelName = "SQ7",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 76,
				ManufacturerId = 4,
				ModelName = "SQ8",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 77,
				ManufacturerId = 4,
				ModelName = "TT",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 78,
				ManufacturerId = 4,
				ModelName = "TT RS",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 79,
				ManufacturerId = 4,
				ModelName = "TTS",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 80,
				ManufacturerId = 5,
				ModelName = "Arnage",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 81,
				ManufacturerId = 5,
				ModelName = "Azure",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 82,
				ManufacturerId = 5,
				ModelName = "Bentayga",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 83,
				ManufacturerId = 5,
				ModelName = "Brooklands",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 84,
				ManufacturerId = 5,
				ModelName = "Continental",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 85,
				ManufacturerId = 5,
				ModelName = "Continental Flying Spur",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 86,
				ManufacturerId = 5,
				ModelName = "Continental GT",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 87,
				ManufacturerId = 5,
				ModelName = "Flying Spur",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 88,
				ManufacturerId = 5,
				ModelName = "Mulsanne",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 89,
				ManufacturerId = 6,
				ModelName = "1 series",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 90,
				ManufacturerId = 6,
				ModelName = "2 series",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 91,
				ManufacturerId = 6,
				ModelName = "3 series",
				Year = 1982,
				Is_Active = true
			},
			new Model()
			{
				Id = 92,
				ManufacturerId = 6,
				ModelName = "4 series",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 93,
				ManufacturerId = 6,
				ModelName = "5 series",
				Year = 1988,
				Is_Active = true
			},
			new Model()
			{
				Id = 94,
				ManufacturerId = 6,
				ModelName = "6 series",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 95,
				ManufacturerId = 6,
				ModelName = "7 series",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 96,
				ManufacturerId = 6,
				ModelName = "8 series",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				Id = 97,
				ManufacturerId = 6,
				ModelName = "i3",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 98,
				ManufacturerId = 6,
				ModelName = "i8",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 99,
				ManufacturerId = 6,
				ModelName = "M2",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 100,
				ManufacturerId = 6,
				ModelName = "M3",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				Id = 101,
				ManufacturerId = 6,
				ModelName = "M4",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 102,
				ManufacturerId = 6,
				ModelName = "M5",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 103,
				ManufacturerId = 6,
				ModelName = "M6",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 104,
				ManufacturerId = 6,
				ModelName = "X1",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 105,
				ManufacturerId = 6,
				ModelName = "X2",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 106,
				ManufacturerId = 6,
				ModelName = "X3",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 107,
				ManufacturerId = 6,
				ModelName = "X3 M",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 108,
				ManufacturerId = 6,
				ModelName = "X4",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 109,
				ManufacturerId = 6,
				ModelName = "X4 M",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 110,
				ManufacturerId = 6,
				ModelName = "X5",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 111,
				ManufacturerId = 6,
				ModelName = "X5 M",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 112,
				ManufacturerId = 6,
				ModelName = "X6",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 113,
				ManufacturerId = 6,
				ModelName = "X6 M",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 114,
				ManufacturerId = 6,
				ModelName = "X7",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 115,
				ManufacturerId = 6,
				ModelName = "Z3",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 116,
				ManufacturerId = 6,
				ModelName = "Z4",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 117,
				ManufacturerId = 6,
				ModelName = "Z8",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 118,
				ManufacturerId = 7,
				ModelName = "H230",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 119,
				ManufacturerId = 7,
				ModelName = "V3",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 120,
				ManufacturerId = 7,
				ModelName = "V5",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 121,
				ManufacturerId = 8,
				ModelName = "Veyron",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 122,
				ManufacturerId = 9,
				ModelName = "Century",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 123,
				ManufacturerId = 9,
				ModelName = "Enclave",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 124,
				ManufacturerId = 9,
				ModelName = "Envision",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 125,
				ManufacturerId = 9,
				ModelName = "La Crosse",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 126,
				ManufacturerId = 9,
				ModelName = "Le Sabre",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 127,
				ManufacturerId = 9,
				ModelName = "Lucerne",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 128,
				ManufacturerId = 9,
				ModelName = "Park Avenue",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 129,
				ManufacturerId = 9,
				ModelName = "Rainier",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 130,
				ManufacturerId = 9,
				ModelName = "Regal",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 131,
				ManufacturerId = 9,
				ModelName = "Rendezvouz",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 132,
				ManufacturerId = 9,
				ModelName = "Terraza",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 133,
				ManufacturerId = 9,
				ModelName = "Verano",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 134,
				ManufacturerId = 10,
				ModelName = "Qin",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 135,
				ManufacturerId = 11,
				ModelName = "ATS",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 136,
				ManufacturerId = 11,
				ModelName = "ATS-V",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 137,
				ManufacturerId = 11,
				ModelName = "BLS",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 138,
				ManufacturerId = 11,
				ModelName = "CT6",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 139,
				ManufacturerId = 11,
				ModelName = "CTS",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 140,
				ManufacturerId = 11,
				ModelName = "De Ville",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 141,
				ManufacturerId = 11,
				ModelName = "DTS",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 142,
				ManufacturerId = 11,
				ModelName = "Eldorado",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				Id = 143,
				ManufacturerId = 11,
				ModelName = "ELR",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 144,
				ManufacturerId = 11,
				ModelName = "Escalade",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 145,
				ManufacturerId = 11,
				ModelName = "Seville",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 146,
				ManufacturerId = 11,
				ModelName = "SRX",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 147,
				ManufacturerId = 11,
				ModelName = "STS",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 148,
				ManufacturerId = 11,
				ModelName = "XLR",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 149,
				ManufacturerId = 11,
				ModelName = "XT4",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 150,
				ManufacturerId = 11,
				ModelName = "XT5",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 151,
				ManufacturerId = 11,
				ModelName = "XT6",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 152,
				ManufacturerId = 11,
				ModelName = "XTS",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 153,
				ManufacturerId = 12,
				ModelName = "CS35",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 154,
				ManufacturerId = 12,
				ModelName = "CS35 Plus",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 155,
				ManufacturerId = 12,
				ModelName = "CS55",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 156,
				ManufacturerId = 12,
				ModelName = "CS75",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 157,
				ManufacturerId = 12,
				ModelName = "CS95",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 158,
				ManufacturerId = 12,
				ModelName = "Eado",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 159,
				ManufacturerId = 12,
				ModelName = "Raeton",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 160,
				ManufacturerId = 13,
				ModelName = "Amulet",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 161,
				ManufacturerId = 13,
				ModelName = "Arrizo 7",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 162,
				ManufacturerId = 13,
				ModelName = "Bonus",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 163,
				ManufacturerId = 13,
				ModelName = "Bonus 3",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 164,
				ManufacturerId = 13,
				ModelName = "CrossEastar",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 165,
				ManufacturerId = 13,
				ModelName = "Eastar",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 166,
				ManufacturerId = 13,
				ModelName = "Fora",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 167,
				ManufacturerId = 13,
				ModelName = "IndiS",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 168,
				ManufacturerId = 13,
				ModelName = "Kimo",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 169,
				ManufacturerId = 13,
				ModelName = "M11",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 170,
				ManufacturerId = 13,
				ModelName = "QQ",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 171,
				ManufacturerId = 13,
				ModelName = "QQ6",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 172,
				ManufacturerId = 13,
				ModelName = "Tiggo",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 173,
				ManufacturerId = 13,
				ModelName = "Tiggo 3",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 174,
				ManufacturerId = 13,
				ModelName = "Tiggo 4",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 175,
				ManufacturerId = 13,
				ModelName = "Tiggo 5",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 176,
				ManufacturerId = 13,
				ModelName = "Tiggo 7",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 177,
				ManufacturerId = 13,
				ModelName = "Tiggo 8",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 178,
				ManufacturerId = 13,
				ModelName = "Very",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 179,
				ManufacturerId = 14,
				ModelName = "Astro",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 180,
				ManufacturerId = 14,
				ModelName = "Avalanche",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 181,
				ManufacturerId = 14,
				ModelName = "Aveo",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 182,
				ManufacturerId = 14,
				ModelName = "Blazer",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 183,
				ManufacturerId = 14,
				ModelName = "Camaro",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 184,
				ManufacturerId = 14,
				ModelName = "Captiva",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 185,
				ManufacturerId = 14,
				ModelName = "Cavalier",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 186,
				ManufacturerId = 14,
				ModelName = "Cobalt",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 187,
				ManufacturerId = 14,
				ModelName = "Colorado",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 188,
				ManufacturerId = 14,
				ModelName = "Corvette",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 189,
				ManufacturerId = 14,
				ModelName = "Cruze",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 190,
				ManufacturerId = 14,
				ModelName = "Epica",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 191,
				ManufacturerId = 14,
				ModelName = "Equinox",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 192,
				ManufacturerId = 14,
				ModelName = "Express",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 193,
				ManufacturerId = 14,
				ModelName = "HHR",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 194,
				ManufacturerId = 14,
				ModelName = "Impala",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 195,
				ManufacturerId = 14,
				ModelName = "Lacetti",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 196,
				ManufacturerId = 14,
				ModelName = "Lanos",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 197,
				ManufacturerId = 14,
				ModelName = "Malibu",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 198,
				ManufacturerId = 14,
				ModelName = "Monte Carlo",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 199,
				ManufacturerId = 14,
				ModelName = "Niva",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 200,
				ManufacturerId = 14,
				ModelName = "Orlando",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 201,
				ManufacturerId = 14,
				ModelName = "Rezzo",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 202,
				ManufacturerId = 14,
				ModelName = "Silverado",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 203,
				ManufacturerId = 14,
				ModelName = "Silverado 2500 HD",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 204,
				ManufacturerId = 14,
				ModelName = "Spark",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 205,
				ManufacturerId = 14,
				ModelName = "SSR",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 206,
				ManufacturerId = 14,
				ModelName = "Suburban",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 207,
				ManufacturerId = 14,
				ModelName = "Tahoe",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 208,
				ManufacturerId = 14,
				ModelName = "TrailBlazer",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 209,
				ManufacturerId = 14,
				ModelName = "Traverse",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 210,
				ManufacturerId = 14,
				ModelName = "Trax",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 211,
				ManufacturerId = 14,
				ModelName = "Uplander",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 212,
				ManufacturerId = 14,
				ModelName = "Venture",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 213,
				ManufacturerId = 15,
				ModelName = "200",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 214,
				ManufacturerId = 15,
				ModelName = "300",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 215,
				ManufacturerId = 15,
				ModelName = "300M",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 216,
				ManufacturerId = 15,
				ModelName = "Aspen",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 217,
				ManufacturerId = 15,
				ModelName = "Concorde",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 218,
				ManufacturerId = 15,
				ModelName = "Crossfire",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 219,
				ManufacturerId = 15,
				ModelName = "Grand Voyager",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 220,
				ManufacturerId = 15,
				ModelName = "Pacifica",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 221,
				ManufacturerId = 15,
				ModelName = "PT Cruiser",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 222,
				ManufacturerId = 15,
				ModelName = "Sebring",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 223,
				ManufacturerId = 15,
				ModelName = "Town & Country",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 224,
				ManufacturerId = 15,
				ModelName = "Voyager",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 225,
				ManufacturerId = 16,
				ModelName = "Berlingo",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 226,
				ManufacturerId = 16,
				ModelName = "C-Crosser",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 227,
				ManufacturerId = 16,
				ModelName = "C-Elysee",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 228,
				ManufacturerId = 16,
				ModelName = "C1",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 229,
				ManufacturerId = 16,
				ModelName = "C2",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 230,
				ManufacturerId = 16,
				ModelName = "C3",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 231,
				ManufacturerId = 16,
				ModelName = "C3 Aircross",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 232,
				ManufacturerId = 16,
				ModelName = "C3 Picasso",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 233,
				ManufacturerId = 16,
				ModelName = "C3 Pluriel",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 234,
				ManufacturerId = 16,
				ModelName = "C4",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 235,
				ManufacturerId = 16,
				ModelName = "C4 Aircross",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 236,
				ManufacturerId = 16,
				ModelName = "C4 Cactus",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 237,
				ManufacturerId = 16,
				ModelName = "C4 Picasso",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 238,
				ManufacturerId = 16,
				ModelName = "C5",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 239,
				ManufacturerId = 16,
				ModelName = "C6",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 240,
				ManufacturerId = 16,
				ModelName = "C8",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 241,
				ManufacturerId = 16,
				ModelName = "DS 7 Crossback",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 242,
				ManufacturerId = 16,
				ModelName = "DS3",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 243,
				ManufacturerId = 16,
				ModelName = "DS4",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 244,
				ManufacturerId = 16,
				ModelName = "DS5",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 245,
				ManufacturerId = 16,
				ModelName = "Grand C4 Picasso",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 246,
				ManufacturerId = 16,
				ModelName = "Jumpy",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 247,
				ManufacturerId = 16,
				ModelName = "Nemo",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 248,
				ManufacturerId = 16,
				ModelName = "Saxo",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 249,
				ManufacturerId = 16,
				ModelName = "Spacetourer",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 250,
				ManufacturerId = 16,
				ModelName = "Xsara",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 251,
				ManufacturerId = 16,
				ModelName = "Xsara Picasso",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 252,
				ManufacturerId = 17,
				ModelName = "Evanda",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 253,
				ManufacturerId = 17,
				ModelName = "Kalos",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 254,
				ManufacturerId = 17,
				ModelName = "Leganza",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 255,
				ManufacturerId = 17,
				ModelName = "Magnus",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 256,
				ManufacturerId = 17,
				ModelName = "Matiz",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 257,
				ManufacturerId = 17,
				ModelName = "Nexia",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 258,
				ManufacturerId = 17,
				ModelName = "Nubira",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 259,
				ManufacturerId = 18,
				ModelName = "Applause",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 260,
				ManufacturerId = 18,
				ModelName = "Cast",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 261,
				ManufacturerId = 18,
				ModelName = "Copen",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 262,
				ManufacturerId = 18,
				ModelName = "Cuore",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 263,
				ManufacturerId = 18,
				ModelName = "Gran Move",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 264,
				ManufacturerId = 18,
				ModelName = "Luxio",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 265,
				ManufacturerId = 18,
				ModelName = "Materia",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 266,
				ManufacturerId = 18,
				ModelName = "Mebius",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 267,
				ManufacturerId = 18,
				ModelName = "Move",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 268,
				ManufacturerId = 18,
				ModelName = "Rocky",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 269,
				ManufacturerId = 18,
				ModelName = "Sirion",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 270,
				ManufacturerId = 18,
				ModelName = "Terios",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 271,
				ManufacturerId = 18,
				ModelName = "Trevis",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 272,
				ManufacturerId = 18,
				ModelName = "YRV",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 273,
				ManufacturerId = 19,
				ModelName = "mi-DO",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 274,
				ManufacturerId = 19,
				ModelName = "on-DO",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 275,
				ManufacturerId = 20,
				ModelName = "Avenger",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 276,
				ManufacturerId = 20,
				ModelName = "Caliber",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 277,
				ManufacturerId = 20,
				ModelName = "Caliber SRT4",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 278,
				ManufacturerId = 20,
				ModelName = "Caravan",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 279,
				ManufacturerId = 20,
				ModelName = "Challenger",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 280,
				ManufacturerId = 20,
				ModelName = "Charger",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 281,
				ManufacturerId = 20,
				ModelName = "Dakota",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 282,
				ManufacturerId = 20,
				ModelName = "Dart",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 283,
				ManufacturerId = 20,
				ModelName = "Durango",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 284,
				ManufacturerId = 20,
				ModelName = "Intrepid",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 285,
				ManufacturerId = 20,
				ModelName = "Journey",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 286,
				ManufacturerId = 20,
				ModelName = "Magnum",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 287,
				ManufacturerId = 20,
				ModelName = "Neon",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 288,
				ManufacturerId = 20,
				ModelName = "Nitro",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 289,
				ManufacturerId = 20,
				ModelName = "Ram 1500",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 290,
				ManufacturerId = 20,
				ModelName = "Ram 2500",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 291,
				ManufacturerId = 20,
				ModelName = "Ram 3500",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 292,
				ManufacturerId = 20,
				ModelName = "Ram SRT10",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 293,
				ManufacturerId = 20,
				ModelName = "Stratus",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 294,
				ManufacturerId = 20,
				ModelName = "Viper",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 295,
				ManufacturerId = 21,
				ModelName = "580",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 296,
				ManufacturerId = 21,
				ModelName = "A30",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 297,
				ManufacturerId = 21,
				ModelName = "AX7",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 298,
				ManufacturerId = 21,
				ModelName = "H30 Cross",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 299,
				ManufacturerId = 22,
				ModelName = "Besturn B30",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 300,
				ManufacturerId = 22,
				ModelName = "Besturn B50",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 301,
				ManufacturerId = 22,
				ModelName = "Besturn X40",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 302,
				ManufacturerId = 22,
				ModelName = "Besturn X80",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 303,
				ManufacturerId = 22,
				ModelName = "Oley",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 304,
				ManufacturerId = 22,
				ModelName = "Vita",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 305,
				ManufacturerId = 23,
				ModelName = "348",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				Id = 306,
				ManufacturerId = 23,
				ModelName = "360",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 307,
				ManufacturerId = 23,
				ModelName = "456",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				Id = 308,
				ManufacturerId = 23,
				ModelName = "458",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 309,
				ManufacturerId = 23,
				ModelName = "488",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 310,
				ManufacturerId = 23,
				ModelName = "512",
				Year = 1991,
				Is_Active = true
			},
			new Model()
			{
				Id = 311,
				ManufacturerId = 23,
				ModelName = "550",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 312,
				ManufacturerId = 23,
				ModelName = "575 M",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 313,
				ManufacturerId = 23,
				ModelName = "599 GTB Fiorano",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 314,
				ManufacturerId = 23,
				ModelName = "599 GTO",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 315,
				ManufacturerId = 23,
				ModelName = "612",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 316,
				ManufacturerId = 23,
				ModelName = "812",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 317,
				ManufacturerId = 23,
				ModelName = "California",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 318,
				ManufacturerId = 23,
				ModelName = "California T",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 319,
				ManufacturerId = 23,
				ModelName = "Challenge Stradale",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 320,
				ManufacturerId = 23,
				ModelName = "Enzo",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 321,
				ManufacturerId = 23,
				ModelName = "F12",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 322,
				ManufacturerId = 23,
				ModelName = "F355",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 323,
				ManufacturerId = 23,
				ModelName = "F430",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 324,
				ManufacturerId = 23,
				ModelName = "F50",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 325,
				ManufacturerId = 23,
				ModelName = "F512 M",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 326,
				ManufacturerId = 23,
				ModelName = "FF",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 327,
				ManufacturerId = 23,
				ModelName = "GTC4 Lusso",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 328,
				ManufacturerId = 23,
				ModelName = "LaFerrari",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 329,
				ManufacturerId = 24,
				ModelName = "124 Spider",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 330,
				ManufacturerId = 24,
				ModelName = "500",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 331,
				ManufacturerId = 24,
				ModelName = "500L",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 332,
				ManufacturerId = 24,
				ModelName = "500X",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 333,
				ManufacturerId = 24,
				ModelName = "Albea",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 334,
				ManufacturerId = 24,
				ModelName = "Brava",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 335,
				ManufacturerId = 24,
				ModelName = "Bravo",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 336,
				ManufacturerId = 24,
				ModelName = "Coupe",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				Id = 337,
				ManufacturerId = 24,
				ModelName = "Croma",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 338,
				ManufacturerId = 24,
				ModelName = "Doblo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 339,
				ManufacturerId = 24,
				ModelName = "Ducato",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 340,
				ManufacturerId = 24,
				ModelName = "Freemont",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 341,
				ManufacturerId = 24,
				ModelName = "Grande Punto",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 342,
				ManufacturerId = 24,
				ModelName = "Idea",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 343,
				ManufacturerId = 24,
				ModelName = "Linea",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 344,
				ManufacturerId = 24,
				ModelName = "Marea",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 345,
				ManufacturerId = 24,
				ModelName = "Multipla",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 346,
				ManufacturerId = 24,
				ModelName = "Palio",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 347,
				ManufacturerId = 24,
				ModelName = "Panda",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 348,
				ManufacturerId = 24,
				ModelName = "Panda 4x4",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 349,
				ManufacturerId = 24,
				ModelName = "Punto",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 350,
				ManufacturerId = 24,
				ModelName = "Qubo",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 351,
				ManufacturerId = 24,
				ModelName = "Sedici",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 352,
				ManufacturerId = 24,
				ModelName = "Siena",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 353,
				ManufacturerId = 24,
				ModelName = "Stilo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 354,
				ManufacturerId = 24,
				ModelName = "Strada",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 355,
				ManufacturerId = 24,
				ModelName = "Tipo",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 356,
				ManufacturerId = 24,
				ModelName = "Ulysse",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 357,
				ManufacturerId = 25,
				ModelName = "Karma",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 358,
				ManufacturerId = 26,
				ModelName = "B-Max",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 359,
				ManufacturerId = 26,
				ModelName = "C-Max",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 360,
				ManufacturerId = 26,
				ModelName = "Cougar",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 361,
				ManufacturerId = 26,
				ModelName = "Crown Victoria",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 362,
				ManufacturerId = 26,
				ModelName = "EcoSport",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 363,
				ManufacturerId = 26,
				ModelName = "Edge",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 364,
				ManufacturerId = 26,
				ModelName = "Escape",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 365,
				ManufacturerId = 26,
				ModelName = "Excursion",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 366,
				ManufacturerId = 26,
				ModelName = "Expedition",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 367,
				ManufacturerId = 26,
				ModelName = "Explorer",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 368,
				ManufacturerId = 26,
				ModelName = "Explorer Sport Trac",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 369,
				ManufacturerId = 26,
				ModelName = "F-150",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 370,
				ManufacturerId = 26,
				ModelName = "F-250",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 371,
				ManufacturerId = 26,
				ModelName = "F-350",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 372,
				ManufacturerId = 26,
				ModelName = "Falcon",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 373,
				ManufacturerId = 26,
				ModelName = "Fiesta",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 374,
				ManufacturerId = 26,
				ModelName = "Five Hundred",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 375,
				ManufacturerId = 26,
				ModelName = "Flex",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 376,
				ManufacturerId = 26,
				ModelName = "Focus",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 377,
				ManufacturerId = 26,
				ModelName = "Focus Active",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 378,
				ManufacturerId = 26,
				ModelName = "Freestar",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 379,
				ManufacturerId = 26,
				ModelName = "Freestyle",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 380,
				ManufacturerId = 26,
				ModelName = "Fusion",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 381,
				ManufacturerId = 26,
				ModelName = "Galaxy",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 382,
				ManufacturerId = 26,
				ModelName = "Ka",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 383,
				ManufacturerId = 26,
				ModelName = "Kuga",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 384,
				ManufacturerId = 26,
				ModelName = "Maverick",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				Id = 385,
				ManufacturerId = 26,
				ModelName = "Mondeo",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 386,
				ManufacturerId = 26,
				ModelName = "Mustang",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 387,
				ManufacturerId = 26,
				ModelName = "Mustang Shelby GT350",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 388,
				ManufacturerId = 26,
				ModelName = "Mustang Shelby GT500",
				Year = 2020,
				Is_Active = true
			},
			new Model()
			{
				Id = 389,
				ManufacturerId = 26,
				ModelName = "Puma",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 390,
				ManufacturerId = 26,
				ModelName = "Ranger",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 391,
				ManufacturerId = 26,
				ModelName = "S-Max",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 392,
				ManufacturerId = 26,
				ModelName = "Taurus",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 393,
				ManufacturerId = 26,
				ModelName = "Taurus X",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 394,
				ManufacturerId = 26,
				ModelName = "Thunderbird",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 395,
				ManufacturerId = 26,
				ModelName = "Tourneo Connect",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 396,
				ManufacturerId = 26,
				ModelName = "Transit",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 397,
				ManufacturerId = 26,
				ModelName = "Transit Connect",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 398,
				ManufacturerId = 27,
				ModelName = "3102",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 399,
				ManufacturerId = 27,
				ModelName = "31105",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 400,
				ManufacturerId = 27,
				ModelName = "Siber",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 401,
				ManufacturerId = 27,
				ModelName = "Sobol",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 402,
				ManufacturerId = 28,
				ModelName = "Atlas",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 403,
				ManufacturerId = 28,
				ModelName = "Coolray",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 404,
				ManufacturerId = 28,
				ModelName = "Emgrand 7",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 405,
				ManufacturerId = 28,
				ModelName = "Emgrand EC7",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 406,
				ManufacturerId = 28,
				ModelName = "Emgrand GS",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 407,
				ManufacturerId = 28,
				ModelName = "Emgrand X7",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 408,
				ManufacturerId = 28,
				ModelName = "GC9",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 409,
				ManufacturerId = 28,
				ModelName = "GС6",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 410,
				ManufacturerId = 28,
				ModelName = "MK",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 411,
				ManufacturerId = 28,
				ModelName = "Otaka",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 412,
				ManufacturerId = 28,
				ModelName = "Vision",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 413,
				ManufacturerId = 29,
				ModelName = "G70",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 414,
				ManufacturerId = 29,
				ModelName = "G80",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 415,
				ManufacturerId = 29,
				ModelName = "G90",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 416,
				ManufacturerId = 30,
				ModelName = "Acadia",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 417,
				ManufacturerId = 30,
				ModelName = "Canyon",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 418,
				ManufacturerId = 30,
				ModelName = "Envoy",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 419,
				ManufacturerId = 30,
				ModelName = "Sierra 1500",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 420,
				ManufacturerId = 30,
				ModelName = "Sierra 2500",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 421,
				ManufacturerId = 30,
				ModelName = "Terrain",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 422,
				ManufacturerId = 30,
				ModelName = "Yukon",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 423,
				ManufacturerId = 31,
				ModelName = "Cowry",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 424,
				ManufacturerId = 31,
				ModelName = "Deer",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 425,
				ManufacturerId = 31,
				ModelName = "Hover",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 426,
				ManufacturerId = 31,
				ModelName = "Hover M2",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 427,
				ManufacturerId = 31,
				ModelName = "Pegasus",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 428,
				ManufacturerId = 31,
				ModelName = "Peri",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 429,
				ManufacturerId = 31,
				ModelName = "Safe",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 430,
				ManufacturerId = 31,
				ModelName = "Sailor",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 431,
				ManufacturerId = 31,
				ModelName = "Sing",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 432,
				ManufacturerId = 31,
				ModelName = "Socool",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 433,
				ManufacturerId = 31,
				ModelName = "Wingle",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 434,
				ManufacturerId = 32,
				ModelName = "F7",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 435,
				ManufacturerId = 32,
				ModelName = "H4",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 436,
				ManufacturerId = 32,
				ModelName = "H6",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 437,
				ManufacturerId = 32,
				ModelName = "H9",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 438,
				ManufacturerId = 33,
				ModelName = "Commodore",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 439,
				ManufacturerId = 34,
				ModelName = "Accord",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 440,
				ManufacturerId = 34,
				ModelName = "Amaze",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 441,
				ManufacturerId = 34,
				ModelName = "City",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 442,
				ManufacturerId = 34,
				ModelName = "Civic",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 443,
				ManufacturerId = 34,
				ModelName = "CR-V",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 444,
				ManufacturerId = 34,
				ModelName = "CR-Z",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 445,
				ManufacturerId = 34,
				ModelName = "Crosstour",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 446,
				ManufacturerId = 34,
				ModelName = "Element",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 447,
				ManufacturerId = 34,
				ModelName = "Fit",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 448,
				ManufacturerId = 34,
				ModelName = "FR-V",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 449,
				ManufacturerId = 34,
				ModelName = "HR-V",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 450,
				ManufacturerId = 34,
				ModelName = "HR-V II (GJ)",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 451,
				ManufacturerId = 34,
				ModelName = "Insight",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 452,
				ManufacturerId = 34,
				ModelName = "Jade",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 453,
				ManufacturerId = 34,
				ModelName = "Jazz",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 454,
				ManufacturerId = 34,
				ModelName = "Legend",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 455,
				ManufacturerId = 34,
				ModelName = "Odyssey",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 456,
				ManufacturerId = 34,
				ModelName = "Pilot",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 457,
				ManufacturerId = 34,
				ModelName = "Prelude",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 458,
				ManufacturerId = 34,
				ModelName = "Ridgeline",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 459,
				ManufacturerId = 34,
				ModelName = "S2000",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 460,
				ManufacturerId = 34,
				ModelName = "Shuttle",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 461,
				ManufacturerId = 34,
				ModelName = "Stream",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 462,
				ManufacturerId = 34,
				ModelName = "Vezel",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 463,
				ManufacturerId = 35,
				ModelName = "H1",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				Id = 464,
				ManufacturerId = 35,
				ModelName = "H2",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 465,
				ManufacturerId = 35,
				ModelName = "H3",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 466,
				ManufacturerId = 36,
				ModelName = "Accent",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 467,
				ManufacturerId = 36,
				ModelName = "Atos Prime",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 468,
				ManufacturerId = 36,
				ModelName = "Azera",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 469,
				ManufacturerId = 36,
				ModelName = "Centennial",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 470,
				ManufacturerId = 36,
				ModelName = "Creta",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 471,
				ManufacturerId = 36,
				ModelName = "Elantra",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 472,
				ManufacturerId = 36,
				ModelName = "Entourage",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 473,
				ManufacturerId = 36,
				ModelName = "Eon",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 474,
				ManufacturerId = 36,
				ModelName = "Equus",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 475,
				ManufacturerId = 36,
				ModelName = "Galloper",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 476,
				ManufacturerId = 36,
				ModelName = "Genesis",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 477,
				ManufacturerId = 36,
				ModelName = "Genesis Coupe",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 478,
				ManufacturerId = 36,
				ModelName = "Getz",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 479,
				ManufacturerId = 36,
				ModelName = "Grandeur",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 480,
				ManufacturerId = 36,
				ModelName = "H-1",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 481,
				ManufacturerId = 36,
				ModelName = "i10",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 482,
				ManufacturerId = 36,
				ModelName = "i20",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 483,
				ManufacturerId = 36,
				ModelName = "i30",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 484,
				ManufacturerId = 36,
				ModelName = "i30 N",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 485,
				ManufacturerId = 36,
				ModelName = "i40",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 486,
				ManufacturerId = 36,
				ModelName = "Ioniq",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 487,
				ManufacturerId = 36,
				ModelName = "ix20",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 488,
				ManufacturerId = 36,
				ModelName = "ix35",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 489,
				ManufacturerId = 36,
				ModelName = "Kona",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 490,
				ManufacturerId = 36,
				ModelName = "Matrix",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 491,
				ManufacturerId = 36,
				ModelName = "Palisade",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 492,
				ManufacturerId = 36,
				ModelName = "Porter",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 493,
				ManufacturerId = 36,
				ModelName = "Santa Fe",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 494,
				ManufacturerId = 36,
				ModelName = "Solaris",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 495,
				ManufacturerId = 36,
				ModelName = "Sonata",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 496,
				ManufacturerId = 36,
				ModelName = "Terracan",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 497,
				ManufacturerId = 36,
				ModelName = "Trajet",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 498,
				ManufacturerId = 36,
				ModelName = "Tucson",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 499,
				ManufacturerId = 36,
				ModelName = "Veloster",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 500,
				ManufacturerId = 36,
				ModelName = "Veracruz",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 501,
				ManufacturerId = 36,
				ModelName = "Verna",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 502,
				ManufacturerId = 36,
				ModelName = "Xcent",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 503,
				ManufacturerId = 36,
				ModelName = "XG",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 504,
				ManufacturerId = 37,
				ModelName = "EX",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 505,
				ManufacturerId = 37,
				ModelName = "FX",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 506,
				ManufacturerId = 37,
				ModelName = "G",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 507,
				ManufacturerId = 37,
				ModelName = "I35",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 508,
				ManufacturerId = 37,
				ModelName = "JX",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 509,
				ManufacturerId = 37,
				ModelName = "M",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 510,
				ManufacturerId = 37,
				ModelName = "Q30",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 511,
				ManufacturerId = 37,
				ModelName = "Q40",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 512,
				ManufacturerId = 37,
				ModelName = "Q45",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 513,
				ManufacturerId = 37,
				ModelName = "Q50",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 514,
				ManufacturerId = 37,
				ModelName = "Q60",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 515,
				ManufacturerId = 37,
				ModelName = "Q70",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 516,
				ManufacturerId = 37,
				ModelName = "QX30",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 517,
				ManufacturerId = 37,
				ModelName = "QX4",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 518,
				ManufacturerId = 37,
				ModelName = "QX50",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 519,
				ManufacturerId = 37,
				ModelName = "QX56",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 520,
				ManufacturerId = 37,
				ModelName = "QX60",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 521,
				ManufacturerId = 37,
				ModelName = "QX70",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 522,
				ManufacturerId = 37,
				ModelName = "QX80",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 523,
				ManufacturerId = 38,
				ModelName = "Ascender",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 524,
				ManufacturerId = 38,
				ModelName = "Axiom",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 525,
				ManufacturerId = 38,
				ModelName = "D-Max",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 526,
				ManufacturerId = 38,
				ModelName = "D-Max Rodeo",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 527,
				ManufacturerId = 38,
				ModelName = "I280",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 528,
				ManufacturerId = 38,
				ModelName = "I290",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 529,
				ManufacturerId = 38,
				ModelName = "I350",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 530,
				ManufacturerId = 38,
				ModelName = "I370",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 531,
				ManufacturerId = 38,
				ModelName = "Rodeo",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 532,
				ManufacturerId = 38,
				ModelName = "Trooper",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				Id = 533,
				ManufacturerId = 38,
				ModelName = "VehiCross",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 534,
				ManufacturerId = 39,
				ModelName = "Daily",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 535,
				ManufacturerId = 40,
				ModelName = "E-Pace",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 536,
				ManufacturerId = 40,
				ModelName = "F-Pace",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 537,
				ManufacturerId = 40,
				ModelName = "F-Type",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 538,
				ManufacturerId = 40,
				ModelName = "I-Pace",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 539,
				ManufacturerId = 40,
				ModelName = "S-Type",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 540,
				ManufacturerId = 40,
				ModelName = "X-Type",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 541,
				ManufacturerId = 40,
				ModelName = "XE",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 542,
				ManufacturerId = 40,
				ModelName = "XF",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 543,
				ManufacturerId = 40,
				ModelName = "XJ",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 544,
				ManufacturerId = 40,
				ModelName = "XK/XKR",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 545,
				ManufacturerId = 41,
				ModelName = "Cherokee",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 546,
				ManufacturerId = 41,
				ModelName = "Commander",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 547,
				ManufacturerId = 41,
				ModelName = "Compass",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 548,
				ManufacturerId = 41,
				ModelName = "Gladiator",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 549,
				ManufacturerId = 41,
				ModelName = "Grand Cherokee",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 550,
				ManufacturerId = 41,
				ModelName = "Liberty",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 551,
				ManufacturerId = 41,
				ModelName = "Patriot",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 552,
				ManufacturerId = 41,
				ModelName = "Renegade",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 553,
				ManufacturerId = 41,
				ModelName = "Wrangler",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 554,
				ManufacturerId = 42,
				ModelName = "Carens",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 555,
				ManufacturerId = 42,
				ModelName = "Carnival",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 556,
				ManufacturerId = 42,
				ModelName = "Ceed",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 557,
				ManufacturerId = 42,
				ModelName = "Cerato",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 558,
				ManufacturerId = 42,
				ModelName = "Clarus",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 559,
				ManufacturerId = 42,
				ModelName = "Forte",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 560,
				ManufacturerId = 42,
				ModelName = "K900",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 561,
				ManufacturerId = 42,
				ModelName = "Magentis",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 562,
				ManufacturerId = 42,
				ModelName = "Mohave",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 563,
				ManufacturerId = 42,
				ModelName = "Niro",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 564,
				ManufacturerId = 42,
				ModelName = "Opirus",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 565,
				ManufacturerId = 42,
				ModelName = "Optima",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 566,
				ManufacturerId = 42,
				ModelName = "Picanto",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 567,
				ManufacturerId = 42,
				ModelName = "ProCeed",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 568,
				ManufacturerId = 42,
				ModelName = "Quoris",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 569,
				ManufacturerId = 42,
				ModelName = "Ray",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 570,
				ManufacturerId = 42,
				ModelName = "Rio",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 571,
				ManufacturerId = 42,
				ModelName = "Rio X-Line",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 572,
				ManufacturerId = 42,
				ModelName = "Seltos",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 573,
				ManufacturerId = 42,
				ModelName = "Shuma",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 574,
				ManufacturerId = 42,
				ModelName = "Sorento",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 575,
				ManufacturerId = 42,
				ModelName = "Sorento Prime",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 576,
				ManufacturerId = 42,
				ModelName = "Soul",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 577,
				ManufacturerId = 42,
				ModelName = "Spectra",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 578,
				ManufacturerId = 42,
				ModelName = "Sportage",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				Id = 579,
				ManufacturerId = 42,
				ModelName = "Stinger",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 580,
				ManufacturerId = 42,
				ModelName = "Stonic",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 581,
				ManufacturerId = 42,
				ModelName = "Telluride",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 582,
				ManufacturerId = 42,
				ModelName = "Venga",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 583,
				ManufacturerId = 43,
				ModelName = "Aventador",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 584,
				ManufacturerId = 43,
				ModelName = "Centenario",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 585,
				ManufacturerId = 43,
				ModelName = "Diablo",
				Year = 1991,
				Is_Active = true
			},
			new Model()
			{
				Id = 586,
				ManufacturerId = 43,
				ModelName = "Gallardo",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 587,
				ManufacturerId = 43,
				ModelName = "Huracan",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 588,
				ManufacturerId = 43,
				ModelName = "Murcielago",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 589,
				ManufacturerId = 43,
				ModelName = "Reventon",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 590,
				ManufacturerId = 43,
				ModelName = "Urus",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 591,
				ManufacturerId = 44,
				ModelName = "Delta",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 592,
				ManufacturerId = 44,
				ModelName = "Lybra",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 593,
				ManufacturerId = 44,
				ModelName = "Musa",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 594,
				ManufacturerId = 44,
				ModelName = "Phedra",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 595,
				ManufacturerId = 44,
				ModelName = "Thema",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 596,
				ManufacturerId = 44,
				ModelName = "Thesis",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 597,
				ManufacturerId = 44,
				ModelName = "Ypsilon",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 598,
				ManufacturerId = 45,
				ModelName = "Defender",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 599,
				ManufacturerId = 45,
				ModelName = "Discovery",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 600,
				ManufacturerId = 45,
				ModelName = "Discovery Sport",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 601,
				ManufacturerId = 45,
				ModelName = "Evoque",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 602,
				ManufacturerId = 45,
				ModelName = "Freelander",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 603,
				ManufacturerId = 45,
				ModelName = "Range Rover",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 604,
				ManufacturerId = 45,
				ModelName = "Range Rover Sport",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 605,
				ManufacturerId = 45,
				ModelName = "Range Rover Velar",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 606,
				ManufacturerId = 46,
				ModelName = "CT",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 607,
				ManufacturerId = 46,
				ModelName = "ES",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 608,
				ManufacturerId = 46,
				ModelName = "GS",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 609,
				ManufacturerId = 46,
				ModelName = "GX",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 610,
				ManufacturerId = 46,
				ModelName = "HS",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 611,
				ManufacturerId = 46,
				ModelName = "IS",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 612,
				ManufacturerId = 46,
				ModelName = "LC",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 613,
				ManufacturerId = 46,
				ModelName = "LFA",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 614,
				ManufacturerId = 46,
				ModelName = "LS",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 615,
				ManufacturerId = 46,
				ModelName = "LX",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 616,
				ManufacturerId = 46,
				ModelName = "NX",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 617,
				ManufacturerId = 46,
				ModelName = "RC",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 618,
				ManufacturerId = 46,
				ModelName = "RX",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 619,
				ManufacturerId = 46,
				ModelName = "SC",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 620,
				ManufacturerId = 46,
				ModelName = "UX",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 621,
				ManufacturerId = 47,
				ModelName = "Breez",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 622,
				ManufacturerId = 47,
				ModelName = "Cebrium",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 623,
				ManufacturerId = 47,
				ModelName = "Celliya",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 624,
				ManufacturerId = 47,
				ModelName = "Smily",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 625,
				ManufacturerId = 47,
				ModelName = "Solano",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 626,
				ManufacturerId = 47,
				ModelName = "X50",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 627,
				ManufacturerId = 47,
				ModelName = "X60",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 628,
				ManufacturerId = 48,
				ModelName = "Aviator",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 629,
				ManufacturerId = 48,
				ModelName = "Corsair",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 630,
				ManufacturerId = 48,
				ModelName = "Mark LT",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 631,
				ManufacturerId = 48,
				ModelName = "MKC",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 632,
				ManufacturerId = 48,
				ModelName = "MKS",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 633,
				ManufacturerId = 48,
				ModelName = "MKT",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 634,
				ManufacturerId = 48,
				ModelName = "MKX",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 635,
				ManufacturerId = 48,
				ModelName = "MKZ",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 636,
				ManufacturerId = 48,
				ModelName = "Navigator",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 637,
				ManufacturerId = 48,
				ModelName = "Town Car",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 638,
				ManufacturerId = 48,
				ModelName = "Zephyr",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 639,
				ManufacturerId = 49,
				ModelName = "Elise",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 640,
				ManufacturerId = 49,
				ModelName = "Europa S",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 641,
				ManufacturerId = 49,
				ModelName = "Evora",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 642,
				ManufacturerId = 49,
				ModelName = "Exige",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 643,
				ManufacturerId = 50,
				ModelName = "B1",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 644,
				ManufacturerId = 50,
				ModelName = "B2",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 645,
				ManufacturerId = 51,
				ModelName = "3200 GT",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 646,
				ManufacturerId = 51,
				ModelName = "Ghibli",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 647,
				ManufacturerId = 51,
				ModelName = "Gran Cabrio",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 648,
				ManufacturerId = 51,
				ModelName = "Gran Turismo",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 649,
				ManufacturerId = 51,
				ModelName = "Gran Turismo S",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 650,
				ManufacturerId = 51,
				ModelName = "Levante",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 651,
				ManufacturerId = 51,
				ModelName = "Quattroporte",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 652,
				ManufacturerId = 51,
				ModelName = "Quattroporte S",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 653,
				ManufacturerId = 52,
				ModelName = "57",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 654,
				ManufacturerId = 52,
				ModelName = "57 S",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 655,
				ManufacturerId = 52,
				ModelName = "62",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 656,
				ManufacturerId = 52,
				ModelName = "62 S",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 657,
				ManufacturerId = 52,
				ModelName = "Landaulet",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 658,
				ManufacturerId = 53,
				ModelName = "2",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 659,
				ManufacturerId = 53,
				ModelName = "3",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 660,
				ManufacturerId = 53,
				ModelName = "323",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 661,
				ManufacturerId = 53,
				ModelName = "5",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 662,
				ManufacturerId = 53,
				ModelName = "6",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 663,
				ManufacturerId = 53,
				ModelName = "626",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 664,
				ManufacturerId = 53,
				ModelName = "B-Series",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 665,
				ManufacturerId = 53,
				ModelName = "BT-50",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 666,
				ManufacturerId = 53,
				ModelName = "CX-3",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 667,
				ManufacturerId = 53,
				ModelName = "CX-5",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 668,
				ManufacturerId = 53,
				ModelName = "CX-7",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 669,
				ManufacturerId = 53,
				ModelName = "CX-9",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 670,
				ManufacturerId = 53,
				ModelName = "MPV",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 671,
				ManufacturerId = 53,
				ModelName = "MX-5",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 672,
				ManufacturerId = 53,
				ModelName = "Premacy",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 673,
				ManufacturerId = 53,
				ModelName = "RX-7",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				Id = 674,
				ManufacturerId = 53,
				ModelName = "RX-8",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 675,
				ManufacturerId = 53,
				ModelName = "Tribute",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 676,
				ManufacturerId = 54,
				ModelName = "540C",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 677,
				ManufacturerId = 54,
				ModelName = "570S",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 678,
				ManufacturerId = 54,
				ModelName = "600LT",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 679,
				ManufacturerId = 54,
				ModelName = "650S",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 680,
				ManufacturerId = 54,
				ModelName = "675LT",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 681,
				ManufacturerId = 54,
				ModelName = "720S",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 682,
				ManufacturerId = 54,
				ModelName = "MP4-12C",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 683,
				ManufacturerId = 54,
				ModelName = "P1",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 684,
				ManufacturerId = 55,
				ModelName = "A-class",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 685,
				ManufacturerId = 55,
				ModelName = "AMG GT",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 686,
				ManufacturerId = 55,
				ModelName = "AMG GT 4-Door",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 687,
				ManufacturerId = 55,
				ModelName = "B-class",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 688,
				ManufacturerId = 55,
				ModelName = "C-class",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 689,
				ManufacturerId = 55,
				ModelName = "C-class Sport Coupe",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 690,
				ManufacturerId = 55,
				ModelName = "CL-class",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				Id = 691,
				ManufacturerId = 55,
				ModelName = "CLA-class",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 692,
				ManufacturerId = 55,
				ModelName = "CLC-class",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 693,
				ManufacturerId = 55,
				ModelName = "CLK-class",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 694,
				ManufacturerId = 55,
				ModelName = "CLS-class",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 695,
				ManufacturerId = 55,
				ModelName = "E-class",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 696,
				ManufacturerId = 55,
				ModelName = "E-class Coupe",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 697,
				ManufacturerId = 55,
				ModelName = "EQC",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 698,
				ManufacturerId = 55,
				ModelName = "G-class",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 699,
				ManufacturerId = 55,
				ModelName = "GL-class",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 700,
				ManufacturerId = 55,
				ModelName = "GLA-class",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 701,
				ManufacturerId = 55,
				ModelName = "GLB-class",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 702,
				ManufacturerId = 55,
				ModelName = "GLC-class",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 703,
				ManufacturerId = 55,
				ModelName = "GLC-class Coupe",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 704,
				ManufacturerId = 55,
				ModelName = "GLE-class",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 705,
				ManufacturerId = 55,
				ModelName = "GLE-class Coupe",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 706,
				ManufacturerId = 55,
				ModelName = "GLK-class",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 707,
				ManufacturerId = 55,
				ModelName = "GLS-class",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 708,
				ManufacturerId = 55,
				ModelName = "M-class",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 709,
				ManufacturerId = 55,
				ModelName = "R-class",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 710,
				ManufacturerId = 55,
				ModelName = "S-class",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				Id = 711,
				ManufacturerId = 55,
				ModelName = "S-class Cabrio",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 712,
				ManufacturerId = 55,
				ModelName = "S-class Coupe",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 713,
				ManufacturerId = 55,
				ModelName = "SL-class",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 714,
				ManufacturerId = 55,
				ModelName = "SLK-class",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 715,
				ManufacturerId = 55,
				ModelName = "SLR-class",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 716,
				ManufacturerId = 55,
				ModelName = "SLS AMG",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 717,
				ManufacturerId = 55,
				ModelName = "Sprinter",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 718,
				ManufacturerId = 55,
				ModelName = "Vaneo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 719,
				ManufacturerId = 55,
				ModelName = "Viano",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 720,
				ManufacturerId = 55,
				ModelName = "Vito",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 721,
				ManufacturerId = 55,
				ModelName = "X-class",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 722,
				ManufacturerId = 56,
				ModelName = "Grand Marquis",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 723,
				ManufacturerId = 56,
				ModelName = "Mariner",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 724,
				ManufacturerId = 56,
				ModelName = "Milan",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 725,
				ManufacturerId = 56,
				ModelName = "Montego",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 726,
				ManufacturerId = 56,
				ModelName = "Monterey",
				Year = 1991,
				Is_Active = true
			},
			new Model()
			{
				Id = 727,
				ManufacturerId = 56,
				ModelName = "Mountaineer",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 728,
				ManufacturerId = 56,
				ModelName = "Sable",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 729,
				ManufacturerId = 57,
				ModelName = "TF",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 730,
				ManufacturerId = 57,
				ModelName = "XPower SV",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 731,
				ManufacturerId = 57,
				ModelName = "ZR",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 732,
				ManufacturerId = 57,
				ModelName = "ZS",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 733,
				ManufacturerId = 57,
				ModelName = "ZT",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 734,
				ManufacturerId = 57,
				ModelName = "ZT-T",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 735,
				ManufacturerId = 58,
				ModelName = "Clubman",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 736,
				ManufacturerId = 58,
				ModelName = "Clubman S",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 737,
				ManufacturerId = 58,
				ModelName = "Clubvan",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 738,
				ManufacturerId = 58,
				ModelName = "Cooper",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 739,
				ManufacturerId = 58,
				ModelName = "Cooper Cabrio",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 740,
				ManufacturerId = 58,
				ModelName = "Cooper S",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 741,
				ManufacturerId = 58,
				ModelName = "Cooper S Cabrio",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 742,
				ManufacturerId = 58,
				ModelName = "Cooper S Countryman All4",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 743,
				ManufacturerId = 58,
				ModelName = "Countryman",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 744,
				ManufacturerId = 58,
				ModelName = "One",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 745,
				ManufacturerId = 59,
				ModelName = "3000 GT",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				Id = 746,
				ManufacturerId = 59,
				ModelName = "ASX",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 747,
				ManufacturerId = 59,
				ModelName = "Carisma",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 748,
				ManufacturerId = 59,
				ModelName = "Colt",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 749,
				ManufacturerId = 59,
				ModelName = "Dignity",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 750,
				ManufacturerId = 59,
				ModelName = "Eclipse",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 751,
				ManufacturerId = 59,
				ModelName = "Eclipse Cross",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 752,
				ManufacturerId = 59,
				ModelName = "Endeavor",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 753,
				ManufacturerId = 59,
				ModelName = "Galant",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 754,
				ManufacturerId = 59,
				ModelName = "Grandis",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 755,
				ManufacturerId = 59,
				ModelName = "i-MiEV",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 756,
				ManufacturerId = 59,
				ModelName = "L200",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 757,
				ManufacturerId = 59,
				ModelName = "Lancer",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 758,
				ManufacturerId = 59,
				ModelName = "Lancer Evo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 759,
				ManufacturerId = 59,
				ModelName = "Mirage",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 760,
				ManufacturerId = 59,
				ModelName = "Outlander",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 761,
				ManufacturerId = 59,
				ModelName = "Outlander XL",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 762,
				ManufacturerId = 59,
				ModelName = "Pajero",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				Id = 763,
				ManufacturerId = 59,
				ModelName = "Pajero Pinin",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 764,
				ManufacturerId = 59,
				ModelName = "Pajero Sport",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 765,
				ManufacturerId = 59,
				ModelName = "Raider",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 766,
				ManufacturerId = 59,
				ModelName = "Space Gear",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 767,
				ManufacturerId = 59,
				ModelName = "Space Runner",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 768,
				ManufacturerId = 59,
				ModelName = "Space Star",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 769,
				ManufacturerId = 60,
				ModelName = "350Z",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 770,
				ManufacturerId = 60,
				ModelName = "370Z",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 771,
				ManufacturerId = 60,
				ModelName = "Almera",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 772,
				ManufacturerId = 60,
				ModelName = "Almera Classic",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 773,
				ManufacturerId = 60,
				ModelName = "Almera Tino",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 774,
				ManufacturerId = 60,
				ModelName = "Altima",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 775,
				ManufacturerId = 60,
				ModelName = "Armada",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 776,
				ManufacturerId = 60,
				ModelName = "Bluebird Sylphy",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 777,
				ManufacturerId = 60,
				ModelName = "GT-R",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 778,
				ManufacturerId = 60,
				ModelName = "Juke",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 779,
				ManufacturerId = 60,
				ModelName = "Leaf",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 780,
				ManufacturerId = 60,
				ModelName = "Maxima",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 781,
				ManufacturerId = 60,
				ModelName = "Micra",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 782,
				ManufacturerId = 60,
				ModelName = "Murano",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 783,
				ManufacturerId = 60,
				ModelName = "Navara",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 784,
				ManufacturerId = 60,
				ModelName = "Note",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 785,
				ManufacturerId = 60,
				ModelName = "NP300",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 786,
				ManufacturerId = 60,
				ModelName = "Pathfinder",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 787,
				ManufacturerId = 60,
				ModelName = "Patrol",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 788,
				ManufacturerId = 60,
				ModelName = "Primera",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 789,
				ManufacturerId = 60,
				ModelName = "Qashqai",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 790,
				ManufacturerId = 60,
				ModelName = "Qashqai+2",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 791,
				ManufacturerId = 60,
				ModelName = "Quest",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 792,
				ManufacturerId = 60,
				ModelName = "Rogue",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 793,
				ManufacturerId = 60,
				ModelName = "Sentra",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 794,
				ManufacturerId = 60,
				ModelName = "Skyline",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 795,
				ManufacturerId = 60,
				ModelName = "Sylphy",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 796,
				ManufacturerId = 60,
				ModelName = "Teana",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 797,
				ManufacturerId = 60,
				ModelName = "Terrano",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				Id = 798,
				ManufacturerId = 60,
				ModelName = "Tiida",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 799,
				ManufacturerId = 60,
				ModelName = "Titan",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 800,
				ManufacturerId = 60,
				ModelName = "Titan XD",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 801,
				ManufacturerId = 60,
				ModelName = "X-Trail",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 802,
				ManufacturerId = 60,
				ModelName = "XTerra",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 803,
				ManufacturerId = 60,
				ModelName = "Z",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 804,
				ManufacturerId = 61,
				ModelName = "M600",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 805,
				ManufacturerId = 62,
				ModelName = "Adam",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 806,
				ManufacturerId = 62,
				ModelName = "Agila",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 807,
				ManufacturerId = 62,
				ModelName = "Antara",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 808,
				ManufacturerId = 62,
				ModelName = "Astra",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 809,
				ManufacturerId = 62,
				ModelName = "Astra GTS",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 810,
				ManufacturerId = 62,
				ModelName = "Cascada",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 811,
				ManufacturerId = 62,
				ModelName = "Combo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 812,
				ManufacturerId = 62,
				ModelName = "Corsa",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 813,
				ManufacturerId = 62,
				ModelName = "Corsa OPC",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 814,
				ManufacturerId = 62,
				ModelName = "Crossland X",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 815,
				ManufacturerId = 62,
				ModelName = "Frontera",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 816,
				ManufacturerId = 62,
				ModelName = "Grandland X",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 817,
				ManufacturerId = 62,
				ModelName = "Insignia",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 818,
				ManufacturerId = 62,
				ModelName = "Insignia OPC",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 819,
				ManufacturerId = 62,
				ModelName = "Karl",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 820,
				ManufacturerId = 62,
				ModelName = "Meriva",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 821,
				ManufacturerId = 62,
				ModelName = "Mokka",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 822,
				ManufacturerId = 62,
				ModelName = "Omega",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 823,
				ManufacturerId = 62,
				ModelName = "Signum",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 824,
				ManufacturerId = 62,
				ModelName = "Speedster",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 825,
				ManufacturerId = 62,
				ModelName = "Tigra",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 826,
				ManufacturerId = 62,
				ModelName = "Vectra",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 827,
				ManufacturerId = 62,
				ModelName = "Vivaro",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 828,
				ManufacturerId = 62,
				ModelName = "Zafira",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 829,
				ManufacturerId = 62,
				ModelName = "Zafira Tourer",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 830,
				ManufacturerId = 63,
				ModelName = "1007",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 831,
				ManufacturerId = 63,
				ModelName = "107",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 832,
				ManufacturerId = 63,
				ModelName = "108",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 833,
				ManufacturerId = 63,
				ModelName = "2008",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 834,
				ManufacturerId = 63,
				ModelName = "206",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 835,
				ManufacturerId = 63,
				ModelName = "207",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 836,
				ManufacturerId = 63,
				ModelName = "208",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 837,
				ManufacturerId = 63,
				ModelName = "3008",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 838,
				ManufacturerId = 63,
				ModelName = "301",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 839,
				ManufacturerId = 63,
				ModelName = "307",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 840,
				ManufacturerId = 63,
				ModelName = "308",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 841,
				ManufacturerId = 63,
				ModelName = "4007",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 842,
				ManufacturerId = 63,
				ModelName = "4008",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 843,
				ManufacturerId = 63,
				ModelName = "406",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 844,
				ManufacturerId = 63,
				ModelName = "407",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 845,
				ManufacturerId = 63,
				ModelName = "408",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 846,
				ManufacturerId = 63,
				ModelName = "5008",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 847,
				ManufacturerId = 63,
				ModelName = "508",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 848,
				ManufacturerId = 63,
				ModelName = "607",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 849,
				ManufacturerId = 63,
				ModelName = "807",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 850,
				ManufacturerId = 63,
				ModelName = "Boxer",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 851,
				ManufacturerId = 63,
				ModelName = "Partner",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 852,
				ManufacturerId = 63,
				ModelName = "RCZ Sport",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 853,
				ManufacturerId = 64,
				ModelName = "Road Runner",
				Year = 1968,
				Is_Active = true
			},
			new Model()
			{
				Id = 854,
				ManufacturerId = 65,
				ModelName = "Aztec",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 855,
				ManufacturerId = 65,
				ModelName = "Bonneville",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 856,
				ManufacturerId = 65,
				ModelName = "Firebird",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				Id = 857,
				ManufacturerId = 65,
				ModelName = "G5 Pursuit",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 858,
				ManufacturerId = 65,
				ModelName = "G6",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 859,
				ManufacturerId = 65,
				ModelName = "G8",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 860,
				ManufacturerId = 65,
				ModelName = "Grand AM",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 861,
				ManufacturerId = 65,
				ModelName = "Grand Prix",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 862,
				ManufacturerId = 65,
				ModelName = "GTO",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 863,
				ManufacturerId = 65,
				ModelName = "Montana",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 864,
				ManufacturerId = 65,
				ModelName = "Solstice",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 865,
				ManufacturerId = 65,
				ModelName = "Sunfire",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 866,
				ManufacturerId = 65,
				ModelName = "Torrent",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 867,
				ManufacturerId = 65,
				ModelName = "Vibe",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 868,
				ManufacturerId = 66,
				ModelName = "718 Boxster",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 869,
				ManufacturerId = 66,
				ModelName = "718 Cayman",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 870,
				ManufacturerId = 66,
				ModelName = "911",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 871,
				ManufacturerId = 66,
				ModelName = "Boxster",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 872,
				ManufacturerId = 66,
				ModelName = "Cayenne",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 873,
				ManufacturerId = 66,
				ModelName = "Cayman",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 874,
				ManufacturerId = 66,
				ModelName = "Macan",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 875,
				ManufacturerId = 66,
				ModelName = "Panamera",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 876,
				ManufacturerId = 66,
				ModelName = "Taycan",
				Year = 2020,
				Is_Active = true
			},
			new Model()
			{
				Id = 877,
				ManufacturerId = 67,
				ModelName = "Gentra",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 878,
				ManufacturerId = 68,
				ModelName = "Arkana",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 879,
				ManufacturerId = 68,
				ModelName = "Avantime",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 880,
				ManufacturerId = 68,
				ModelName = "Captur",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 881,
				ManufacturerId = 68,
				ModelName = "Clio",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 882,
				ManufacturerId = 68,
				ModelName = "Duster",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 883,
				ManufacturerId = 68,
				ModelName = "Duster Oroch",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 884,
				ManufacturerId = 68,
				ModelName = "Espace",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 885,
				ManufacturerId = 68,
				ModelName = "Fluence",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 886,
				ManufacturerId = 68,
				ModelName = "Grand Scenic",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 887,
				ManufacturerId = 68,
				ModelName = "Kadjar",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 888,
				ManufacturerId = 68,
				ModelName = "Kangoo",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 889,
				ManufacturerId = 68,
				ModelName = "Kaptur",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 890,
				ManufacturerId = 68,
				ModelName = "Koleos",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 891,
				ManufacturerId = 68,
				ModelName = "Laguna",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				Id = 892,
				ManufacturerId = 68,
				ModelName = "Latitude",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 893,
				ManufacturerId = 68,
				ModelName = "Logan",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 894,
				ManufacturerId = 68,
				ModelName = "Master",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 895,
				ManufacturerId = 68,
				ModelName = "Megane",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 896,
				ManufacturerId = 68,
				ModelName = "Modus",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 897,
				ManufacturerId = 68,
				ModelName = "Sandero",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 898,
				ManufacturerId = 68,
				ModelName = "Sandero Stepway",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 899,
				ManufacturerId = 68,
				ModelName = "Scenic",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 900,
				ManufacturerId = 68,
				ModelName = "Symbol",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 901,
				ManufacturerId = 68,
				ModelName = "Talisman",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 902,
				ManufacturerId = 68,
				ModelName = "Trafic",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 903,
				ManufacturerId = 68,
				ModelName = "Twingo",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				Id = 904,
				ManufacturerId = 68,
				ModelName = "Twizy",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 905,
				ManufacturerId = 68,
				ModelName = "Vel Satis",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 906,
				ManufacturerId = 68,
				ModelName = "Wind",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 907,
				ManufacturerId = 68,
				ModelName = "Zoe",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 908,
				ManufacturerId = 69,
				ModelName = "Cullinan",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 909,
				ManufacturerId = 69,
				ModelName = "Dawn",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 910,
				ManufacturerId = 69,
				ModelName = "Ghost",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 911,
				ManufacturerId = 69,
				ModelName = "Phantom",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 912,
				ManufacturerId = 69,
				ModelName = "Wraith",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 913,
				ManufacturerId = 70,
				ModelName = "25",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 914,
				ManufacturerId = 70,
				ModelName = "400",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 915,
				ManufacturerId = 70,
				ModelName = "45",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 916,
				ManufacturerId = 70,
				ModelName = "600",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 917,
				ManufacturerId = 70,
				ModelName = "75",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 918,
				ManufacturerId = 70,
				ModelName = "Streetwise",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 919,
				ManufacturerId = 71,
				ModelName = "9-2x",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 920,
				ManufacturerId = 71,
				ModelName = "9-3",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 921,
				ManufacturerId = 71,
				ModelName = "9-4x",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 922,
				ManufacturerId = 71,
				ModelName = "9-5",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 923,
				ManufacturerId = 71,
				ModelName = "9-7x",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 924,
				ManufacturerId = 72,
				ModelName = "Aura",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 925,
				ManufacturerId = 72,
				ModelName = "Ion",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 926,
				ManufacturerId = 72,
				ModelName = "LW",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 927,
				ManufacturerId = 72,
				ModelName = "Outlook",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 928,
				ManufacturerId = 72,
				ModelName = "Sky",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 929,
				ManufacturerId = 72,
				ModelName = "Vue",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 930,
				ManufacturerId = 73,
				ModelName = "FR-S",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 931,
				ManufacturerId = 73,
				ModelName = "tC",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 932,
				ManufacturerId = 73,
				ModelName = "xA",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 933,
				ManufacturerId = 73,
				ModelName = "xB",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 934,
				ManufacturerId = 73,
				ModelName = "xD",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 935,
				ManufacturerId = 74,
				ModelName = "Alhambra",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 936,
				ManufacturerId = 74,
				ModelName = "Altea",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 937,
				ManufacturerId = 74,
				ModelName = "Altea Freetrack",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 938,
				ManufacturerId = 74,
				ModelName = "Altea XL",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 939,
				ManufacturerId = 74,
				ModelName = "Arosa",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 940,
				ManufacturerId = 74,
				ModelName = "Ateca",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 941,
				ManufacturerId = 74,
				ModelName = "Cordoba",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 942,
				ManufacturerId = 74,
				ModelName = "Exeo",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 943,
				ManufacturerId = 74,
				ModelName = "Ibiza",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 944,
				ManufacturerId = 74,
				ModelName = "Leon",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 945,
				ManufacturerId = 74,
				ModelName = "Mii",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 946,
				ManufacturerId = 74,
				ModelName = "Toledo",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 947,
				ManufacturerId = 75,
				ModelName = "Citigo",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 948,
				ManufacturerId = 75,
				ModelName = "Fabia",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 949,
				ManufacturerId = 75,
				ModelName = "Felicia",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 950,
				ManufacturerId = 75,
				ModelName = "Kamiq",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 951,
				ManufacturerId = 75,
				ModelName = "Karoq",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 952,
				ManufacturerId = 75,
				ModelName = "Kodiaq",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 953,
				ManufacturerId = 75,
				ModelName = "Octavia",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 954,
				ManufacturerId = 75,
				ModelName = "Octavia Scout",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 955,
				ManufacturerId = 75,
				ModelName = "Octavia Tour",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 956,
				ManufacturerId = 75,
				ModelName = "Praktik",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 957,
				ManufacturerId = 75,
				ModelName = "Rapid",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 958,
				ManufacturerId = 75,
				ModelName = "Rapid Spaceback (NH1)",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 959,
				ManufacturerId = 75,
				ModelName = "Roomster",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 960,
				ManufacturerId = 75,
				ModelName = "Superb",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 961,
				ManufacturerId = 75,
				ModelName = "Yeti",
				Year = 2010,
				Is_Active = true
			},
			new Model()
			{
				Id = 962,
				ManufacturerId = 76,
				ModelName = "Forfour",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 963,
				ManufacturerId = 76,
				ModelName = "Fortwo",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 964,
				ManufacturerId = 76,
				ModelName = "Roadster",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 965,
				ManufacturerId = 77,
				ModelName = "Actyon",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 966,
				ManufacturerId = 77,
				ModelName = "Actyon Sports",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 967,
				ManufacturerId = 77,
				ModelName = "Chairman",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 968,
				ManufacturerId = 77,
				ModelName = "Korando",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 969,
				ManufacturerId = 77,
				ModelName = "Kyron",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 970,
				ManufacturerId = 77,
				ModelName = "Musso",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				Id = 971,
				ManufacturerId = 77,
				ModelName = "Musso Sport",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 972,
				ManufacturerId = 77,
				ModelName = "Rexton",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 973,
				ManufacturerId = 77,
				ModelName = "Rodius",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 974,
				ManufacturerId = 77,
				ModelName = "Stavic",
				Year = 2013,
				Is_Active = true
			},
			new Model()
			{
				Id = 975,
				ManufacturerId = 77,
				ModelName = "Tivoli",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 976,
				ManufacturerId = 77,
				ModelName = "XLV",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 977,
				ManufacturerId = 78,
				ModelName = "Ascent",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 978,
				ManufacturerId = 78,
				ModelName = "Baja",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 979,
				ManufacturerId = 78,
				ModelName = "Crosstrack",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 980,
				ManufacturerId = 78,
				ModelName = "Exiga",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 981,
				ManufacturerId = 78,
				ModelName = "Forester",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 982,
				ManufacturerId = 78,
				ModelName = "Impreza",
				Year = 1992,
				Is_Active = true
			},
			new Model()
			{
				Id = 983,
				ManufacturerId = 78,
				ModelName = "Justy",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 984,
				ManufacturerId = 78,
				ModelName = "Legacy",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 985,
				ManufacturerId = 78,
				ModelName = "Levorg",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 986,
				ManufacturerId = 78,
				ModelName = "Outback",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 987,
				ManufacturerId = 78,
				ModelName = "Traviq",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 988,
				ManufacturerId = 78,
				ModelName = "Tribeca",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 989,
				ManufacturerId = 78,
				ModelName = "WRX",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 990,
				ManufacturerId = 78,
				ModelName = "XV",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 991,
				ManufacturerId = 79,
				ModelName = "Alto",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 992,
				ManufacturerId = 79,
				ModelName = "Baleno",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 993,
				ManufacturerId = 79,
				ModelName = "Celerio",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 994,
				ManufacturerId = 79,
				ModelName = "Ciaz",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 995,
				ManufacturerId = 79,
				ModelName = "Grand Vitara",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 996,
				ManufacturerId = 79,
				ModelName = "Grand Vitara XL7",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 997,
				ManufacturerId = 79,
				ModelName = "Ignis",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 998,
				ManufacturerId = 79,
				ModelName = "Jimny",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 999,
				ManufacturerId = 79,
				ModelName = "Kizashi",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 1000,
				ManufacturerId = 79,
				ModelName = "Liana",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 1001,
				ManufacturerId = 79,
				ModelName = "Splash",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 1002,
				ManufacturerId = 79,
				ModelName = "Swift",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 1003,
				ManufacturerId = 79,
				ModelName = "SX4",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 1004,
				ManufacturerId = 79,
				ModelName = "Vitara",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 1005,
				ManufacturerId = 79,
				ModelName = "Wagon R",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 1006,
				ManufacturerId = 79,
				ModelName = "Wagon R+",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 1007,
				ManufacturerId = 80,
				ModelName = "Model 3",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 1008,
				ManufacturerId = 80,
				ModelName = "Model S",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 1009,
				ManufacturerId = 80,
				ModelName = "Model X",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 1010,
				ManufacturerId = 80,
				ModelName = "Model Y",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 1011,
				ManufacturerId = 81,
				ModelName = "4Runner",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 1012,
				ManufacturerId = 81,
				ModelName = "Alphard",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 1013,
				ManufacturerId = 81,
				ModelName = "Auris",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 1014,
				ManufacturerId = 81,
				ModelName = "Avalon",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 1015,
				ManufacturerId = 81,
				ModelName = "Avensis",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 1016,
				ManufacturerId = 81,
				ModelName = "Avensis Verso",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 1017,
				ManufacturerId = 81,
				ModelName = "Aygo",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 1018,
				ManufacturerId = 81,
				ModelName = "C-HR",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 1019,
				ManufacturerId = 81,
				ModelName = "Caldina",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 1020,
				ManufacturerId = 81,
				ModelName = "Camry",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 1021,
				ManufacturerId = 81,
				ModelName = "Celica",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 1022,
				ManufacturerId = 81,
				ModelName = "Corolla",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 1023,
				ManufacturerId = 81,
				ModelName = "Corolla Verso",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 1024,
				ManufacturerId = 81,
				ModelName = "FJ Cruiser",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 1025,
				ManufacturerId = 81,
				ModelName = "Fortuner",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 1026,
				ManufacturerId = 81,
				ModelName = "GT 86",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 1027,
				ManufacturerId = 81,
				ModelName = "Hiace",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 1028,
				ManufacturerId = 81,
				ModelName = "Highlander",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 1029,
				ManufacturerId = 81,
				ModelName = "Hilux",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 1030,
				ManufacturerId = 81,
				ModelName = "iQ",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 1031,
				ManufacturerId = 81,
				ModelName = "ist",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 1032,
				ManufacturerId = 81,
				ModelName = "Land Cruiser",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				Id = 1033,
				ManufacturerId = 81,
				ModelName = "Land Cruiser Prado",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 1034,
				ManufacturerId = 81,
				ModelName = "Mark II",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 1035,
				ManufacturerId = 81,
				ModelName = "Mirai",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 1036,
				ManufacturerId = 81,
				ModelName = "MR2",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 1037,
				ManufacturerId = 81,
				ModelName = "Picnic",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 1038,
				ManufacturerId = 81,
				ModelName = "Previa",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 1039,
				ManufacturerId = 81,
				ModelName = "Prius",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 1040,
				ManufacturerId = 81,
				ModelName = "RAV4",
				Year = 1994,
				Is_Active = true
			},
			new Model()
			{
				Id = 1041,
				ManufacturerId = 81,
				ModelName = "Sequoia",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 1042,
				ManufacturerId = 81,
				ModelName = "Sienna",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 1043,
				ManufacturerId = 81,
				ModelName = "Supra",
				Year = 2019,
				Is_Active = true
			},
			new Model()
			{
				Id = 1044,
				ManufacturerId = 81,
				ModelName = "Tacoma",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 1045,
				ManufacturerId = 81,
				ModelName = "Tundra",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 1046,
				ManufacturerId = 81,
				ModelName = "Venza",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 1047,
				ManufacturerId = 81,
				ModelName = "Verso",
				Year = 2009,
				Is_Active = true
			},
			new Model()
			{
				Id = 1048,
				ManufacturerId = 81,
				ModelName = "Vitz",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 1049,
				ManufacturerId = 81,
				ModelName = "Yaris",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 1050,
				ManufacturerId = 81,
				ModelName = "Yaris Verso",
				Year = 1999,
				Is_Active = true
			},
			new Model()
			{
				Id = 1051,
				ManufacturerId = 82,
				ModelName = "Pickup",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 1052,
				ManufacturerId = 82,
				ModelName = "Патриот",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 1053,
				ManufacturerId = 82,
				ModelName = "Хантер",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 1054,
				ManufacturerId = 83,
				ModelName = "2101-2107",
				Year = 1976,
				Is_Active = true
			},
			new Model()
			{
				Id = 1055,
				ManufacturerId = 83,
				ModelName = "2108, 2109, 21099",
				Year = 1984,
				Is_Active = true
			},
			new Model()
			{
				Id = 1056,
				ManufacturerId = 83,
				ModelName = "2110, 2111, 2112",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 1057,
				ManufacturerId = 83,
				ModelName = "2113, 2114, 2115",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 1058,
				ManufacturerId = 83,
				ModelName = "4x4 Urban",
				Year = 2014,
				Is_Active = true
			},
			new Model()
			{
				Id = 1059,
				ManufacturerId = 83,
				ModelName = "Granta",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 1060,
				ManufacturerId = 83,
				ModelName = "Largus",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 1061,
				ManufacturerId = 83,
				ModelName = "Largus Cross",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 1062,
				ManufacturerId = 83,
				ModelName = "Vesta Cross",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 1063,
				ManufacturerId = 83,
				ModelName = "Vesta Sport",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 1064,
				ManufacturerId = 83,
				ModelName = "Vesta SW",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 1065,
				ManufacturerId = 83,
				ModelName = "XRay",
				Year = 2016,
				Is_Active = true
			},
			new Model()
			{
				Id = 1066,
				ManufacturerId = 83,
				ModelName = "XRay Cross",
				Year = 2018,
				Is_Active = true
			},
			new Model()
			{
				Id = 1067,
				ManufacturerId = 83,
				ModelName = "Веста",
				Year = 2015,
				Is_Active = true
			},
			new Model()
			{
				Id = 1068,
				ManufacturerId = 83,
				ModelName = "Калина",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 1069,
				ManufacturerId = 83,
				ModelName = "Нива 4X4",
				Year = 1977,
				Is_Active = true
			},
			new Model()
			{
				Id = 1070,
				ManufacturerId = 83,
				ModelName = "Ока",
				Year = 1988,
				Is_Active = true
			},
			new Model()
			{
				Id = 1071,
				ManufacturerId = 83,
				ModelName = "Приора",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 1072,
				ManufacturerId = 84,
				ModelName = "Amarok",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				Id = 1073,
				ManufacturerId = 84,
				ModelName = "Arteon",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 1074,
				ManufacturerId = 84,
				ModelName = "Beetle",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 1075,
				ManufacturerId = 84,
				ModelName = "Bora",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 1076,
				ManufacturerId = 84,
				ModelName = "Caddy",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 1077,
				ManufacturerId = 84,
				ModelName = "CC",
				Year = 2012,
				Is_Active = true
			},
			new Model()
			{
				Id = 1078,
				ManufacturerId = 84,
				ModelName = "Crafter",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 1079,
				ManufacturerId = 84,
				ModelName = "CrossGolf",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 1080,
				ManufacturerId = 84,
				ModelName = "CrossPolo",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 1081,
				ManufacturerId = 84,
				ModelName = "CrossTouran",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 1082,
				ManufacturerId = 84,
				ModelName = "Eos",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 1083,
				ManufacturerId = 84,
				ModelName = "Fox",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 1084,
				ManufacturerId = 84,
				ModelName = "Golf",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 1085,
				ManufacturerId = 84,
				ModelName = "Jetta",
				Year = 2005,
				Is_Active = true
			},
			new Model()
			{
				Id = 1086,
				ManufacturerId = 84,
				ModelName = "Lupo",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 1087,
				ManufacturerId = 84,
				ModelName = "Multivan",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 1088,
				ManufacturerId = 84,
				ModelName = "New Beetle",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 1089,
				ManufacturerId = 84,
				ModelName = "Passat",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 1090,
				ManufacturerId = 84,
				ModelName = "Passat CC",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 1091,
				ManufacturerId = 84,
				ModelName = "Phaeton",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 1092,
				ManufacturerId = 84,
				ModelName = "Pointer",
				Year = 1993,
				Is_Active = true
			},
			new Model()
			{
				Id = 1093,
				ManufacturerId = 84,
				ModelName = "Polo",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 1094,
				ManufacturerId = 84,
				ModelName = "Routan",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 1095,
				ManufacturerId = 84,
				ModelName = "Scirocco",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 1096,
				ManufacturerId = 84,
				ModelName = "Sharan",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 1097,
				ManufacturerId = 84,
				ModelName = "T-Roc",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 1098,
				ManufacturerId = 84,
				ModelName = "Teramont",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 1099,
				ManufacturerId = 84,
				ModelName = "Tiguan",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 1100,
				ManufacturerId = 84,
				ModelName = "Touareg",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 1101,
				ManufacturerId = 84,
				ModelName = "Touran",
				Year = 2003,
				Is_Active = true
			},
			new Model()
			{
				Id = 1102,
				ManufacturerId = 84,
				ModelName = "Transporter",
				Year = 1990,
				Is_Active = true
			},
			new Model()
			{
				Id = 1103,
				ManufacturerId = 84,
				ModelName = "Up",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 1104,
				ManufacturerId = 85,
				ModelName = "C30",
				Year = 2007,
				Is_Active = true
			},
			new Model()
			{
				Id = 1105,
				ManufacturerId = 85,
				ModelName = "C70",
				Year = 2006,
				Is_Active = true
			},
			new Model()
			{
				Id = 1106,
				ManufacturerId = 85,
				ModelName = "C70 Convertible",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 1107,
				ManufacturerId = 85,
				ModelName = "C70 Coupe",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 1108,
				ManufacturerId = 85,
				ModelName = "S40",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 1109,
				ManufacturerId = 85,
				ModelName = "S60",
				Year = 2000,
				Is_Active = true
			},
			new Model()
			{
				Id = 1110,
				ManufacturerId = 85,
				ModelName = "S70",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 1111,
				ManufacturerId = 85,
				ModelName = "S80",
				Year = 1998,
				Is_Active = true
			},
			new Model()
			{
				Id = 1112,
				ManufacturerId = 85,
				ModelName = "S90",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 1113,
				ManufacturerId = 85,
				ModelName = "V40",
				Year = 1995,
				Is_Active = true
			},
			new Model()
			{
				Id = 1114,
				ManufacturerId = 85,
				ModelName = "V50",
				Year = 2004,
				Is_Active = true
			},
			new Model()
			{
				Id = 1115,
				ManufacturerId = 85,
				ModelName = "V60",
				Year = 2011,
				Is_Active = true
			},
			new Model()
			{
				Id = 1116,
				ManufacturerId = 85,
				ModelName = "V70",
				Year = 1996,
				Is_Active = true
			},
			new Model()
			{
				Id = 1117,
				ManufacturerId = 85,
				ModelName = "V90",
				Year = 1997,
				Is_Active = true
			},
			new Model()
			{
				Id = 1118,
				ManufacturerId = 85,
				ModelName = "XC40",
				Year = 2017,
				Is_Active = true
			},
			new Model()
			{
				Id = 1119,
				ManufacturerId = 85,
				ModelName = "XC60",
				Year = 2008,
				Is_Active = true
			},
			new Model()
			{
				Id = 1120,
				ManufacturerId = 85,
				ModelName = "XC70",
				Year = 2001,
				Is_Active = true
			},
			new Model()
			{
				Id = 1121,
				ManufacturerId = 85,
				ModelName = "XC90",
				Year = 2002,
				Is_Active = true
			},
			new Model()
			{
				Id = 1122,
				ManufacturerId = 24,
				ModelName = "Cinquecento",
				Year = 1991,
				Is_Active = true
			}

				);

			modelBuilder.Entity<Engine>().HasData(
				new Engine()
				{
					Id = 1,
					Type = "Inline 4, 85",
					Size = "1.2",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 20.4,
					Watt_Hours_Per_KM = null,
					ModelId = 482,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
                {
                    Id = 2,
                    Type = "Inline 4, 100",
                    Size = "1.4",
                    Fuel = "Petrol",
                    WLTP = 0,
                    NEDC = 19.2,
                    Watt_Hours_Per_KM = null,
                    ModelId = 482,
                    Is_Active = true,
                    Is_Electric = false,
                },
				new Engine()
				{
					Id = 3,
					Type = "Inline 4, 75",
					Size = "1.1",
					Fuel = "Diesel",
					WLTP = 0,
					NEDC = 27.8,
					Watt_Hours_Per_KM = null,
					ModelId = 482,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 4,
					Type = "Ionic 5",
					Size = "55",
					Fuel = "Electric",
					WLTP = 220,
					NEDC = 0,
					Watt_Hours_Per_KM = null,
					ModelId = 482,
					Is_Active = true,
					Is_Electric = true,
				},
				new Engine()
				{
					Id = 5,
					Type = "Inline 4 180",
					Size = "1.6",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 12.4,
					Watt_Hours_Per_KM = null,
					ModelId = 3,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 6,
					Type = "Inline 4 220",
					Size = "2.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 12.4,
					Watt_Hours_Per_KM = null,
					ModelId = 9,
					Is_Active = true,
					Is_Electric = false,
				}, 
				new Engine()
				{
					Id = 7,
					Type = "Inline 4 160",
					Size = "1.6",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 11.4,
					Watt_Hours_Per_KM = null,
					ModelId = 1,
					Is_Active = true,
					Is_Electric = false,
				}, 
				new Engine()
				{
					Id = 8,
					Type = "Inline 4 160",
					Size = "1.6",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 11.4,
					Watt_Hours_Per_KM = null,
					ModelId = 2,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 9,
					Type = "V6 300",
					Size = "3.2",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 9.4,
					Watt_Hours_Per_KM = null,
					ModelId = 5,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 10,
					Type = "Inline 4 240",
					Size = "2.3",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 11.0,
					Watt_Hours_Per_KM = null,
					ModelId = 6,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 11,
					Type = "V6",
					Size = "3.5",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 9.4,
					Watt_Hours_Per_KM = null,
					ModelId = 7,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 12,
					Type = "V6 Hybrid",
					Size = "3.5",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 12.4,
					Watt_Hours_Per_KM = null,
					ModelId = 8,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 13,
					Type = "I4 Twin Spark",
					Size = "1.6",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 12.1,
					Watt_Hours_Per_KM = null,
					ModelId = 14,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 14,
					Type = "I4 Twin Spark",
					Size = "1.6",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 12.1,
					Watt_Hours_Per_KM = null,
					ModelId = 15,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 15,
					Type = "V6",
					Size = "3.2",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 10.4,
					Watt_Hours_Per_KM = null,
					ModelId = 16,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 16,
					Type = "I4 Twin Spark",
					Size = "1.6",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 11.1,
					Watt_Hours_Per_KM = null,
					ModelId = 18,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 17,
					Type = "V6",
					Size = "3.2",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 10.4,
					Watt_Hours_Per_KM = null,
					ModelId = 18,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 18,
					Type = "I4 Twin Spark",
					Size = "1.6",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 11.1,
					Watt_Hours_Per_KM = null,
					ModelId = 19,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 19,
					Type = "I4 Twin Spark",
					Size = "1.6",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 11.1,
					Watt_Hours_Per_KM = null,
					ModelId = 20,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 20,
					Type = "Inline 4 Turbo",
					Size = "1.75",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 11.1,
					Watt_Hours_Per_KM = null,
					ModelId = 21,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 21,
					Type = "V12",
					Size = "6.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 8.1,
					Watt_Hours_Per_KM = null,
					ModelId = 32,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 22,
					Type = "V12",
					Size = "6.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 8.1,
					Watt_Hours_Per_KM = null,
					ModelId = 33,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 23,
					Type = "V12",
					Size = "6.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 8.1,
					Watt_Hours_Per_KM = null,
					ModelId = 34,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 24,
					Type = "V12",
					Size = "6.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 8.1,
					Watt_Hours_Per_KM = null,
					ModelId = 35,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 25,
					Type = "V12",
					Size = "6.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 8.1,
					Watt_Hours_Per_KM = null,
					ModelId = 36,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 26,
					Type = "V12",
					Size = "6.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 8.1,
					Watt_Hours_Per_KM = null,
					ModelId = 37,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 27,
					Type = "V12",
					Size = "6.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 8.1,
					Watt_Hours_Per_KM = null,
					ModelId = 38,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 28,
					Type = "V8",
					Size = "4.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 8.8,
					Watt_Hours_Per_KM = null,
					ModelId = 39,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 29,
					Type = "V12",
					Size = "6.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 8.1,
					Watt_Hours_Per_KM = null,
					ModelId = 40,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 30,
					Type = "V12",
					Size = "6.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 8.1,
					Watt_Hours_Per_KM = null,
					ModelId = 41,
					Is_Active = true,
					Is_Electric = false,
				},
				new Engine()
				{
					Id = 31,
					Type = "V12",
					Size = "6.0",
					Fuel = "Petrol",
					WLTP = 0,
					NEDC = 8.1,
					Watt_Hours_Per_KM = null,
					ModelId = 42,
					Is_Active = true,
					Is_Electric = false,
				}

				);

			modelBuilder.Entity<EconomyReportICE>().HasData(
				new EconomyReportICE()
				{
					Id = 1,
					Motorway = 14,
					City = 16,
					Average = 15,
					EngineId = 1,
					UserID = 1,
					Is_Active = true
				},
				new EconomyReportICE()
				{
					Id = 2,
					Motorway = 15.1,
					City = 14.1,
					Average = 16,
					EngineId = 1,
					UserID = 1,
					Is_Active = true
				},
				new EconomyReportICE()
				{
					Id = 3,
					Motorway = 16.1,
					City = 16.3,
					Average = 17,
					EngineId = 1,
					UserID = 1,
					Is_Active = true
				}
			); ;

			modelBuilder.Entity<EconomyReportElectric>().HasData(
				new EconomyReportElectric()
                {
					Id = 1,
					EngineId = 4,
					Full_Range = 200,
					UserID = 1,
					Is_Active = true
				},
				new EconomyReportElectric()
				{
					Id = 2,
					EngineId = 4,
					Full_Range = 180,
					UserID = 1,
					Is_Active = true
				}
			);

			modelBuilder.Entity<EconomySummaryICE>().HasData(
				new EconomySummaryICE()
				{
					Id = 1,
					Reported_Motorway = 15.5,
					Reported_City = 15.5,
					Reported_Average = 16,
					Manufacturer_Average = 20.4,
					Amount_Of_Reports = 3,
					EngineId = 1
				}
			);

			modelBuilder.Entity<EconomySummaryElectric>().HasData(
				new EconomySummaryElectric()
				{
					Id = 1,
					Reported_Full_Range = 190,
					Manufacturer_Full_Range = 220,
					Amount_Of_Reports = 3,
					EngineId = 4
				}
			);

			modelBuilder.Entity<Comment>().HasData(
				new Comment()
				{
					Id = 1,
					CreationDate = DateTime.Now,
					ModelID = 482,
					CommentContent = "Slow but reliable. The Economy is fine, but it does not match factory specification.",
					UserID = 2,
					UserName = "Hans Hansen",
					Engine = "Inline 4, 85",
					Is_Active = true
				},
				new Comment()
				{
					Id = 2,
					CreationDate = DateTime.Now,
					ModelID = 482,
					CommentContent = "Just a note, engine ticking is normal on this engine, before the 2019 refresh.",
					UserID = 10,
					UserName = "Frank Frandsen",
					Engine = "Inline 4, 85",
					Is_Active = true
				},
				new Comment()
				{
					Id = 3,
					CreationDate = DateTime.Now,
					ModelID = 482,
					CommentContent = "Economy drops sharply at 130 km/t. Staying at 110 km/t is much better.",
					UserID = 5,
					UserName = "Anne Annesen",
					Engine = "Inline 4, 85",
					Is_Active = true
				}

			);
		}

    }
}
