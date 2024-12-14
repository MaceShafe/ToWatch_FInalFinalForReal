using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToWatch_FInalFinalForReal.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_PriorityId",
                table: "Movies",
                column: "PriorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Priorities_PriorityId",
                table: "Movies",
                column: "PriorityId",
                principalTable: "Priorities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Priorities_PriorityId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_PriorityId",
                table: "Movies");

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "Movies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
