using ParserCooking.Interpreters;

namespace ParserCooking.Parsers;

public class CookingRecipeTokenChain : CookingRecipeTokenHandler
{
    private static CookingRecipeTokenChain? _instance;
    public static CookingRecipeTokenChain GetInstance()
        => _instance ??= new CookingRecipeTokenChain();

    private CookingRecipeTokenChain() : base("START")
    {}

    public override ICookingOrder? Handle(RecipeTree recipeTree)
    {
        return HasNext() ? Next!.Handle(recipeTree) : null;
    }
}