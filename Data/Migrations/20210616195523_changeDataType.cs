using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class changeDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Products",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mansoura" },
                    { 2, "Alexandria" },
                    { 3, "Luxor" },
                    { 4, "Asyut" },
                    { 5, "Tanta" },
                    { 6, "Luxor" },
                    { 7, "Cairo" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[,]
                {
                    { 2, 1, "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.", "Bremer" },
                    { 4, 1, "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.", "Cafe Supreme" },
                    { 3, 2, "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.", "Smoven restaurant" },
                    { 5, 4, "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.", "Oriental Grill" },
                    { 1, 6, "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.", "Koshary Abou Tarek" },
                    { 6, 6, "Abou El Sid is the must-go-to restaurant if you want classic Egyptian dishes (check out our article 12 Local Egyptian Foods You Need To Try) in a super ambient atmosphere (the decor, music, and wall art is enough to make it worth it). They also offer shisha and Egyptian twists on alcoholic cocktails, like vodka with fresh sugarcane juice.", "Shashlik" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Photo", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 4, "Product1", "Product1", null, 22.0, 2 },
                    { 5, "Product2", "Product2", null, 43.0, 2 },
                    { 6, "Product3", "Product3", null, 21.0, 2 },
                    { 7, "Product1", "Product1", null, 54.0, 3 },
                    { 8, "Product2", "Product2", null, 22.0, 3 },
                    { 9, "Product3", "Product3", null, 31.0, 3 },
                    { 1, "Product1", "Product1", null, 10.0, 1 },
                    { 2, "Product2", "Product2", null, 14.0, 1 },
                    { 3, "Product3", "Product3", null, 12.0, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Restaurants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Restaurants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
