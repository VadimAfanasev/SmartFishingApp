using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeOfFishing",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfFishing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rod",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Length = table.Column<string>(type: "text", nullable: true),
                    Class = table.Column<string>(type: "text", nullable: true),
                    TypeOfFishingId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rod_TypeOfFishing_TypeOfFishingId",
                        column: x => x.TypeOfFishingId,
                        principalTable: "TypeOfFishing",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TackleCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TypeOfFishingId = table.Column<Guid>(type: "uuid", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TackleCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TackleCategory_TypeOfFishing_TypeOfFishingId",
                        column: x => x.TypeOfFishingId,
                        principalTable: "TypeOfFishing",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Alives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alives_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Corns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Corns_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FeederAlives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true),
                    Lure = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeederAlives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeederAlives_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FeederBoils",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Size = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Lure = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeederBoils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeederBoils_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FeederCorns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true),
                    Lure = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeederCorns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeederCorns_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Jigs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Form = table.Column<string>(type: "text", nullable: true),
                    Length = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jigs_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rockers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<double>(type: "double precision", nullable: true),
                    Length = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rockers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rockers_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Spoons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Form = table.Column<string>(type: "text", nullable: true),
                    SizeNumber = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spoons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spoons_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Voblers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<double>(type: "double precision", nullable: true),
                    Length = table.Column<double>(type: "double precision", nullable: true),
                    Depenning = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Flotation = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voblers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voblers_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WinterJigs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<double>(type: "double precision", nullable: true),
                    Form = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterJigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinterJigs_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WinterSpoons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<double>(type: "double precision", nullable: true),
                    Length = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterSpoons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinterSpoons_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WinterVobler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<double>(type: "double precision", nullable: true),
                    Length = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterVobler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinterVobler_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alives_CategoryId",
                table: "Alives",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Corns_CategoryId",
                table: "Corns",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FeederAlives_CategoryId",
                table: "FeederAlives",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FeederBoils_CategoryId",
                table: "FeederBoils",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FeederCorns_CategoryId",
                table: "FeederCorns",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Jigs_CategoryId",
                table: "Jigs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rockers_CategoryId",
                table: "Rockers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rod_TypeOfFishingId",
                table: "Rod",
                column: "TypeOfFishingId");

            migrationBuilder.CreateIndex(
                name: "IX_Spoons_CategoryId",
                table: "Spoons",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TackleCategory_TypeOfFishingId",
                table: "TackleCategory",
                column: "TypeOfFishingId");

            migrationBuilder.CreateIndex(
                name: "IX_Voblers_CategoryId",
                table: "Voblers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WinterJigs_CategoryId",
                table: "WinterJigs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WinterSpoons_CategoryId",
                table: "WinterSpoons",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WinterVobler_CategoryId",
                table: "WinterVobler",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alives");

            migrationBuilder.DropTable(
                name: "Corns");

            migrationBuilder.DropTable(
                name: "FeederAlives");

            migrationBuilder.DropTable(
                name: "FeederBoils");

            migrationBuilder.DropTable(
                name: "FeederCorns");

            migrationBuilder.DropTable(
                name: "Jigs");

            migrationBuilder.DropTable(
                name: "Rockers");

            migrationBuilder.DropTable(
                name: "Rod");

            migrationBuilder.DropTable(
                name: "Spoons");

            migrationBuilder.DropTable(
                name: "Voblers");

            migrationBuilder.DropTable(
                name: "WinterJigs");

            migrationBuilder.DropTable(
                name: "WinterSpoons");

            migrationBuilder.DropTable(
                name: "WinterVobler");

            migrationBuilder.DropTable(
                name: "TackleCategory");

            migrationBuilder.DropTable(
                name: "TypeOfFishing");
        }
    }
}
