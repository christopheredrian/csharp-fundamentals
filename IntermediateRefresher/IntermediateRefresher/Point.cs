using System;

namespace IntermediateRefresher
{
    public class Point
    {

        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newPos)
        {
            if (newPos == null)
            {
                throw new ArgumentNullException("Invalid point");
            }
            this.Move(newPos.X, newPos.Y);
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                System.Console.WriteLine($"Point is at ({point.X}, {point.Y})");

                point.Move(100, 200);
                System.Console.WriteLine($"Point is at ({point.X}, {point.Y})");

                point.Move(null);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static void Run()
        {
            
         

        }

    }
}
