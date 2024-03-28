using Decorator_Pattern.components;
using Decorator_Pattern.decorators;

namespace Decorator_Pattern;

class Program
{
    static void Main()
    {
        var concreteComponent = new ConcreteComponent();

        var plainDecorator = new PlainDecorator(concreteComponent);
        var upperCaseDecorator = new UpperCaseDecorator(concreteComponent);
        var colorDecorator = new ColorDecorator(concreteComponent);

        Console.WriteLine($"{plainDecorator.GetText()}");
        Console.WriteLine($"{upperCaseDecorator.GetText()}");
        Console.WriteLine($"{colorDecorator.GetText()}");
    }
}