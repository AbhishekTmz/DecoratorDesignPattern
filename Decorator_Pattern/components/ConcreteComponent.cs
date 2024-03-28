namespace Decorator_Pattern.components;

public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return "Abhishek Tamang";
    }
}