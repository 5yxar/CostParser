using AngleSharp.Html.Dom;

namespace ParserBeru.Core
{
    interface IParser<T> where T: class
    {
        T Parse(IHtmlDocument document);

    }
}
