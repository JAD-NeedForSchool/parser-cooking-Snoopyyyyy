using ParserCooking.Interpreters;

namespace ParserCooking.Parsers;

public abstract class CookingRecipeTokenHandler(string token, CookingRecipeTokenHandler? next = null)
{
   public string Token { get; set; } = token;
   protected CookingRecipeTokenHandler? Next { get; } = next;
   protected bool HasNext()
       => Next is not null;

   public abstract ICookingOrder? Handle(RecipeTree recipeTree);
}