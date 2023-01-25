using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iPantry.Migrations
{
    public partial class servicesupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientItem_recipes_RecipeId",
                table: "IngredientItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pantryItems",
                table: "pantryItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientItem",
                table: "IngredientItem");

            migrationBuilder.RenameTable(
                name: "pantryItems",
                newName: "PantryItems");

            migrationBuilder.RenameTable(
                name: "IngredientItem",
                newName: "ingredientItems");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientItem_RecipeId",
                table: "ingredientItems",
                newName: "IX_ingredientItems_RecipeId");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "recipes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PantryId",
                table: "PantryItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PantryItems",
                table: "PantryItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ingredientItems",
                table: "ingredientItems",
                column: "id");

            migrationBuilder.CreateTable(
                name: "pantries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pantries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pantries_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_recipes_AccountId",
                table: "recipes",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PantryItems_PantryId",
                table: "PantryItems",
                column: "PantryId");

            migrationBuilder.CreateIndex(
                name: "IX_pantries_AccountId",
                table: "pantries",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_ingredientItems_recipes_RecipeId",
                table: "ingredientItems",
                column: "RecipeId",
                principalTable: "recipes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItems_pantries_PantryId",
                table: "PantryItems",
                column: "PantryId",
                principalTable: "pantries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_recipes_accounts_AccountId",
                table: "recipes",
                column: "AccountId",
                principalTable: "accounts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ingredientItems_recipes_RecipeId",
                table: "ingredientItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PantryItems_pantries_PantryId",
                table: "PantryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_recipes_accounts_AccountId",
                table: "recipes");

            migrationBuilder.DropTable(
                name: "pantries");

            migrationBuilder.DropIndex(
                name: "IX_recipes_AccountId",
                table: "recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PantryItems",
                table: "PantryItems");

            migrationBuilder.DropIndex(
                name: "IX_PantryItems_PantryId",
                table: "PantryItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ingredientItems",
                table: "ingredientItems");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "recipes");

            migrationBuilder.DropColumn(
                name: "PantryId",
                table: "PantryItems");

            migrationBuilder.RenameTable(
                name: "PantryItems",
                newName: "pantryItems");

            migrationBuilder.RenameTable(
                name: "ingredientItems",
                newName: "IngredientItem");

            migrationBuilder.RenameIndex(
                name: "IX_ingredientItems_RecipeId",
                table: "IngredientItem",
                newName: "IX_IngredientItem_RecipeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pantryItems",
                table: "pantryItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientItem",
                table: "IngredientItem",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientItem_recipes_RecipeId",
                table: "IngredientItem",
                column: "RecipeId",
                principalTable: "recipes",
                principalColumn: "Id");
        }
    }
}
