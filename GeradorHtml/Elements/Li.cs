using GeradorHtml.Decorators;

namespace GeradorHtml.Elements
{
    public class Li : DecoratorElement
    {
        public override string GetTagName()
        {
            return "li";
        }
    }
}
