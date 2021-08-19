using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Dietitians_CommentForeignKey",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CommentForeignKey",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "RatedId",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "CommentForeignKey",
                table: "Comments",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Dietitians_Id",
                table: "Comments",
                column: "Id",
                principalTable: "Dietitians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Dietitians_Id",
                table: "Comments");

            migrationBuilder.AlterColumn<Guid>(
                name: "CommentForeignKey",
                table: "Comments",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RatedId",
                table: "Comments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentForeignKey",
                table: "Comments",
                column: "CommentForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Dietitians_CommentForeignKey",
                table: "Comments",
                column: "CommentForeignKey",
                principalTable: "Dietitians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
