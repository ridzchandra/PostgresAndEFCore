using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresAndEFCore.Migrations
{
    /// <inheritdoc />
    public partial class alter_driver_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavouriteColor",
                table: "driver",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavouriteColor",
                table: "driver");
        }
    }
}
