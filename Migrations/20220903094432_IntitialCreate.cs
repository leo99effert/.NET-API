using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_epl.Migrations
{
    public partial class IntitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttackValue = table.Column<int>(type: "int", nullable: false),
                    DefenceValue = table.Column<int>(type: "int", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Draws = table.Column<int>(type: "int", nullable: false),
                    Losses = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "AttackValue", "DefenceValue", "Draws", "Losses", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 4, 3, 0, 0, "Arsenal", 0 },
                    { 2, 1, 2, 0, 0, "Aston Villa", 0 },
                    { 3, 2, 1, 0, 0, "Bournemouth", 0 },
                    { 4, 2, 1, 0, 0, "Brentford", 0 },
                    { 5, 1, 3, 0, 0, "Brighton", 0 },
                    { 6, 4, 5, 0, 0, "Chelsea", 0 },
                    { 7, 3, 2, 0, 0, "Crystal Palace", 0 },
                    { 8, 4, 2, 0, 0, "Everton", 0 },
                    { 9, 2, 1, 0, 0, "Fulham", 0 },
                    { 10, 3, 2, 0, 0, "Leeds", 0 },
                    { 11, 2, 3, 0, 0, "Leicester", 0 },
                    { 12, 5, 4, 0, 0, "Liverpool", 0 },
                    { 13, 4, 5, 0, 0, "Man City", 0 },
                    { 14, 5, 3, 0, 0, "Man United", 0 },
                    { 15, 3, 2, 0, 0, "Newcastle", 0 },
                    { 16, 2, 1, 0, 0, "Nottingham", 0 },
                    { 17, 1, 2, 0, 0, "Southampton", 0 },
                    { 18, 5, 4, 0, 0, "Tottenham", 0 },
                    { 19, 3, 1, 0, 0, "West Ham", 0 },
                    { 20, 4, 1, 0, 0, "Wolves", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
