using ParserCooking.Ingredients;
using ParserCooking.Interpreters;

namespace ParserCooking.Parsers;

public class IngredientCookingOrderHandler(string token, IngredientBase ingredient) : CookingRecipeTokenHandler(token)
{
    public IngredientBase Ingredient { get; } = ingredient;
    
    public override ICookingOrder? Handle(RecipeTree recipeTree)
    {
        throw new NotImplementedException();
    }
}