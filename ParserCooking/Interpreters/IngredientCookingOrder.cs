using ParserCooking.Ingredients;

namespace ParserCooking.Interpreters;

public class IngredientCookingOrder(IngredientBase ingredient) : ICookingOrder
{
    public void Interpret(CookingRecipeOrder context)
    {
        context.Ingredient = ingredient;
    }
}