using GeradorHtml.Elements;
using Xunit;

namespace GeradorHtml.Test
{
    public class UnitTest1
    {
        [Fact]
        public void ToHtml()
        {
            var div = new Div();
            var b = new Bold();
            var i = new Italic();
            var span = new Span();

            span.AddAttribute("class", "banana");
            span.AddContent("meu texto estiloso!");
            b.AddElement(i);
            i.AddElement(span);
            div.AddElement(b);

            Assert.Equal("<div><b><i><span class=\"banana\">meu texto estiloso!</span></i></b></div>", div.ToHTML());
        }
    }
}
