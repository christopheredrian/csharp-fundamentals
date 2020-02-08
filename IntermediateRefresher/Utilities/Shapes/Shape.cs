using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Shapes
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        public ShapeType Type { get; set; }

        public abstract void Draw();
    }
}
