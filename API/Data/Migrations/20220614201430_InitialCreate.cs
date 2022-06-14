using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users", //create a table called "users"
                columns: table => new
                { //two columns, one an int
                    Id = table.Column<int>(type: "INTEGER", nullable: false) //anything called Id should be our primary key
                        .Annotation("Sqlite:Autoincrement", true), //auto increment
                    UserName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) //drop the table
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
