using Microsoft.EntityFrameworkCore.Migrations;

namespace TopologyAPI.Migrations
{
    public partial class ModifyDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_Resistors_Type",
                table: "Components");

            migrationBuilder.DropTable(
                name: "Resistors");

            migrationBuilder.DropIndex(
                name: "IX_Components_Type",
                table: "Components");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "defualt",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "drain",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gate",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "max",
                table: "Components",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "min",
                table: "Components",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "source",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "t1",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "t2",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "defualt",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "drain",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "gate",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "max",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "min",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "source",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "t1",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "t2",
                table: "Components");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Components",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Resistors",
                columns: table => new
                {
                    defualt = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    max = table.Column<int>(type: "int", nullable: false),
                    min = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resistors", x => x.defualt);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Components_Type",
                table: "Components",
                column: "Type");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_Resistors_Type",
                table: "Components",
                column: "Type",
                principalTable: "Resistors",
                principalColumn: "defualt",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
