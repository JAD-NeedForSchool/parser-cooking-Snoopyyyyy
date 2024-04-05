using ParserCooking.Ingredients.Complex;
using ParserCooking.Operations;

namespace ParserCooking.Interpreters;

public class SimpleOperationCookingOrder(OperationBase operation, ICookingOrder cookingOrder) : ICookingOrder
{
    public void Interpret(CookingRecipeOrder context)
    {
        cookingOrder.Interpret(context);
        context.Ingredient = new ComplexIngredient(operation.Name + "(" + context.Ingredient.Name + ")");
    }
}