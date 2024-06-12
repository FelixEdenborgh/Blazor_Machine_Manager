using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_Machine_Manager.Migrations
{
    /// <inheritdoc />
    public partial class updatedModuleWithSpecialAbilityOfMachine_String : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpecialAbilityOfMachine",
                table: "Machines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialAbilityOfMachine",
                table: "Machines");
        }
    }
}
