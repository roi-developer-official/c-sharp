using System;

namespace chapter3
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        //call the base ctor
        public Text(int color)
            : base(color)
        {

        }
        
        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a Link to" + url);
        }
    }
}
