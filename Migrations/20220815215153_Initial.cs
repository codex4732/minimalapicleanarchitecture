using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace minimalapicleanarchitecture.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    DtAccess = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    DtAccess = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "DtAccess", "Name", "Status", "UserId" },
                values: new object[,]
                {
                    { 101, "KI", new DateTime(2022, 6, 19, 22, 30, 36, 425, DateTimeKind.Local).AddTicks(3395), "Western Sahara", "ꃥ", 14 },
                    { 102, "LV", new DateTime(2022, 7, 21, 9, 59, 3, 996, DateTimeKind.Local).AddTicks(1817), "Portugal", "", 14 },
                    { 103, "GB", new DateTime(2022, 1, 24, 20, 33, 8, 747, DateTimeKind.Local).AddTicks(5906), "Belarus", "ⓑ", 10 },
                    { 104, "GP", new DateTime(2022, 4, 27, 2, 39, 0, 593, DateTimeKind.Local).AddTicks(7896), "Taiwan", "⽆", 9 },
                    { 105, "KR", new DateTime(2021, 9, 14, 8, 13, 22, 379, DateTimeKind.Local).AddTicks(5882), "Grenada", "谌", 9 },
                    { 106, "BH", new DateTime(2022, 7, 30, 18, 26, 53, 530, DateTimeKind.Local).AddTicks(712), "Netherlands", "検", 14 },
                    { 107, "TV", new DateTime(2021, 11, 25, 20, 24, 2, 717, DateTimeKind.Local).AddTicks(9804), "Philippines", "理", 11 },
                    { 108, "MQ", new DateTime(2022, 6, 8, 12, 35, 13, 174, DateTimeKind.Local).AddTicks(298), "Marshall Islands", "誃", 4 },
                    { 109, "AW", new DateTime(2022, 2, 18, 13, 1, 51, 411, DateTimeKind.Local).AddTicks(4751), "Philippines", "䊉", 15 },
                    { 110, "FK", new DateTime(2021, 9, 6, 0, 46, 50, 114, DateTimeKind.Local).AddTicks(8193), "Benin", "⊠", 13 },
                    { 111, "MH", new DateTime(2022, 7, 21, 20, 50, 57, 472, DateTimeKind.Local).AddTicks(1402), "Comoros", "뉚", 12 },
                    { 112, "KW", new DateTime(2021, 9, 23, 19, 37, 9, 644, DateTimeKind.Local).AddTicks(9208), "Qatar", "䝜", 3 },
                    { 113, "SH", new DateTime(2022, 3, 30, 2, 16, 45, 1, DateTimeKind.Local).AddTicks(2955), "Tanzania", "཮", 2 },
                    { 114, "BT", new DateTime(2022, 5, 16, 11, 32, 32, 761, DateTimeKind.Local).AddTicks(7305), "Faroe Islands", "⮁", 11 },
                    { 115, "CF", new DateTime(2022, 8, 8, 11, 54, 57, 659, DateTimeKind.Local).AddTicks(3838), "Guadeloupe", "鐙", 6 },
                    { 116, "BG", new DateTime(2022, 1, 12, 21, 26, 2, 75, DateTimeKind.Local).AddTicks(3649), "Tanzania", "ᱧ", 19 },
                    { 117, "SD", new DateTime(2022, 6, 12, 20, 52, 24, 251, DateTimeKind.Local).AddTicks(9163), "Iraq", "濅", 7 },
                    { 118, "FJ", new DateTime(2021, 10, 9, 7, 20, 54, 877, DateTimeKind.Local).AddTicks(9496), "Mali", "㤋", 6 },
                    { 119, "NP", new DateTime(2022, 8, 13, 4, 25, 1, 672, DateTimeKind.Local).AddTicks(9304), "Bangladesh", "Ꞡ", 18 },
                    { 120, "CH", new DateTime(2021, 8, 31, 8, 44, 42, 642, DateTimeKind.Local).AddTicks(8855), "Pitcairn Islands", "澴", 10 },
                    { 121, "TH", new DateTime(2022, 4, 19, 17, 37, 39, 251, DateTimeKind.Local).AddTicks(4559), "Hungary", "ၑ", 8 },
                    { 122, "HT", new DateTime(2022, 4, 20, 14, 49, 36, 668, DateTimeKind.Local).AddTicks(4493), "Egypt", "ཋ", 7 },
                    { 123, "SN", new DateTime(2021, 12, 21, 0, 20, 10, 169, DateTimeKind.Local).AddTicks(3160), "Colombia", "嫁", 20 },
                    { 124, "WS", new DateTime(2021, 11, 23, 13, 20, 2, 785, DateTimeKind.Local).AddTicks(1700), "San Marino", "੠", 9 },
                    { 125, "CX", new DateTime(2022, 3, 12, 4, 41, 10, 369, DateTimeKind.Local).AddTicks(4844), "Spain", "㩙", 7 },
                    { 126, "ZM", new DateTime(2022, 7, 28, 14, 19, 31, 437, DateTimeKind.Local).AddTicks(1222), "Democratic People's Republic of Korea", "", 1 },
                    { 127, "LT", new DateTime(2022, 1, 26, 21, 32, 6, 318, DateTimeKind.Local).AddTicks(6466), "Luxembourg", "ꎋ", 12 },
                    { 128, "DO", new DateTime(2022, 4, 11, 1, 57, 39, 546, DateTimeKind.Local).AddTicks(1273), "Qatar", "ᰥ", 3 },
                    { 129, "TK", new DateTime(2022, 7, 13, 11, 22, 16, 73, DateTimeKind.Local).AddTicks(7793), "Chad", "Ꮻ", 5 },
                    { 130, "ES", new DateTime(2022, 7, 16, 0, 10, 9, 816, DateTimeKind.Local).AddTicks(6338), "Antigua and Barbuda", "䉌", 11 },
                    { 131, "VI", new DateTime(2022, 7, 7, 7, 6, 5, 153, DateTimeKind.Local).AddTicks(3586), "Malaysia", "鴾", 3 },
                    { 132, "BM", new DateTime(2021, 9, 13, 0, 22, 51, 931, DateTimeKind.Local).AddTicks(3218), "Mauritania", "ፒ", 20 },
                    { 133, "AU", new DateTime(2022, 8, 2, 13, 11, 37, 955, DateTimeKind.Local).AddTicks(1585), "Albania", "ꭞ", 20 },
                    { 134, "PR", new DateTime(2021, 10, 3, 9, 38, 30, 868, DateTimeKind.Local).AddTicks(5233), "Maldives", "脨", 14 },
                    { 135, "TN", new DateTime(2022, 1, 7, 14, 53, 38, 152, DateTimeKind.Local).AddTicks(4376), "Saudi Arabia", "ॉ", 11 },
                    { 136, "GL", new DateTime(2021, 12, 20, 1, 2, 29, 804, DateTimeKind.Local).AddTicks(9739), "Kiribati", "", 10 },
                    { 137, "VE", new DateTime(2022, 1, 12, 1, 24, 49, 666, DateTimeKind.Local).AddTicks(3293), "Japan", "ⷥ", 18 },
                    { 138, "ID", new DateTime(2022, 6, 28, 18, 5, 22, 419, DateTimeKind.Local).AddTicks(9346), "Burkina Faso", "⤋", 14 },
                    { 139, "UM", new DateTime(2021, 11, 15, 17, 47, 29, 158, DateTimeKind.Local).AddTicks(4201), "Democratic People's Republic of Korea", "㓸", 14 },
                    { 140, "HU", new DateTime(2022, 5, 16, 14, 11, 27, 268, DateTimeKind.Local).AddTicks(965), "Malta", "첆", 19 },
                    { 141, "WS", new DateTime(2022, 2, 26, 21, 21, 23, 241, DateTimeKind.Local).AddTicks(4569), "New Zealand", "疪", 4 },
                    { 142, "NZ", new DateTime(2022, 7, 5, 6, 28, 59, 44, DateTimeKind.Local).AddTicks(5722), "Namibia", "", 19 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "DtAccess", "Name", "Status", "UserId" },
                values: new object[,]
                {
                    { 143, "CA", new DateTime(2021, 9, 29, 23, 27, 38, 965, DateTimeKind.Local).AddTicks(3329), "Andorra", "蛧", 12 },
                    { 144, "BR", new DateTime(2021, 10, 1, 10, 51, 23, 644, DateTimeKind.Local).AddTicks(8293), "Aruba", "嚶", 6 },
                    { 145, "FR", new DateTime(2022, 8, 15, 17, 46, 8, 917, DateTimeKind.Local).AddTicks(2790), "Tunisia", "摼", 6 },
                    { 146, "JP", new DateTime(2021, 8, 18, 20, 11, 52, 680, DateTimeKind.Local).AddTicks(3284), "Qatar", "", 3 },
                    { 147, "KZ", new DateTime(2022, 6, 26, 23, 21, 7, 100, DateTimeKind.Local).AddTicks(2913), "Burkina Faso", "ㅘ", 11 },
                    { 148, "TG", new DateTime(2022, 3, 9, 6, 51, 54, 940, DateTimeKind.Local).AddTicks(5901), "Fiji", "ᱸ", 4 },
                    { 149, "MM", new DateTime(2021, 10, 1, 6, 38, 4, 811, DateTimeKind.Local).AddTicks(3254), "Cuba", "ꅦ", 9 },
                    { 150, "EC", new DateTime(2022, 5, 3, 2, 36, 32, 870, DateTimeKind.Local).AddTicks(2728), "Sweden", "", 15 },
                    { 151, "JP", new DateTime(2022, 7, 13, 19, 18, 2, 657, DateTimeKind.Local).AddTicks(8861), "Solomon Islands", "ꤥ", 12 },
                    { 152, "LC", new DateTime(2022, 6, 29, 4, 52, 38, 106, DateTimeKind.Local).AddTicks(5499), "Latvia", "봄", 18 },
                    { 153, "GH", new DateTime(2021, 10, 5, 21, 54, 49, 544, DateTimeKind.Local).AddTicks(5375), "South Africa", "Ϊ", 6 },
                    { 154, "GD", new DateTime(2022, 1, 4, 6, 57, 44, 145, DateTimeKind.Local).AddTicks(3015), "Oman", "࿮", 3 },
                    { 155, "RU", new DateTime(2022, 2, 22, 0, 33, 31, 392, DateTimeKind.Local).AddTicks(3926), "Rwanda", "᫡", 8 },
                    { 156, "SB", new DateTime(2022, 5, 10, 0, 9, 17, 924, DateTimeKind.Local).AddTicks(5745), "Eritrea", "ⷌ", 11 },
                    { 157, "KN", new DateTime(2022, 8, 1, 9, 24, 41, 350, DateTimeKind.Local).AddTicks(5944), "Bouvet Island (Bouvetoya)", "�", 19 },
                    { 158, "CY", new DateTime(2021, 9, 3, 12, 6, 50, 0, DateTimeKind.Local).AddTicks(9530), "Sao Tome and Principe", "朥", 18 },
                    { 159, "MN", new DateTime(2022, 4, 30, 22, 50, 53, 730, DateTimeKind.Local).AddTicks(2889), "Mozambique", "艣", 11 },
                    { 160, "GU", new DateTime(2021, 12, 2, 15, 16, 52, 422, DateTimeKind.Local).AddTicks(8551), "Argentina", "Ｔ", 8 },
                    { 161, "ES", new DateTime(2022, 4, 7, 9, 40, 42, 332, DateTimeKind.Local).AddTicks(6711), "Slovakia (Slovak Republic)", "ᮆ", 4 },
                    { 162, "CL", new DateTime(2022, 1, 8, 20, 10, 56, 327, DateTimeKind.Local).AddTicks(6372), "Anguilla", "꠸", 18 },
                    { 163, "KW", new DateTime(2022, 6, 17, 19, 22, 28, 730, DateTimeKind.Local).AddTicks(7241), "Antarctica (the territory South of 60 deg S)", "홋", 9 },
                    { 164, "KZ", new DateTime(2022, 6, 30, 10, 21, 20, 601, DateTimeKind.Local).AddTicks(9940), "Ireland", "", 18 },
                    { 165, "BW", new DateTime(2022, 4, 12, 22, 37, 28, 883, DateTimeKind.Local).AddTicks(8866), "Australia", "מּ", 14 },
                    { 166, "EE", new DateTime(2021, 10, 1, 11, 10, 58, 459, DateTimeKind.Local).AddTicks(2145), "Bahrain", "咇", 8 },
                    { 167, "CX", new DateTime(2021, 10, 15, 19, 58, 28, 31, DateTimeKind.Local).AddTicks(6738), "Bouvet Island (Bouvetoya)", "귇", 5 },
                    { 168, "TN", new DateTime(2021, 11, 28, 7, 27, 33, 782, DateTimeKind.Local).AddTicks(6072), "Malta", "坣", 20 },
                    { 169, "CH", new DateTime(2022, 7, 16, 2, 21, 25, 669, DateTimeKind.Local).AddTicks(9290), "Israel", "圼", 9 },
                    { 170, "KH", new DateTime(2021, 10, 23, 15, 10, 20, 623, DateTimeKind.Local).AddTicks(9478), "New Caledonia", "ƴ", 7 },
                    { 171, "MR", new DateTime(2022, 2, 19, 15, 56, 38, 378, DateTimeKind.Local).AddTicks(8291), "Saudi Arabia", "㱞", 3 },
                    { 172, "ER", new DateTime(2022, 1, 16, 10, 9, 38, 234, DateTimeKind.Local).AddTicks(2530), "Cameroon", "ꝲ", 9 },
                    { 173, "LA", new DateTime(2022, 4, 1, 6, 30, 17, 142, DateTimeKind.Local).AddTicks(1423), "Saint Vincent and the Grenadines", "鏕", 18 },
                    { 174, "KR", new DateTime(2022, 5, 29, 19, 42, 28, 592, DateTimeKind.Local).AddTicks(7440), "Heard Island and McDonald Islands", "箰", 15 },
                    { 175, "LS", new DateTime(2021, 11, 14, 20, 16, 35, 17, DateTimeKind.Local).AddTicks(6682), "Cuba", "ᇰ", 4 },
                    { 176, "AI", new DateTime(2021, 11, 14, 13, 31, 57, 143, DateTimeKind.Local).AddTicks(4871), "Mayotte", "塞", 11 },
                    { 177, "IR", new DateTime(2021, 11, 16, 19, 5, 56, 255, DateTimeKind.Local).AddTicks(9077), "Gibraltar", "", 5 },
                    { 178, "GQ", new DateTime(2021, 11, 22, 22, 35, 15, 165, DateTimeKind.Local).AddTicks(3511), "Solomon Islands", "兩", 16 },
                    { 179, "AX", new DateTime(2022, 7, 27, 20, 57, 12, 930, DateTimeKind.Local).AddTicks(3354), "Bangladesh", "瓉", 6 },
                    { 180, "SV", new DateTime(2021, 10, 1, 5, 30, 36, 660, DateTimeKind.Local).AddTicks(6382), "Anguilla", "鐉", 14 },
                    { 181, "IN", new DateTime(2021, 9, 14, 5, 4, 8, 379, DateTimeKind.Local).AddTicks(5840), "South Africa", "穎", 6 },
                    { 182, "MA", new DateTime(2022, 7, 2, 5, 5, 41, 290, DateTimeKind.Local).AddTicks(888), "Pakistan", "뛡", 12 },
                    { 183, "GM", new DateTime(2022, 4, 19, 1, 6, 15, 768, DateTimeKind.Local).AddTicks(2616), "Denmark", "ვ", 9 },
                    { 184, "NG", new DateTime(2022, 4, 5, 13, 39, 54, 281, DateTimeKind.Local).AddTicks(3165), "American Samoa", "煮", 14 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "DtAccess", "Name", "Status", "UserId" },
                values: new object[,]
                {
                    { 185, "LR", new DateTime(2022, 4, 24, 0, 31, 55, 648, DateTimeKind.Local).AddTicks(6730), "Czech Republic", "짫", 20 },
                    { 186, "MC", new DateTime(2021, 12, 3, 2, 7, 48, 59, DateTimeKind.Local).AddTicks(4084), "Sweden", "∈", 4 },
                    { 187, "IN", new DateTime(2022, 1, 14, 8, 41, 46, 252, DateTimeKind.Local).AddTicks(7482), "Cyprus", "촽", 6 },
                    { 188, "MW", new DateTime(2021, 12, 22, 6, 41, 53, 344, DateTimeKind.Local).AddTicks(7109), "Martinique", "䇶", 19 },
                    { 189, "SB", new DateTime(2022, 7, 30, 12, 44, 52, 164, DateTimeKind.Local).AddTicks(8536), "Malawi", "ꨆ", 6 },
                    { 190, "LB", new DateTime(2021, 11, 19, 3, 48, 17, 845, DateTimeKind.Local).AddTicks(8322), "Benin", "ᛴ", 20 },
                    { 191, "BY", new DateTime(2021, 12, 2, 20, 59, 33, 247, DateTimeKind.Local).AddTicks(8834), "India", "㲀", 5 },
                    { 192, "AM", new DateTime(2021, 9, 16, 11, 19, 46, 997, DateTimeKind.Local).AddTicks(1738), "Tanzania", "镴", 9 },
                    { 193, "WF", new DateTime(2021, 10, 30, 3, 27, 26, 790, DateTimeKind.Local).AddTicks(4961), "Antigua and Barbuda", "", 18 },
                    { 194, "CK", new DateTime(2021, 12, 19, 15, 11, 22, 598, DateTimeKind.Local).AddTicks(2737), "Saint Martin", "", 1 },
                    { 195, "MO", new DateTime(2022, 8, 2, 16, 53, 30, 808, DateTimeKind.Local).AddTicks(8550), "Maldives", "黽", 18 },
                    { 196, "SV", new DateTime(2022, 8, 12, 15, 32, 6, 968, DateTimeKind.Local).AddTicks(1816), "Bulgaria", "�", 7 },
                    { 197, "CU", new DateTime(2022, 2, 22, 20, 52, 35, 742, DateTimeKind.Local).AddTicks(3637), "Argentina", "Ꞻ", 15 },
                    { 198, "LR", new DateTime(2022, 1, 24, 5, 12, 36, 381, DateTimeKind.Local).AddTicks(5195), "Virgin Islands, British", "䓰", 4 },
                    { 199, "VG", new DateTime(2021, 8, 31, 3, 20, 18, 861, DateTimeKind.Local).AddTicks(3334), "Uganda", "禎", 2 },
                    { 200, "IL", new DateTime(2022, 3, 25, 7, 22, 8, 220, DateTimeKind.Local).AddTicks(2726), "Norway", "꼷", 12 }
                });

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "Address1", "CountryId", "DtAccess", "Email", "FirstName", "LastName", "Phone", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, "367 Elmira Plain", 5, new DateTime(2022, 6, 13, 12, 59, 16, 547, DateTimeKind.Local).AddTicks(902), "Logan.Schoen@gmail.com", "Gerda", "Goodwin", "1-820-818-6868 x26850", "", 17 },
                    { 2, "27746 Torp Radial", 12, new DateTime(2021, 8, 28, 8, 22, 22, 597, DateTimeKind.Local).AddTicks(8376), "Michale3@yahoo.com", "Vincenza", "Bahringer", "807-259-5658 x7778", "粬", 8 },
                    { 3, "7576 Jones Viaduct", 11, new DateTime(2021, 12, 13, 1, 31, 7, 719, DateTimeKind.Local).AddTicks(6884), "Raymond_Parisian@yahoo.com", "Blake", "Beahan", "646-619-5106 x0408", "裲", 19 },
                    { 4, "994 Schumm Village", 6, new DateTime(2022, 8, 3, 9, 20, 3, 160, DateTimeKind.Local).AddTicks(8793), "Wendell_Konopelski@yahoo.com", "Judd", "Kuhn", "780-664-7063 x3326", "㨅", 7 },
                    { 5, "9743 Stroman Pine", 15, new DateTime(2022, 3, 30, 18, 3, 27, 217, DateTimeKind.Local).AddTicks(1558), "Una_Kreiger80@yahoo.com", "Freda", "Waters", "859-289-7619 x2929", "蠶", 7 },
                    { 6, "337 Alessia Mount", 7, new DateTime(2021, 10, 3, 15, 8, 13, 641, DateTimeKind.Local).AddTicks(611), "Laurie_Ullrich@yahoo.com", "Lonzo", "Schuppe", "(425) 427-1556 x86830", "꩎", 20 },
                    { 7, "414 Predovic Summit", 17, new DateTime(2021, 10, 19, 20, 18, 48, 460, DateTimeKind.Local).AddTicks(3644), "Joanie_Waelchi99@hotmail.com", "Liza", "Sauer", "699-699-1264 x8216", "闳", 8 },
                    { 8, "906 Conn Walk", 6, new DateTime(2022, 8, 2, 9, 25, 2, 435, DateTimeKind.Local).AddTicks(6186), "Jacquelyn.Bayer70@hotmail.com", "Charity", "Tillman", "422-506-1262", "៻", 20 },
                    { 9, "3969 Thiel Summit", 3, new DateTime(2022, 1, 16, 19, 53, 3, 826, DateTimeKind.Local).AddTicks(4587), "Jaquan97@hotmail.com", "Jaiden", "Jaskolski", "941-331-0938 x14910", "ḕ", 8 },
                    { 10, "0561 Kevon Courts", 16, new DateTime(2022, 2, 5, 3, 35, 25, 896, DateTimeKind.Local).AddTicks(923), "Aryanna_Schoen@gmail.com", "Terry", "Nolan", "505.329.1308 x9742", "흉", 6 },
                    { 11, "404 Norberto Court", 3, new DateTime(2022, 6, 7, 1, 17, 38, 370, DateTimeKind.Local).AddTicks(8277), "Jaylin25@gmail.com", "Nicholas", "Waters", "493.920.4139 x2905", "鈰", 3 },
                    { 12, "723 Larkin Trail", 10, new DateTime(2021, 12, 8, 7, 23, 32, 912, DateTimeKind.Local).AddTicks(8564), "Stephany_Berge@hotmail.com", "Carmelo", "King", "1-344-825-3713 x8395", "鉺", 20 },
                    { 13, "26977 Sherman Radial", 5, new DateTime(2022, 7, 24, 12, 14, 53, 535, DateTimeKind.Local).AddTicks(5356), "Georgianna99@hotmail.com", "Gregoria", "Johns", "567.975.3188", "纵", 20 },
                    { 14, "2769 Shawn Lodge", 11, new DateTime(2022, 8, 1, 22, 2, 18, 116, DateTimeKind.Local).AddTicks(8207), "Jacey.Casper92@hotmail.com", "Winnifred", "Zieme", "533.666.1401 x3372", "Ḋ", 16 },
                    { 15, "58454 Blanda Drive", 9, new DateTime(2021, 12, 19, 22, 45, 33, 701, DateTimeKind.Local).AddTicks(6538), "Cheyanne.Nader34@hotmail.com", "Ignacio", "Stoltenberg", "(416) 543-5665", "�", 6 },
                    { 16, "464 Pfeffer Lakes", 15, new DateTime(2022, 6, 2, 22, 16, 31, 309, DateTimeKind.Local).AddTicks(3974), "Gay.Batz@gmail.com", "Chaim", "Jones", "(585) 779-6830 x9887", "쨒", 9 },
                    { 17, "46955 Javier Rue", 16, new DateTime(2022, 4, 3, 19, 17, 4, 328, DateTimeKind.Local).AddTicks(6415), "Maribel_Upton67@hotmail.com", "Julie", "Pollich", "1-351-742-3476 x989", "a", 15 },
                    { 18, "927 Terrence Mills", 9, new DateTime(2022, 8, 7, 14, 19, 45, 306, DateTimeKind.Local).AddTicks(1084), "Letitia2@yahoo.com", "John", "Bergstrom", "1-370-710-9405", "薚", 2 },
                    { 19, "618 Coty Lake", 3, new DateTime(2022, 4, 4, 0, 27, 17, 148, DateTimeKind.Local).AddTicks(6676), "Raegan99@gmail.com", "Ruben", "Becker", "681-641-1313 x83059", "췑", 2 },
                    { 20, "48861 Thompson Springs", 10, new DateTime(2021, 8, 23, 6, 21, 34, 75, DateTimeKind.Local).AddTicks(2062), "Geraldine_Conn@gmail.com", "Shaylee", "Gleichner", "(558) 334-9989", "㲈", 10 },
                    { 21, "4263 Jay Centers", 3, new DateTime(2022, 1, 27, 16, 0, 27, 829, DateTimeKind.Local).AddTicks(5480), "Shayna_Schumm@yahoo.com", "Tremaine", "Wolf", "(450) 217-5470", "칶", 10 },
                    { 22, "145 Franecki Oval", 6, new DateTime(2021, 12, 13, 9, 0, 5, 14, DateTimeKind.Local).AddTicks(57), "Emil.Hilll30@yahoo.com", "Maryam", "Runolfsson", "725-793-9900 x9041", "ꄐ", 9 },
                    { 23, "942 Cormier Glen", 9, new DateTime(2022, 6, 29, 7, 40, 53, 74, DateTimeKind.Local).AddTicks(4556), "Odessa_Stroman@hotmail.com", "Kristoffer", "Kuhn", "(672) 538-7644", "䗩", 12 },
                    { 24, "917 Marquardt Forest", 12, new DateTime(2021, 9, 1, 10, 11, 7, 935, DateTimeKind.Local).AddTicks(805), "Dalton.Swift@gmail.com", "Toney", "Cremin", "628.468.5397 x971", "", 10 },
                    { 25, "218 Kutch Bypass", 9, new DateTime(2022, 4, 13, 13, 59, 46, 3, DateTimeKind.Local).AddTicks(4890), "Rafaela_Corwin29@yahoo.com", "Jonathan", "Rutherford", "(528) 566-1082", "", 2 },
                    { 26, "459 Gerry Streets", 1, new DateTime(2021, 12, 9, 14, 1, 53, 98, DateTimeKind.Local).AddTicks(8103), "Conner45@hotmail.com", "Shirley", "Rolfson", "1-370-630-4414", "ఄ", 10 }
                });

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "Address1", "CountryId", "DtAccess", "Email", "FirstName", "LastName", "Phone", "Status", "UserId" },
                values: new object[,]
                {
                    { 27, "094 Roberts Coves", 14, new DateTime(2022, 1, 12, 9, 57, 47, 948, DateTimeKind.Local).AddTicks(6500), "Bennett_Lehner@yahoo.com", "Brisa", "Konopelski", "(226) 283-3344 x011", "㮉", 16 },
                    { 28, "9651 Horacio Mission", 16, new DateTime(2022, 2, 21, 20, 17, 11, 851, DateTimeKind.Local).AddTicks(9186), "Will_Kling80@yahoo.com", "Amelie", "Prohaska", "714.700.4393 x355", "귋", 8 },
                    { 29, "3279 Tony Corner", 8, new DateTime(2021, 10, 22, 11, 52, 25, 800, DateTimeKind.Local).AddTicks(4015), "Einar46@hotmail.com", "Idell", "Kunze", "285.801.4669", "聕", 9 },
                    { 30, "190 Carolanne Oval", 13, new DateTime(2022, 2, 15, 23, 50, 7, 274, DateTimeKind.Local).AddTicks(8144), "Eduardo.Considine@gmail.com", "Diego", "Blick", "754-479-2943", "", 2 },
                    { 31, "708 Emmett Plain", 12, new DateTime(2021, 10, 30, 18, 9, 41, 818, DateTimeKind.Local).AddTicks(9711), "Dangelo45@yahoo.com", "Nola", "Terry", "1-861-265-7665", "㏔", 2 },
                    { 32, "0204 Kozey Dale", 17, new DateTime(2022, 2, 6, 15, 2, 9, 755, DateTimeKind.Local).AddTicks(3821), "Jaren92@hotmail.com", "Raleigh", "Ortiz", "520-561-4142 x91380", "긶", 6 },
                    { 33, "7081 Favian Mountain", 2, new DateTime(2022, 4, 18, 11, 25, 6, 223, DateTimeKind.Local).AddTicks(7430), "Russ.Krajcik39@hotmail.com", "Dianna", "Haley", "445.949.2820 x04385", "극", 10 },
                    { 34, "4089 Price Well", 14, new DateTime(2022, 3, 28, 1, 26, 12, 164, DateTimeKind.Local).AddTicks(3336), "Rosina.Hermiston17@hotmail.com", "Opal", "Conroy", "(453) 932-0999", "킙", 8 },
                    { 35, "014 Floyd Court", 6, new DateTime(2022, 1, 13, 5, 14, 34, 573, DateTimeKind.Local).AddTicks(5844), "Cameron_Friesen@hotmail.com", "Gus", "West", "(451) 805-3966 x183", "ኸ", 9 },
                    { 36, "57623 Jackeline Lane", 16, new DateTime(2021, 9, 20, 5, 44, 27, 37, DateTimeKind.Local).AddTicks(5646), "Madisen94@yahoo.com", "Sandra", "Powlowski", "267-443-5419", "欩", 8 },
                    { 37, "63180 Carter Ford", 16, new DateTime(2021, 12, 14, 6, 14, 4, 76, DateTimeKind.Local).AddTicks(105), "Tomasa75@yahoo.com", "Fausto", "Jacobson", "241.924.1623", "ꛠ", 16 },
                    { 38, "3003 Halie Dam", 10, new DateTime(2021, 11, 25, 18, 57, 37, 258, DateTimeKind.Local).AddTicks(8642), "Garret_Adams@gmail.com", "Stacey", "Thompson", "856-392-3786 x5228", "ሀ", 2 },
                    { 39, "1684 Corwin Mill", 7, new DateTime(2021, 11, 28, 22, 3, 15, 716, DateTimeKind.Local).AddTicks(8894), "Bernadette_Koepp@yahoo.com", "Khalil", "Kuhic", "381.687.8402 x63116", "", 7 },
                    { 40, "53492 Quitzon Lodge", 8, new DateTime(2022, 4, 29, 18, 38, 28, 492, DateTimeKind.Local).AddTicks(5779), "Johan_Larkin53@yahoo.com", "Rhea", "Hegmann", "767.911.6635", "謁", 1 },
                    { 41, "77699 Darion Gateway", 18, new DateTime(2022, 1, 21, 0, 49, 2, 28, DateTimeKind.Local).AddTicks(3086), "Nicolette.Smitham@gmail.com", "Abdiel", "VonRueden", "(258) 767-8165 x81165", "᣿", 7 },
                    { 42, "574 Loyce Grove", 9, new DateTime(2021, 9, 21, 13, 21, 29, 583, DateTimeKind.Local).AddTicks(4456), "Jazmyn_Rodriguez@hotmail.com", "Tom", "Dietrich", "558-227-1541", "횢", 12 },
                    { 43, "76501 Izaiah Estate", 9, new DateTime(2021, 9, 12, 10, 18, 30, 930, DateTimeKind.Local).AddTicks(2072), "Darwin_Mosciski41@gmail.com", "Maxie", "Carroll", "646-621-5481", "귫", 7 },
                    { 44, "629 Davis Prairie", 5, new DateTime(2022, 4, 21, 8, 8, 37, 156, DateTimeKind.Local).AddTicks(7644), "Jeramy20@hotmail.com", "Broderick", "Weimann", "1-595-703-7326", "", 5 },
                    { 45, "967 Adalberto Inlet", 14, new DateTime(2021, 12, 19, 8, 52, 11, 715, DateTimeKind.Local).AddTicks(346), "Friedrich.Schneider@hotmail.com", "Graham", "Stamm", "321-380-2663", "㸐", 18 },
                    { 46, "6050 Luisa Lake", 5, new DateTime(2021, 10, 2, 0, 1, 30, 383, DateTimeKind.Local).AddTicks(8800), "Emmalee_Stark@gmail.com", "Agustina", "Wolf", "599-350-5587", "뢡", 19 },
                    { 47, "561 Haylee Manor", 6, new DateTime(2022, 6, 23, 12, 48, 56, 491, DateTimeKind.Local).AddTicks(5898), "Wendell_Reinger@yahoo.com", "Brennan", "Rogahn", "(475) 966-9181", "㷠", 5 },
                    { 48, "7690 Marquardt Coves", 9, new DateTime(2022, 5, 31, 11, 6, 36, 82, DateTimeKind.Local).AddTicks(2707), "Gaston_Orn@gmail.com", "Cortez", "Cole", "(201) 614-6534 x989", "㰡", 13 },
                    { 49, "2246 Gutkowski Mountains", 14, new DateTime(2021, 10, 3, 0, 7, 32, 535, DateTimeKind.Local).AddTicks(3694), "Josh.Monahan@hotmail.com", "Chelsey", "Gaylord", "1-862-835-6384 x1672", "", 13 },
                    { 50, "862 Donnelly Lock", 4, new DateTime(2022, 7, 3, 2, 30, 26, 104, DateTimeKind.Local).AddTicks(1587), "Mary34@yahoo.com", "Charity", "Kuhic", "1-230-475-1356 x470", "９", 15 },
                    { 51, "12431 Xzavier Mount", 3, new DateTime(2022, 4, 28, 10, 43, 34, 416, DateTimeKind.Local).AddTicks(6545), "Jo28@yahoo.com", "Dalton", "Marks", "929-630-1552 x42986", "⳴", 2 },
                    { 52, "965 Dietrich Forges", 11, new DateTime(2022, 3, 1, 0, 21, 27, 895, DateTimeKind.Local).AddTicks(9288), "Emil56@yahoo.com", "Talia", "Runolfsson", "449.316.4759 x40734", "㋲", 14 },
                    { 53, "20288 Dedric Light", 18, new DateTime(2022, 4, 15, 6, 46, 40, 734, DateTimeKind.Local).AddTicks(1048), "Madelyn61@yahoo.com", "Dayna", "Vandervort", "429.577.8364 x000", "", 9 },
                    { 54, "0421 Laurianne Isle", 15, new DateTime(2021, 11, 28, 18, 7, 38, 709, DateTimeKind.Local).AddTicks(3287), "Mercedes.Macejkovic2@hotmail.com", "Scarlett", "Purdy", "(394) 979-8300 x5815", "ꦃ", 15 },
                    { 55, "534 Lueilwitz Wells", 1, new DateTime(2021, 11, 10, 18, 24, 14, 136, DateTimeKind.Local).AddTicks(2669), "Jordon_Deckow4@yahoo.com", "Roxanne", "Wiegand", "(782) 993-6501 x4698", "䆜", 5 },
                    { 56, "1701 Littel Ways", 20, new DateTime(2022, 7, 25, 22, 49, 27, 134, DateTimeKind.Local).AddTicks(7554), "Nat51@yahoo.com", "Owen", "Hettinger", "540.428.5198", "瑊", 8 },
                    { 57, "361 Gerhold Village", 16, new DateTime(2022, 1, 31, 22, 36, 25, 149, DateTimeKind.Local).AddTicks(7955), "Ellie_McGlynn@hotmail.com", "Tierra", "Cormier", "306-336-4330", "借", 5 },
                    { 58, "436 Darius Parkways", 11, new DateTime(2021, 10, 31, 9, 22, 5, 683, DateTimeKind.Local).AddTicks(8178), "Elliott_McGlynn10@yahoo.com", "Chyna", "Kris", "1-278-844-9134 x61812", "垤", 14 },
                    { 59, "16395 Crona Lock", 11, new DateTime(2022, 7, 31, 6, 22, 11, 710, DateTimeKind.Local).AddTicks(2727), "Alexane_Hoeger57@hotmail.com", "Isaiah", "O'Connell", "345-684-3794 x127", "잖", 12 },
                    { 60, "05605 Wava Ridge", 13, new DateTime(2022, 6, 18, 4, 46, 50, 630, DateTimeKind.Local).AddTicks(322), "Madison51@gmail.com", "Destini", "Graham", "989.680.0440 x3033", "㎣", 18 },
                    { 61, "52899 Lynch Forges", 6, new DateTime(2022, 4, 23, 22, 24, 8, 465, DateTimeKind.Local).AddTicks(2213), "Macie_Hegmann98@yahoo.com", "Christine", "Torp", "831.770.6871 x51109", "䣊", 18 },
                    { 62, "43886 Haag Fall", 18, new DateTime(2022, 2, 3, 10, 25, 46, 286, DateTimeKind.Local).AddTicks(7055), "Cole_Rowe23@gmail.com", "Kenton", "Frami", "686-753-1473", "㉫", 9 },
                    { 63, "20847 Kacie Plains", 17, new DateTime(2022, 1, 5, 8, 22, 2, 203, DateTimeKind.Local).AddTicks(6122), "Berneice.Jerde9@yahoo.com", "Terry", "Herman", "(614) 612-9054 x64226", "ᐟ", 7 },
                    { 64, "933 Ryder Groves", 5, new DateTime(2021, 10, 20, 22, 45, 40, 640, DateTimeKind.Local).AddTicks(2690), "Mohamed85@gmail.com", "Reid", "Stroman", "329.802.6753 x2881", "场", 9 },
                    { 65, "1880 Vena Lane", 14, new DateTime(2021, 9, 10, 19, 0, 48, 838, DateTimeKind.Local).AddTicks(1930), "Rosalinda_Veum60@gmail.com", "Emiliano", "Fay", "(512) 360-6097", "煦", 16 },
                    { 66, "96506 Roman Isle", 5, new DateTime(2022, 4, 17, 23, 39, 42, 371, DateTimeKind.Local).AddTicks(8147), "Baylee_Lueilwitz@gmail.com", "Micah", "Pagac", "829.576.8777 x95427", "玽", 7 },
                    { 67, "23485 Reynolds Walk", 18, new DateTime(2021, 11, 22, 18, 28, 46, 191, DateTimeKind.Local).AddTicks(4579), "Brant_Hills13@yahoo.com", "Rupert", "Homenick", "646.354.9143 x24247", "㴀", 19 },
                    { 68, "4371 Shany Roads", 19, new DateTime(2021, 9, 26, 19, 9, 42, 482, DateTimeKind.Local).AddTicks(5987), "Isabelle_Schultz57@yahoo.com", "Aniyah", "Fadel", "587-634-9371", "杌", 15 }
                });

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "Address1", "CountryId", "DtAccess", "Email", "FirstName", "LastName", "Phone", "Status", "UserId" },
                values: new object[,]
                {
                    { 69, "9081 Pfannerstill Isle", 17, new DateTime(2022, 2, 21, 12, 32, 36, 71, DateTimeKind.Local).AddTicks(2294), "Nestor_Cremin6@gmail.com", "Jay", "Abshire", "481.592.3505", "ꠖ", 14 },
                    { 70, "874 Monahan Vista", 13, new DateTime(2022, 4, 30, 3, 58, 16, 405, DateTimeKind.Local).AddTicks(4425), "Remington3@gmail.com", "Yadira", "Kemmer", "699-678-9921 x21150", "놀", 6 },
                    { 71, "7640 Leonora Heights", 6, new DateTime(2021, 12, 8, 6, 18, 30, 887, DateTimeKind.Local).AddTicks(1454), "Ettie.Boyer@yahoo.com", "Gerry", "Emmerich", "(201) 680-8299 x024", "", 20 },
                    { 72, "9061 Pascale Centers", 13, new DateTime(2022, 5, 13, 23, 59, 51, 759, DateTimeKind.Local).AddTicks(5997), "Merlin_Bauch32@gmail.com", "Lester", "Bogisich", "(950) 324-2802", "", 13 },
                    { 73, "84942 Armstrong Roads", 1, new DateTime(2022, 6, 1, 8, 6, 24, 127, DateTimeKind.Local).AddTicks(5121), "Jarrell78@gmail.com", "Kaylah", "Flatley", "283.837.8562 x48464", "䱰", 1 },
                    { 74, "6996 Zulauf Land", 5, new DateTime(2022, 7, 14, 0, 24, 54, 475, DateTimeKind.Local).AddTicks(9528), "Jewell_Welch@yahoo.com", "Helmer", "Jaskolski", "891.287.9497", "⎧", 12 },
                    { 75, "29261 Rogahn Pines", 17, new DateTime(2021, 9, 23, 21, 59, 35, 860, DateTimeKind.Local).AddTicks(1488), "Rene53@gmail.com", "Jeffery", "Tremblay", "270.916.9211", "튳", 11 },
                    { 76, "4795 Parisian Forks", 14, new DateTime(2022, 6, 12, 5, 43, 52, 164, DateTimeKind.Local).AddTicks(424), "Antonina83@hotmail.com", "Garrett", "Koch", "800-904-3106 x870", "뱨", 20 },
                    { 77, "50828 Monty Place", 11, new DateTime(2022, 3, 23, 16, 4, 23, 662, DateTimeKind.Local).AddTicks(6480), "Cleora50@hotmail.com", "Amely", "Emard", "815.975.5158", "痉", 5 },
                    { 78, "0215 Keely Road", 2, new DateTime(2021, 10, 23, 19, 44, 49, 64, DateTimeKind.Local).AddTicks(7590), "Denis74@yahoo.com", "Roosevelt", "Zboncak", "232.755.2967", "熳", 15 },
                    { 79, "511 Fidel Squares", 9, new DateTime(2021, 11, 12, 22, 38, 38, 438, DateTimeKind.Local).AddTicks(5824), "Ronaldo_Wilkinson@hotmail.com", "Stacy", "Wuckert", "692-230-6985 x999", "刜", 15 },
                    { 80, "735 Kaya Ranch", 20, new DateTime(2022, 1, 9, 15, 52, 18, 901, DateTimeKind.Local).AddTicks(1465), "Cordell.Moen@gmail.com", "Lenny", "Bartoletti", "(418) 639-9080 x04330", "활", 8 },
                    { 81, "8025 Monahan Loaf", 5, new DateTime(2021, 12, 16, 22, 47, 53, 574, DateTimeKind.Local).AddTicks(6477), "Pedro61@hotmail.com", "Guadalupe", "Swift", "1-569-809-9006", "靖", 19 },
                    { 82, "815 Schimmel Mountains", 15, new DateTime(2022, 5, 1, 8, 32, 48, 653, DateTimeKind.Local).AddTicks(8511), "Bulah60@yahoo.com", "Baylee", "Glover", "382-220-9284 x664", "奐", 9 },
                    { 83, "17026 Welch Flats", 19, new DateTime(2022, 2, 27, 2, 9, 3, 381, DateTimeKind.Local).AddTicks(1339), "Deondre_Buckridge@yahoo.com", "Eula", "Sauer", "(356) 811-7581", "봲", 6 },
                    { 84, "5185 Noble Turnpike", 5, new DateTime(2021, 8, 20, 18, 58, 1, 84, DateTimeKind.Local).AddTicks(6363), "Selina20@yahoo.com", "Lelia", "Lind", "1-322-294-8499", "׳", 17 },
                    { 85, "2827 Johns Island", 10, new DateTime(2022, 6, 10, 3, 42, 55, 724, DateTimeKind.Local).AddTicks(2578), "Nyasia_Murphy88@gmail.com", "Omer", "Rutherford", "623-609-9738", "薫", 7 },
                    { 86, "8899 Padberg Hollow", 16, new DateTime(2022, 7, 14, 18, 30, 58, 647, DateTimeKind.Local).AddTicks(4916), "Adrian86@hotmail.com", "Flavio", "Kautzer", "383.728.8517", "", 11 },
                    { 87, "1857 Charity Viaduct", 20, new DateTime(2021, 9, 30, 18, 56, 11, 572, DateTimeKind.Local).AddTicks(4082), "Clinton_Stoltenberg@hotmail.com", "Norbert", "Torp", "(715) 540-6969 x0594", "", 4 },
                    { 88, "047 Irwin Street", 15, new DateTime(2021, 11, 17, 19, 38, 4, 589, DateTimeKind.Local).AddTicks(2428), "Ethelyn_Hintz79@yahoo.com", "Hector", "Hodkiewicz", "(678) 708-8990", "⎦", 1 },
                    { 89, "8955 Zemlak Ferry", 14, new DateTime(2022, 4, 29, 3, 31, 54, 701, DateTimeKind.Local).AddTicks(3609), "Anita16@gmail.com", "Giovanna", "Bosco", "841-531-7828", "府", 10 },
                    { 90, "0568 Levi Square", 6, new DateTime(2021, 11, 13, 0, 43, 47, 2, DateTimeKind.Local).AddTicks(8091), "Ena97@gmail.com", "Victor", "Herman", "757-520-2111", "", 5 },
                    { 91, "565 Hintz Extension", 4, new DateTime(2021, 10, 14, 7, 28, 4, 627, DateTimeKind.Local).AddTicks(1079), "Gideon42@yahoo.com", "Alexys", "Treutel", "(364) 244-3746", "ᕲ", 9 },
                    { 92, "6874 Myles Garden", 19, new DateTime(2021, 8, 25, 4, 23, 31, 769, DateTimeKind.Local).AddTicks(5872), "Jennyfer.Franecki@gmail.com", "Daniela", "Brekke", "1-850-814-2640", "", 15 },
                    { 93, "578 Stokes Camp", 3, new DateTime(2021, 11, 25, 14, 59, 44, 504, DateTimeKind.Local).AddTicks(7094), "Raphaelle20@hotmail.com", "Audrey", "Bode", "372.786.2055 x778", "᭚", 4 },
                    { 94, "9148 Keanu Tunnel", 11, new DateTime(2022, 7, 3, 18, 43, 19, 50, DateTimeKind.Local).AddTicks(2318), "Dusty_MacGyver@hotmail.com", "Landen", "Macejkovic", "575.819.9713", "瀩", 3 },
                    { 95, "705 Bernier Cliff", 1, new DateTime(2021, 11, 12, 5, 1, 52, 504, DateTimeKind.Local).AddTicks(1299), "Kristin.Greenholt34@yahoo.com", "Agustin", "Runte", "995-362-9728 x4039", "ꁼ", 6 },
                    { 96, "071 Batz Prairie", 5, new DateTime(2022, 2, 24, 10, 17, 21, 216, DateTimeKind.Local).AddTicks(7520), "Gerry70@yahoo.com", "Jade", "Lakin", "(211) 936-2679 x866", "ꗑ", 11 },
                    { 97, "2241 Jermey Manor", 11, new DateTime(2022, 6, 26, 11, 24, 46, 665, DateTimeKind.Local).AddTicks(8042), "Barney72@gmail.com", "Caroline", "O'Conner", "210-523-9023 x743", "鳰", 4 },
                    { 98, "0233 Leuschke Route", 16, new DateTime(2022, 5, 3, 9, 32, 50, 653, DateTimeKind.Local).AddTicks(4251), "Haylee_Graham9@gmail.com", "Amos", "Bernhard", "(805) 435-9143", "否", 15 },
                    { 99, "433 Chase Crest", 3, new DateTime(2022, 2, 9, 18, 8, 43, 945, DateTimeKind.Local).AddTicks(6391), "Woodrow_Ledner48@yahoo.com", "Theresa", "Fay", "1-486-460-4191", "", 14 },
                    { 100, "732 Raquel Court", 7, new DateTime(2022, 3, 3, 18, 20, 4, 137, DateTimeKind.Local).AddTicks(6056), "Wendell_Schuppe11@gmail.com", "Joshuah", "Quitzon", "359-495-7071 x59359", "昚", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Entities");
        }
    }
}
