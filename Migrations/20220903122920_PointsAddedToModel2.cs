﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_epl.Migrations
{
    public partial class PointsAddedToModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "Teams");
        }
    }
}
