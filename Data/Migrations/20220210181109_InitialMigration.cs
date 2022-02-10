using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaAPI.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrderDetails = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    OrderStatus = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    OrderDate = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    OrderStartingTime = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    OrderDeliveryTime = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    OrderPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    OrderLocation = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Pizza",
                columns: table => new
                {
                    PizzaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PizzaType = table.Column<int>(type: "INTEGER", nullable: false),
                    PizzaDescription = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza", x => x.PizzaId);
                    table.ForeignKey(
                        name: "FK_Pizza_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "OrderDate", "OrderDeliveryTime", "OrderDetails", "OrderLocation", "OrderPrice", "OrderStartingTime", "OrderStatus" },
                values: new object[] { new Guid("1bb1c44f-87ef-46b6-8031-ca09cc419624"), "2/10/22", "11:11 AM", "Deliver at front door", "SW 3, White Ave, Burnaby, BC V5G 3H2", 29.99m, "10:11 AM", "Complete" });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "OrderDate", "OrderDeliveryTime", "OrderDetails", "OrderLocation", "OrderPrice", "OrderStartingTime", "OrderStatus" },
                values: new object[] { new Guid("24a36310-6c27-424d-8eaf-238fabe3298a"), "2/10/22", "", "Deliver at back door", "7399 122 St, Surrey, BC V3W 5J2", 35.99m, "10:11 AM", "In Process" });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "OrderDate", "OrderDeliveryTime", "OrderDetails", "OrderLocation", "OrderPrice", "OrderStartingTime", "OrderStatus" },
                values: new object[] { new Guid("d5473fbd-b5d2-427a-8561-0de46b84da4a"), "2/10/22", "11:11 AM", "Deliver at side door", "2100 Viceroy Pl, Richmond, BC V6V 1Y9", 25.99m, "10:11 AM", "Complete" });

            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "PizzaId", "OrderId", "PizzaDescription", "PizzaType" },
                values: new object[] { new Guid("12e4ab6c-a818-43a9-9211-8b3bf5381448"), new Guid("24a36310-6c27-424d-8eaf-238fabe3298a"), "No sauce", 2 });

            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "PizzaId", "OrderId", "PizzaDescription", "PizzaType" },
                values: new object[] { new Guid("32f24690-cc94-4120-ade3-5e04e3c6f267"), new Guid("1bb1c44f-87ef-46b6-8031-ca09cc419624"), "Extra Cheese and Extra Sause", 0 });

            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "PizzaId", "OrderId", "PizzaDescription", "PizzaType" },
                values: new object[] { new Guid("84a4c8d7-05ef-4501-b083-d04659e1b189"), new Guid("24a36310-6c27-424d-8eaf-238fabe3298a"), "Extra BBQ Sause", 3 });

            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "PizzaId", "OrderId", "PizzaDescription", "PizzaType" },
                values: new object[] { new Guid("9b1acd4c-d3cc-41c7-bbf8-2d318b2d32af"), new Guid("24a36310-6c27-424d-8eaf-238fabe3298a"), "No Pinapples", 1 });

            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "PizzaId", "OrderId", "PizzaDescription", "PizzaType" },
                values: new object[] { new Guid("ad7ca64a-acc4-42b1-b7e1-8372a29329ee"), new Guid("d5473fbd-b5d2-427a-8561-0de46b84da4a"), "Normal Cheese Pizza", 0 });

            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "PizzaId", "OrderId", "PizzaDescription", "PizzaType" },
                values: new object[] { new Guid("b298ae88-5093-4e10-b559-dd9715ed03f7"), new Guid("1bb1c44f-87ef-46b6-8031-ca09cc419624"), "Normal Cheese Pizza", 0 });

            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "PizzaId", "OrderId", "PizzaDescription", "PizzaType" },
                values: new object[] { new Guid("c12cda48-fa5c-4629-a844-ea8169d77187"), new Guid("d5473fbd-b5d2-427a-8561-0de46b84da4a"), "Extra spicy", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_OrderId",
                table: "Pizza",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizza");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
