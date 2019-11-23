namespace GeradorHtml.Elements
{
    public class Span : Element
    {
        private string _content;

        public Span() 
        {
            _content = string.Empty;
        }

        public void AddContent(string content)
        {
            _content = content;
        }

        public override string ToHTML()
        {
            return GetTagOpen() + _content + GetTagClose();
        }

        public override string GetTagName()
        {
            return "span";
        }
    }
}
