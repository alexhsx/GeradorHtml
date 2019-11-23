using System.Collections.Generic;
using GeradorHtml.Elements;

namespace GeradorHtml.Decorators
{
    public abstract class DecoratorElement : Element
    {
        protected List<Element> _elementContent;

        public DecoratorElement()
        {
            _elementContent = new List<Element>();
        }

        public DecoratorElement AddElement(Element element)
        {
            _elementContent.Add(element);
            return this;
        }

        public override string ToHTML()
        {
            var content = GetTagOpen();
            _elementContent.ForEach(c => content += c.ToHTML());
            content += GetTagClose();
            return content;
        }
    }
}
