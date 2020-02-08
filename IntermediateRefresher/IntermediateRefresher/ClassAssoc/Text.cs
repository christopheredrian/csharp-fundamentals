using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediateRefresher.ClassAssoc
{
    class Text: PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("Add link to url" + url);
        }
    }
}
