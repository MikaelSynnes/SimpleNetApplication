using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleNetApplication.Storage.Migrations
{
    /// <inheritdoc />
    public partial class testmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SimpleModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SimpleSubDbModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DbModelFk = table.Column<int>(type: "INTEGER", nullable: false),
                    SimpleDbModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleSubDbModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SimpleSubDbModel_SimpleModels_SimpleDbModelId",
                        column: x => x.SimpleDbModelId,
                        principalTable: "SimpleModels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SimpleSubDbModel_SimpleDbModelId",
                table: "SimpleSubDbModel",
                column: "SimpleDbModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SimpleSubDbModel");

            migrationBuilder.DropTable(
                name: "SimpleModels");
        }
    }
}
