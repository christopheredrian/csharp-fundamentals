using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediateRefresher.ClassAssoc
{
    class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Console copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}
