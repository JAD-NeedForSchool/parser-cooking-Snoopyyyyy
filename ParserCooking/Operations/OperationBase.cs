namespace ParserCooking.Operations;

public abstract class OperationBase(string name)
{
    public string Name { get; } = name;
}