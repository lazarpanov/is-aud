using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShopApplication.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedOrder3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrder_Orders_OrderId",
                table: "ProductInOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrder_Product_ProductId",
                table: "ProductInOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCart_Product_ProductId",
                table: "ProductInShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCart_ShoppingCarts_ShoppingCartId",
                table: "ProductInShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInShoppingCart",
                table: "ProductInShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInOrder",
                table: "ProductInOrder");

            migrationBuilder.RenameTable(
                name: "ProductInShoppingCart",
                newName: "ProductInShoppingCarts");

            migrationBuilder.RenameTable(
                name: "ProductInOrder",
                newName: "ProductInOrders");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCart_ShoppingCartId",
                table: "ProductInShoppingCarts",
                newName: "IX_ProductInShoppingCarts_ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCart_ProductId",
                table: "ProductInShoppingCarts",
                newName: "IX_ProductInShoppingCarts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInOrder_ProductId",
                table: "ProductInOrders",
                newName: "IX_ProductInOrders_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInOrder_OrderId",
                table: "ProductInOrders",
                newName: "IX_ProductInOrders_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInOrders",
                table: "ProductInOrders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Orders_OrderId",
                table: "ProductInOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Product_ProductId",
                table: "ProductInOrders",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_Product_ProductId",
                table: "ProductInShoppingCarts",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_ShoppingCartId",
                table: "ProductInShoppingCarts",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Orders_OrderId",
                table: "ProductInOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Product_ProductId",
                table: "ProductInOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_Product_ProductId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_ShoppingCartId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInOrders",
                table: "ProductInOrders");

            migrationBuilder.RenameTable(
                name: "ProductInShoppingCarts",
                newName: "ProductInShoppingCart");

            migrationBuilder.RenameTable(
                name: "ProductInOrders",
                newName: "ProductInOrder");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCarts_ShoppingCartId",
                table: "ProductInShoppingCart",
                newName: "IX_ProductInShoppingCart_ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCarts_ProductId",
                table: "ProductInShoppingCart",
                newName: "IX_ProductInShoppingCart_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInOrders_ProductId",
                table: "ProductInOrder",
                newName: "IX_ProductInOrder_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInOrders_OrderId",
                table: "ProductInOrder",
                newName: "IX_ProductInOrder_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInShoppingCart",
                table: "ProductInShoppingCart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInOrder",
                table: "ProductInOrder",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrder_Orders_OrderId",
                table: "ProductInOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrder_Product_ProductId",
                table: "ProductInOrder",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCart_Product_ProductId",
                table: "ProductInShoppingCart",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCart_ShoppingCarts_ShoppingCartId",
                table: "ProductInShoppingCart",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
