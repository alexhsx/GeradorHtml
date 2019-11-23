using GeradorHtml.Decorators;

namespace GeradorHtml.Elements
{
    public class Italic : DecoratorElement
    {
        public override string GetTagName()
        {
            return "i";
        }
    }
}
