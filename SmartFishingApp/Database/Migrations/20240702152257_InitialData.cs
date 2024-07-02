using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FishingReelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Инерционная катушка" },
                    { 2, "Безинерционная катушка" },
                    { 3, "Мультипликатор" },
                    { 4, "Нахлыстовая катушка" },
                });

            migrationBuilder.InsertData(
                table: "RodTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Болонское удилище" },
                    { 2, "Карповое удилище" },
                    { 3, "Кастинговое удилище" },
                    { 4, "Джерковое удилище" },
                    { 5, "Матчевое удилище" },
                    { 6, "Маховое удилище" },
                    { 7, "Нахлыствое удилище" },
                    { 8, "Спинниговое удилище" },
                    { 9, "Фидерное удилище" },
                    { 10, "Зимнее удилище для блеснения" },
                    { 11, "Зимнее удилище для мормышки" },
                });

            migrationBuilder.InsertData(
                table: "TypesOfFishing",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Спинниг с берега" },
                    { 2, "Спинниг с лодки" },
                    { 3, "Фидер" },
                    { 4, "Поплавочная удочка" },
                    { 5, "Зимняя рыбалка на хищника" },
                    { 6, "Зимняя рыбалка на мирную рыбу" },
                });

            migrationBuilder.InsertData(
                table: "TackleCategories",
                columns: new[] { "Id", "Name", "TypeOfFishingId", "Commentary" },
                values: new object[,]
                {
                    { 1, "Живая насадка", 3, "Фидер" },
                    { 2, "Бойл", 3, "Фидер" },
                    { 3, "Растительная насадка", 3, "Фидер"  },
                    { 4, "Живая насадка", 4, "Поплавочная удочка" },
                    { 5, "Растительная насадка", 4, "Поплавочная удочка" },
                    { 6, "Джиг", 1, "Спинниг с берега" },
                    { 7, "Блесна", 1, "Спинниг с берега" },
                    { 8, "Воблер", 1, "Спинниг с берега" },
                    { 9, "Джиг", 2, "Спинниг с лодки" },
                    { 10, "Блесна", 2, "Спинниг с лодки" },
                    { 11, "Воблер", 2, "Спинниг с лодки" },
                    { 12, "Мормышка", 6, "Зимняя рыбалка на мирную рыбу" },
                    { 13, "Балансир", 5, "Зимняя рыбалка на хищника" },
                    { 14, "Зимняя блесна", 5, "Зимняя рыбалка на хищника" },
                    { 15, "Зимний воблер", 5, "Зимняя рыбалка на хищника" },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FishingReelType");

            migrationBuilder.DropTable(
                name: "RodType");

            migrationBuilder.DropTable(
                name: "TypeOfFishing");

            migrationBuilder.DropTable(
                name: "TackleCategory");
        }
    }
}
