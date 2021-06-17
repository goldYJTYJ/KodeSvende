using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Reset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AccountCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    Is_Administrator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentContent = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Engine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    ModelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Models_ModelID",
                        column: x => x.ModelID,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Engine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Size = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fuel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WLTP = table.Column<double>(type: "float", nullable: false),
                    NEDC = table.Column<double>(type: "float", nullable: false),
                    Watt_Hours_Per_KM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_Electric = table.Column<bool>(type: "bit", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engine_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EconomyReportElectric",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_Range = table.Column<double>(type: "float", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconomyReportElectric", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EconomyReportElectric_Engine_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EconomyReportICE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Motorway = table.Column<double>(type: "float", nullable: false),
                    City = table.Column<double>(type: "float", nullable: false),
                    Average = table.Column<double>(type: "float", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconomyReportICE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EconomyReportICE_Engine_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EconomySummaryElectrics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reported_Full_Range = table.Column<double>(type: "float", nullable: false),
                    Manufacturer_Full_Range = table.Column<double>(type: "float", nullable: false),
                    Reported_Watt_Hours_Per_100Km = table.Column<double>(type: "float", nullable: false),
                    Manufacturer_Watt_Hours_Per_100Km = table.Column<double>(type: "float", nullable: false),
                    Amount_Of_Reports = table.Column<int>(type: "int", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconomySummaryElectrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EconomySummaryElectrics_Engine_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EconomySummaryICEs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reported_Motorway = table.Column<double>(type: "float", nullable: false),
                    Reported_City = table.Column<double>(type: "float", nullable: false),
                    Reported_Average = table.Column<double>(type: "float", nullable: false),
                    Amount_Of_Reports = table.Column<int>(type: "int", nullable: false),
                    Manufacturer_Average = table.Column<double>(type: "float", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconomySummaryICEs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EconomySummaryICEs_Engine_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Manufacturer",
                columns: new[] { "Id", "Is_Active", "Name" },
                values: new object[,]
                {
                    { 1, true, "Acura" },
                    { 63, true, "Peugeot" },
                    { 62, true, "Opel" },
                    { 61, true, "Noble" },
                    { 60, true, "Nissan" },
                    { 59, true, "Mitsubishi" },
                    { 58, true, "Mini" },
                    { 57, true, "MG" },
                    { 56, true, "Mercury" },
                    { 55, true, "Mercedes" },
                    { 53, true, "Mazda" },
                    { 52, true, "Maybach" },
                    { 51, true, "Maserati" },
                    { 50, true, "Marussia" },
                    { 49, true, "Lotus" },
                    { 48, true, "Lincoln" },
                    { 47, true, "Lifan" },
                    { 46, true, "Lexus" },
                    { 64, true, "Plymouth" },
                    { 65, true, "Pontiac" },
                    { 66, true, "Porsche" },
                    { 67, true, "Ravon" },
                    { 85, true, "Volvo" },
                    { 84, true, "Volkswagen" },
                    { 83, true, "VAZ" },
                    { 82, true, "UAZ" },
                    { 81, true, "Toyota" },
                    { 80, true, "Tesla" },
                    { 79, true, "Suzuki" },
                    { 78, true, "Subaru" },
                    { 45, true, "Land Rover" },
                    { 77, true, "Ssang Yong" },
                    { 75, true, "Skoda" },
                    { 74, true, "Seat" },
                    { 73, true, "Scion" },
                    { 72, true, "Saturn" },
                    { 71, true, "Saab" },
                    { 70, true, "Rover" },
                    { 69, true, "Rolls-Royce" },
                    { 68, true, "Renault" },
                    { 76, true, "Smart" },
                    { 44, true, "Lancia" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturer",
                columns: new[] { "Id", "Is_Active", "Name" },
                values: new object[,]
                {
                    { 54, true, "McLaren" },
                    { 42, true, "Kia" },
                    { 19, true, "Datsun" },
                    { 18, true, "Daihatsu" },
                    { 17, true, "Daewoo" },
                    { 16, true, "Citroen" },
                    { 15, true, "Chrysler" },
                    { 14, true, "Chevrolet" },
                    { 13, true, "Chery" },
                    { 43, true, "Lamborghini" },
                    { 20, true, "Dodge" },
                    { 11, true, "Cadillac" },
                    { 9, true, "Buick" },
                    { 8, true, "Bugatti" },
                    { 7, true, "Brilliance" },
                    { 6, true, "BMW" },
                    { 5, true, "Bentley" },
                    { 4, true, "Audi" },
                    { 3, true, "Aston Martin" },
                    { 2, true, "Alfa Romeo" },
                    { 10, true, "BYD" },
                    { 21, true, "Dongfeng" },
                    { 12, true, "Changan" },
                    { 23, true, "Ferrari" },
                    { 22, true, "FAW" },
                    { 41, true, "Jeep" },
                    { 40, true, "Jaguar" },
                    { 39, true, "Iveco" },
                    { 38, true, "Isuzu" },
                    { 37, true, "Infiniti" },
                    { 35, true, "Hummer" },
                    { 34, true, "Honda" },
                    { 33, true, "Holden" },
                    { 36, true, "Hyundai" },
                    { 32, true, "Haval" },
                    { 25, true, "Fisker" },
                    { 26, true, "Ford" },
                    { 27, true, "GAZ" },
                    { 28, true, "Geely" },
                    { 24, true, "Fiat" },
                    { 30, true, "GMC" },
                    { 31, true, "Great Wall" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturer",
                columns: new[] { "Id", "Is_Active", "Name" },
                values: new object[] { 29, true, "Genesis" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountCreation", "Email", "FirstName", "Is_Active", "Is_Administrator", "LastLogin", "LastName", "Password" },
                values: new object[,]
                {
                    { 12, new DateTime(2021, 6, 7, 9, 48, 30, 294, DateTimeKind.Local).AddTicks(2718), "DD@live.dk", "Helle", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hansen", "$2b$10$nGNQRDt57b8/wWwyFfopsu7W2O5xu1czyufwX4fryEXQOsC0cwu26" },
                    { 20, new DateTime(2021, 6, 7, 9, 48, 31, 204, DateTimeKind.Local).AddTicks(8198), "RR@live.dk", "Ronald", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rollesen", "$2b$10$.nnvGBWDAoAvQi/TKxQiGegRfkPkQygBCKCz/8EEvILnmW8/7gZB2" },
                    { 19, new DateTime(2021, 6, 7, 9, 48, 31, 94, DateTimeKind.Local).AddTicks(4487), "OO@live.dk", "Ole", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olesen", "$2b$10$Jc/PT5v8kB8k6BwmVExljO.KBp89sWMFhv6byjqHqTMLshAH.JVvO" },
                    { 18, new DateTime(2021, 6, 7, 9, 48, 30, 981, DateTimeKind.Local).AddTicks(8262), "NN@live.dk", "Noel", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noelsen", "$2b$10$6Cf5joiKrVy6FG9x2VIWKORxA7wH6BfaPqA8MSX6dmex.HGjtrdQ." },
                    { 17, new DateTime(2021, 6, 7, 9, 48, 30, 865, DateTimeKind.Local).AddTicks(8252), "MM@live.dk", "Martin", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martinsen", "$2b$10$LRBXisjWX8FJmUVIEUVeSOqF8Wym6nk.vtN0I5a0/1uHXib4M1ovG" },
                    { 16, new DateTime(2021, 6, 7, 9, 48, 30, 753, DateTimeKind.Local).AddTicks(5217), "LL@live.dk", "Lau", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauersen", "$2b$10$2.237IxOQhBjNkALvPz/Y.u0UwUVSrb8WtlCMjRyQDcQcQpLFt4FW" },
                    { 15, new DateTime(2021, 6, 7, 9, 48, 30, 642, DateTimeKind.Local).AddTicks(3943), "KK@live.dk", "Karen", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "karensen", "$2b$10$ESgvWkoO/9dgAUYw6R3Pi.CaUfVIqKkC2fncDLMYn09FBLu34sc1W" },
                    { 14, new DateTime(2021, 6, 7, 9, 48, 30, 530, DateTimeKind.Local).AddTicks(3936), "JJ@live.dk", "Jon", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonsen", "$2b$10$0isCi09ksJrnw9Tnazh8Buzvpukwwa1OuR7svxFDlL96AHfsLi/YO" },
                    { 13, new DateTime(2021, 6, 7, 9, 48, 30, 418, DateTimeKind.Local).AddTicks(8488), "II@live.dk", "Ida", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Idasen", "$2b$10$aWI4IKKIDebylhW3y/Yy/uDsW0vW3RoFnq//lyBv0HWWbb1cUrFDi" },
                    { 11, new DateTime(2021, 6, 7, 9, 48, 30, 174, DateTimeKind.Local).AddTicks(9398), "GG@live.dk", "Gyrne", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gyrnesen", "$2b$10$wsNcGwnz/wUUp6M7Eotdn.NuBSvReupcWJT4RG44hjU30caSUAN3y" },
                    { 1, new DateTime(2021, 6, 7, 9, 48, 29, 9, DateTimeKind.Local).AddTicks(8886), "Admin@live.dk", "CfDJ8JYpcSqp0EdEsEwdw1heA4bSL13TwtDcYloExs8JJw0J2Bzw_CeLojzx_m-qvFTe239xzoAlBpbL0VqfBurUJDjYg1W16A_-uCHQ7nnVQGN616PCvZrdZBfRf_8RtlW9xA", true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adminson", "$2b$10$PzfxW9X907tcxi0ZcYJeY.ivOMZlkgx7pmmKBscOQ/GjTsY8cVL5K" },
                    { 9, new DateTime(2021, 6, 7, 9, 48, 29, 944, DateTimeKind.Local).AddTicks(9281), "EE@live.dk", "Emil", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emilsen", "$2b$10$YX9PzqyVMoPKD24KDSwrg.b6pO6ytASP0dika4kBpkkXUP4J5RfJW" },
                    { 8, new DateTime(2021, 6, 7, 9, 48, 29, 830, DateTimeKind.Local).AddTicks(5875), "DD@live.dk", "Dan", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dannesen", "$2b$10$zkn14tKp7vqSRBJzMR6J/uegzuuo90Dmv4lPs.X0B16C2lYgTklNi" },
                    { 7, new DateTime(2021, 6, 7, 9, 48, 29, 715, DateTimeKind.Local).AddTicks(7889), "CC@live.dk", "Caroline", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carolinesen", "$2b$10$8aHF7LHi2Q98iKNHvRb2qOekR.o/4j4CwL6gRlIEOmZuHbwmYEG1S" },
                    { 6, new DateTime(2021, 6, 7, 9, 48, 29, 598, DateTimeKind.Local).AddTicks(1779), "BB@live.dk", "Bo", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boesen", "$2b$10$rM94jGYm5emSW8dXgcSGpexuwgHtA5ZRMVSO8j2EPlDcfvYZrjJe6" },
                    { 5, new DateTime(2021, 6, 7, 9, 48, 29, 486, DateTimeKind.Local).AddTicks(2166), "AA@live.dk", "Anne", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annesen", "$2b$10$WCjOxgVjyBmOHCLbPTejheuediXt72r51cNJHKCCcBZ3imoV7xNii" },
                    { 4, new DateTime(2021, 6, 7, 9, 48, 29, 354, DateTimeKind.Local).AddTicks(5857), "EE@live.dk", "Erik", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eriksen", "$2b$10$GNidvNrLBYblsaDXz5y9gu2ky9fjGCGDPa5pYt.0ppTNMbGWq1.z2" },
                    { 3, new DateTime(2021, 6, 7, 9, 48, 29, 243, DateTimeKind.Local).AddTicks(7185), "PP@live.dk", "Poul", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poulsen", "$2b$10$Xtjn0jXaQwhFAGZZ2ChhjeRundUJPscm8isI4NwdkRZn9hq6/Q336" },
                    { 2, new DateTime(2021, 6, 7, 9, 48, 29, 132, DateTimeKind.Local).AddTicks(1815), "HH@live.dk", "Hans", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hansen", "$2b$10$CP0AtgxFkWc06DzCRnDTFOFhBePKvVWD5JZ3ydJFt1Se5Ch2o6A5S" },
                    { 21, new DateTime(2021, 6, 7, 9, 48, 31, 320, DateTimeKind.Local).AddTicks(4842), "SS@live.dk", "Søren", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sørensen", "$2b$10$XqlShi3WFQ6T.2xL10b4HuSpNgK0JJwBZqrGBhNPJFIWukDrXkriO" },
                    { 10, new DateTime(2021, 6, 7, 9, 48, 30, 59, DateTimeKind.Local).AddTicks(5215), "FF@live.dk", "Frank", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fransen", "$2b$10$Y1nFS6WKMYWGmEce5KOgSeLpJzPfX8t8Wim7YQT2iGeVOxJCW2FQW" },
                    { 22, new DateTime(2021, 6, 7, 9, 48, 31, 430, DateTimeKind.Local).AddTicks(5348), "TT@live.dk", "Thomas", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomsen", "$2b$10$edONIlNblEtVwrdaYbCTb.gQzT7iTri22HIzfyLThh1elLHDL4/SW" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 1, true, 1, "EL", 1997 },
                    { 738, true, 58, "Cooper", 2001 },
                    { 739, true, 58, "Cooper Cabrio", 2001 },
                    { 740, true, 58, "Cooper S", 2001 },
                    { 741, true, 58, "Cooper S Cabrio", 2001 },
                    { 742, true, 58, "Cooper S Countryman All4", 2010 },
                    { 743, true, 58, "Countryman", 2010 },
                    { 744, true, 58, "One", 2001 },
                    { 745, true, 59, "3000 GT", 1992 },
                    { 746, true, 59, "ASX", 2010 },
                    { 747, true, 59, "Carisma", 1995 },
                    { 748, true, 59, "Colt", 1995 },
                    { 749, true, 59, "Dignity", 2012 },
                    { 750, true, 59, "Eclipse", 1995 },
                    { 751, true, 59, "Eclipse Cross", 2017 },
                    { 752, true, 59, "Endeavor", 2004 },
                    { 753, true, 59, "Galant", 1996 },
                    { 754, true, 59, "Grandis", 2003 },
                    { 768, true, 59, "Space Star", 1998 },
                    { 767, true, 59, "Space Runner", 1999 },
                    { 766, true, 59, "Space Gear", 1995 },
                    { 765, true, 59, "Raider", 2006 },
                    { 764, true, 59, "Pajero Sport", 1998 },
                    { 763, true, 59, "Pajero Pinin", 1999 },
                    { 737, true, 58, "Clubvan", 2012 },
                    { 762, true, 59, "Pajero", 1990 },
                    { 760, true, 59, "Outlander", 2003 },
                    { 759, true, 59, "Mirage", 2012 },
                    { 758, true, 59, "Lancer Evo", 2001 },
                    { 757, true, 59, "Lancer", 1996 },
                    { 756, true, 59, "L200", 1996 },
                    { 755, true, 59, "i-MiEV", 2009 },
                    { 761, true, 59, "Outlander XL", 2006 },
                    { 769, true, 60, "350Z", 2002 },
                    { 736, true, 58, "Clubman S", 2007 },
                    { 734, true, 57, "ZT-T", 2001 },
                    { 703, true, 55, "GLC-class Coupe", 2016 },
                    { 704, true, 55, "GLE-class", 2015 },
                    { 705, true, 55, "GLE-class Coupe", 2015 },
                    { 706, true, 55, "GLK-class", 2008 },
                    { 707, true, 55, "GLS-class", 2015 },
                    { 708, true, 55, "M-class", 1997 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 709, true, 55, "R-class", 2005 },
                    { 710, true, 55, "S-class", 1990 },
                    { 711, true, 55, "S-class Cabrio", 2015 },
                    { 712, true, 55, "S-class Coupe", 2015 },
                    { 713, true, 55, "SL-class", 2001 },
                    { 714, true, 55, "SLK-class", 1996 },
                    { 715, true, 55, "SLR-class", 2003 },
                    { 716, true, 55, "SLS AMG", 2010 },
                    { 717, true, 55, "Sprinter", 2000 },
                    { 718, true, 55, "Vaneo", 2001 },
                    { 719, true, 55, "Viano", 2003 },
                    { 733, true, 57, "ZT", 2001 },
                    { 732, true, 57, "ZS", 2001 },
                    { 731, true, 57, "ZR", 2001 },
                    { 730, true, 57, "XPower SV", 2003 },
                    { 729, true, 57, "TF", 2002 },
                    { 728, true, 56, "Sable", 1995 },
                    { 735, true, 58, "Clubman", 2007 },
                    { 727, true, 56, "Mountaineer", 2003 },
                    { 725, true, 56, "Montego", 2004 },
                    { 724, true, 56, "Milan", 2006 },
                    { 723, true, 56, "Mariner", 2005 },
                    { 722, true, 56, "Grand Marquis", 2003 },
                    { 721, true, 55, "X-class", 2018 },
                    { 720, true, 55, "Vito", 1999 },
                    { 726, true, 56, "Monterey", 1991 },
                    { 702, true, 55, "GLC-class", 2015 },
                    { 770, true, 60, "370Z", 2009 },
                    { 772, true, 60, "Almera Classic", 2005 },
                    { 808, true, 62, "Astra", 1998 },
                    { 809, true, 62, "Astra GTS", 2011 },
                    { 810, true, 62, "Cascada", 2013 },
                    { 811, true, 62, "Combo", 2001 },
                    { 812, true, 62, "Corsa", 2000 },
                    { 813, true, 62, "Corsa OPC", 2007 },
                    { 814, true, 62, "Crossland X", 2017 },
                    { 815, true, 62, "Frontera", 1998 },
                    { 816, true, 62, "Grandland X", 2017 },
                    { 817, true, 62, "Insignia", 2008 },
                    { 818, true, 62, "Insignia OPC", 2009 },
                    { 819, true, 62, "Karl", 2015 },
                    { 820, true, 62, "Meriva", 2003 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 821, true, 62, "Mokka", 2012 },
                    { 822, true, 62, "Omega", 1994 },
                    { 823, true, 62, "Signum", 2003 },
                    { 824, true, 62, "Speedster", 2000 },
                    { 838, true, 63, "301", 2012 },
                    { 837, true, 63, "3008", 2009 },
                    { 836, true, 63, "208", 2012 },
                    { 835, true, 63, "207", 2006 },
                    { 834, true, 63, "206", 1998 },
                    { 833, true, 63, "2008", 2013 },
                    { 807, true, 62, "Antara", 2006 },
                    { 832, true, 63, "108", 2014 },
                    { 830, true, 63, "1007", 2004 },
                    { 829, true, 62, "Zafira Tourer", 2012 },
                    { 828, true, 62, "Zafira", 1999 },
                    { 827, true, 62, "Vivaro", 2014 },
                    { 826, true, 62, "Vectra", 1995 },
                    { 825, true, 62, "Tigra", 1994 },
                    { 831, true, 63, "107", 2005 },
                    { 771, true, 60, "Almera", 2000 },
                    { 806, true, 62, "Agila", 2000 },
                    { 804, true, 61, "M600", 2010 },
                    { 773, true, 60, "Almera Tino", 2000 },
                    { 774, true, 60, "Altima", 2002 },
                    { 775, true, 60, "Armada", 2003 },
                    { 776, true, 60, "Bluebird Sylphy", 2000 },
                    { 777, true, 60, "GT-R", 2007 },
                    { 778, true, 60, "Juke", 2011 },
                    { 779, true, 60, "Leaf", 2010 },
                    { 780, true, 60, "Maxima", 2000 },
                    { 781, true, 60, "Micra", 2003 },
                    { 782, true, 60, "Murano", 2002 },
                    { 783, true, 60, "Navara", 2005 },
                    { 784, true, 60, "Note", 2005 },
                    { 785, true, 60, "NP300", 2008 },
                    { 786, true, 60, "Pathfinder", 1997 },
                    { 787, true, 60, "Patrol", 1997 },
                    { 788, true, 60, "Primera", 1996 },
                    { 789, true, 60, "Qashqai", 2007 },
                    { 803, true, 60, "Z", 2003 },
                    { 802, true, 60, "XTerra", 2001 },
                    { 801, true, 60, "X-Trail", 2001 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 800, true, 60, "Titan XD", 2016 },
                    { 799, true, 60, "Titan", 2003 },
                    { 798, true, 60, "Tiida", 2007 },
                    { 805, true, 62, "Adam", 2013 },
                    { 797, true, 60, "Terrano", 1993 },
                    { 795, true, 60, "Sylphy", 2012 },
                    { 794, true, 60, "Skyline", 2001 },
                    { 793, true, 60, "Sentra", 1999 },
                    { 792, true, 60, "Rogue", 2008 },
                    { 791, true, 60, "Quest", 2003 },
                    { 790, true, 60, "Qashqai+2", 2008 },
                    { 796, true, 60, "Teana", 2005 },
                    { 839, true, 63, "307", 2000 },
                    { 701, true, 55, "GLB-class", 2019 },
                    { 699, true, 55, "GL-class", 2006 },
                    { 598, true, 45, "Defender", 2007 },
                    { 599, true, 45, "Discovery", 1998 },
                    { 600, true, 45, "Discovery Sport", 2014 },
                    { 601, true, 45, "Evoque", 2011 },
                    { 602, true, 45, "Freelander", 1998 },
                    { 603, true, 45, "Range Rover", 1994 },
                    { 604, true, 45, "Range Rover Sport", 2004 },
                    { 605, true, 45, "Range Rover Velar", 2017 },
                    { 606, true, 46, "CT", 2010 },
                    { 607, true, 46, "ES", 2001 },
                    { 608, true, 46, "GS", 1997 },
                    { 609, true, 46, "GX", 2002 },
                    { 610, true, 46, "HS", 2009 },
                    { 611, true, 46, "IS", 1998 },
                    { 612, true, 46, "LC", 2017 },
                    { 613, true, 46, "LFA", 2010 },
                    { 614, true, 46, "LS", 1995 },
                    { 628, true, 48, "Aviator", 2003 },
                    { 627, true, 47, "X60", 2011 },
                    { 626, true, 47, "X50", 2014 },
                    { 625, true, 47, "Solano", 2008 },
                    { 624, true, 47, "Smily", 2008 },
                    { 623, true, 47, "Celliya", 2013 },
                    { 597, true, 44, "Ypsilon", 2003 },
                    { 622, true, 47, "Cebrium", 2013 },
                    { 620, true, 46, "UX", 2018 },
                    { 619, true, 46, "SC", 1999 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 618, true, 46, "RX", 1997 },
                    { 617, true, 46, "RC", 2014 },
                    { 616, true, 46, "NX", 2014 },
                    { 615, true, 46, "LX", 1998 },
                    { 621, true, 47, "Breez", 2007 },
                    { 629, true, 48, "Corsair", 2019 },
                    { 596, true, 44, "Thesis", 2001 },
                    { 594, true, 44, "Phedra", 2002 },
                    { 563, true, 42, "Niro", 2016 },
                    { 564, true, 42, "Opirus", 2003 },
                    { 565, true, 42, "Optima", 2010 },
                    { 566, true, 42, "Picanto", 2004 },
                    { 567, true, 42, "ProCeed", 2019 },
                    { 568, true, 42, "Quoris", 2012 },
                    { 569, true, 42, "Ray", 2011 },
                    { 570, true, 42, "Rio", 2000 },
                    { 571, true, 42, "Rio X-Line", 2017 },
                    { 572, true, 42, "Seltos", 2019 },
                    { 573, true, 42, "Shuma", 1997 },
                    { 574, true, 42, "Sorento", 2002 },
                    { 575, true, 42, "Sorento Prime", 2015 },
                    { 576, true, 42, "Soul", 2009 },
                    { 577, true, 42, "Spectra", 2005 },
                    { 578, true, 42, "Sportage", 1993 },
                    { 579, true, 42, "Stinger", 2017 },
                    { 593, true, 44, "Musa", 2004 },
                    { 592, true, 44, "Lybra", 1999 },
                    { 591, true, 44, "Delta", 2008 },
                    { 590, true, 43, "Urus", 2018 },
                    { 589, true, 43, "Reventon", 2008 },
                    { 588, true, 43, "Murcielago", 2003 },
                    { 595, true, 44, "Thema", 2011 },
                    { 587, true, 43, "Huracan", 2014 },
                    { 585, true, 43, "Diablo", 1991 },
                    { 584, true, 43, "Centenario", 2016 },
                    { 583, true, 43, "Aventador", 2011 },
                    { 582, true, 42, "Venga", 2011 },
                    { 581, true, 42, "Telluride", 2019 },
                    { 580, true, 42, "Stonic", 2017 },
                    { 586, true, 43, "Gallardo", 2003 },
                    { 700, true, 55, "GLA-class", 2013 },
                    { 630, true, 48, "Mark LT", 2006 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 632, true, 48, "MKS", 2008 },
                    { 668, true, 53, "CX-7", 2006 },
                    { 669, true, 53, "CX-9", 2007 },
                    { 670, true, 53, "MPV", 1999 },
                    { 671, true, 53, "MX-5", 1998 },
                    { 672, true, 53, "Premacy", 1999 },
                    { 673, true, 53, "RX-7", 1992 },
                    { 674, true, 53, "RX-8", 2003 },
                    { 675, true, 53, "Tribute", 2000 },
                    { 676, true, 54, "540C", 2015 },
                    { 677, true, 54, "570S", 2015 },
                    { 678, true, 54, "600LT", 2018 },
                    { 679, true, 54, "650S", 2014 },
                    { 680, true, 54, "675LT", 2015 },
                    { 681, true, 54, "720S", 2017 },
                    { 682, true, 54, "MP4-12C", 2011 },
                    { 683, true, 54, "P1", 2013 },
                    { 684, true, 55, "A-class", 1997 },
                    { 698, true, 55, "G-class", 1996 },
                    { 697, true, 55, "EQC", 2019 },
                    { 696, true, 55, "E-class Coupe", 2017 },
                    { 695, true, 55, "E-class", 1995 },
                    { 694, true, 55, "CLS-class", 2004 },
                    { 693, true, 55, "CLK-class", 1997 },
                    { 667, true, 53, "CX-5", 2012 },
                    { 692, true, 55, "CLC-class", 2008 },
                    { 690, true, 55, "CL-class", 1992 },
                    { 689, true, 55, "C-class Sport Coupe", 2001 },
                    { 688, true, 55, "C-class", 1997 },
                    { 687, true, 55, "B-class", 2005 },
                    { 686, true, 55, "AMG GT 4-Door", 2018 },
                    { 685, true, 55, "AMG GT", 2014 },
                    { 691, true, 55, "CLA-class", 2013 },
                    { 631, true, 48, "MKC", 2014 },
                    { 666, true, 53, "CX-3", 2015 },
                    { 664, true, 53, "B-Series", 1999 },
                    { 633, true, 48, "MKT", 2009 },
                    { 634, true, 48, "MKX", 2006 },
                    { 635, true, 48, "MKZ", 2006 },
                    { 636, true, 48, "Navigator", 1997 },
                    { 637, true, 48, "Town Car", 1998 },
                    { 638, true, 48, "Zephyr", 2006 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 639, true, 49, "Elise", 2001 },
                    { 640, true, 49, "Europa S", 2005 },
                    { 641, true, 49, "Evora", 2009 },
                    { 642, true, 49, "Exige", 2001 },
                    { 643, true, 50, "B1", 2008 },
                    { 644, true, 50, "B2", 2010 },
                    { 645, true, 51, "3200 GT", 1998 },
                    { 646, true, 51, "Ghibli", 2013 },
                    { 647, true, 51, "Gran Cabrio", 2010 },
                    { 648, true, 51, "Gran Turismo", 2007 },
                    { 649, true, 51, "Gran Turismo S", 2008 },
                    { 663, true, 53, "626", 1997 },
                    { 662, true, 53, "6", 2002 },
                    { 661, true, 53, "5", 2005 },
                    { 660, true, 53, "323", 1998 },
                    { 659, true, 53, "3", 2003 },
                    { 658, true, 53, "2", 2003 },
                    { 665, true, 53, "BT-50", 2011 },
                    { 657, true, 52, "Landaulet", 2003 },
                    { 655, true, 52, "62", 2002 },
                    { 654, true, 52, "57 S", 2007 },
                    { 653, true, 52, "57", 2002 },
                    { 652, true, 51, "Quattroporte S", 2007 },
                    { 651, true, 51, "Quattroporte", 2003 },
                    { 650, true, 51, "Levante", 2016 },
                    { 656, true, 52, "62 S", 2007 },
                    { 840, true, 63, "308", 2007 },
                    { 841, true, 63, "4007", 2007 },
                    { 842, true, 63, "4008", 2012 },
                    { 1019, true, 81, "Caldina", 2002 },
                    { 1020, true, 81, "Camry", 1996 },
                    { 1021, true, 81, "Celica", 1999 },
                    { 1022, true, 81, "Corolla", 1995 },
                    { 1023, true, 81, "Corolla Verso", 2002 },
                    { 1024, true, 81, "FJ Cruiser", 2007 },
                    { 1025, true, 81, "Fortuner", 2004 },
                    { 1026, true, 81, "GT 86", 2012 },
                    { 1027, true, 81, "Hiace", 2006 },
                    { 1028, true, 81, "Highlander", 2000 },
                    { 1029, true, 81, "Hilux", 2005 },
                    { 1030, true, 81, "iQ", 2008 },
                    { 1031, true, 81, "ist", 2002 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 1032, true, 81, "Land Cruiser", 1990 },
                    { 1033, true, 81, "Land Cruiser Prado", 2002 },
                    { 1034, true, 81, "Mark II", 2000 },
                    { 1035, true, 81, "Mirai", 2014 },
                    { 1049, true, 81, "Yaris", 1999 },
                    { 1048, true, 81, "Vitz", 2005 },
                    { 1047, true, 81, "Verso", 2009 },
                    { 1046, true, 81, "Venza", 2008 },
                    { 1045, true, 81, "Tundra", 1999 },
                    { 1044, true, 81, "Tacoma", 2005 },
                    { 1018, true, 81, "C-HR", 2016 },
                    { 1043, true, 81, "Supra", 2019 },
                    { 1041, true, 81, "Sequoia", 2001 },
                    { 1040, true, 81, "RAV4", 1994 },
                    { 1039, true, 81, "Prius", 2003 },
                    { 1038, true, 81, "Previa", 2000 },
                    { 1037, true, 81, "Picnic", 1995 },
                    { 1036, true, 81, "MR2", 1999 },
                    { 1042, true, 81, "Sienna", 2002 },
                    { 1050, true, 81, "Yaris Verso", 1999 },
                    { 1017, true, 81, "Aygo", 2005 },
                    { 1015, true, 81, "Avensis", 1997 },
                    { 984, true, 78, "Legacy", 1994 },
                    { 985, true, 78, "Levorg", 2014 },
                    { 986, true, 78, "Outback", 1997 },
                    { 987, true, 78, "Traviq", 2001 },
                    { 988, true, 78, "Tribeca", 2005 },
                    { 989, true, 78, "WRX", 2014 },
                    { 990, true, 78, "XV", 2012 },
                    { 991, true, 79, "Alto", 2002 },
                    { 992, true, 79, "Baleno", 1995 },
                    { 993, true, 79, "Celerio", 2014 },
                    { 994, true, 79, "Ciaz", 2014 },
                    { 995, true, 79, "Grand Vitara", 1998 },
                    { 996, true, 79, "Grand Vitara XL7", 1998 },
                    { 997, true, 79, "Ignis", 2000 },
                    { 998, true, 79, "Jimny", 1998 },
                    { 999, true, 79, "Kizashi", 2009 },
                    { 1000, true, 79, "Liana", 2002 },
                    { 1014, true, 81, "Avalon", 2000 },
                    { 1013, true, 81, "Auris", 2007 },
                    { 1012, true, 81, "Alphard", 2002 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 1011, true, 81, "4Runner", 1995 },
                    { 1010, true, 80, "Model Y", 2019 },
                    { 1009, true, 80, "Model X", 2015 },
                    { 1016, true, 81, "Avensis Verso", 2001 },
                    { 1008, true, 80, "Model S", 2012 },
                    { 1006, true, 79, "Wagon R+", 2000 },
                    { 1005, true, 79, "Wagon R", 2012 },
                    { 1004, true, 79, "Vitara", 2015 },
                    { 1003, true, 79, "SX4", 2006 },
                    { 1002, true, 79, "Swift", 2005 },
                    { 1001, true, 79, "Splash", 2008 },
                    { 1007, true, 80, "Model 3", 2017 },
                    { 983, true, 78, "Justy", 1995 },
                    { 1051, true, 82, "Pickup", 2008 },
                    { 1053, true, 82, "Хантер", 2003 },
                    { 1089, true, 84, "Passat", 2000 },
                    { 1090, true, 84, "Passat CC", 2008 },
                    { 1091, true, 84, "Phaeton", 2002 },
                    { 1092, true, 84, "Pointer", 1993 },
                    { 1093, true, 84, "Polo", 2001 },
                    { 1094, true, 84, "Routan", 2008 },
                    { 1095, true, 84, "Scirocco", 2008 },
                    { 1096, true, 84, "Sharan", 1995 },
                    { 1097, true, 84, "T-Roc", 2017 },
                    { 1098, true, 84, "Teramont", 2017 },
                    { 1099, true, 84, "Tiguan", 2007 },
                    { 1100, true, 84, "Touareg", 2002 },
                    { 1101, true, 84, "Touran", 2003 },
                    { 1102, true, 84, "Transporter", 1990 },
                    { 1103, true, 84, "Up", 2011 },
                    { 1104, true, 85, "C30", 2007 },
                    { 1105, true, 85, "C70", 2006 },
                    { 1119, true, 85, "XC60", 2008 },
                    { 1118, true, 85, "XC40", 2017 },
                    { 1117, true, 85, "V90", 1997 },
                    { 1116, true, 85, "V70", 1996 },
                    { 1115, true, 85, "V60", 2011 },
                    { 1114, true, 85, "V50", 2004 },
                    { 1088, true, 84, "New Beetle", 1998 },
                    { 1113, true, 85, "V40", 1995 },
                    { 1111, true, 85, "S80", 1998 },
                    { 1110, true, 85, "S70", 1996 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 1109, true, 85, "S60", 2000 },
                    { 1108, true, 85, "S40", 1995 },
                    { 1107, true, 85, "C70 Coupe", 1996 },
                    { 1106, true, 85, "C70 Convertible", 1997 },
                    { 1112, true, 85, "S90", 1997 },
                    { 1052, true, 82, "Патриот", 2005 },
                    { 1087, true, 84, "Multivan", 2003 },
                    { 1085, true, 84, "Jetta", 2005 },
                    { 1054, true, 83, "2101-2107", 1976 },
                    { 1055, true, 83, "2108, 2109, 21099", 1984 },
                    { 1056, true, 83, "2110, 2111, 2112", 1996 },
                    { 1057, true, 83, "2113, 2114, 2115", 1997 },
                    { 1058, true, 83, "4x4 Urban", 2014 },
                    { 1059, true, 83, "Granta", 2011 },
                    { 1060, true, 83, "Largus", 2012 },
                    { 1061, true, 83, "Largus Cross", 2015 },
                    { 1062, true, 83, "Vesta Cross", 2018 },
                    { 1063, true, 83, "Vesta Sport", 2018 },
                    { 1064, true, 83, "Vesta SW", 2017 },
                    { 1065, true, 83, "XRay", 2016 },
                    { 1066, true, 83, "XRay Cross", 2018 },
                    { 1067, true, 83, "Веста", 2015 },
                    { 1068, true, 83, "Калина", 2004 },
                    { 1069, true, 83, "Нива 4X4", 1977 },
                    { 1070, true, 83, "Ока", 1988 },
                    { 1084, true, 84, "Golf", 1997 },
                    { 1083, true, 84, "Fox", 2005 },
                    { 1082, true, 84, "Eos", 2006 },
                    { 1081, true, 84, "CrossTouran", 2007 },
                    { 1080, true, 84, "CrossPolo", 2006 },
                    { 1079, true, 84, "CrossGolf", 2007 },
                    { 1086, true, 84, "Lupo", 1998 },
                    { 1078, true, 84, "Crafter", 2008 },
                    { 1076, true, 84, "Caddy", 2004 },
                    { 1075, true, 84, "Bora", 1998 },
                    { 1074, true, 84, "Beetle", 2011 },
                    { 1073, true, 84, "Arteon", 2017 },
                    { 1072, true, 84, "Amarok", 1990 },
                    { 1071, true, 83, "Приора", 2007 },
                    { 1077, true, 84, "CC", 2012 },
                    { 982, true, 78, "Impreza", 1992 },
                    { 981, true, 78, "Forester", 1997 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 980, true, 78, "Exiga", 2008 },
                    { 878, true, 68, "Arkana", 2019 },
                    { 879, true, 68, "Avantime", 2001 },
                    { 880, true, 68, "Captur", 2013 },
                    { 881, true, 68, "Clio", 1998 },
                    { 882, true, 68, "Duster", 2010 },
                    { 883, true, 68, "Duster Oroch", 2015 },
                    { 884, true, 68, "Espace", 1996 },
                    { 885, true, 68, "Fluence", 2010 },
                    { 886, true, 68, "Grand Scenic", 2009 },
                    { 887, true, 68, "Kadjar", 2015 },
                    { 888, true, 68, "Kangoo", 1998 },
                    { 889, true, 68, "Kaptur", 2016 },
                    { 890, true, 68, "Koleos", 2008 },
                    { 891, true, 68, "Laguna", 1993 },
                    { 892, true, 68, "Latitude", 2010 },
                    { 893, true, 68, "Logan", 2004 },
                    { 894, true, 68, "Master", 2011 },
                    { 908, true, 69, "Cullinan", 2018 },
                    { 907, true, 68, "Zoe", 2012 },
                    { 906, true, 68, "Wind", 2010 },
                    { 905, true, 68, "Vel Satis", 2002 },
                    { 904, true, 68, "Twizy", 2012 },
                    { 903, true, 68, "Twingo", 1993 },
                    { 877, true, 67, "Gentra", 2015 },
                    { 902, true, 68, "Trafic", 2001 },
                    { 900, true, 68, "Symbol", 2002 },
                    { 899, true, 68, "Scenic", 1996 },
                    { 898, true, 68, "Sandero Stepway", 2008 },
                    { 897, true, 68, "Sandero", 2007 },
                    { 896, true, 68, "Modus", 2004 },
                    { 895, true, 68, "Megane", 1996 },
                    { 901, true, 68, "Talisman", 2015 },
                    { 909, true, 69, "Dawn", 2015 },
                    { 876, true, 66, "Taycan", 2020 },
                    { 874, true, 66, "Macan", 2014 },
                    { 843, true, 63, "406", 1995 },
                    { 844, true, 63, "407", 2004 },
                    { 845, true, 63, "408", 2010 },
                    { 846, true, 63, "5008", 2009 },
                    { 847, true, 63, "508", 2011 },
                    { 848, true, 63, "607", 2000 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 849, true, 63, "807", 2002 },
                    { 850, true, 63, "Boxer", 2008 },
                    { 851, true, 63, "Partner", 1996 },
                    { 852, true, 63, "RCZ Sport", 2010 },
                    { 853, true, 64, "Road Runner", 1968 },
                    { 854, true, 65, "Aztec", 2001 },
                    { 855, true, 65, "Bonneville", 1999 },
                    { 856, true, 65, "Firebird", 1993 },
                    { 857, true, 65, "G5 Pursuit", 2004 },
                    { 858, true, 65, "G6", 2004 },
                    { 859, true, 65, "G8", 2008 },
                    { 873, true, 66, "Cayman", 2005 },
                    { 872, true, 66, "Cayenne", 2002 },
                    { 871, true, 66, "Boxster", 1996 },
                    { 870, true, 66, "911", 1997 },
                    { 869, true, 66, "718 Cayman", 2016 },
                    { 868, true, 66, "718 Boxster", 2016 },
                    { 875, true, 66, "Panamera", 2009 },
                    { 867, true, 65, "Vibe", 2002 },
                    { 865, true, 65, "Sunfire", 1995 },
                    { 864, true, 65, "Solstice", 2005 },
                    { 863, true, 65, "Montana", 1997 },
                    { 862, true, 65, "GTO", 2004 },
                    { 861, true, 65, "Grand Prix", 1996 },
                    { 860, true, 65, "Grand AM", 1998 },
                    { 866, true, 65, "Torrent", 2005 },
                    { 910, true, 69, "Ghost", 2009 },
                    { 911, true, 69, "Phantom", 2003 },
                    { 912, true, 69, "Wraith", 2013 },
                    { 949, true, 75, "Felicia", 1995 },
                    { 950, true, 75, "Kamiq", 2019 },
                    { 951, true, 75, "Karoq", 2017 },
                    { 952, true, 75, "Kodiaq", 2016 },
                    { 953, true, 75, "Octavia", 1995 },
                    { 954, true, 75, "Octavia Scout", 2007 },
                    { 955, true, 75, "Octavia Tour", 2006 },
                    { 956, true, 75, "Praktik", 2007 },
                    { 957, true, 75, "Rapid", 2012 },
                    { 958, true, 75, "Rapid Spaceback (NH1)", 2013 },
                    { 959, true, 75, "Roomster", 2006 },
                    { 960, true, 75, "Superb", 2002 },
                    { 961, true, 75, "Yeti", 2010 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 962, true, 76, "Forfour", 2004 },
                    { 963, true, 76, "Fortwo", 1997 },
                    { 964, true, 76, "Roadster", 2003 },
                    { 965, true, 77, "Actyon", 2005 },
                    { 979, true, 78, "Crosstrack", 2018 },
                    { 978, true, 78, "Baja", 2002 },
                    { 977, true, 78, "Ascent", 2018 },
                    { 976, true, 77, "XLV", 2016 },
                    { 975, true, 77, "Tivoli", 2015 },
                    { 974, true, 77, "Stavic", 2013 },
                    { 948, true, 75, "Fabia", 1999 },
                    { 973, true, 77, "Rodius", 2004 },
                    { 971, true, 77, "Musso Sport", 2004 },
                    { 970, true, 77, "Musso", 1993 },
                    { 969, true, 77, "Kyron", 2005 },
                    { 968, true, 77, "Korando", 2002 },
                    { 967, true, 77, "Chairman", 1997 },
                    { 966, true, 77, "Actyon Sports", 2006 },
                    { 972, true, 77, "Rexton", 2001 },
                    { 947, true, 75, "Citigo", 2011 },
                    { 946, true, 74, "Toledo", 2004 },
                    { 945, true, 74, "Mii", 2012 },
                    { 926, true, 72, "LW", 1998 },
                    { 925, true, 72, "Ion", 2003 },
                    { 924, true, 72, "Aura", 2007 },
                    { 923, true, 71, "9-7x", 2005 },
                    { 922, true, 71, "9-5", 1997 },
                    { 921, true, 71, "9-4x", 2011 },
                    { 927, true, 72, "Outlook", 2006 },
                    { 920, true, 71, "9-3", 2003 },
                    { 918, true, 70, "Streetwise", 2003 },
                    { 917, true, 70, "75", 1999 },
                    { 916, true, 70, "600", 1999 },
                    { 915, true, 70, "45", 2000 },
                    { 914, true, 70, "400", 1996 },
                    { 913, true, 70, "25", 1999 },
                    { 919, true, 71, "9-2x", 2004 },
                    { 562, true, 42, "Mohave", 2008 },
                    { 928, true, 72, "Sky", 2007 },
                    { 930, true, 73, "FR-S", 2012 },
                    { 944, true, 74, "Leon", 1999 },
                    { 943, true, 74, "Ibiza", 2002 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 942, true, 74, "Exeo", 2008 },
                    { 941, true, 74, "Cordoba", 1999 },
                    { 940, true, 74, "Ateca", 2016 },
                    { 939, true, 74, "Arosa", 1997 },
                    { 929, true, 72, "Vue", 2002 },
                    { 938, true, 74, "Altea XL", 2007 },
                    { 936, true, 74, "Altea", 2004 },
                    { 935, true, 74, "Alhambra", 1998 },
                    { 934, true, 73, "xD", 2007 },
                    { 933, true, 73, "xB", 2003 },
                    { 932, true, 73, "xA", 2003 },
                    { 931, true, 73, "tC", 2004 },
                    { 937, true, 74, "Altea Freetrack", 2007 },
                    { 561, true, 42, "Magentis", 2001 },
                    { 560, true, 42, "K900", 2019 },
                    { 559, true, 42, "Forte", 2008 },
                    { 178, true, 13, "Very", 2011 },
                    { 179, true, 14, "Astro", 1995 },
                    { 180, true, 14, "Avalanche", 2002 },
                    { 181, true, 14, "Aveo", 2004 },
                    { 182, true, 14, "Blazer", 1994 },
                    { 183, true, 14, "Camaro", 1998 },
                    { 184, true, 14, "Captiva", 2006 },
                    { 185, true, 14, "Cavalier", 1995 },
                    { 186, true, 14, "Cobalt", 2005 },
                    { 187, true, 14, "Colorado", 2004 },
                    { 188, true, 14, "Corvette", 2005 },
                    { 189, true, 14, "Cruze", 2009 },
                    { 190, true, 14, "Epica", 2006 },
                    { 191, true, 14, "Equinox", 2005 },
                    { 192, true, 14, "Express", 2003 },
                    { 193, true, 14, "HHR", 2006 },
                    { 194, true, 14, "Impala", 2006 },
                    { 208, true, 14, "TrailBlazer", 2002 },
                    { 207, true, 14, "Tahoe", 2000 },
                    { 206, true, 14, "Suburban", 2001 },
                    { 205, true, 14, "SSR", 2003 },
                    { 204, true, 14, "Spark", 2005 },
                    { 203, true, 14, "Silverado 2500 HD", 2001 },
                    { 177, true, 13, "Tiggo 8", 2018 },
                    { 202, true, 14, "Silverado", 1999 },
                    { 200, true, 14, "Orlando", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 199, true, 14, "Niva", 2002 },
                    { 198, true, 14, "Monte Carlo", 2005 },
                    { 197, true, 14, "Malibu", 2004 },
                    { 196, true, 14, "Lanos", 1997 },
                    { 195, true, 14, "Lacetti", 2002 },
                    { 201, true, 14, "Rezzo", 2000 },
                    { 209, true, 14, "Traverse", 2009 },
                    { 176, true, 13, "Tiggo 7", 2016 },
                    { 174, true, 13, "Tiggo 4", 2017 },
                    { 143, true, 11, "ELR", 2013 },
                    { 144, true, 11, "Escalade", 2002 },
                    { 145, true, 11, "Seville", 1998 },
                    { 146, true, 11, "SRX", 2004 },
                    { 147, true, 11, "STS", 2004 },
                    { 148, true, 11, "XLR", 2003 },
                    { 149, true, 11, "XT4", 2018 },
                    { 150, true, 11, "XT5", 2016 },
                    { 151, true, 11, "XT6", 2019 },
                    { 152, true, 11, "XTS", 2012 },
                    { 153, true, 12, "CS35", 2012 },
                    { 154, true, 12, "CS35 Plus", 2018 },
                    { 155, true, 12, "CS55", 2017 },
                    { 156, true, 12, "CS75", 2013 },
                    { 157, true, 12, "CS95", 2017 },
                    { 158, true, 12, "Eado", 2012 },
                    { 159, true, 12, "Raeton", 2013 },
                    { 173, true, 13, "Tiggo 3", 2014 },
                    { 172, true, 13, "Tiggo", 2006 },
                    { 171, true, 13, "QQ6", 2006 },
                    { 170, true, 13, "QQ", 2003 },
                    { 169, true, 13, "M11", 2008 },
                    { 168, true, 13, "Kimo", 2008 },
                    { 175, true, 13, "Tiggo 5", 2014 },
                    { 167, true, 13, "IndiS", 2011 },
                    { 165, true, 13, "Eastar", 2003 },
                    { 164, true, 13, "CrossEastar", 2006 },
                    { 163, true, 13, "Bonus 3", 2013 },
                    { 162, true, 13, "Bonus", 2011 },
                    { 161, true, 13, "Arrizo 7", 2013 },
                    { 160, true, 13, "Amulet", 2003 },
                    { 166, true, 13, "Fora", 2006 },
                    { 142, true, 11, "Eldorado", 1992 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 210, true, 14, "Trax", 2013 },
                    { 212, true, 14, "Venture", 1996 },
                    { 248, true, 16, "Saxo", 1996 },
                    { 249, true, 16, "Spacetourer", 2016 },
                    { 250, true, 16, "Xsara", 1997 },
                    { 251, true, 16, "Xsara Picasso", 1999 },
                    { 252, true, 17, "Evanda", 2002 },
                    { 253, true, 17, "Kalos", 2002 },
                    { 254, true, 17, "Leganza", 1997 },
                    { 255, true, 17, "Magnus", 2000 },
                    { 256, true, 17, "Matiz", 2000 },
                    { 257, true, 17, "Nexia", 1995 },
                    { 258, true, 17, "Nubira", 1997 },
                    { 259, true, 18, "Applause", 1997 },
                    { 260, true, 18, "Cast", 2015 },
                    { 261, true, 18, "Copen", 2002 },
                    { 262, true, 18, "Cuore", 2003 },
                    { 263, true, 18, "Gran Move", 1996 },
                    { 264, true, 18, "Luxio", 2009 },
                    { 278, true, 20, "Caravan", 1995 },
                    { 277, true, 20, "Caliber SRT4", 2007 },
                    { 276, true, 20, "Caliber", 2006 },
                    { 275, true, 20, "Avenger", 1994 },
                    { 274, true, 19, "on-DO", 2014 },
                    { 273, true, 19, "mi-DO", 2014 },
                    { 247, true, 16, "Nemo", 2008 },
                    { 272, true, 18, "YRV", 2000 },
                    { 270, true, 18, "Terios", 1997 },
                    { 269, true, 18, "Sirion", 1998 },
                    { 268, true, 18, "Rocky", 2019 },
                    { 267, true, 18, "Move", 2014 },
                    { 266, true, 18, "Mebius", 2013 },
                    { 265, true, 18, "Materia", 2006 },
                    { 271, true, 18, "Trevis", 2006 },
                    { 211, true, 14, "Uplander", 2005 },
                    { 246, true, 16, "Jumpy", 2007 },
                    { 244, true, 16, "DS5", 2011 },
                    { 213, true, 15, "200", 2010 },
                    { 214, true, 15, "300", 2004 },
                    { 215, true, 15, "300M", 1998 },
                    { 216, true, 15, "Aspen", 2006 },
                    { 217, true, 15, "Concorde", 1998 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 218, true, 15, "Crossfire", 2003 },
                    { 219, true, 15, "Grand Voyager", 2008 },
                    { 220, true, 15, "Pacifica", 2004 },
                    { 221, true, 15, "PT Cruiser", 2000 },
                    { 222, true, 15, "Sebring", 2000 },
                    { 223, true, 15, "Town & Country", 2008 },
                    { 224, true, 15, "Voyager", 1995 },
                    { 225, true, 16, "Berlingo", 1996 },
                    { 226, true, 16, "C-Crosser", 2007 },
                    { 227, true, 16, "C-Elysee", 2012 },
                    { 228, true, 16, "C1", 2005 },
                    { 229, true, 16, "C2", 2003 },
                    { 243, true, 16, "DS4", 2010 },
                    { 242, true, 16, "DS3", 2009 },
                    { 241, true, 16, "DS 7 Crossback", 2018 },
                    { 240, true, 16, "C8", 2002 },
                    { 239, true, 16, "C6", 2004 },
                    { 238, true, 16, "C5", 2001 },
                    { 245, true, 16, "Grand C4 Picasso", 2006 },
                    { 237, true, 16, "C4 Picasso", 2006 },
                    { 235, true, 16, "C4 Aircross", 2012 },
                    { 234, true, 16, "C4", 2004 },
                    { 233, true, 16, "C3 Pluriel", 2003 },
                    { 232, true, 16, "C3 Picasso", 2009 },
                    { 231, true, 16, "C3 Aircross", 2017 },
                    { 230, true, 16, "C3", 2002 },
                    { 236, true, 16, "C4 Cactus", 2014 },
                    { 141, true, 11, "DTS", 2006 },
                    { 140, true, 11, "De Ville", 2000 },
                    { 139, true, 11, "CTS", 2002 },
                    { 37, true, 3, "Rapide", 2010 },
                    { 38, true, 3, "V12 Vantage", 2010 },
                    { 39, true, 3, "V8 Vantage", 2001 },
                    { 40, true, 3, "Valkyrie", 2019 },
                    { 41, true, 3, "Vanquish", 2001 },
                    { 42, true, 3, "Virage", 2011 },
                    { 43, true, 3, "Zagato Coupe", 2016 },
                    { 44, true, 4, "A1", 2010 },
                    { 45, true, 4, "A2", 2000 },
                    { 46, true, 4, "A3", 1996 },
                    { 47, true, 4, "A4", 1995 },
                    { 48, true, 4, "A4 Allroad Quattro", 2009 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 49, true, 4, "A5", 2007 },
                    { 50, true, 4, "A6", 1998 },
                    { 51, true, 4, "A7", 2010 },
                    { 52, true, 4, "A8", 1994 },
                    { 53, true, 4, "Allroad", 2000 },
                    { 67, true, 4, "S3", 2006 },
                    { 66, true, 4, "RS7", 2013 },
                    { 65, true, 4, "RS6", 2002 },
                    { 64, true, 4, "RS5", 2010 },
                    { 63, true, 4, "RS4", 2005 },
                    { 62, true, 4, "RS3", 2011 },
                    { 36, true, 3, "DBX", 2020 },
                    { 61, true, 4, "RS Q3", 2012 },
                    { 59, true, 4, "Q8", 2018 },
                    { 58, true, 4, "Q7", 2006 },
                    { 57, true, 4, "Q5", 2008 },
                    { 56, true, 4, "Q3", 2011 },
                    { 55, true, 4, "Q2", 2016 },
                    { 54, true, 4, "E-Tron", 2019 },
                    { 60, true, 4, "R8", 2006 },
                    { 68, true, 4, "S4", 1998 },
                    { 35, true, 3, "DBS Violante", 2007 },
                    { 33, true, 3, "DB9", 2004 },
                    { 2, true, 1, "ILX", 2012 },
                    { 3, true, 1, "Integra", 1998 },
                    { 4, true, 1, "MDX", 2001 },
                    { 5, true, 1, "NSX", 2001 },
                    { 6, true, 1, "RDX", 2006 },
                    { 7, true, 1, "RL", 1995 },
                    { 8, true, 1, "RLX", 2013 },
                    { 9, true, 1, "RSX", 2002 },
                    { 10, true, 1, "TL", 1999 },
                    { 11, true, 1, "TLX", 2014 },
                    { 12, true, 1, "TSX", 2003 },
                    { 13, true, 1, "ZDX", 2010 },
                    { 14, true, 2, "146", 1994 },
                    { 15, true, 2, "147", 1998 },
                    { 16, true, 2, "147 GTA", 2002 },
                    { 17, true, 2, "156", 1997 },
                    { 18, true, 2, "156 GTA", 2002 },
                    { 32, true, 3, "DB11", 2016 },
                    { 31, true, 3, "Cygnet", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 30, true, 2, "Stelvio", 2017 },
                    { 29, true, 2, "Spider", 1998 },
                    { 28, true, 2, "MiTo", 2008 },
                    { 27, true, 2, "GTV", 1995 },
                    { 34, true, 3, "DBS", 2003 },
                    { 26, true, 2, "GT", 2003 },
                    { 24, true, 2, "Giulia", 2016 },
                    { 23, true, 2, "Brera", 2005 },
                    { 22, true, 2, "8C Competizione", 2008 },
                    { 21, true, 2, "4C", 2013 },
                    { 20, true, 2, "166", 1998 },
                    { 19, true, 2, "159", 2005 },
                    { 25, true, 2, "Giulietta", 2010 },
                    { 69, true, 4, "S5", 2007 },
                    { 70, true, 4, "S6", 1999 },
                    { 71, true, 4, "S7", 2012 },
                    { 108, true, 6, "X4", 2014 },
                    { 109, true, 6, "X4 M", 2019 },
                    { 110, true, 6, "X5", 2000 },
                    { 111, true, 6, "X5 M", 2009 },
                    { 112, true, 6, "X6", 2008 },
                    { 113, true, 6, "X6 M", 2009 },
                    { 114, true, 6, "X7", 2018 },
                    { 115, true, 6, "Z3", 1996 },
                    { 116, true, 6, "Z4", 2002 },
                    { 117, true, 6, "Z8", 2000 },
                    { 118, true, 7, "H230", 2012 },
                    { 119, true, 7, "V3", 2014 },
                    { 120, true, 7, "V5", 2011 },
                    { 121, true, 8, "Veyron", 2005 },
                    { 122, true, 9, "Century", 1997 },
                    { 123, true, 9, "Enclave", 2007 },
                    { 124, true, 9, "Envision", 2014 },
                    { 138, true, 11, "CT6", 2016 },
                    { 137, true, 11, "BLS", 2006 },
                    { 136, true, 11, "ATS-V", 2016 },
                    { 135, true, 11, "ATS", 2012 },
                    { 134, true, 10, "Qin", 2014 },
                    { 133, true, 9, "Verano", 2012 },
                    { 107, true, 6, "X3 M", 2019 },
                    { 132, true, 9, "Terraza", 2005 },
                    { 130, true, 9, "Regal", 2009 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 129, true, 9, "Rainier", 2003 },
                    { 128, true, 9, "Park Avenue", 1996 },
                    { 127, true, 9, "Lucerne", 2005 },
                    { 126, true, 9, "Le Sabre", 1999 },
                    { 125, true, 9, "La Crosse", 2004 },
                    { 131, true, 9, "Rendezvouz", 2001 },
                    { 106, true, 6, "X3", 2004 },
                    { 105, true, 6, "X2", 2017 },
                    { 104, true, 6, "X1", 2009 },
                    { 85, true, 5, "Continental Flying Spur", 2005 },
                    { 84, true, 5, "Continental", 2003 },
                    { 83, true, 5, "Brooklands", 2008 },
                    { 82, true, 5, "Bentayga", 2015 },
                    { 81, true, 5, "Azure", 1999 },
                    { 80, true, 5, "Arnage", 1999 },
                    { 86, true, 5, "Continental GT", 2018 },
                    { 79, true, 4, "TTS", 2008 },
                    { 77, true, 4, "TT", 1998 },
                    { 76, true, 4, "SQ8", 2019 },
                    { 75, true, 4, "SQ7", 2016 },
                    { 74, true, 4, "SQ5", 2012 },
                    { 73, true, 4, "SQ2", 2019 },
                    { 72, true, 4, "S8", 1996 },
                    { 78, true, 4, "TT RS", 2008 },
                    { 279, true, 20, "Challenger", 2008 },
                    { 87, true, 5, "Flying Spur", 2013 },
                    { 89, true, 6, "1 series", 2004 },
                    { 103, true, 6, "M6", 2005 },
                    { 102, true, 6, "M5", 1998 },
                    { 101, true, 6, "M4", 2012 },
                    { 100, true, 6, "M3", 1992 },
                    { 99, true, 6, "M2", 2015 },
                    { 98, true, 6, "i8", 2014 },
                    { 88, true, 5, "Mulsanne", 2010 },
                    { 97, true, 6, "i3", 2013 },
                    { 95, true, 6, "7 series", 1995 },
                    { 94, true, 6, "6 series", 2004 },
                    { 93, true, 6, "5 series", 1988 },
                    { 92, true, 6, "4 series", 2013 },
                    { 91, true, 6, "3 series", 1982 },
                    { 90, true, 6, "2 series", 2013 },
                    { 96, true, 6, "8 series", 1990 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 1120, true, 85, "XC70", 2001 },
                    { 280, true, 20, "Charger", 2006 },
                    { 282, true, 20, "Dart", 2012 },
                    { 458, true, 34, "Ridgeline", 2005 },
                    { 459, true, 34, "S2000", 1999 },
                    { 460, true, 34, "Shuttle", 1994 },
                    { 461, true, 34, "Stream", 2001 },
                    { 462, true, 34, "Vezel", 2013 },
                    { 463, true, 35, "H1", 1992 },
                    { 464, true, 35, "H2", 2003 },
                    { 465, true, 35, "H3", 2005 },
                    { 466, true, 36, "Accent", 2000 },
                    { 467, true, 36, "Atos Prime", 1999 },
                    { 468, true, 36, "Azera", 2006 },
                    { 469, true, 36, "Centennial", 1999 },
                    { 470, true, 36, "Creta", 2015 },
                    { 471, true, 36, "Elantra", 2000 },
                    { 472, true, 36, "Entourage", 2007 },
                    { 473, true, 36, "Eon", 2011 },
                    { 474, true, 36, "Equus", 2009 },
                    { 488, true, 36, "ix35", 2010 },
                    { 487, true, 36, "ix20", 2010 },
                    { 486, true, 36, "Ioniq", 2016 },
                    { 485, true, 36, "i40", 2011 },
                    { 484, true, 36, "i30 N", 2017 },
                    { 483, true, 36, "i30", 2007 },
                    { 457, true, 34, "Prelude", 1996 },
                    { 482, true, 36, "i20", 2008 },
                    { 480, true, 36, "H-1", 1998 },
                    { 479, true, 36, "Grandeur", 2005 },
                    { 478, true, 36, "Getz", 2002 },
                    { 477, true, 36, "Genesis Coupe", 2008 },
                    { 476, true, 36, "Genesis", 2008 },
                    { 475, true, 36, "Galloper", 1998 },
                    { 481, true, 36, "i10", 2008 },
                    { 489, true, 36, "Kona", 2017 },
                    { 456, true, 34, "Pilot", 2002 },
                    { 454, true, 34, "Legend", 2006 },
                    { 423, true, 31, "Cowry", 2007 },
                    { 424, true, 31, "Deer", 2003 },
                    { 425, true, 31, "Hover", 2005 },
                    { 426, true, 31, "Hover M2", 2010 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 427, true, 31, "Pegasus", 2005 },
                    { 428, true, 31, "Peri", 2007 },
                    { 429, true, 31, "Safe", 2002 },
                    { 430, true, 31, "Sailor", 2004 },
                    { 431, true, 31, "Sing", 2004 },
                    { 432, true, 31, "Socool", 2004 },
                    { 433, true, 31, "Wingle", 2008 },
                    { 434, true, 32, "F7", 2018 },
                    { 435, true, 32, "H4", 2018 },
                    { 436, true, 32, "H6", 2017 },
                    { 437, true, 32, "H9", 2015 },
                    { 438, true, 33, "Commodore", 2004 },
                    { 439, true, 34, "Accord", 1998 },
                    { 453, true, 34, "Jazz", 2001 },
                    { 452, true, 34, "Jade", 2013 },
                    { 451, true, 34, "Insight", 1999 },
                    { 450, true, 34, "HR-V II (GJ)", 2014 },
                    { 449, true, 34, "HR-V", 1998 },
                    { 448, true, 34, "FR-V", 2004 },
                    { 455, true, 34, "Odyssey", 1999 },
                    { 447, true, 34, "Fit", 2001 },
                    { 445, true, 34, "Crosstour", 2010 },
                    { 444, true, 34, "CR-Z", 2010 },
                    { 443, true, 34, "CR-V", 1995 },
                    { 442, true, 34, "Civic", 2001 },
                    { 441, true, 34, "City", 2014 },
                    { 440, true, 34, "Amaze", 2011 },
                    { 446, true, 34, "Element", 2003 },
                    { 422, true, 30, "Yukon", 2000 },
                    { 490, true, 36, "Matrix", 2001 },
                    { 492, true, 36, "Porter", 1996 },
                    { 528, true, 38, "I290", 2007 },
                    { 529, true, 38, "I350", 2005 },
                    { 530, true, 38, "I370", 2007 },
                    { 531, true, 38, "Rodeo", 1998 },
                    { 532, true, 38, "Trooper", 1992 },
                    { 533, true, 38, "VehiCross", 1997 },
                    { 534, true, 39, "Daily", 2006 },
                    { 535, true, 40, "E-Pace", 2017 },
                    { 536, true, 40, "F-Pace", 2015 },
                    { 537, true, 40, "F-Type", 2013 },
                    { 538, true, 40, "I-Pace", 2018 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 539, true, 40, "S-Type", 1998 },
                    { 540, true, 40, "X-Type", 2001 },
                    { 541, true, 40, "XE", 2015 },
                    { 542, true, 40, "XF", 2007 },
                    { 543, true, 40, "XJ", 1997 },
                    { 544, true, 40, "XK/XKR", 2002 },
                    { 558, true, 42, "Clarus", 1998 },
                    { 557, true, 42, "Cerato", 2004 },
                    { 556, true, 42, "Ceed", 2006 },
                    { 555, true, 42, "Carnival", 1999 },
                    { 554, true, 42, "Carens", 2002 },
                    { 553, true, 41, "Wrangler", 1998 },
                    { 527, true, 38, "I280", 2005 },
                    { 552, true, 41, "Renegade", 2014 },
                    { 550, true, 41, "Liberty", 2006 },
                    { 549, true, 41, "Grand Cherokee", 1999 },
                    { 548, true, 41, "Gladiator", 2019 },
                    { 547, true, 41, "Compass", 2007 },
                    { 546, true, 41, "Commander", 2006 },
                    { 545, true, 41, "Cherokee", 2002 },
                    { 551, true, 41, "Patriot", 2006 },
                    { 491, true, 36, "Palisade", 2018 },
                    { 526, true, 38, "D-Max Rodeo", 2007 },
                    { 524, true, 38, "Axiom", 2002 },
                    { 493, true, 36, "Santa Fe", 2001 },
                    { 494, true, 36, "Solaris", 2010 },
                    { 495, true, 36, "Sonata", 1998 },
                    { 496, true, 36, "Terracan", 2001 },
                    { 497, true, 36, "Trajet", 2000 },
                    { 498, true, 36, "Tucson", 2004 },
                    { 499, true, 36, "Veloster", 2011 },
                    { 500, true, 36, "Veracruz", 2007 },
                    { 501, true, 36, "Verna", 2005 },
                    { 502, true, 36, "Xcent", 2014 },
                    { 503, true, 36, "XG", 1998 },
                    { 504, true, 37, "EX", 2008 },
                    { 505, true, 37, "FX", 2003 },
                    { 506, true, 37, "G", 2003 },
                    { 507, true, 37, "I35", 2002 },
                    { 508, true, 37, "JX", 2012 },
                    { 509, true, 37, "M", 2001 },
                    { 523, true, 38, "Ascender", 2002 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 522, true, 37, "QX80", 2013 },
                    { 521, true, 37, "QX70", 2013 },
                    { 520, true, 37, "QX60", 2013 },
                    { 519, true, 37, "QX56", 2004 },
                    { 518, true, 37, "QX50", 2013 },
                    { 525, true, 38, "D-Max", 2011 },
                    { 517, true, 37, "QX4", 1997 },
                    { 515, true, 37, "Q70", 2013 },
                    { 514, true, 37, "Q60", 2013 },
                    { 513, true, 37, "Q50", 2013 },
                    { 512, true, 37, "Q45", 2002 },
                    { 511, true, 37, "Q40", 2014 },
                    { 510, true, 37, "Q30", 2016 },
                    { 516, true, 37, "QX30", 2016 },
                    { 421, true, 30, "Terrain", 2010 },
                    { 420, true, 30, "Sierra 2500", 1999 },
                    { 419, true, 30, "Sierra 1500", 1999 },
                    { 318, true, 23, "California T", 2014 },
                    { 319, true, 23, "Challenge Stradale", 2003 },
                    { 320, true, 23, "Enzo", 2002 },
                    { 321, true, 23, "F12", 2012 },
                    { 322, true, 23, "F355", 1994 },
                    { 323, true, 23, "F430", 2004 },
                    { 324, true, 23, "F50", 1995 },
                    { 325, true, 23, "F512 M", 1994 },
                    { 326, true, 23, "FF", 2011 },
                    { 327, true, 23, "GTC4 Lusso", 2016 },
                    { 328, true, 23, "LaFerrari", 2013 },
                    { 329, true, 24, "124 Spider", 2015 },
                    { 330, true, 24, "500", 2007 },
                    { 331, true, 24, "500L", 2012 },
                    { 332, true, 24, "500X", 2014 },
                    { 333, true, 24, "Albea", 2002 },
                    { 334, true, 24, "Brava", 1995 },
                    { 348, true, 24, "Panda 4x4", 2003 },
                    { 347, true, 24, "Panda", 2003 },
                    { 346, true, 24, "Palio", 1996 },
                    { 345, true, 24, "Multipla", 1998 },
                    { 344, true, 24, "Marea", 1996 },
                    { 343, true, 24, "Linea", 2007 },
                    { 317, true, 23, "California", 2008 },
                    { 342, true, 24, "Idea", 2004 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 340, true, 24, "Freemont", 2011 },
                    { 339, true, 24, "Ducato", 2006 },
                    { 338, true, 24, "Doblo", 2001 },
                    { 337, true, 24, "Croma", 2005 },
                    { 336, true, 24, "Coupe", 1993 },
                    { 335, true, 24, "Bravo", 1995 },
                    { 341, true, 24, "Grande Punto", 2005 },
                    { 349, true, 24, "Punto", 1999 },
                    { 316, true, 23, "812", 2017 },
                    { 314, true, 23, "599 GTO", 2010 },
                    { 283, true, 20, "Durango", 1998 },
                    { 284, true, 20, "Intrepid", 1998 },
                    { 285, true, 20, "Journey", 2008 },
                    { 286, true, 20, "Magnum", 2004 },
                    { 287, true, 20, "Neon", 2000 },
                    { 288, true, 20, "Nitro", 2007 },
                    { 289, true, 20, "Ram 1500", 2001 },
                    { 290, true, 20, "Ram 2500", 2002 },
                    { 291, true, 20, "Ram 3500", 2002 },
                    { 292, true, 20, "Ram SRT10", 2004 },
                    { 293, true, 20, "Stratus", 2001 },
                    { 294, true, 20, "Viper", 1996 },
                    { 295, true, 21, "580", 2016 },
                    { 296, true, 21, "A30", 2014 },
                    { 297, true, 21, "AX7", 2014 },
                    { 298, true, 21, "H30 Cross", 2013 },
                    { 299, true, 22, "Besturn B30", 2016 },
                    { 313, true, 23, "599 GTB Fiorano", 2006 },
                    { 312, true, 23, "575 M", 2002 },
                    { 311, true, 23, "550", 1996 },
                    { 310, true, 23, "512", 1991 },
                    { 309, true, 23, "488", 2015 },
                    { 308, true, 23, "458", 2009 },
                    { 315, true, 23, "612", 2004 },
                    { 307, true, 23, "456", 1992 },
                    { 305, true, 23, "348", 1993 },
                    { 304, true, 22, "Vita", 2006 },
                    { 303, true, 22, "Oley", 2012 },
                    { 302, true, 22, "Besturn X80", 2014 },
                    { 301, true, 22, "Besturn X40", 2017 },
                    { 300, true, 22, "Besturn B50", 2009 },
                    { 306, true, 23, "360", 1999 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 350, true, 24, "Qubo", 2008 },
                    { 351, true, 24, "Sedici", 2005 },
                    { 352, true, 24, "Siena", 2014 },
                    { 388, true, 26, "Mustang Shelby GT500", 2020 },
                    { 389, true, 26, "Puma", 1997 },
                    { 390, true, 26, "Ranger", 2006 },
                    { 391, true, 26, "S-Max", 2006 },
                    { 392, true, 26, "Taurus", 2000 },
                    { 393, true, 26, "Taurus X", 2007 },
                    { 394, true, 26, "Thunderbird", 2000 },
                    { 395, true, 26, "Tourneo Connect", 2002 },
                    { 396, true, 26, "Transit", 2001 },
                    { 397, true, 26, "Transit Connect", 2002 },
                    { 398, true, 27, "3102", 1997 },
                    { 399, true, 27, "31105", 1997 },
                    { 400, true, 27, "Siber", 2008 },
                    { 401, true, 27, "Sobol", 2002 },
                    { 402, true, 28, "Atlas", 2018 },
                    { 403, true, 28, "Coolray", 2019 },
                    { 404, true, 28, "Emgrand 7", 2016 },
                    { 418, true, 30, "Envoy", 2001 },
                    { 417, true, 30, "Canyon", 2004 },
                    { 416, true, 30, "Acadia", 2007 },
                    { 415, true, 29, "G90", 2016 },
                    { 414, true, 29, "G80", 2017 },
                    { 413, true, 29, "G70", 2018 },
                    { 387, true, 26, "Mustang Shelby GT350", 2016 },
                    { 412, true, 28, "Vision", 2006 },
                    { 410, true, 28, "MK", 2008 },
                    { 409, true, 28, "GС6", 2014 },
                    { 408, true, 28, "GC9", 2015 },
                    { 407, true, 28, "Emgrand X7", 2011 },
                    { 406, true, 28, "Emgrand GS", 2016 },
                    { 405, true, 28, "Emgrand EC7", 2009 },
                    { 411, true, 28, "Otaka", 2006 },
                    { 386, true, 26, "Mustang", 1995 },
                    { 385, true, 26, "Mondeo", 2000 },
                    { 384, true, 26, "Maverick", 1992 },
                    { 365, true, 26, "Excursion", 1999 },
                    { 364, true, 26, "Escape", 2001 },
                    { 363, true, 26, "Edge", 2007 },
                    { 362, true, 26, "EcoSport", 2003 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Is_Active", "ManufacturerId", "ModelName", "Year" },
                values: new object[,]
                {
                    { 361, true, 26, "Crown Victoria", 1999 },
                    { 360, true, 26, "Cougar", 1998 },
                    { 366, true, 26, "Expedition", 1998 },
                    { 359, true, 26, "C-Max", 2003 },
                    { 357, true, 25, "Karma", 2011 },
                    { 1122, true, 24, "Cinquecento", 1991 },
                    { 356, true, 24, "Ulysse", 2002 },
                    { 355, true, 24, "Tipo", 2015 },
                    { 354, true, 24, "Strada", 2014 },
                    { 353, true, 24, "Stilo", 2001 },
                    { 358, true, 26, "B-Max", 2012 },
                    { 281, true, 20, "Dakota", 2005 },
                    { 367, true, 26, "Explorer", 1995 },
                    { 369, true, 26, "F-150", 1997 },
                    { 383, true, 26, "Kuga", 2008 },
                    { 382, true, 26, "Ka", 2003 },
                    { 381, true, 26, "Galaxy", 1995 },
                    { 380, true, 26, "Fusion", 2002 },
                    { 379, true, 26, "Freestyle", 2004 },
                    { 378, true, 26, "Freestar", 2003 },
                    { 368, true, 26, "Explorer Sport Trac", 2007 },
                    { 377, true, 26, "Focus Active", 2018 },
                    { 375, true, 26, "Flex", 2008 },
                    { 374, true, 26, "Five Hundred", 2005 },
                    { 373, true, 26, "Fiesta", 2002 },
                    { 372, true, 26, "Falcon", 2005 },
                    { 371, true, 26, "F-350", 2017 },
                    { 370, true, 26, "F-250", 2011 },
                    { 376, true, 26, "Focus", 1998 },
                    { 1121, true, 85, "XC90", 2002 }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "CommentContent", "CreationDate", "Engine", "Is_Active", "ModelID", "UserID", "UserName" },
                values: new object[,]
                {
                    { 2, "Just a note, engine ticking is normal on this engine, before the 2019 refresh.", new DateTime(2021, 6, 7, 9, 48, 31, 437, DateTimeKind.Local).AddTicks(9273), "Inline 4, 85", true, 482, 10, "Frank Frandsen" },
                    { 1, "Slow but reliable. The Economy is fine, but it does not match factory specification.", new DateTime(2021, 6, 7, 9, 48, 31, 437, DateTimeKind.Local).AddTicks(5462), "Inline 4, 85", true, 482, 2, "Hans Hansen" }
                });

            migrationBuilder.InsertData(
                table: "Engine",
                columns: new[] { "Id", "Fuel", "Is_Active", "Is_Electric", "ModelId", "NEDC", "Size", "Type", "WLTP", "Watt_Hours_Per_KM" },
                values: new object[,]
                {
                    { 7, "Petrol", true, false, 1, 11.4, "1.6", "Inline 4 160", 0.0, null },
                    { 2, "Petrol", true, false, 482, 19.199999999999999, "1.4", "Inline 4, 100", 0.0, null },
                    { 1, "Petrol", true, false, 482, 20.399999999999999, "1.2", "Inline 4, 85", 0.0, null },
                    { 31, "Petrol", true, false, 42, 8.0999999999999996, "6.0", "V12", 0.0, null },
                    { 30, "Petrol", true, false, 41, 8.0999999999999996, "6.0", "V12", 0.0, null },
                    { 29, "Petrol", true, false, 40, 8.0999999999999996, "6.0", "V12", 0.0, null },
                    { 28, "Petrol", true, false, 39, 8.8000000000000007, "4.0", "V8", 0.0, null },
                    { 27, "Petrol", true, false, 38, 8.0999999999999996, "6.0", "V12", 0.0, null },
                    { 26, "Petrol", true, false, 37, 8.0999999999999996, "6.0", "V12", 0.0, null },
                    { 25, "Petrol", true, false, 36, 8.0999999999999996, "6.0", "V12", 0.0, null },
                    { 24, "Petrol", true, false, 35, 8.0999999999999996, "6.0", "V12", 0.0, null },
                    { 23, "Petrol", true, false, 34, 8.0999999999999996, "6.0", "V12", 0.0, null },
                    { 22, "Petrol", true, false, 33, 8.0999999999999996, "6.0", "V12", 0.0, null },
                    { 3, "Diesel", true, false, 482, 27.800000000000001, "1.1", "Inline 4, 75", 0.0, null },
                    { 21, "Petrol", true, false, 32, 8.0999999999999996, "6.0", "V12", 0.0, null },
                    { 19, "Petrol", true, false, 20, 11.1, "1.6", "I4 Twin Spark", 0.0, null },
                    { 18, "Petrol", true, false, 19, 11.1, "1.6", "I4 Twin Spark", 0.0, null },
                    { 17, "Petrol", true, false, 18, 10.4, "3.2", "V6", 0.0, null },
                    { 16, "Petrol", true, false, 18, 11.1, "1.6", "I4 Twin Spark", 0.0, null },
                    { 15, "Petrol", true, false, 16, 10.4, "3.2", "V6", 0.0, null },
                    { 14, "Petrol", true, false, 15, 12.1, "1.6", "I4 Twin Spark", 0.0, null },
                    { 13, "Petrol", true, false, 14, 12.1, "1.6", "I4 Twin Spark", 0.0, null },
                    { 6, "Petrol", true, false, 9, 12.4, "2.0", "Inline 4 220", 0.0, null },
                    { 12, "Petrol", true, false, 8, 12.4, "3.5", "V6 Hybrid", 0.0, null },
                    { 11, "Petrol", true, false, 7, 9.4000000000000004, "3.5", "V6", 0.0, null },
                    { 10, "Petrol", true, false, 6, 11.0, "2.3", "Inline 4 240", 0.0, null },
                    { 9, "Petrol", true, false, 5, 9.4000000000000004, "3.2", "V6 300", 0.0, null },
                    { 5, "Petrol", true, false, 3, 12.4, "1.6", "Inline 4 180", 0.0, null },
                    { 8, "Petrol", true, false, 2, 11.4, "1.6", "Inline 4 160", 0.0, null },
                    { 20, "Petrol", true, false, 21, 11.1, "1.75", "Inline 4 Turbo", 0.0, null },
                    { 4, "Electric", true, true, 482, 0.0, "55", "Test Electric", 220.0, null }
                });

            migrationBuilder.InsertData(
                table: "EconomyReportElectric",
                columns: new[] { "Id", "EngineId", "Full_Range", "Is_Active", "UserID" },
                values: new object[,]
                {
                    { 1, 4, 200.0, true, 1 },
                    { 2, 4, 180.0, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "EconomyReportICE",
                columns: new[] { "Id", "Average", "City", "EngineId", "Is_Active", "Motorway", "UserID" },
                values: new object[,]
                {
                    { 1, 15.0, 16.0, 1, true, 14.0, 1 },
                    { 2, 16.0, 14.1, 1, true, 15.1, 1 },
                    { 3, 17.0, 16.300000000000001, 1, true, 16.100000000000001, 1 }
                });

            migrationBuilder.InsertData(
                table: "EconomySummaryElectrics",
                columns: new[] { "Id", "Amount_Of_Reports", "EngineId", "Manufacturer_Full_Range", "Manufacturer_Watt_Hours_Per_100Km", "Reported_Full_Range", "Reported_Watt_Hours_Per_100Km" },
                values: new object[] { 1, 3, 4, 220.0, 0.0, 190.0, 0.0 });

            migrationBuilder.InsertData(
                table: "EconomySummaryICEs",
                columns: new[] { "Id", "Amount_Of_Reports", "EngineId", "Manufacturer_Average", "Reported_Average", "Reported_City", "Reported_Motorway" },
                values: new object[] { 1, 3, 1, 20.399999999999999, 16.0, 15.5, 15.5 });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ModelID",
                table: "Comment",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserID",
                table: "Comment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_EconomyReportElectric_EngineId",
                table: "EconomyReportElectric",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_EconomyReportICE_EngineId",
                table: "EconomyReportICE",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_EconomySummaryElectrics_EngineId",
                table: "EconomySummaryElectrics",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_EconomySummaryICEs_EngineId",
                table: "EconomySummaryICEs",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Engine_ModelId",
                table: "Engine",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_ManufacturerId",
                table: "Models",
                column: "ManufacturerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "EconomyReportElectric");

            migrationBuilder.DropTable(
                name: "EconomyReportICE");

            migrationBuilder.DropTable(
                name: "EconomySummaryElectrics");

            migrationBuilder.DropTable(
                name: "EconomySummaryICEs");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Engine");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Manufacturer");
        }
    }
}
