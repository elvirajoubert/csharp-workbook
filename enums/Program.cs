using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Enum.GetValues(typeof(System.DayOfWeek)))
            {
                var enumMonth = (DayOfWeek)item;
                var point = new System.Drawing.Point(0, 0);
                point = new System.Drawing.Point(5, 5);
                point.X = point.X * point.X;
                Console.WriteLine();

                Console.WriteLine(enumMonth.ToString());
                
            }
        
    
        }

    public struct StructPoint
        {
            public StructPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int X { get; set; }

            public int Y { get; set; }

            //public object MyObject { get; set; }
        }

    }
}

