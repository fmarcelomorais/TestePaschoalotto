using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestePaschoalotto.Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class AjustaTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Cordinates_CordinatesId",
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
                name: "IX_Locations_CordinatesId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_StreetId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_TimezoneId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CordinatesId",
                table: "Locations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CordinatesId",
                table: "Locations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "IX_Locations_CordinatesId",
                table: "Locations",
                column: "CordinatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_StreetId",
                table: "Locations",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_TimezoneId",
                table: "Locations",
                column: "TimezoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Cordinates_CordinatesId",
                table: "Locations",
                column: "CordinatesId",
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
    }
}
