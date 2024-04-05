using ParserCooking.Ingredients.Basic;
using ParserCooking.Interpreters;

namespace ParserCooking.Parsers;

public class CookingRecipeParser
{
    private const char OpenCharacter = '(';
    private const char CloseCharacter = ')';
    private const char SeparatorCharacter = ' ';
    
    public static ICookingOrder Parse(string recipeText)
    {
        var tree = TextToTree(recipeText);
        return TreeToOrder(tree);
    }

    // Touiller(Ajouter(Mélanger(PrendreJaune(Oeuf) Moutarde Vinaigre) Huile))
    private static RecipeTree TextToTree(string recipeText)
    {
        var root = new RecipeTree("");
        var openCount = 0;
        var closeCount = 0;
        var lastSeparatorIndex = 0;
        
        for (var i = 0; (i < recipeText.Length) && (openCount + closeCount >= 0); i++)
        {
            switch (recipeText[i])
            {
                case OpenCharacter:
                    if (openCount == closeCount) 
                        lastSeparatorIndex = i + 1;
                    openCount++;
                    break;
                case CloseCharacter:
                    closeCount++;
                    if(openCount == closeCount) 
                        root.AddSubRecipes(TextToTree(recipeText.Substring(lastSeparatorIndex, i - lastSeparatorIndex + 1)));
                    break;
                case SeparatorCharacter:
                    if (openCount == (closeCount + 1)) {
                        root.AddSubRecipes(TextToTree(recipeText.Substring(lastSeparatorIndex, i - lastSeparatorIndex + 1)));
                        lastSeparatorIndex = i + 1;
                    }
                    break;
                default:
                    if (openCount == closeCount) root.Token += recipeText[i];
                    break;
            }
        }
        return root;
    }

    private static ICookingOrder TreeToOrder(RecipeTree tree)
    {
        return new IngredientCookingOrder(new BasicIngredient(""));
    }
}
