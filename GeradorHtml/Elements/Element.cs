namespace GeradorHtml.Elements
{
    public abstract class Element
    {
        private string _attributes;

        public abstract string ToHTML();
        public abstract string GetTagName();

        public Element()
        {
            _attributes = string.Empty;
        }

        protected string GetTagOpen()
        {
            return $"<{GetTagName()}{_attributes}>";
        }

        protected string GetTagClose()
        {
            return $"</{GetTagName()}>";
        }

        public void AddAttribute(string attributeName, string attributeValue)
        {
            _attributes += $" {attributeName}=\"{attributeValue}\"";
        }
    }
}
