using GeradorHtml.Decorators;

namespace GeradorHtml.Elements
{
    public class Ul : DecoratorElement
    {
        public override string GetTagName()
        {
            return "ul";
        }
    }
}
