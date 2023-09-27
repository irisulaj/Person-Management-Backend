using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonManagement.Migrations
{
    /// <inheritdoc />
    public partial class createmaritalstatustable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PM02_MaritalStatus",
                columns: table => new
                {
                    Id_MaritalStatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaritalStatus = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PM02_MaritalStatus", x => x.Id_MaritalStatus);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PM02_MaritalStatus");
        }
    }
}
