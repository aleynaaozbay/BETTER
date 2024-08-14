using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Better.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DalExtension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("353fc1a7-be3e-4780-8099-6082cd3e6f43"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("cc8a0add-1bae-49aa-9ae7-f4d5b162a93f"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("786214dc-4b54-4438-a673-412a43f62331"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 14, 16, 15, 5, 460, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("daa90872-2b2e-474c-a464-4b0009dfbe0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 14, 16, 15, 5, 460, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("35bdb1a3-c402-4a7e-910c-5b7b2e79e486"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 14, 16, 15, 5, 461, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c600ef28-de70-45d8-8689-2ace26134f37"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 14, 16, 15, 5, 461, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ImageId", "Materials", "Preparation", "Title" },
                values: new object[,]
                {
                    { new Guid("3834159f-8b06-4537-8cc8-de863089228e"), new Guid("daa90872-2b2e-474c-a464-4b0009dfbe0b"), new DateTime(2024, 8, 14, 16, 15, 5, 461, DateTimeKind.Local).AddTicks(5394), new Guid("c600ef28-de70-45d8-8689-2ace26134f37"), "\r\n1 salatalık\r\n1/2 (yarım) yeşil elma\r\n1/4 (çeyrek) bağ kadar maydanoz\r\n1 dal nane\r\n1 bardak su", "Bütün malzemeleri blender ya da shaker'dan geçirin. Afiyet Olsun :)", "Ödem Attırıcı Smoothie" },
                    { new Guid("9163c233-7944-45a5-a724-bd278de6fdf8"), new Guid("786214dc-4b54-4438-a673-412a43f62331"), new DateTime(2024, 8, 14, 16, 15, 5, 461, DateTimeKind.Local).AddTicks(5443), new Guid("35bdb1a3-c402-4a7e-910c-5b7b2e79e486"), "\r\n1 su bardağı yulaf ezmesi\r\n\r\n2 yemek kaşığı bal\r\n\r\n1 yemek kaşığı chia tohumu\r\n\r\n2 yemek kaşığı keten tohumu\r\n\r\n1 çay kaşığı Hindistan cevizi yağı\r\n\r\n1 çay bardağı karışık kuru yemiş\r\n\r\n2 yemek kaşığı fıstık ezmesi\r\n\r\n1 tatlı kaşığı tarçın", "İlk olarak geniş bir kap almalısın. Ardından tüm malzemeleri sırayla bu kabın içine dök.\r\n\r\nMalzemeleri homojen bir kıvam alıncaya kadar karıştır.\r\n\r\nTüm malzemeler bir homojen bir kıvama geldikten sonra bir tepsiye yağlı kağıt ser ve hazırlamış olduğun karışımı bu kağıdın üstüne yay.\r\n\r\nKarışım tepsi içerisinde dümdüz bir hal almasını sağla ve karışımı ortalama 20 dk. kadar buzdolabında beklet.\r\n\r\n20 dk. sonunda hazırlamış olduğun barını dilediğin boyutlarda parçalara ayıracak şekilde keserek tüketebilirsin.\r\n", "Protein Yüksek Atıştırmalık" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3834159f-8b06-4537-8cc8-de863089228e"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9163c233-7944-45a5-a724-bd278de6fdf8"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("786214dc-4b54-4438-a673-412a43f62331"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 17, 19, 43, 306, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("daa90872-2b2e-474c-a464-4b0009dfbe0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 17, 19, 43, 306, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("35bdb1a3-c402-4a7e-910c-5b7b2e79e486"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 17, 19, 43, 306, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c600ef28-de70-45d8-8689-2ace26134f37"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 17, 19, 43, 306, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ImageId", "Materials", "Preparation", "Title" },
                values: new object[,]
                {
                    { new Guid("353fc1a7-be3e-4780-8099-6082cd3e6f43"), new Guid("786214dc-4b54-4438-a673-412a43f62331"), new DateTime(2024, 8, 12, 17, 19, 43, 306, DateTimeKind.Local).AddTicks(7688), new Guid("35bdb1a3-c402-4a7e-910c-5b7b2e79e486"), "\r\n1 su bardağı yulaf ezmesi\r\n\r\n2 yemek kaşığı bal\r\n\r\n1 yemek kaşığı chia tohumu\r\n\r\n2 yemek kaşığı keten tohumu\r\n\r\n1 çay kaşığı Hindistan cevizi yağı\r\n\r\n1 çay bardağı karışık kuru yemiş\r\n\r\n2 yemek kaşığı fıstık ezmesi\r\n\r\n1 tatlı kaşığı tarçın", "İlk olarak geniş bir kap almalısın. Ardından tüm malzemeleri sırayla bu kabın içine dök.\r\n\r\nMalzemeleri homojen bir kıvam alıncaya kadar karıştır.\r\n\r\nTüm malzemeler bir homojen bir kıvama geldikten sonra bir tepsiye yağlı kağıt ser ve hazırlamış olduğun karışımı bu kağıdın üstüne yay.\r\n\r\nKarışım tepsi içerisinde dümdüz bir hal almasını sağla ve karışımı ortalama 20 dk. kadar buzdolabında beklet.\r\n\r\n20 dk. sonunda hazırlamış olduğun barını dilediğin boyutlarda parçalara ayıracak şekilde keserek tüketebilirsin.\r\n", "Protein Yüksek Atıştırmalık" },
                    { new Guid("cc8a0add-1bae-49aa-9ae7-f4d5b162a93f"), new Guid("daa90872-2b2e-474c-a464-4b0009dfbe0b"), new DateTime(2024, 8, 12, 17, 19, 43, 306, DateTimeKind.Local).AddTicks(7655), new Guid("c600ef28-de70-45d8-8689-2ace26134f37"), "\r\n1 salatalık\r\n1/2 (yarım) yeşil elma\r\n1/4 (çeyrek) bağ kadar maydanoz\r\n1 dal nane\r\n1 bardak su", "Bütün malzemeleri blender ya da shaker'dan geçirin. Afiyet Olsun :)", "Ödem Attırıcı Smoothie" }
                });
        }
    }
}
