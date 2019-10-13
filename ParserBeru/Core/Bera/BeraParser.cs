using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;

namespace ParserBeru.Core.Bera
{
    class BeraParser : IParser<string[]>

    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("h1").Where(item => item.ClassName != null && item.ClassName.Contains("_3TfWusA7bt _26mXJDBxtH"));

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            var prices = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("_23tNgir0Bf pv8IvbZFh- _withAbsoluteDiscount Tuefsruoma"));
            foreach (var price in prices)
            {
                list.Add(price.TextContent);
            }
            return list.ToArray();
        }
    }
}
