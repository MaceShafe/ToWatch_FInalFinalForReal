using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToWatch_FInalFinalForReal.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyMovieUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Users_UserID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_UserID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "MovieUsers",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieUsers", x => new { x.MoviesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MovieUsers_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieUsers_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieUsers_UsersId",
                table: "MovieUsers",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieUsers");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserID",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_UserID",
                table: "Movies",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Users_UserID",
                table: "Movies",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
