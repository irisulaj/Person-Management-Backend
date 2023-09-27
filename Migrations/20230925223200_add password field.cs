using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonManagement.Migrations
{
    /// <inheritdoc />
    public partial class addpasswordfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "PM03_User",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "PM03_User");
        }
    }
}
