using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SomeFeatureEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SomeFeatureEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SomeFeatureDetailEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SomeFeatureEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SomeFeatureDetailEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SomeFeatureDetailEntities_SomeFeatureEntity_SomeFeatureEntityId",
                        column: x => x.SomeFeatureEntityId,
                        principalTable: "SomeFeatureEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SomeFeatureDetailEntities_SomeFeatureEntityId",
                table: "SomeFeatureDetailEntities",
                column: "SomeFeatureEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SomeFeatureDetailEntities");

            migrationBuilder.DropTable(
                name: "SomeFeatureEntity");
        }
    }
}
