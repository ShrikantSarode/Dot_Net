using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CfirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class NewCF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeCity",
                table: "Employes",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeCity",
                table: "Employes");
        }
    }
}
