using Decorator_Pattern.components;

namespace Decorator_Pattern.decorators;

public class UpperCaseDecorator : Decorator<string>
{
    public UpperCaseDecorator(IComponent<string> component)
        : base(component) { }

    public override string GetText()
    {
        return base.GetText().ToUpper();
    }
}