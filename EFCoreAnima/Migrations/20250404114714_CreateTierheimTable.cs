using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAnima.Migrations
{
    /// <inheritdoc />
    public partial class CreateTierheimTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tierheime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TierheimName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tierheime", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_TierheimId",
                table: "Animals",
                column: "TierheimId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tierheime");
        }
    }
}
