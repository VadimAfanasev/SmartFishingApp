using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                name: "FishingReelType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishingReelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RodType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfFishing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfFishing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FishingReel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    ReelTypeId = table.Column<int>(type: "integer", nullable: true),
                    TypeOfFishingId = table.Column<int>(type: "integer", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishingReel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FishingReel_FishingReelType_ReelTypeId",
                        column: x => x.ReelTypeId,
                        principalTable: "FishingReelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FishingReel_TypeOfFishing_TypeOfFishingId",
                        column: x => x.TypeOfFishingId,
                        principalTable: "TypeOfFishing",
                        principalColumn: "Id");
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
                    RodTypeId = table.Column<int>(type: "integer", nullable: true),
                    TypeOfFishingId = table.Column<int>(type: "integer", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rod_RodType_RodTypeId",
                        column: x => x.RodTypeId,
                        principalTable: "RodType",
                        principalColumn: "Id");
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TypeOfFishingId = table.Column<int>(type: "integer", nullable: false),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TackleCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TackleCategory_TypeOfFishing_TypeOfFishingId",
                        column: x => x.TypeOfFishingId,
                        principalTable: "TypeOfFishing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeederAlives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true),
                    Lure = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeederAlives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeederAlives_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
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
                    Lure = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeederBoils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeederBoils_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeederCorns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true),
                    Lure = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeederCorns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeederCorns_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FloatAlives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloatAlives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FloatAlives_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FloatCorns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NozzleType = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloatCorns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FloatCorns_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpinningJigs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Form = table.Column<string>(type: "text", nullable: true),
                    Length = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpinningJigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpinningJigs_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpinningSpoons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Form = table.Column<string>(type: "text", nullable: true),
                    SizeNumber = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpinningSpoons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpinningSpoons_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpinningVoblers",
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
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpinningVoblers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpinningVoblers_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
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
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterJigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinterJigs_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WinterRockers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<double>(type: "double precision", nullable: true),
                    Length = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterRockers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinterRockers_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
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
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterSpoons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinterSpoons_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
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
                    Color = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TackleCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterVobler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinterVobler_TackleCategory_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeederAlives_TackleCategoryId",
                table: "FeederAlives",
                column: "TackleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FeederBoils_TackleCategoryId",
                table: "FeederBoils",
                column: "TackleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FeederCorns_TackleCategoryId",
                table: "FeederCorns",
                column: "TackleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FishingReel_ReelTypeId",
                table: "FishingReel",
                column: "ReelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FishingReel_TypeOfFishingId",
                table: "FishingReel",
                column: "TypeOfFishingId");

            migrationBuilder.CreateIndex(
                name: "IX_FloatAlives_TackleCategoryId",
                table: "FloatAlives",
                column: "TackleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FloatCorns_TackleCategoryId",
                table: "FloatCorns",
                column: "TackleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rod_RodTypeId",
                table: "Rod",
                column: "RodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rod_TypeOfFishingId",
                table: "Rod",
                column: "TypeOfFishingId");

            migrationBuilder.CreateIndex(
                name: "IX_SpinningJigs_TackleCategoryId",
                table: "SpinningJigs",
                column: "TackleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SpinningSpoons_TackleCategoryId",
                table: "SpinningSpoons",
                column: "TackleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SpinningVoblers_TackleCategoryId",
                table: "SpinningVoblers",
                column: "TackleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TackleCategory_TypeOfFishingId",
                table: "TackleCategory",
                column: "TypeOfFishingId");

            migrationBuilder.CreateIndex(
                name: "IX_WinterJigs_TackleCategoryId",
                table: "WinterJigs",
                column: "TackleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WinterRockers_TackleCategoryId",
                table: "WinterRockers",
                column: "TackleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WinterSpoons_TackleCategoryId",
                table: "WinterSpoons",
                column: "TackleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WinterVobler_TackleCategoryId",
                table: "WinterVobler",
                column: "TackleCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeederAlives");

            migrationBuilder.DropTable(
                name: "FeederBoils");

            migrationBuilder.DropTable(
                name: "FeederCorns");

            migrationBuilder.DropTable(
                name: "FishingReel");

            migrationBuilder.DropTable(
                name: "FloatAlives");

            migrationBuilder.DropTable(
                name: "FloatCorns");

            migrationBuilder.DropTable(
                name: "Rod");

            migrationBuilder.DropTable(
                name: "SpinningJigs");

            migrationBuilder.DropTable(
                name: "SpinningSpoons");

            migrationBuilder.DropTable(
                name: "SpinningVoblers");

            migrationBuilder.DropTable(
                name: "WinterJigs");

            migrationBuilder.DropTable(
                name: "WinterRockers");

            migrationBuilder.DropTable(
                name: "WinterSpoons");

            migrationBuilder.DropTable(
                name: "WinterVobler");

            migrationBuilder.DropTable(
                name: "FishingReelType");

            migrationBuilder.DropTable(
                name: "RodType");

            migrationBuilder.DropTable(
                name: "TackleCategory");

            migrationBuilder.DropTable(
                name: "TypeOfFishing");
        }
    }
}
