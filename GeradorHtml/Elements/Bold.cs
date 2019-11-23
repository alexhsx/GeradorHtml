using GeradorHtml.Decorators;

namespace GeradorHtml.Elements
{
    public class Bold : DecoratorElement
    {
        public override string GetTagName()
        {
            return "b";
        }
    }
}
