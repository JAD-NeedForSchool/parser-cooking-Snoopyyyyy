using ParserCooking.Ingredients.Basic;
using ParserCooking.Interpreters;
using ParserCooking.Operations.Nary;
using ParserCooking.Operations.Simple;

var context = new CookingRecipeOrder();

// Ingredients
var egg = new BasicIngredient("Egg");
var mustard = new BasicIngredient("Mustard");
var vinegar = new BasicIngredient("Vinegar");
var oil = new BasicIngredient("Oil");

// Opérations
var extractYellow = new SimpleOperation("ExtractYellow");
var blend = new NaryOperation("Blend");
var add = new NaryOperation("Add");
var mix = new SimpleOperation("Mix");

ICookingOrder takeYellowOrder = new SimpleOperationCookingOrder(extractYellow, new IngredientCookingOrder(egg));
ICookingOrder mixOrder = new NaryOperationCookingOrder(blend, [
    takeYellowOrder,
    new IngredientCookingOrder(mustard),
    new IngredientCookingOrder(vinegar),
]);
ICookingOrder addOrder = new NaryOperationCookingOrder(add, [ mixOrder, new IngredientCookingOrder(oil)]);

ICookingOrder mayonnaiseRecipe = new SimpleOperationCookingOrder(mix, addOrder);

var mayonnaiseOrder = new CookingRecipeOrder();

mayonnaiseRecipe.Interpret(mayonnaiseOrder);

Console.WriteLine(mayonnaiseOrder.Ingredient.Name);