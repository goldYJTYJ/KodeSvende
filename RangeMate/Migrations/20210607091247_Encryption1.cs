using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Encryption1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 6, 7, 11, 12, 45, 503, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 6, 7, 11, 12, 45, 503, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 42, 888, DateTimeKind.Local).AddTicks(2130), "CfDJ8JYpcSqp0EdEsEwdw1heA4ZldqkDNeODtmuNNn9DM26a0vEe9tJ5e12aN4rApXRBvZvAOsRztJZHSDZLfcaJnkAOpk__-uEG1SCu_GojNskivnGWQVXTIjLA-rsgH0QGhQ", "CfDJ8JYpcSqp0EdEsEwdw1heA4bpSvesAcJdTqHol9XssXEda7Xhust7isDPQGRkBix-scx4CkUAnimk1zr-Og6gV4xPRTTm5HTTuUExWYAUgPRqTFk4509ldAvUPVKkDbCBjQ", "$2b$10$kRpoiX5oHGlpLs.F6NFIzeoKFdoHlgWTYv6yz9HUPMHN28gquKSLm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 43, 22, DateTimeKind.Local).AddTicks(4237), "CfDJ8JYpcSqp0EdEsEwdw1heA4ZBP5ajyDlgQmlvkaAUHEFA4Uig5dVXCnGqnkZhO7wtiCVx4ujQXTHFB1McNCY5qKvSMi4wpEqXrCA0TQ9ufhNXgBJ-GUd9fvvKk-7OlXVg3Q", "CfDJ8JYpcSqp0EdEsEwdw1heA4YAr0ntt7CtvQ5jAsFrASgjtJnGSb8U_anFXQ4Lm7GDhCeg_Y_fwyXOc9N4KWiT91uBfjn9mST6WeM4Ct0Agr8A1IiyGOKpVqhc5UD-wJ6tKg", "$2b$10$Mnot7.sCUSn0SOl/gUnOZO4Fn87UofZ/T35NdN6Ajd5xRhGIUDiAK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 43, 140, DateTimeKind.Local).AddTicks(2995), "CfDJ8JYpcSqp0EdEsEwdw1heA4at14IIKnYBCrxtapuLA_eBYMbG0V1QVX4guZaFceM3005yzQQeCT00azZBiqKLIUshr9ueGzh4XYTq5KC0MjxcppfiKt7r1jOnV25OqKVMFg", "CfDJ8JYpcSqp0EdEsEwdw1heA4a-367sup7-oBaylN5aF4YAulPhSlyw9Cjvw_LSZhq616hjI1xGqWRnp6p64PGYO_u98D6k23O2lZFfBdwPNgIWuJtmdup_JJwxjBCxoqxbjQ", "$2b$10$BM9rCkr5g/1abHQlHs/d8.drXv/ljqgBfYfQuLIBBFnb3jzrQZcDG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 43, 271, DateTimeKind.Local).AddTicks(4919), "CfDJ8JYpcSqp0EdEsEwdw1heA4bXW-qHNium6whk90ruOwd1hHghKDbthKA1hjq1dRk8E-wuwezm4KLuISYYTAqHhiP0t1gEAFZdIYmJUpF2RzVkClDve-yvbNsYWECMjR6Bbg", "CfDJ8JYpcSqp0EdEsEwdw1heA4bknpQtnTagnE27plMJVymAq7okcX0otIgcsvtYsduMWFpGNBWnb-UfH3OZbNMW4kFxsFRtHH71NZKh-wETzo2kwmBB3hy0Vg_SmqcMqPp9lw", "$2b$10$WZJgOhsb73PIrS77BQF3/.VqH4LcC3AXkcX6RgxK36jZB6l7VcpHe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 43, 386, DateTimeKind.Local).AddTicks(335), "CfDJ8JYpcSqp0EdEsEwdw1heA4Y3nxjT_6KOKRHCZM0xPUDeKoxmekUeFDUiANZwBF7PaPD6u2vUcI_mjHjiz0uNIae-3cUgR36V4hhpnRA47XsTLOrhig9iLtmQFVX--4n51A", "CfDJ8JYpcSqp0EdEsEwdw1heA4ZAj_fEuhg4uE0V4wI4xwWtnZp17hw7wrLupUc-tM-_h-AC-9sEKcYNgT6OS6vodlFrZ12o6ioeMyM8ZLTHKhkRCuGVgW8doFWqOdqNLUnx_Q", "$2b$10$./m8TKp4ybZ/pKCG.0MHFuuK0T69TxU0DgHs/ar7TJbPwHf8ZdN9W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 43, 504, DateTimeKind.Local).AddTicks(4848), "CfDJ8JYpcSqp0EdEsEwdw1heA4ZMu-ZK6cI6b6QJ_Xx1L-73CdII-SR8cPp3gLPIvub8_qVBRO1URO80FsRfbKYDLETrCzRXs8yeYXSxLPoY2iQHtFwR-BnM89V1LSjmfXlL0w", "CfDJ8JYpcSqp0EdEsEwdw1heA4ZLhGycmajGG4URZwMmfcFVGmwoS08HPnTsiyN4zy3TmcIAr6IMG9o326HUZJpXP0OENYbuM2DWx8AuUmBpjMVnxKhnZ372na2Rpv6K2RkELQ", "$2b$10$Q7fI8aS/GrHcTteo9rZ3suBGP725poCpgQ7eC.fRQd8hvzyZHnsuW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 43, 634, DateTimeKind.Local).AddTicks(3184), "CfDJ8JYpcSqp0EdEsEwdw1heA4ba6dYQMeDCS14V8UA9BuHXVp5P7ZhzHSO6-bypLo069iT6ire7Nb_q58E-febjNTyLjHxDb66mzYY0o9cCekJMCuFUCU38xe0sc4HucS01Mg", "CfDJ8JYpcSqp0EdEsEwdw1heA4b8QhsyEhZ4f4QfYWa53kETDTbZPbrjhqInrRGxFQ-kx3XRa8saiD5WwvM0M6v-SoZqVkLMOaqIRaw9ffZJtB2pChBTmymr3E6_hdQNLbOd6w", "$2b$10$sI9vmYHa7doT0.TJSn3RcuBckbigTLtsj5bV.z0aH3b6VSLy4sLr2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 43, 764, DateTimeKind.Local).AddTicks(49), "CfDJ8JYpcSqp0EdEsEwdw1heA4YlTHXUgQp8w3e21F_aiCa5eh_5fDsIVwPFUzcONp4OvN-CVAd2Y0LwfMsUoA4ywi2ndNdseZbyog2xYu08jEfVYeIY65nMH6qqOBZQjsxBmA", "CfDJ8JYpcSqp0EdEsEwdw1heA4bdB-TFpp4Pl42XOZ0Ia3_AA_nNu9zFF6VaPEZoBjpPU6MfgykYNV502deheNcexiFAAl1_5lp9f4-wInrQ9dDe-ey6yo-iL71gYGBppk4SFA", "$2b$10$GAIDlkW1llDVi7VSolsCNu8c8MFcqMTiPwhyaKuDGpvC.TczIFRWW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 43, 886, DateTimeKind.Local).AddTicks(939), "CfDJ8JYpcSqp0EdEsEwdw1heA4bigWUPV7B5KAzbP4H1-TIUHvkGIpg6qIhLqpUuaFvUuMlGxzUgt7xKbGEvZZOU4ypM7nwaPKXaIYfxUNAacz9CQmIMtxzC8wYbAKN5-1BBUA", "CfDJ8JYpcSqp0EdEsEwdw1heA4aL5uNVmxGH1KLAryADX7KsMxGe322iuRlh18-Q6uLu-NoMt7TowMKl_isKhPKM_PJJQujlkoMqcfxeWdenOb6Rt60DNG6HAYm0-qWzmgwAwA", "$2b$10$jzSxJs0PahSDAvSYdNrRNOrpKR1q1GLKQeE/hViviaFqQx6scBh02" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 44, 3, DateTimeKind.Local).AddTicks(2248), "CfDJ8JYpcSqp0EdEsEwdw1heA4avqqXzP0xGOpgVyR-phCDBogQd-VIdIGUXqMQPb2xSq1xBksu3cT8tmuzIufWbkWElYIonb-KUiH7qprVj8Fg1aHWosp6LLd1LYohA4m7hiQ", "CfDJ8JYpcSqp0EdEsEwdw1heA4ZaCHc_D87_d80D-q9EuekKE91L0Na949ygvFzJdaeLSCjYai8H_gnBAKpSZGeqMeg09F7xzZwIHnnDa_-RuQFvndRimo5IXu-xZ2KqSCmu-Q", "$2b$10$P8m/lrdycatSjlALO/GII.hGXV7ECW3yqK6ORke5yDJqFxazIxFny" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 44, 121, DateTimeKind.Local).AddTicks(6012), "CfDJ8JYpcSqp0EdEsEwdw1heA4ZA6D3tROk0kqJ5LVhE_uLA3oDGQHcZN2pa_ZcFulgzDTv7yDIiVPAsDVJCIrvzfr_l902eiA016FEYBJhF4ITCxwllR9Is2u_BvtLG6FpoEA", "CfDJ8JYpcSqp0EdEsEwdw1heA4bq0bclIJM6ynXSURIztg924fX8djkhtaDG84hXgZuDPrmoWLtawHmbPSg_iYN4iNNrt0kx-RakNNwH5A4V4p75goM1rzP1K9xjsZ7BL2HSJA", "$2b$10$hySXvoxo7hZbOpLL9nCBy.Mj6V0ddZnhuk8Lynfj12x8h7XACOCs6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 44, 257, DateTimeKind.Local).AddTicks(7311), "CfDJ8JYpcSqp0EdEsEwdw1heA4ZBW-FYIaaobx40PUAMCrkAfJ30SdX7tK_-A4BwFJwhjjgrSbs0_w_BLe9xc6ylqrcg7zYs0KbpO6UB0E6uItkLiIU348JubNKHHkcFfdIG4w", "CfDJ8JYpcSqp0EdEsEwdw1heA4aThN-sPNjiU2UQyCUZNTHub3awy2YiFBuyiZ4feHvwfD68vuTIuZ2_jjqzssNiYHLhbOl-alhu6xzIS902pJOfPBDMZ_l55kHnfmA-mnPdQQ", "$2b$10$SFTQrjouZHl3x61Zdj8b5ef4satYHauj/ae9jmMuz2rnocsHvhIwa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 44, 387, DateTimeKind.Local).AddTicks(3972), "CfDJ8JYpcSqp0EdEsEwdw1heA4Y4U2ekh-tBKEwVaapxIztgd_uPEJPhFi5U2uMYURA6sdByXCGbkNze5F0-AcYUFAznx7aJGhdkLDgU6wD2Xo4xhVMgv0J8LoNpIRyJUOfKSQ", "CfDJ8JYpcSqp0EdEsEwdw1heA4bwyOwSqjgAauiiIHnnK33FCExttVfbYGApm-WdRpzKUzUy2VlbSH9yDw4hCOkyHkm7YPiMFD_9pQtujvXqZr2B12uNFqKypbScQjKMakYBYg", "$2b$10$FAdqKhJSvR36KAQT5gpRPuYhQi8x.m9IgqBo9etYOAWz.iUYh0NDe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 44, 503, DateTimeKind.Local).AddTicks(5541), "CfDJ8JYpcSqp0EdEsEwdw1heA4bjv0ereDDxSyfatZImqOf3mRpH6DVVxK8vAlZwNkH4FKTyI4P0I7nELUuz-sI3YkYeFgh_RFyKIBBDUhIDfubcENbzrypYSPWKmviOFp1Apg", "CfDJ8JYpcSqp0EdEsEwdw1heA4Y3C_MzL0lQ-SQuJGE4Rcl2V7fEEjuF6pn9qUQEO0QgFwUGWG3PXrw3stEQ7uodNKoSQcg7OnTpBjK9E278qzyZZVkwseuy9l0znMlAjn8nBQ", "$2b$10$86j0d8NUMvF0DwoXAj5nQuDM2dgHm7A1G2Ao7SGBbg1QEWIRy4Xte" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 44, 629, DateTimeKind.Local).AddTicks(9664), "CfDJ8JYpcSqp0EdEsEwdw1heA4bsxMmo0TLrucYATqSbaksIuWdv8rU2F-860OUjct_uS5pf4Nm9QIF3mmvLEIjtPu6N0ce7keXOdz5xkGQm0p9C0iPVOlhkdYEwosFPkT2KPg", "CfDJ8JYpcSqp0EdEsEwdw1heA4abw1qmQLbpltyRLD8zmbLTDzZKpBL0HpuutFPT5P7CsFPdt6mNPtUqqWrAbph4LqigM96tTMbeBSZeCRNFmXRUynaxl6Yh0I226ceji0yfog", "$2b$10$XncWmvKx0D/1RgcVn8nfweTBq7RH2P1i6KpYyTaQaACEqEC1t2Eay" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 44, 758, DateTimeKind.Local).AddTicks(97), "CfDJ8JYpcSqp0EdEsEwdw1heA4buCBoWFJwKow8O4FkMAqZ4Nc8xE25b4ju7-EhP35vFub4_lSCg13ANTQd2c5_rDio0TeLPf1fAiGERy4Q-9nL0x44FrNOK6fWKLwAI7Mlheg", "CfDJ8JYpcSqp0EdEsEwdw1heA4Zqiva36mEMLec4AKKdBVXvO7tft0OzDps2AgNyzRRMDUCoeRXtoQGClrta3D7_4SCTLXk1LPwfrj3YKCHpI-Bm8s56uWvpHUErcHLqCptXFw", "$2b$10$Lfw6Me8HuJSCOMAIJ5qtS.fb4/VKizkHlufgMBQbiE4qXvTKfplXW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 44, 889, DateTimeKind.Local).AddTicks(1317), "CfDJ8JYpcSqp0EdEsEwdw1heA4bWzKr-9oeWZynJVmXPRzeH1h6kR5HaqoBgF48QoThWHiuG1gFyOoMjozoypKiOhxHK-Izb006P2ZlatPOarWN6sQ4ZYMJl3YJ8FsLdfx6E-Q", "CfDJ8JYpcSqp0EdEsEwdw1heA4alPPEPcyALPE8RZwxIJdLJIejdQf34gdTtvwQ07y3FpJhMDXb3cxRkUeOPzLCRJ1n0RbNvyjoPMlSrcreh82cma3bbh0MgupfZsjdaPEdHPw", "$2b$10$k/WAJKLCZQdluZx73FeABelv8KTe7LN..TCqg5FgA./.HI1xSQ9je" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 45, 17, DateTimeKind.Local).AddTicks(4638), "CfDJ8JYpcSqp0EdEsEwdw1heA4aY73Ed-1vNgfyimPOmLhfKAYuz1dnbcDCJJQ-cdZHwXDSToHSCbHY2vVUUJzT8D_aMEZL4pSYr-KnSJybVjX8ZsFZP4GYP9lves-1mBRySRw", "CfDJ8JYpcSqp0EdEsEwdw1heA4YOdUGCOKPHTqnWHCXkdTtIX-OOEZE2bMrpI8kqq-KtWh1jozlOlM40WGdRYvXEg7pIvwknMPWgjKXqnjRA1VaWtQo-0l9z03D0RuJN48nllg", "$2b$10$bqdEfOFsq6.98ZZuB0JBo.DPpQrK2d7cJASD4i5C8lqt5tJtwrCJ6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 45, 130, DateTimeKind.Local).AddTicks(4376), "CfDJ8JYpcSqp0EdEsEwdw1heA4aFcd1-jwK2w_LxpsdW0HAM9FDKR2CJtdsdbY7Kspv_YzCzz0WatpKW0TBTpqajjIe8ZwaHQeEKCja24jRMaW6Bp5yjeRg-qoaIk6a5stOkuw", "CfDJ8JYpcSqp0EdEsEwdw1heA4YkgcbO5_6KvVXAmbo2qzEzUyT_3s-l70FPoYR5JZ0i6mT5XWIG21OsC-rtRGKzn6SluVpKdU9E0RFs5ZvUQPuUaeltJJswKH3Ja_zaUze70g", "$2b$10$8Ed2Bih6/g8gvdoqhI1DdecP94l6s7QDH1FLgTlzGwb.G1hi6coO6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 45, 253, DateTimeKind.Local).AddTicks(894), "CfDJ8JYpcSqp0EdEsEwdw1heA4ZLSN6CfRytosRYRL0SP3yzYSeDpTKTI1zshVH8gAZgwnH8rsY_XSeuxL-kScTRoZFujZDukhH9f41khrBknM33iVdi96dg-D-hzGIL0FOwdQ", "CfDJ8JYpcSqp0EdEsEwdw1heA4ZHVnlCuH7pdmA13do3_YsGXSGIOlSv6z0CKbhIg9wacAahTA8qWKNaxzET3wDU1gtuihXmZuk-YoDnGm0GSd1VnFXuqs85h6Il_ohNLBr3cw", "$2b$10$YpmeWiR/kVwtNWaBxSrON.pEl/9rzK303OfG/N/0/pZ1ueNpoUSS." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 45, 370, DateTimeKind.Local).AddTicks(8980), "CfDJ8JYpcSqp0EdEsEwdw1heA4bk4zP-cDk26uJD5BFVrMG5XpEdcYGOf-zj452Lf6fBafL5YwYEl1qJryj1AiIb36_rD3IrEfSZH8fJZgvV-e_ZD5Kb5Vr4gvXVyaTjR-JoSQ", "CfDJ8JYpcSqp0EdEsEwdw1heA4YlU-uA15ulZ5lehqGkgDwjQbwQfYYnUBsKgHWu78D6JG_PglZdIf_9UDH0dXRUJ-hEqMw2fAujPCBBoKMK1GcHQ1VLnKGE7U-7vSoM87BZ-A", "$2b$10$7qpXhYrrZxQEbXFm7oqqA.LbvRJrH/wAa7at7mMOMNVbZucOFs7ta" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 12, 45, 496, DateTimeKind.Local).AddTicks(5362), "CfDJ8JYpcSqp0EdEsEwdw1heA4YubTdjtsdaRWi6VgzWluX69hAoepuh9RKXaLr7rkgbNhHLL4VNvVoSJ_KeAv53iMT-S4M-S1Dgmu9UzPfEeXXtgYj-vKP5wEUiuEJqiTb7lA", "CfDJ8JYpcSqp0EdEsEwdw1heA4ZNNGrfKSFJ1TmopMGUHzhPhO6r5o-Ol30EbQqIzwIev87-KBNl9vOTI8_olokhHKuh3tWW6UzLw1yfXz96XlKTOXGEcQtFjfW_inExLLskWw", "$2b$10$um/ueUkv3LhQAHHs.nQl8u7p5dIW.wAOorHO203uapV2v2nSINlx2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 320, DateTimeKind.Local).AddTicks(7588), "Hans", "Hansen", "$2b$10$aguJx0bCke/fEvsDDqh4Ue00.W.45Ciead6fsmDx8VfXEgDcgyb/S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 437, DateTimeKind.Local).AddTicks(7915), "Poul", "Poulsen", "$2b$10$0lziIUnv42XZFk1UiWVvQ.qWoe5fA/bAsMR/1aPugDWGv6rNIg192" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 543, DateTimeKind.Local).AddTicks(4293), "Erik", "Eriksen", "$2b$10$2tmzu.Ov3A3CkvUjDnUdZ.yarg9trrYPoHpGauU2AE1GpVfa.MavG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 661, DateTimeKind.Local).AddTicks(6048), "Anne", "Annesen", "$2b$10$QVyVY7ElQurqneNn8vnXFemuEAXixk82fIV2bT99LwanRm.jPuGnq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 776, DateTimeKind.Local).AddTicks(4250), "Bo", "Boesen", "$2b$10$oNIdSvetewjDa0EnZ6YdmOlPNsdW9wgDPRfPeh2a0MeGNF3QkmPim" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 50, 897, DateTimeKind.Local).AddTicks(3752), "Caroline", "Carolinesen", "$2b$10$xuLdETtDKArrUHBDJG716es5INajA0fB5daPqkF0COC.Quod2NP02" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 23, DateTimeKind.Local).AddTicks(9297), "Dan", "Dannesen", "$2b$10$5IzacoUj0eF3ZRKFpnHGY.EWZz.Ztc.VD5fb/CEH2dZnALDgblTRG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 163, DateTimeKind.Local).AddTicks(2888), "Emil", "Emilsen", "$2b$10$VWEOfC8W/lvFpwQPmNWhL.g5UWrI1px1T3RQOnJUCkFzhjQ49wkjK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 278, DateTimeKind.Local).AddTicks(4308), "Frank", "Fransen", "$2b$10$DgKTLKw7gzrH8PTWrOSd9OeSU/lWF7yf0YiHP7PLIPqa4HaSuIVly" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 399, DateTimeKind.Local).AddTicks(1748), "Gyrne", "Gyrnesen", "$2b$10$KPO20Z9L56iX0f.SL9aUEOONvQ5/tMsGqANRCDVKorOmTG.IMZObC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 524, DateTimeKind.Local).AddTicks(8149), "Helle", "Hansen", "$2b$10$8Ap6l/hQECSeIIRpOmho/e/2sXKCu//ztFawwkZExBE1pdB7JBFcC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 642, DateTimeKind.Local).AddTicks(8444), "Ida", "Idasen", "$2b$10$X6k1WBKFmz5ce2HZmdvLZO01QG0Pb0JMa0KZlCk13oAzWY.x0tGjS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 760, DateTimeKind.Local).AddTicks(6150), "Jon", "Jonsen", "$2b$10$YrqYa9TTeEInFw/FbkeoQ.D5ubINI5C2pVVZnTtZJiZx36VhoqaM2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 51, 885, DateTimeKind.Local).AddTicks(834), "Karen", "karensen", "$2b$10$WIJNnhTIIu87gmDRqNUwf.HL0qiIIst4QXAzJ3DsDZRfDOB/qYwwe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 36, DateTimeKind.Local).AddTicks(6964), "Lau", "Lauersen", "$2b$10$1tUVJ16TarwcFVXmFicIzOGdi/I8snQ8mKHojXsTIhoxWOaUhIO1W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 162, DateTimeKind.Local).AddTicks(9623), "Martin", "Martinsen", "$2b$10$n8l7YKfJ7dX5biQ.IMLh..U/.slVkrSGj1CuqJ1lGIalxbFEPRv7K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 291, DateTimeKind.Local).AddTicks(9502), "Noel", "Noelsen", "$2b$10$G8LwTeHB2hhFpmc0KUhWAup1NlC9BqPmC2hQ3qtl9.bg4zG.76xgC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 404, DateTimeKind.Local).AddTicks(4273), "Ole", "Olesen", "$2b$10$M7WcVp.dBcdnU2Wch6IUVO.RxnzKu1.YVB9ZV/Wci4s2.q1BemFl2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 523, DateTimeKind.Local).AddTicks(4913), "Ronald", "Rollesen", "$2b$10$Osb.FTSAmJOpp0zsweLuH.um0cGwF3k8C4NX78t98/Gy9FuWpxLly" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 634, DateTimeKind.Local).AddTicks(5873), "Søren", "Sørensen", "$2b$10$x6b1BDbJmoMUMBk6FluIoOx/ILIWYmejU5uHqHXMhZlYnCnPJtV92" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AccountCreation", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2021, 6, 7, 11, 6, 52, 743, DateTimeKind.Local).AddTicks(851), "Thomas", "Thomsen", "$2b$10$/1qCMV.Mv9T2ek6g.6oDfeH0.rVkjo.M3ka2lXFN.dnzDa2rPVCNW" });
        }
    }
}
