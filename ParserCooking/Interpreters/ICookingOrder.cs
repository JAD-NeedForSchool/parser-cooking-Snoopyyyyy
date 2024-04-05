namespace ParserCooking.Interpreters;

public interface ICookingOrder
{
    void Interpret(CookingRecipeOrder context);
}