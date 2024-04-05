using ParserCooking.Interpreters;
using ParserCooking.Operations.Nary;

namespace ParserCooking.Parsers;

public class NaryOperationCookingOrderHandler(string token, NaryOperation operation) : CookingRecipeTokenHandler(token)
{
    public NaryOperation Operation { get; } = operation;
    
    public override ICookingOrder Handle(RecipeTree recipeTree)
    {
        throw new NotImplementedException();
    }
}