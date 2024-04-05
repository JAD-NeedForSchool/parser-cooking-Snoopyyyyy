using ParserCooking.Ingredients;
using ParserCooking.Ingredients.Basic;

namespace ParserCooking.Interpreters;

public class CookingRecipeOrder() {
    public IngredientBase Ingredient { get; set; } = new BasicIngredient("");
}