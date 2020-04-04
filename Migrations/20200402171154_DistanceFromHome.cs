using Microsoft.EntityFrameworkCore.Migrations;

namespace ICDE.CompareProducts.Migrations
{
    public partial class DistanceFromHome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DailyRate",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DistanceFromHome",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EducationField",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnvironmentSatisfaction",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HourlyRate",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PercentSalaryHike",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PerformanceRating",
                table: "Employee",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistanceFromHome",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EducationField",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EnvironmentSatisfaction",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "HourlyRate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PercentSalaryHike",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PerformanceRating",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "DailyRate",
                table: "Employee",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
