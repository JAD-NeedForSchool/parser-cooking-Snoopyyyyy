using ParserCooking.Ingredients.Complex;
using ParserCooking.Operations;

namespace ParserCooking.Interpreters;

public class NaryOperationCookingOrder(OperationBase operation, List<ICookingOrder> cookingOrders) : ICookingOrder
{
    public void Interpret(CookingRecipeOrder context)
    {
        var subIngredients = "";
        foreach (var order in cookingOrders) { 
            var subContext = new CookingRecipeOrder();
            order.Interpret(subContext);
            subIngredients += subContext.Ingredient.Name + " ";
        }
            
        context.Ingredient = new ComplexIngredient(operation.Name + "(" + subIngredients + ")");
    }
}