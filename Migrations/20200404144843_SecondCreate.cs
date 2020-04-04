using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICDE.CompareProducts.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    User_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_firstname = table.Column<string>(nullable: false),
                    User_lastname = table.Column<string>(nullable: false),
                    User_email = table.Column<string>(nullable: false),
                    Company_Fk_Name = table.Column<string>(nullable: true),
                    Role_Fk_id = table.Column<int>(nullable: false),
                    Years_At_Company = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ConfirmPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.User_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registrations");
        }
    }
}
