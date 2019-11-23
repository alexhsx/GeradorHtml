using GeradorHtml.Decorators;

namespace GeradorHtml.Elements
{
    public class Em : DecoratorElement
    {
        public override string GetTagName()
        {
            return "em";
        }
    }
}
