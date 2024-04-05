namespace ParserCooking.Ingredients;

public abstract class IngredientBase(string name)
{
    public string Name { get; } = name;
}