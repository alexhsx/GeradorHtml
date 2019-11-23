using GeradorHtml.Elements;
using System;

namespace GeradorHtml
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine(div.ToHTML());

            //ProgramDecorator.MainDecorator(args);
        }
    }
}
