using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoItemsAPI.Migrations
{
    public partial class todoitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoItem",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItem", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1L, "Drink Coffee" });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2L, "Brush Teeth" });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "IsComplete", "Name" },
                values: new object[,]
                {
                    { 3L, true, "Go to Work" },
                    { 4L, true, "Clean Windows" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItem");
        }
    }
}
