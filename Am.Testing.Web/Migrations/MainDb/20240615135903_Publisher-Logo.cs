using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Am.Testing.Web.Migrations.MainDb
{
    /// <inheritdoc />
    public partial class PublisherLogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "logo",
                schema: "public",
                table: "publisher",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "logo",
                schema: "public",
                table: "publisher");
        }
    }
}
