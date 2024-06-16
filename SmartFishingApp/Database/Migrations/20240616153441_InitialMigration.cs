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
                name: "TackleBase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    TypeOfFishingId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TackleBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TackleBase_TackleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TackleBase_TypeOfFishing_TypeOfFishingId",
                        column: x => x.TypeOfFishingId,
                        principalTable: "TypeOfFishing",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Alives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alives_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Corns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Corns_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeederAlives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true),
                    Lure = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeederAlives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeederAlives_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Lure = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeederBoils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeederBoils_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeederCorns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true),
                    Lure = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeederCorns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeederCorns_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Color = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jigs_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Color = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rockers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rockers_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Color = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spoons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spoons_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Flotation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voblers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voblers_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Color = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterJigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinterJigs_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Color = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterSpoons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinterSpoons_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Color = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterVobler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinterVobler_TackleBase_Id",
                        column: x => x.Id,
                        principalTable: "TackleBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rod_TypeOfFishingId",
                table: "Rod",
                column: "TypeOfFishingId");

            migrationBuilder.CreateIndex(
                name: "IX_TackleBase_CategoryId",
                table: "TackleBase",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TackleBase_TypeOfFishingId",
                table: "TackleBase",
                column: "TypeOfFishingId");

            migrationBuilder.CreateIndex(
                name: "IX_TackleCategory_TypeOfFishingId",
                table: "TackleCategory",
                column: "TypeOfFishingId");
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
                name: "TackleBase");

            migrationBuilder.DropTable(
                name: "TackleCategory");

            migrationBuilder.DropTable(
                name: "TypeOfFishing");
        }
    }
}
