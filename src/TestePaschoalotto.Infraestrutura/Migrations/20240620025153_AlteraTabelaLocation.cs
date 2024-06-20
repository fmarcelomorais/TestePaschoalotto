using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestePaschoalotto.Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class AlteraTabelaLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodinatesId",
                table: "Locations",
                newName: "CoordinatesId");

            migrationBuilder.AddColumn<Guid>(
                name: "CoordinateId",
                table: "Users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Id",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_DobId",
                table: "Users",
                column: "DobId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LocationId",
                table: "Users",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LoginId",
                table: "Users",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NameId",
                table: "Users",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PictureId",
                table: "Users",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RegisteredId",
                table: "Users",
                column: "RegisteredId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CoordinatesId",
                table: "Locations",
                column: "CoordinatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_StreetId",
                table: "Locations",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_TimezoneId",
                table: "Locations",
                column: "TimezoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Cordinates_CoordinatesId",
                table: "Locations",
                column: "CoordinatesId",
                principalTable: "Cordinates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Streets_StreetId",
                table: "Locations",
                column: "StreetId",
                principalTable: "Streets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Timezones_TimezoneId",
                table: "Locations",
                column: "TimezoneId",
                principalTable: "Timezones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Dobs_DobId",
                table: "Users",
                column: "DobId",
                principalTable: "Dobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Locations_LocationId",
                table: "Users",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Logins_LoginId",
                table: "Users",
                column: "LoginId",
                principalTable: "Logins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Names_NameId",
                table: "Users",
                column: "NameId",
                principalTable: "Names",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Pictures_PictureId",
                table: "Users",
                column: "PictureId",
                principalTable: "Pictures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Registereds_RegisteredId",
                table: "Users",
                column: "RegisteredId",
                principalTable: "Registereds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Cordinates_CoordinatesId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Streets_StreetId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Timezones_TimezoneId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Dobs_DobId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Locations_LocationId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Logins_LoginId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Names_NameId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Pictures_PictureId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Registereds_RegisteredId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Id");

            migrationBuilder.DropIndex(
                name: "IX_Users_DobId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_LocationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_LoginId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_NameId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PictureId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RegisteredId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CoordinatesId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_StreetId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_TimezoneId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CoordinateId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "CoordinatesId",
                table: "Locations",
                newName: "CodinatesId");
        }
    }
}
