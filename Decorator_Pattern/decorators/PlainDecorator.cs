using System.ComponentModel;
using System.Data.Common;
using Decorator_Pattern.components;

namespace Decorator_Pattern.decorators;

public class PlainDecorator : Decorator<string>
{
    public PlainDecorator(IComponent<string> component)
        : base(component) { }

    public override string GetText()
    {
        return "I like playing BasketBall" + base.GetText();
    }
}