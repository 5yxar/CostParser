

namespace ParserBeru.Core.Bera
{
    class BeraSettings : IParserSettings
    {

        public BeraSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "https://beru.ru/product/smartfon-apple-iphone-xr-64gb-chernyi-mry42ru-a/100427327869?show-uid=15709771547496079869706001";
        public string Prefix { get; set; } = "page{CurrentId}";
        public int StartPoint { get ; set ; }
        public int EndPoint { get ; set ; }
    }
}
