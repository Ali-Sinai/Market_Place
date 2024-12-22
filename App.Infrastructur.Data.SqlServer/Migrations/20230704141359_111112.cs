using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infrastructure.Data.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class _111112 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Factors",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Factors",
                columns: new[] { "Id", "CustomerId", "CustomerId1", "SumOfPrice" },
                values: new object[,]
                {
                    { 1, 1, null, 920537 },
                    { 2, 2, null, 484400 },
                    { 3, 3, null, 426062 },
                    { 4, 4, null, 839202 },
                    { 5, 5, null, 935835 },
                    { 6, 6, null, 811397 },
                    { 7, 7, null, 895658 },
                    { 8, 8, null, 560166 },
                    { 9, 9, null, 563211 },
                    { 10, 10, null, 272597 },
                    { 11, 11, null, 729995 },
                    { 12, 12, null, 482458 },
                    { 13, 13, null, 411860 },
                    { 14, 14, null, 772755 },
                    { 15, 15, null, 776209 },
                    { 16, 16, null, 399151 },
                    { 17, 17, null, 469027 },
                    { 18, 18, null, 362223 },
                    { 19, 19, null, 297218 },
                    { 20, 20, null, 982774 },
                    { 21, 21, null, 910244 },
                    { 22, 22, null, 300667 },
                    { 23, 23, null, 708536 },
                    { 24, 24, null, 559049 },
                    { 25, 25, null, 404839 },
                    { 26, 26, null, 807808 },
                    { 27, 27, null, 219547 },
                    { 28, 28, null, 869331 },
                    { 29, 29, null, 761673 },
                    { 30, 30, null, 824601 },
                    { 31, 31, null, 420876 },
                    { 32, 32, null, 508935 },
                    { 33, 33, null, 986902 },
                    { 34, 34, null, 38839 },
                    { 35, 35, null, 98067 },
                    { 36, 36, null, 502315 },
                    { 37, 37, null, 534946 },
                    { 38, 38, null, 641043 },
                    { 39, 39, null, 403341 },
                    { 40, 40, null, 398434 },
                    { 41, 41, null, 732333 },
                    { 42, 42, null, 945003 },
                    { 43, 43, null, 662057 },
                    { 44, 44, null, 467571 },
                    { 45, 45, null, 160591 },
                    { 46, 46, null, 476392 },
                    { 47, 47, null, 984424 },
                    { 48, 48, null, 169169 },
                    { 49, 49, null, 401671 },
                    { 50, 50, null, 442852 }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "At tempore velit quos quaerat totam qui enim et molestias. Ratione ab sunt facilis illo doloremque ipsa. Reiciendis nesciunt molestias esse facilis ducimus. Cupiditate est enim maxime corrupti cupiditate aut adipisci.", "Handmade Rubber Shirt", "236.57" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Voluptatem sed laboriosam atque. Non praesentium quibusdam quam cum est. Tenetur esse possimus ut aliquam assumenda ipsa. Earum omnis alias possimus voluptatem aperiam dolores. Suscipit autem molestias molestiae ut consectetur dolorem eaque dolorem. Numquam et sit est enim harum sit ut sunt deserunt.", "Refined Rubber Computer", "440.28" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Corporis reprehenderit sed qui. Qui reprehenderit id laudantium et ipsum. Veniam voluptas officia porro dolor quia iste sed odio.", "Unbranded Rubber Cheese", "216.27" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Ut esse dignissimos adipisci qui eos. Rerum iusto sint. Totam illum provident in voluptatem facilis laudantium.", "Sleek Cotton Fish", "215.73" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Ad modi earum facere sunt ut facere pariatur. Non pariatur consectetur sit iusto dignissimos. Et debitis sequi et deserunt at id officia eos tenetur. Et cupiditate commodi expedita sed eligendi minus sint quas. Nostrum quibusdam provident dolorem id inventore necessitatibus soluta eum dolore.", "Handcrafted Soft Chair", "210.88" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Et sed nihil corrupti aliquid necessitatibus eos inventore pariatur. Ab enim ipsam et quis. Itaque sit hic vitae dolorum quidem vero. Pariatur et deleniti nihil quidem aut dolore sint qui. Est laborum dolores perferendis similique in distinctio voluptatum. Velit consequatur et consequatur rerum.", "Small Plastic Table", "959.41" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Tempora quis quaerat fuga rerum ducimus velit et nihil. Beatae dolores ut et est tempore sit molestiae qui unde. Ratione ipsam ducimus autem incidunt ut. Placeat earum et asperiores quam aut praesentium.", "Handcrafted Steel Ball", "488.06" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Incidunt illo aliquid suscipit accusamus architecto quod neque quis cum. Et rerum nihil beatae. Vel fugiat voluptate et qui soluta deleniti neque vitae quo.", "Fantastic Fresh Shirt", "658.98" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Sit natus consectetur explicabo delectus aut et. Quibusdam et praesentium voluptatem. Consectetur voluptatum blanditiis vel occaecati ut eaque delectus.", "Rustic Concrete Gloves", "214.08" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Nesciunt esse in et ut. Est rem eum ut maiores consequatur cumque. Aliquam aut iure modi eius occaecati saepe labore sed repellendus.", "Rustic Rubber Towels", "718.77" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Facilis occaecati est eos voluptas id. Molestias quos minus aperiam. Sunt modi reprehenderit sint quo consequuntur quo aut.", "Licensed Wooden Towels", "780.92" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Numquam temporibus sed consectetur nihil accusantium ex asperiores officia totam. Voluptas voluptatem sint rerum. Minus atque atque quia voluptatem reiciendis qui sed earum voluptatibus. Perferendis est voluptatem dolorem aut quas nulla occaecati iusto.", "Incredible Plastic Chicken", "303.26" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Quidem molestiae quis. Reiciendis adipisci eius eveniet deserunt officiis amet dolor assumenda labore. Alias magnam odio sequi laboriosam eum. Corporis consequuntur suscipit corporis repellat.", "Incredible Plastic Chair", "451.53" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Illo nisi totam sint earum alias cum quibusdam quo. Exercitationem repudiandae quia beatae veniam ipsa ullam ab. Vero accusantium impedit commodi fuga nesciunt distinctio tempore velit. Voluptatem neque cumque porro consequatur quo eveniet molestiae vitae.", "Awesome Cotton Mouse", "308.74" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Aut non perferendis modi porro velit minima. Corporis et repellendus ut reiciendis nulla. Minima voluptas deleniti doloremque reprehenderit error deserunt velit tenetur. Eum fugit eius quod et. Deleniti aperiam qui et hic est.", "Practical Granite Towels", "451.49" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Aspernatur culpa commodi et vitae quia. Odit asperiores excepturi. Reiciendis esse aut inventore vero. Exercitationem veritatis quidem accusamus labore. Enim sequi incidunt consequatur harum. Repellat tempore aliquid repellendus adipisci aut autem alias laudantium aperiam.", "Sleek Plastic Chair", "892.19" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Nulla velit itaque deserunt mollitia voluptatem veritatis voluptatibus qui. Eos ad ab voluptas at sint qui. Asperiores voluptas recusandae adipisci. Voluptates nobis at et. Ipsum molestiae perspiciatis at suscipit. Enim doloremque officiis eaque veniam pariatur laborum.", "Handmade Plastic Shirt", "369.77" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Cumque sit autem voluptatem explicabo iure consequuntur illum et voluptatibus. Voluptates quod veniam. Vel eius voluptatibus consequatur itaque quos qui qui rerum.", "Generic Metal Bike", "359.02" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Unde nam qui ut dolorem vitae autem. Ducimus laudantium non maxime distinctio quae nulla. Perspiciatis error vel iste. Nobis ut nesciunt praesentium dolore ea. A voluptatem et ut aliquam aut et commodi.", "Tasty Wooden Bike", "323.26" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Provident ut qui placeat autem omnis quibusdam. Ea culpa esse consequatur. Et et molestiae dignissimos.", "Refined Wooden Fish", "920.77" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Enim quos iste laborum. Aut nihil ducimus aspernatur sed consequatur. Eligendi molestiae quo qui. Itaque qui placeat distinctio atque dolore aut.", "Handmade Steel Tuna", "569.84" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Delectus delectus incidunt voluptatem quam aliquam labore neque ipsam quam. Dolores ipsam totam ipsam quo id alias qui. Eos sed sint omnis error dolorem.", "Unbranded Fresh Shirt", "245.10" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Magnam aut sunt nulla et. Consequatur blanditiis numquam nihil dolorum nemo. Non ipsum omnis. Vero adipisci saepe nam est at nulla ab. Facere mollitia perferendis et sed assumenda molestias eum. Non eveniet rem temporibus ea repellat ad aliquam porro dolores.", "Awesome Steel Towels", "607.35" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Amet aliquid voluptatem est cupiditate magnam est autem labore dolorum. Dignissimos natus corporis at et libero. A debitis amet et quo eveniet iure rem. Ut dignissimos dolor porro.", "Sleek Steel Tuna", "944.40" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Minus ex sapiente ipsum cum omnis. Officia eum optio velit facilis aut quo reprehenderit. Officia quod sed sint consequuntur quaerat illo aut. Aliquid veritatis et laudantium ut fugiat.", "Awesome Soft Sausages", "374.69" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Impedit molestias sint aspernatur nemo iste est est nihil quidem. Quia dolore tenetur maiores vel. Commodi rem corporis pariatur autem voluptas corrupti fugiat consequuntur non. Eaque quia quos et odit cumque debitis incidunt animi.", "Practical Plastic Sausages", "417.99" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Porro quisquam culpa numquam rerum nulla natus sed. Praesentium maiores ratione sint sit doloremque voluptatem sit et voluptates. Dolores qui iusto eius unde architecto possimus non. Perspiciatis assumenda voluptatem praesentium sed est.", "Licensed Metal Ball", "765.16" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Tempore ut dignissimos sed omnis sapiente. Sunt sequi quidem. Consequatur cumque quia.", "Gorgeous Frozen Chips", "571.90" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Aliquid ab voluptate. Sapiente nobis quibusdam sunt voluptatem aut enim rerum. Non dolorem animi doloribus aspernatur repellat fugit impedit quidem sit. Optio expedita omnis rerum eaque deleniti saepe dolore sed recusandae. Dolorum dolores possimus. Accusamus dolorem voluptatum nemo.", "Gorgeous Plastic Tuna", "145.52" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Ut exercitationem quaerat libero facere. Porro quisquam quas asperiores nemo molestiae. Sed repellendus fugit voluptatem cupiditate a dicta sed totam. Earum consequuntur rerum ut.", "Fantastic Cotton Shoes", "328.65" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Deserunt quasi amet harum culpa. Omnis voluptate ut et voluptas. Rerum ipsam earum cupiditate doloremque ut voluptates occaecati voluptate.", "Intelligent Granite Ball", "151.72" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Ratione iure sed delectus minus magni expedita quaerat laudantium. Deleniti dignissimos nesciunt voluptate cum ullam quo. Explicabo sit harum nostrum aut sequi. Ut distinctio vero odio. Consequuntur ipsam eaque iste voluptate voluptatem consequatur.", "Sleek Steel Gloves", "663.69" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Molestiae unde et facere aut minus. Nam deserunt modi ex quia at qui vel omnis. Rem quibusdam illum eveniet voluptatum neque.", "Small Metal Ball", "404.44" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Iusto autem eveniet in. Debitis est veniam mollitia unde consequuntur deserunt ut provident. Nobis vel omnis. Maiores rerum est dolore corrupti ut. Qui eum et ratione aut beatae sint. Sequi nulla praesentium mollitia aperiam nihil.", "Generic Steel Tuna", "771.72" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Asperiores earum quasi quisquam. Ducimus numquam rerum quis. Magni velit nisi labore molestiae modi repellendus ducimus odio. Tempore velit vel. Tempora repellendus sint minus numquam.", "Sleek Soft Sausages", "393.18" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Excepturi ipsam dolor molestiae distinctio et ut. Consequatur quo quae aliquam. Ad unde impedit suscipit atque fuga iste qui natus.", "Refined Plastic Bacon", "816.52" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Eveniet molestiae consequatur mollitia suscipit expedita sint voluptates. Cupiditate omnis sit. Non perferendis ut dolor non quisquam praesentium libero. Non quo consectetur qui repellat hic et veniam.", "Sleek Cotton Sausages", "488.46" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Et qui et dolores ea quidem. Vel impedit odio pariatur quis perspiciatis minima voluptatem. Non voluptatem et non in ut voluptate aut distinctio delectus. Quisquam aperiam ab et totam et.", "Handmade Cotton Bike", "574.91" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Doloremque voluptatibus quo. Placeat id et ea. Delectus culpa occaecati commodi. Explicabo ipsa recusandae ipsa. Voluptatum reprehenderit tempora.", "Generic Soft Soap", "980.65" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Ut facilis officia ullam fuga et. Incidunt nobis quo. Ad doloremque natus amet possimus blanditiis non odio. Vel provident optio nobis similique.", "Licensed Metal Tuna", "109.64" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Odit modi neque iusto in autem. Eveniet odio dolores eos ex. Eum voluptas ducimus. Eaque modi voluptatem magni sed dicta et iusto rerum. Qui sint non ut incidunt maxime consequatur omnis illo et. Laborum vel quia harum.", "Handmade Soft Chair", "997.55" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Et distinctio aut omnis omnis. Nisi et eos excepturi repellat harum rem. Vel incidunt ut harum est minus eum. Culpa cumque molestiae voluptas ratione dolores quia et. Quaerat nisi animi non at voluptas rem qui.", "Rustic Frozen Mouse", "130.24" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Reiciendis voluptates dolorum magnam. Quaerat ipsam similique accusamus rem sunt vitae sit suscipit. Rem nulla optio numquam consequatur id nostrum accusamus fuga non. Et sit deleniti impedit sit autem modi similique qui recusandae.", "Small Metal Sausages", "524.82" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Voluptatum magni quo assumenda ratione dolores sint expedita. Hic nihil unde qui. Eaque repellat est et eum dolores sunt nesciunt. Ullam vero laborum aut alias.", "Gorgeous Cotton Tuna", "946.51" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Illum quod temporibus. Possimus exercitationem nam qui sed incidunt sunt cum quia. Saepe cupiditate occaecati sunt quo aliquam animi ipsam voluptas. Voluptates provident magnam sint quo sunt eligendi.", "Generic Concrete Towels", "154.45" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Delectus odit provident totam. Fuga inventore non sit iusto. Odit quam vitae. Quo ipsum ducimus et eveniet magnam pariatur modi.", "Rustic Plastic Pizza", "44.44" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Omnis eum necessitatibus deserunt ipsam iste totam corporis repellendus sit. Repellendus voluptas qui explicabo magni voluptate nostrum quos. Odio tenetur ut. Ea a fugit aut corrupti. Nesciunt nam sint ad et.", "Rustic Wooden Chips", "609.15" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Voluptate eum fugit vel. Molestiae quia magni. Quod illum rem sed dolores mollitia non occaecati consectetur ex. Qui illum laudantium quia voluptatem ut. Aspernatur corrupti ut.", "Intelligent Granite Computer", "894.45" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Repellendus iste quis doloremque asperiores facere in. Nisi adipisci voluptatibus omnis doloremque soluta quo. Placeat vitae quidem deserunt et.", "Intelligent Frozen Cheese", "940.92" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Aut nulla harum et placeat laudantium accusantium qui. Ut quia ducimus eum et aut eum eum veniam enim. Aut amet sunt.", "Licensed Fresh Salad", "436.25" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "North Bernie", "Waylon_Brown@gmail.com", "Shemar", "Corwin", "76230574468", "Idella_OConner43" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Bergstromburgh", "Letitia37@gmail.com", "Vicenta", "Mann", "21414761110", "Lee_Wiegand27" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Ashleigh", "Mya_Schowalter2@yahoo.com", "Hoyt", "Cormier", "27450626259", "Adella.Funk" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Leoton", "Keyon18@hotmail.com", "Marguerite", "Trantow", "32975356449", "Yasmine_Schuster" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Chasityborough", "Destin_Johns98@gmail.com", "Hassie", "Orn", "39173337338", "Ida.Bahringer75" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Lake Keyshawn", "Ayden_Wuckert@hotmail.com", "Lucio", "Quitzon", "59429508327", "Ludwig38" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Kihnbury", "Maverick38@yahoo.com", "Ewald", "Grady", "66532296184", "Fabiola57" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Walton", "Sterling.Daniel41@yahoo.com", "Rodrigo", "Schuster", "06828138385", "Savannah93" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Bartonburgh", "Jany_Romaguera@yahoo.com", "Osborne", "Mosciski", "61974628128", "Kurt.Reichert90" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Felicitahaven", "Carolyne.Cremin45@yahoo.com", "King", "Lynch", "97541178418", "Adela42" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Bergnaumchester", "Randal.Hegmann@yahoo.com", "Chelsea", "Hessel", "40350230752", "Ophelia_Lebsack68" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Shanaland", "Gordon38@yahoo.com", "Cody", "Collins", "69672917767", "Shyanne.Kertzmann" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Earnestview", "Jacquelyn_Bogan@hotmail.com", "Marques", "Goldner", "73628070132", "Elmira.Dare" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Port Kris", "Adele.Hane33@yahoo.com", "Mackenzie", "Cole", "26131822554", "Zander49" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Ernserborough", "Neil.Wiza10@gmail.com", "Teagan", "Lindgren", "09070725818", "Mozell_Rau" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Krajcikmouth", "Jason.Mayer60@yahoo.com", "Jaunita", "Bernier", "55346230821", "Simone_Cassin" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Leonebury", "Arden_Wilderman28@gmail.com", "Dino", "Hilll", "46530441713", "Morton_Rodriguez49" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Denesikborough", "Dax_Brown32@hotmail.com", "Carissa", "Koelpin", "31343689843", "Cicero65" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Lake Noemi", "Lavon_Heaney8@gmail.com", "Aletha", "Marquardt", "71425856138", "Keenan.Dach" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Lionelside", "Okey68@hotmail.com", "Miles", "Nicolas", "93627775286", "Jennings26" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "South Kelsi", "Laura.Lakin@gmail.com", "Josephine", "Homenick", "65639505549", "Jess_Cruickshank29" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Swaniawskitown", "Quinten.Mraz60@hotmail.com", "Ashlynn", "Ratke", "95367185119", "Kellen6" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Port Lesliefort", "Brett_Padberg@hotmail.com", "Javon", "Beahan", "63328972365", "Estella.Breitenberg" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Clara", "Kristoffer_Schuppe@gmail.com", "Lavina", "Streich", "41978881743", "Hardy_Tremblay2" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Gersonland", "Janie_Smitham79@yahoo.com", "Mariah", "Kuhn", "06374333048", "Giles.Ward49" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Timmyshire", "Abdul_Lindgren96@yahoo.com", "Joe", "Cassin", "10860000743", "Bridgette61" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "South Hayley", "Daniela.Yost@yahoo.com", "Sincere", "Torp", "36110161423", "Kyra.Adams" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "O'Keefeborough", "Kyleigh_Bogisich41@yahoo.com", "Otho", "Mertz", "51448033749", "Garrett73" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Violetborough", "Lance.Romaguera@gmail.com", "Newton", "Lockman", "89787544654", "Jamison.Roob" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "North Savannah", "Mylene_Ritchie11@yahoo.com", "Ethel", "Dach", "31329374015", "Brannon_Pagac" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "West Luzton", "Guy1@yahoo.com", "Jamey", "Hansen", "93950179622", "Wilhelm82" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Whiteside", "Jaylen75@hotmail.com", "Vivienne", "MacGyver", "07069002097", "Elissa_Fahey" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "West Dejaton", "Aryanna_Deckow10@yahoo.com", "Pierre", "Kozey", "96329723108", "Germaine15" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "New Leliamouth", "Cyril_Green7@hotmail.com", "Carlotta", "Mosciski", "19526804970", "Ashleigh.Dicki29" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "South Clement", "Austen75@yahoo.com", "Nelle", "Mills", "68190721256", "Gerard.Hegmann41" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Smithamtown", "Katelin_Bednar@hotmail.com", "Lavina", "Feil", "40974454036", "Richie11" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "West Quintenton", "Samanta.Rutherford@gmail.com", "Dejah", "Hettinger", "60410174057", "Isaac96" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Susannaborough", "Toy5@gmail.com", "Anastasia", "Turcotte", "86862558302", "Harvey.Schoen99" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Kovacekchester", "Tamara_Crona@gmail.com", "Pedro", "Jaskolski", "57605370982", "Johnpaul68" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Kamrynside", "Alexandra59@yahoo.com", "Raegan", "Yundt", "46236761298", "Missouri.Wintheiser" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "North Jonas", "Hettie.Frami94@gmail.com", "Frances", "Emmerich", "50456441746", "Waino.Kozey" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Mireille", "Yolanda63@hotmail.com", "Peyton", "Dare", "61310627108", "Newton.Wolf42" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Isaactown", "Armand_Nitzsche26@yahoo.com", "Ofelia", "Jenkins", "89581140837", "Bianka_Vandervort" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "West Viviane", "Austyn60@hotmail.com", "Angelita", "Halvorson", "07325555772", "Frida31" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Lake Enochfort", "Jamal.Ledner@yahoo.com", "Napoleon", "Wyman", "79534725203", "Cathrine_Terry" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "North Tyson", "Kiel.Hansen@hotmail.com", "Daren", "Bosco", "23062728591", "Melisa.Effertz4" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "West Joshuaport", "Hosea.Keeling80@yahoo.com", "Nova", "Boyer", "06190850114", "Troy.Jaskolski55" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Bradtkebury", "Veda42@gmail.com", "Damion", "Gibson", "26696899214", "Valentine87" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Jena", "Susie.Bauch@yahoo.com", "Issac", "Veum", "43197738668", "Lennie.Wilkinson" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "South Idellton", "Ross_Barrows67@gmail.com", "Kathlyn", "Cassin", "92882627158", "Hal_Gulgowski" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "quos" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 8, "omnis" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "commodi");

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "voluptatibus" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "qui" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 7, "soluta" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 6, "et" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 7, "veniam" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 4, "a" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "quo" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "aut" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 8, "aliquid" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "qui" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 6, "ipsam" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "quis" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 4, "quibusdam" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 10, "porro" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "ea" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "adipisci" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "enim" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 6, "ullam" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "id");

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 7, "rerum" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 24,
                column: "CategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 6, "ut" });

            migrationBuilder.CreateIndex(
                name: "IX_Factors_CustomerId1",
                table: "Factors",
                column: "CustomerId1",
                unique: true,
                filter: "[CustomerId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Factors_Customer_CustomerId1",
                table: "Factors",
                column: "CustomerId1",
                principalTable: "Customer",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factors_Customer_CustomerId1",
                table: "Factors");

            migrationBuilder.DropIndex(
                name: "IX_Factors_CustomerId1",
                table: "Factors");

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Factors",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Factors");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Ea sed aliquid repellat iste voluptatum. Neque distinctio ipsum perferendis fuga fugit voluptatem. Officia ut velit quidem quia ratione saepe. Ipsa et ab repudiandae ea aut sunt non sapiente. Quasi quo animi et voluptas asperiores doloribus.", "Intelligent Steel Car", "671.92" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Natus reprehenderit qui repudiandae at tempore velit quos quaerat. Qui enim et molestias natus ratione. Sunt facilis illo. Ipsa iusto reiciendis. Molestias esse facilis ducimus.", "Sleek Cotton Car", "640.04" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Cupiditate aut adipisci ut at unde. Consequatur dolore voluptatem. Laboriosam atque et. Praesentium quibusdam quam cum est sint tenetur. Possimus ut aliquam assumenda ipsa dolorum.", "Sleek Metal Gloves", "942.23" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Dolores at suscipit. Molestias molestiae ut consectetur dolorem eaque dolorem recusandae numquam. Sit est enim harum sit ut sunt deserunt odio necessitatibus.", "Handmade Steel Cheese", "598.24" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Sed qui laudantium qui reprehenderit id. Et ipsum et veniam voluptas officia. Dolor quia iste sed odio numquam corrupti consequatur. Ab laudantium ut esse dignissimos adipisci qui eos.", "Licensed Steel Mouse", "43.47" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Illum provident in voluptatem facilis laudantium. Est aut consequatur quisquam. Ad modi earum facere sunt ut facere pariatur. Non pariatur consectetur sit iusto dignissimos. Et debitis sequi et deserunt at id officia eos tenetur.", "Unbranded Cotton Sausages", "845.48" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Eligendi minus sint quas et nostrum quibusdam. Dolorem id inventore necessitatibus soluta eum dolore. Voluptatem ad ducimus non. Et sed nihil corrupti aliquid necessitatibus eos inventore pariatur. Ab enim ipsam et quis.", "Unbranded Granite Pants", "515.73" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Quidem vero quibusdam pariatur et deleniti nihil. Aut dolore sint qui est est laborum dolores. Similique in distinctio.", "Unbranded Steel Sausages", "476.14" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Rerum a optio vitae aliquam. Nulla tempora quis quaerat fuga rerum. Velit et nihil delectus beatae dolores. Et est tempore sit molestiae qui unde. Ratione ipsam ducimus autem incidunt ut.", "Incredible Cotton Chair", "592.06" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Aut praesentium corrupti ex officiis autem. Doloribus incidunt illo. Suscipit accusamus architecto quod neque. Cum nesciunt et rerum nihil. Ut vel fugiat. Et qui soluta deleniti neque vitae.", "Handmade Frozen Bacon", "714.36" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Unde sit natus consectetur. Delectus aut et. Quibusdam et praesentium voluptatem. Consectetur voluptatum blanditiis vel occaecati ut eaque delectus.", "Handcrafted Wooden Bike", "214.08" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Nesciunt esse in et ut. Est rem eum ut maiores consequatur cumque. Aliquam aut iure modi eius occaecati saepe labore sed repellendus.", "Rustic Rubber Towels", "718.77" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Facilis occaecati est eos voluptas id. Molestias quos minus aperiam. Sunt modi reprehenderit sint quo consequuntur quo aut.", "Licensed Wooden Towels", "780.92" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Numquam temporibus sed consectetur nihil accusantium ex asperiores officia totam. Voluptas voluptatem sint rerum. Minus atque atque quia voluptatem reiciendis qui sed earum voluptatibus. Perferendis est voluptatem dolorem aut quas nulla occaecati iusto.", "Incredible Plastic Chicken", "303.26" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Quidem molestiae quis. Reiciendis adipisci eius eveniet deserunt officiis amet dolor assumenda labore. Alias magnam odio sequi laboriosam eum. Corporis consequuntur suscipit corporis repellat.", "Incredible Plastic Chair", "451.53" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Illo nisi totam sint earum alias cum quibusdam quo. Exercitationem repudiandae quia beatae veniam ipsa ullam ab. Vero accusantium impedit commodi fuga nesciunt distinctio tempore velit. Voluptatem neque cumque porro consequatur quo eveniet molestiae vitae.", "Awesome Cotton Mouse", "308.74" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Aut non perferendis modi porro velit minima. Corporis et repellendus ut reiciendis nulla. Minima voluptas deleniti doloremque reprehenderit error deserunt velit tenetur. Eum fugit eius quod et. Deleniti aperiam qui et hic est.", "Practical Granite Towels", "451.49" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Aspernatur culpa commodi et vitae quia. Odit asperiores excepturi. Reiciendis esse aut inventore vero. Exercitationem veritatis quidem accusamus labore. Enim sequi incidunt consequatur harum. Repellat tempore aliquid repellendus adipisci aut autem alias laudantium aperiam.", "Sleek Plastic Chair", "892.19" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Nulla velit itaque deserunt mollitia voluptatem veritatis voluptatibus qui. Eos ad ab voluptas at sint qui. Asperiores voluptas recusandae adipisci. Voluptates nobis at et. Ipsum molestiae perspiciatis at suscipit. Enim doloremque officiis eaque veniam pariatur laborum.", "Handmade Plastic Shirt", "369.77" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Cumque sit autem voluptatem explicabo iure consequuntur illum et voluptatibus. Voluptates quod veniam. Vel eius voluptatibus consequatur itaque quos qui qui rerum.", "Generic Metal Bike", "359.02" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Unde nam qui ut dolorem vitae autem. Ducimus laudantium non maxime distinctio quae nulla. Perspiciatis error vel iste. Nobis ut nesciunt praesentium dolore ea. A voluptatem et ut aliquam aut et commodi.", "Tasty Wooden Bike", "323.26" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Provident ut qui placeat autem omnis quibusdam. Ea culpa esse consequatur. Et et molestiae dignissimos.", "Refined Wooden Fish", "920.77" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Enim quos iste laborum. Aut nihil ducimus aspernatur sed consequatur. Eligendi molestiae quo qui. Itaque qui placeat distinctio atque dolore aut.", "Handmade Steel Tuna", "569.84" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Delectus delectus incidunt voluptatem quam aliquam labore neque ipsam quam. Dolores ipsam totam ipsam quo id alias qui. Eos sed sint omnis error dolorem.", "Unbranded Fresh Shirt", "245.10" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Magnam aut sunt nulla et. Consequatur blanditiis numquam nihil dolorum nemo. Non ipsum omnis. Vero adipisci saepe nam est at nulla ab. Facere mollitia perferendis et sed assumenda molestias eum. Non eveniet rem temporibus ea repellat ad aliquam porro dolores.", "Awesome Steel Towels", "607.35" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Amet aliquid voluptatem est cupiditate magnam est autem labore dolorum. Dignissimos natus corporis at et libero. A debitis amet et quo eveniet iure rem. Ut dignissimos dolor porro.", "Sleek Steel Tuna", "944.40" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Minus ex sapiente ipsum cum omnis. Officia eum optio velit facilis aut quo reprehenderit. Officia quod sed sint consequuntur quaerat illo aut. Aliquid veritatis et laudantium ut fugiat.", "Awesome Soft Sausages", "374.69" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Impedit molestias sint aspernatur nemo iste est est nihil quidem. Quia dolore tenetur maiores vel. Commodi rem corporis pariatur autem voluptas corrupti fugiat consequuntur non. Eaque quia quos et odit cumque debitis incidunt animi.", "Practical Plastic Sausages", "417.99" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Porro quisquam culpa numquam rerum nulla natus sed. Praesentium maiores ratione sint sit doloremque voluptatem sit et voluptates. Dolores qui iusto eius unde architecto possimus non. Perspiciatis assumenda voluptatem praesentium sed est.", "Licensed Metal Ball", "765.16" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Tempore ut dignissimos sed omnis sapiente. Sunt sequi quidem. Consequatur cumque quia.", "Gorgeous Frozen Chips", "571.90" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Aliquid ab voluptate. Sapiente nobis quibusdam sunt voluptatem aut enim rerum. Non dolorem animi doloribus aspernatur repellat fugit impedit quidem sit. Optio expedita omnis rerum eaque deleniti saepe dolore sed recusandae. Dolorum dolores possimus. Accusamus dolorem voluptatum nemo.", "Gorgeous Plastic Tuna", "145.52" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Ut exercitationem quaerat libero facere. Porro quisquam quas asperiores nemo molestiae. Sed repellendus fugit voluptatem cupiditate a dicta sed totam. Earum consequuntur rerum ut.", "Fantastic Cotton Shoes", "328.65" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Deserunt quasi amet harum culpa. Omnis voluptate ut et voluptas. Rerum ipsam earum cupiditate doloremque ut voluptates occaecati voluptate.", "Intelligent Granite Ball", "151.72" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Ratione iure sed delectus minus magni expedita quaerat laudantium. Deleniti dignissimos nesciunt voluptate cum ullam quo. Explicabo sit harum nostrum aut sequi. Ut distinctio vero odio. Consequuntur ipsam eaque iste voluptate voluptatem consequatur.", "Sleek Steel Gloves", "663.69" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Molestiae unde et facere aut minus. Nam deserunt modi ex quia at qui vel omnis. Rem quibusdam illum eveniet voluptatum neque.", "Small Metal Ball", "404.44" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Iusto autem eveniet in. Debitis est veniam mollitia unde consequuntur deserunt ut provident. Nobis vel omnis. Maiores rerum est dolore corrupti ut. Qui eum et ratione aut beatae sint. Sequi nulla praesentium mollitia aperiam nihil.", "Generic Steel Tuna", "771.72" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Asperiores earum quasi quisquam. Ducimus numquam rerum quis. Magni velit nisi labore molestiae modi repellendus ducimus odio. Tempore velit vel. Tempora repellendus sint minus numquam.", "Sleek Soft Sausages", "393.18" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Excepturi ipsam dolor molestiae distinctio et ut. Consequatur quo quae aliquam. Ad unde impedit suscipit atque fuga iste qui natus.", "Refined Plastic Bacon", "816.52" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Eveniet molestiae consequatur mollitia suscipit expedita sint voluptates. Cupiditate omnis sit. Non perferendis ut dolor non quisquam praesentium libero. Non quo consectetur qui repellat hic et veniam.", "Sleek Cotton Sausages", "488.46" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Et qui et dolores ea quidem. Vel impedit odio pariatur quis perspiciatis minima voluptatem. Non voluptatem et non in ut voluptate aut distinctio delectus. Quisquam aperiam ab et totam et.", "Handmade Cotton Bike", "574.91" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Doloremque voluptatibus quo. Placeat id et ea. Delectus culpa occaecati commodi. Explicabo ipsa recusandae ipsa. Voluptatum reprehenderit tempora.", "Generic Soft Soap", "980.65" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Ut facilis officia ullam fuga et. Incidunt nobis quo. Ad doloremque natus amet possimus blanditiis non odio. Vel provident optio nobis similique.", "Licensed Metal Tuna", "109.64" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Odit modi neque iusto in autem. Eveniet odio dolores eos ex. Eum voluptas ducimus. Eaque modi voluptatem magni sed dicta et iusto rerum. Qui sint non ut incidunt maxime consequatur omnis illo et. Laborum vel quia harum.", "Handmade Soft Chair", "997.55" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Et distinctio aut omnis omnis. Nisi et eos excepturi repellat harum rem. Vel incidunt ut harum est minus eum. Culpa cumque molestiae voluptas ratione dolores quia et. Quaerat nisi animi non at voluptas rem qui.", "Rustic Frozen Mouse", "130.24" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Reiciendis voluptates dolorum magnam. Quaerat ipsam similique accusamus rem sunt vitae sit suscipit. Rem nulla optio numquam consequatur id nostrum accusamus fuga non. Et sit deleniti impedit sit autem modi similique qui recusandae.", "Small Metal Sausages", "524.82" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Voluptatum magni quo assumenda ratione dolores sint expedita. Hic nihil unde qui. Eaque repellat est et eum dolores sunt nesciunt. Ullam vero laborum aut alias.", "Gorgeous Cotton Tuna", "946.51" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Illum quod temporibus. Possimus exercitationem nam qui sed incidunt sunt cum quia. Saepe cupiditate occaecati sunt quo aliquam animi ipsam voluptas. Voluptates provident magnam sint quo sunt eligendi.", "Generic Concrete Towels", "154.45" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Delectus odit provident totam. Fuga inventore non sit iusto. Odit quam vitae. Quo ipsum ducimus et eveniet magnam pariatur modi.", "Rustic Plastic Pizza", "44.44" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Omnis eum necessitatibus deserunt ipsam iste totam corporis repellendus sit. Repellendus voluptas qui explicabo magni voluptate nostrum quos. Odio tenetur ut. Ea a fugit aut corrupti. Nesciunt nam sint ad et.", "Rustic Wooden Chips", "609.15" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Voluptate eum fugit vel. Molestiae quia magni. Quod illum rem sed dolores mollitia non occaecati consectetur ex. Qui illum laudantium quia voluptatem ut. Aspernatur corrupti ut.", "Intelligent Granite Computer", "894.45" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Landenside", "Eduardo_Bartoletti57@yahoo.com", "Christop", "Wisoky", "53197067370", "Palma_Bartell" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Grahamburgh", "Rosalinda_Nader@gmail.com", "Triston", "Schamberger", "40199348288", "Rosina64" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Jonesview", "Idella_OConner43@gmail.com", "Anthony", "Schoen", "19157762305", "Citlalli_Marks" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Burdetteland", "Lee_Wiegand27@yahoo.com", "Lorenz", "Schoen", "16503214147", "Faye95" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Efrainstad", "Adella.Funk@gmail.com", "Brionna", "Bechtelar", "67885027450", "Vernice43" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Letitiaview", "Sister_Yundt64@hotmail.com", "Deion", "MacGyver", "85311329753", "Vern8" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "West Micah", "Ida.Bahringer75@hotmail.com", "Ines", "Ward", "02477939173", "Marisol41" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Lake Gordonberg", "Mellie.Nolan38@yahoo.com", "Georgianna", "Hermiston", "70945594295", "Sam36" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Carleyhaven", "Alexie.Hagenes@yahoo.com", "Mellie", "Hahn", "68136653229", "Nakia.Marquardt" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Hoegerhaven", "Brent_Watsica@hotmail.com", "Gunnar", "Tremblay", "18040682813", "Imogene_Howell87" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Rettaside", "Trinity_Howe47@hotmail.com", "Kade", "King", "74961974628", "Cedrick_Witting58" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "North Stacy", "Hershel15@gmail.com", "Alexzander", "Gusikowski", "73497541178", "King99" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Kayceeburgh", "Peggie_Nikolaus81@yahoo.com", "Manley", "Heller", "36440350230", "Silas_Daugherty" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Mabellechester", "Magdalen.Heathcote@yahoo.com", "Oren", "Bergnaum", "22369672917", "Melody88" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Miguel", "Linwood.Berge8@gmail.com", "Lauriane", "Thiel", "45736280701", "Bertha30" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Jaydonport", "Kamren97@yahoo.com", "Earnest", "Keebler", "03261318225", "Mackenzie.Cole5" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Rosenbaumberg", "Alberta_Rogahn0@yahoo.com", "Savion", "McClure", "10907072581", "Teagan_Lindgren45" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Peggie", "Jarrod_Kreiger@yahoo.com", "Erwin", "Kris", "26553462308", "Antone64" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Clevebury", "Jerod95@hotmail.com", "Jarod", "Runte", "88246530441", "Dino_Hilll67" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Kerlukeborough", "Ayden.OHara11@hotmail.com", "Jovan", "Monahan", "78331343689", "Garrett.Crist" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Casandraborough", "Filiberto59@gmail.com", "Thea", "Denesik", "36807142585", "Erna_Barrows" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Mohrmouth", "Brock_Gleason62@hotmail.com", "Rahul", "Gleason", "36936277752", "Rodrick_Rowe49" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Hannaside", "Norene59@hotmail.com", "Lionel", "Volkman", "54165639505", "Josephine.Homenick" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Port Shanonhaven", "Angeline_Streich88@gmail.com", "Hilbert", "Koelpin", "16953671851", "Kelsi_Bogisich90" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Port Lesliefort", "Mckayla_Collier77@gmail.com", "Alfonzo", "Kris", "63328972365", "Alysa45" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Clara", "Kristoffer_Schuppe@gmail.com", "Lavina", "Streich", "41978881743", "Hardy_Tremblay2" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Gersonland", "Janie_Smitham79@yahoo.com", "Mariah", "Kuhn", "06374333048", "Giles.Ward49" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Timmyshire", "Abdul_Lindgren96@yahoo.com", "Joe", "Cassin", "10860000743", "Bridgette61" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "South Hayley", "Daniela.Yost@yahoo.com", "Sincere", "Torp", "36110161423", "Kyra.Adams" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "O'Keefeborough", "Kyleigh_Bogisich41@yahoo.com", "Otho", "Mertz", "51448033749", "Garrett73" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Violetborough", "Lance.Romaguera@gmail.com", "Newton", "Lockman", "89787544654", "Jamison.Roob" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "North Savannah", "Mylene_Ritchie11@yahoo.com", "Ethel", "Dach", "31329374015", "Brannon_Pagac" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "West Luzton", "Guy1@yahoo.com", "Jamey", "Hansen", "93950179622", "Wilhelm82" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Whiteside", "Jaylen75@hotmail.com", "Vivienne", "MacGyver", "07069002097", "Elissa_Fahey" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "West Dejaton", "Aryanna_Deckow10@yahoo.com", "Pierre", "Kozey", "96329723108", "Germaine15" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "New Leliamouth", "Cyril_Green7@hotmail.com", "Carlotta", "Mosciski", "19526804970", "Ashleigh.Dicki29" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "South Clement", "Austen75@yahoo.com", "Nelle", "Mills", "68190721256", "Gerard.Hegmann41" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Smithamtown", "Katelin_Bednar@hotmail.com", "Lavina", "Feil", "40974454036", "Richie11" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "West Quintenton", "Samanta.Rutherford@gmail.com", "Dejah", "Hettinger", "60410174057", "Isaac96" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Susannaborough", "Toy5@gmail.com", "Anastasia", "Turcotte", "86862558302", "Harvey.Schoen99" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Kovacekchester", "Tamara_Crona@gmail.com", "Pedro", "Jaskolski", "57605370982", "Johnpaul68" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Kamrynside", "Alexandra59@yahoo.com", "Raegan", "Yundt", "46236761298", "Missouri.Wintheiser" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "North Jonas", "Hettie.Frami94@gmail.com", "Frances", "Emmerich", "50456441746", "Waino.Kozey" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "East Mireille", "Yolanda63@hotmail.com", "Peyton", "Dare", "61310627108", "Newton.Wolf42" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Isaactown", "Armand_Nitzsche26@yahoo.com", "Ofelia", "Jenkins", "89581140837", "Bianka_Vandervort" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "West Viviane", "Austyn60@hotmail.com", "Angelita", "Halvorson", "07325555772", "Frida31" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Lake Enochfort", "Jamal.Ledner@yahoo.com", "Napoleon", "Wyman", "79534725203", "Cathrine_Terry" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "North Tyson", "Kiel.Hansen@hotmail.com", "Daren", "Bosco", "23062728591", "Melisa.Effertz4" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "West Joshuaport", "Hosea.Keeling80@yahoo.com", "Nova", "Boyer", "06190850114", "Troy.Jaskolski55" });

            migrationBuilder.UpdateData(
                table: "SalesMan",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[] { "Bradtkebury", "Veda42@gmail.com", "Damion", "Gibson", "26696899214", "Valentine87" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "repudiandae" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 7, "tenetur" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "sit");

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 6, "et" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "reprehenderit" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "deleniti" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 4, "fugit" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 10, "quisquam" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 8, "ex" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 9, "est" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 7, "eveniet" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 4, "et" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "omnis" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "voluptate" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "commodi" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 8, "ut" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 9, "doloremque" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 8, "delectus" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 7, "repellat" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "fugiat" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 9, "exercitationem" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "magnam");

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 8, "quia" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 24,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "et" });
        }
    }
}
