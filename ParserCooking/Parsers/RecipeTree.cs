namespace ParserCooking.Parsers;

public class RecipeTree(string token)
{
    public string Token { get; set; } = token;
    public List<RecipeTree> SubRecipes { get; } = [];

    public void AddSubRecipes(RecipeTree recipeTree)
        => SubRecipes.Add(recipeTree);
}