using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Encryption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 6, 7, 11, 6, 52, 748, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 6, 7, 11, 6, 52, 748, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 204, DateTimeKind.Local).AddTicks(1492), "CfDJ8JYpcSqp0EdEsEwdw1heA4ZerH52_9tCJ66B9hINB6mbBqA4Y_IiLzJdyXrlXbSq470S490AOqFtQb3WJw0dI_llQQG8du2Bn7lPfU2ENDZxvlmCkrKc6jJZeH0hgmJJ_g", "CfDJ8JYpcSqp0EdEsEwdw1heA4b0gZl_xJYSbQ3aT_BcissNL3pQEnYHFF6C0D7upZLT1FeF2tIite-omOn08asWqJuPqtn4zjxLpwv-iMu3inj3AP0JKHR8ZA-md2cNXhlnGQ", "$2b$10$1HS1pAGdaczLv8a1q/Dp7eKS/Th73WXpeIZV0EAIwVsETWZ6BQLHy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 320, DateTimeKind.Local).AddTicks(7588), "$2b$10$aguJx0bCke/fEvsDDqh4Ue00.W.45Ciead6fsmDx8VfXEgDcgyb/S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 437, DateTimeKind.Local).AddTicks(7915), "$2b$10$0lziIUnv42XZFk1UiWVvQ.qWoe5fA/bAsMR/1aPugDWGv6rNIg192" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 543, DateTimeKind.Local).AddTicks(4293), "$2b$10$2tmzu.Ov3A3CkvUjDnUdZ.yarg9trrYPoHpGauU2AE1GpVfa.MavG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 661, DateTimeKind.Local).AddTicks(6048), "$2b$10$QVyVY7ElQurqneNn8vnXFemuEAXixk82fIV2bT99LwanRm.jPuGnq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 776, DateTimeKind.Local).AddTicks(4250), "$2b$10$oNIdSvetewjDa0EnZ6YdmOlPNsdW9wgDPRfPeh2a0MeGNF3QkmPim" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 897, DateTimeKind.Local).AddTicks(3752), "$2b$10$xuLdETtDKArrUHBDJG716es5INajA0fB5daPqkF0COC.Quod2NP02" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 23, DateTimeKind.Local).AddTicks(9297), "$2b$10$5IzacoUj0eF3ZRKFpnHGY.EWZz.Ztc.VD5fb/CEH2dZnALDgblTRG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 163, DateTimeKind.Local).AddTicks(2888), "$2b$10$VWEOfC8W/lvFpwQPmNWhL.g5UWrI1px1T3RQOnJUCkFzhjQ49wkjK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 278, DateTimeKind.Local).AddTicks(4308), "$2b$10$DgKTLKw7gzrH8PTWrOSd9OeSU/lWF7yf0YiHP7PLIPqa4HaSuIVly" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 399, DateTimeKind.Local).AddTicks(1748), "$2b$10$KPO20Z9L56iX0f.SL9aUEOONvQ5/tMsGqANRCDVKorOmTG.IMZObC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 524, DateTimeKind.Local).AddTicks(8149), "$2b$10$8Ap6l/hQECSeIIRpOmho/e/2sXKCu//ztFawwkZExBE1pdB7JBFcC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 642, DateTimeKind.Local).AddTicks(8444), "$2b$10$X6k1WBKFmz5ce2HZmdvLZO01QG0Pb0JMa0KZlCk13oAzWY.x0tGjS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 760, DateTimeKind.Local).AddTicks(6150), "$2b$10$YrqYa9TTeEInFw/FbkeoQ.D5ubINI5C2pVVZnTtZJiZx36VhoqaM2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 885, DateTimeKind.Local).AddTicks(834), "$2b$10$WIJNnhTIIu87gmDRqNUwf.HL0qiIIst4QXAzJ3DsDZRfDOB/qYwwe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 36, DateTimeKind.Local).AddTicks(6964), "$2b$10$1tUVJ16TarwcFVXmFicIzOGdi/I8snQ8mKHojXsTIhoxWOaUhIO1W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 162, DateTimeKind.Local).AddTicks(9623), "$2b$10$n8l7YKfJ7dX5biQ.IMLh..U/.slVkrSGj1CuqJ1lGIalxbFEPRv7K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 291, DateTimeKind.Local).AddTicks(9502), "$2b$10$G8LwTeHB2hhFpmc0KUhWAup1NlC9BqPmC2hQ3qtl9.bg4zG.76xgC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 404, DateTimeKind.Local).AddTicks(4273), "$2b$10$M7WcVp.dBcdnU2Wch6IUVO.RxnzKu1.YVB9ZV/Wci4s2.q1BemFl2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 523, DateTimeKind.Local).AddTicks(4913), "$2b$10$Osb.FTSAmJOpp0zsweLuH.um0cGwF3k8C4NX78t98/Gy9FuWpxLly" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 634, DateTimeKind.Local).AddTicks(5873), "$2b$10$x6b1BDbJmoMUMBk6FluIoOx/ILIWYmejU5uHqHXMhZlYnCnPJtV92" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 743, DateTimeKind.Local).AddTicks(851), "$2b$10$/1qCMV.Mv9T2ek6g.6oDfeH0.rVkjo.M3ka2lXFN.dnzDa2rPVCNW" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 6, 7, 9, 48, 31, 437, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 6, 7, 9, 48, 31, 437, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 29, 9, DateTimeKind.Local).AddTicks(8886), "CfDJ8JYpcSqp0EdEsEwdw1heA4bSL13TwtDcYloExs8JJw0J2Bzw_CeLojzx_m-qvFTe239xzoAlBpbL0VqfBurUJDjYg1W16A_-uCHQ7nnVQGN616PCvZrdZBfRf_8RtlW9xA", "Adminson", "$2b$10$PzfxW9X907tcxi0ZcYJeY.ivOMZlkgx7pmmKBscOQ/GjTsY8cVL5K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 29, 132, DateTimeKind.Local).AddTicks(1815), "$2b$10$CP0AtgxFkWc06DzCRnDTFOFhBePKvVWD5JZ3ydJFt1Se5Ch2o6A5S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 29, 243, DateTimeKind.Local).AddTicks(7185), "$2b$10$Xtjn0jXaQwhFAGZZ2ChhjeRundUJPscm8isI4NwdkRZn9hq6/Q336" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 29, 354, DateTimeKind.Local).AddTicks(5857), "$2b$10$GNidvNrLBYblsaDXz5y9gu2ky9fjGCGDPa5pYt.0ppTNMbGWq1.z2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 29, 486, DateTimeKind.Local).AddTicks(2166), "$2b$10$WCjOxgVjyBmOHCLbPTejheuediXt72r51cNJHKCCcBZ3imoV7xNii" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 29, 598, DateTimeKind.Local).AddTicks(1779), "$2b$10$rM94jGYm5emSW8dXgcSGpexuwgHtA5ZRMVSO8j2EPlDcfvYZrjJe6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 29, 715, DateTimeKind.Local).AddTicks(7889), "$2b$10$8aHF7LHi2Q98iKNHvRb2qOekR.o/4j4CwL6gRlIEOmZuHbwmYEG1S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 29, 830, DateTimeKind.Local).AddTicks(5875), "$2b$10$zkn14tKp7vqSRBJzMR6J/uegzuuo90Dmv4lPs.X0B16C2lYgTklNi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 29, 944, DateTimeKind.Local).AddTicks(9281), "$2b$10$YX9PzqyVMoPKD24KDSwrg.b6pO6ytASP0dika4kBpkkXUP4J5RfJW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 30, 59, DateTimeKind.Local).AddTicks(5215), "$2b$10$Y1nFS6WKMYWGmEce5KOgSeLpJzPfX8t8Wim7YQT2iGeVOxJCW2FQW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 30, 174, DateTimeKind.Local).AddTicks(9398), "$2b$10$wsNcGwnz/wUUp6M7Eotdn.NuBSvReupcWJT4RG44hjU30caSUAN3y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 30, 294, DateTimeKind.Local).AddTicks(2718), "$2b$10$nGNQRDt57b8/wWwyFfopsu7W2O5xu1czyufwX4fryEXQOsC0cwu26" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 30, 418, DateTimeKind.Local).AddTicks(8488), "$2b$10$aWI4IKKIDebylhW3y/Yy/uDsW0vW3RoFnq//lyBv0HWWbb1cUrFDi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 30, 530, DateTimeKind.Local).AddTicks(3936), "$2b$10$0isCi09ksJrnw9Tnazh8Buzvpukwwa1OuR7svxFDlL96AHfsLi/YO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 30, 642, DateTimeKind.Local).AddTicks(3943), "$2b$10$ESgvWkoO/9dgAUYw6R3Pi.CaUfVIqKkC2fncDLMYn09FBLu34sc1W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 30, 753, DateTimeKind.Local).AddTicks(5217), "$2b$10$2.237IxOQhBjNkALvPz/Y.u0UwUVSrb8WtlCMjRyQDcQcQpLFt4FW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 30, 865, DateTimeKind.Local).AddTicks(8252), "$2b$10$LRBXisjWX8FJmUVIEUVeSOqF8Wym6nk.vtN0I5a0/1uHXib4M1ovG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 30, 981, DateTimeKind.Local).AddTicks(8262), "$2b$10$6Cf5joiKrVy6FG9x2VIWKORxA7wH6BfaPqA8MSX6dmex.HGjtrdQ." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 31, 94, DateTimeKind.Local).AddTicks(4487), "$2b$10$Jc/PT5v8kB8k6BwmVExljO.KBp89sWMFhv6byjqHqTMLshAH.JVvO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 31, 204, DateTimeKind.Local).AddTicks(8198), "$2b$10$.nnvGBWDAoAvQi/TKxQiGegRfkPkQygBCKCz/8EEvILnmW8/7gZB2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 31, 320, DateTimeKind.Local).AddTicks(4842), "$2b$10$XqlShi3WFQ6T.2xL10b4HuSpNgK0JJwBZqrGBhNPJFIWukDrXkriO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AccountCreation", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 48, 31, 430, DateTimeKind.Local).AddTicks(5348), "$2b$10$edONIlNblEtVwrdaYbCTb.gQzT7iTri22HIzfyLThh1elLHDL4/SW" });
        }
    }
}
