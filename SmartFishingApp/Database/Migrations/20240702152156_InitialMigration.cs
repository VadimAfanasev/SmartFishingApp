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
                name: "FishingReelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Commentary = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishingReelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RodTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RodTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfFishing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Commentary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfFishing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FishingReels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ReelTypeId = table.Column<int>(type: "integer", nullable: true),
                    TypeOfFishingId = table.Column<int>(type: "integer", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishingReels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FishingReels_FishingReelTypes_ReelTypeId",
                        column: x => x.ReelTypeId,
                        principalTable: "FishingReelTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FishingReels_TypesOfFishing_TypeOfFishingId",
                        column: x => x.TypeOfFishingId,
                        principalTable: "TypesOfFishing",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Brand = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Test = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Length = table.Column<string>(type: "text", nullable: true),
                    Class = table.Column<string>(type: "text", nullable: true),
                    RodTypeId = table.Column<int>(type: "integer", nullable: true),
                    TypeOfFishingId = table.Column<int>(type: "integer", nullable: true),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    Commentary = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rods_RodTypes_RodTypeId",
                        column: x => x.RodTypeId,
                        principalTable: "RodTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rods_TypesOfFishing_TypeOfFishingId",
                        column: x => x.TypeOfFishingId,
                        principalTable: "TypesOfFishing",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TackleCategories",
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
                    table.PrimaryKey("PK_TackleCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TackleCategories_TypesOfFishing_TypeOfFishingId",
                        column: x => x.TypeOfFishingId,
                        principalTable: "TypesOfFishing",
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
                        name: "FK_FeederAlives_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
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
                        name: "FK_FeederBoils_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
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
                        name: "FK_FeederCorns_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
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
                        name: "FK_FloatAlives_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
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
                        name: "FK_FloatCorns_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
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
                        name: "FK_SpinningJigs_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
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
                        name: "FK_SpinningSpoons_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
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
                        name: "FK_SpinningVoblers_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
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
                        name: "FK_WinterJigs_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
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
                        name: "FK_WinterRockers_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
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
                        name: "FK_WinterSpoons_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WinterVoblers",
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
                    table.PrimaryKey("PK_WinterVoblers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinterVoblers_TackleCategories_TackleCategoryId",
                        column: x => x.TackleCategoryId,
                        principalTable: "TackleCategories",
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
                name: "IX_FishingReels_ReelTypeId",
                table: "FishingReels",
                column: "ReelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FishingReels_TypeOfFishingId",
                table: "FishingReels",
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
                name: "IX_Rods_RodTypeId",
                table: "Rods",
                column: "RodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rods_TypeOfFishingId",
                table: "Rods",
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
                name: "IX_TackleCategories_TypeOfFishingId",
                table: "TackleCategories",
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
                name: "IX_WinterVoblers_TackleCategoryId",
                table: "WinterVoblers",
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
                name: "FishingReels");

            migrationBuilder.DropTable(
                name: "FloatAlives");

            migrationBuilder.DropTable(
                name: "FloatCorns");

            migrationBuilder.DropTable(
                name: "Rods");

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
                name: "WinterVoblers");

            migrationBuilder.DropTable(
                name: "FishingReelTypes");

            migrationBuilder.DropTable(
                name: "RodTypes");

            migrationBuilder.DropTable(
                name: "TackleCategories");

            migrationBuilder.DropTable(
                name: "TypesOfFishing");
        }
    }
}
