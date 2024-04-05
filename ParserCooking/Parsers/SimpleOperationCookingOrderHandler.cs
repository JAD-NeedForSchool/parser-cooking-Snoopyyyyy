using ParserCooking.Interpreters;
using ParserCooking.Operations.Simple;

namespace ParserCooking.Parsers;

public class SimpleOperationCookingOrderHandler(string token, SimpleOperation operation) : CookingRecipeTokenHandler(token)
{
    public SimpleOperation Operation { get; } = operation;
    
    public override ICookingOrder? Handle(RecipeTree recipeTree)
    {
        throw new NotImplementedException();
    }
}