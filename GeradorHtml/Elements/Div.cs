using GeradorHtml.Decorators;

namespace GeradorHtml.Elements
{
    public class Div : DecoratorElement
    {
        public override string GetTagName()
        {
            return "div";
        }
    }
}
