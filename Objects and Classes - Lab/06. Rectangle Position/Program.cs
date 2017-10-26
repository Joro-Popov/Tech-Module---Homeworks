using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }

        public Rectangle(int T, int L, int W, int H)
        {
            Top = T;
            Left = L;
            Width = W;
            Height = H;
            Right = Math.Abs(Width) + Math.Abs(Left);
            Bottom = Math.Abs(Height) - Math.Abs(Top);
        }
    }
    class Program
    {
        static Rectangle ReadRect()
        {
            List<int> Tokens = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int L = Tokens[0];
            int T = Tokens[1];
            int W = Tokens[2];
            int H = Tokens[3];

            Rectangle Rect = new Rectangle(T, L, W, H);

            return Rect;
        }
        static bool IsInside(Rectangle Rect1, Rectangle Rect2)
        {
            bool isInside = false;

            if (Rect1.Left >= Rect2.Left && 
                Rect1.Right <= Rect2.Right && 
                Rect1.Top <= Rect2.Top && 
                Rect1.Bottom <= Rect2.Bottom)
            {
                isInside = true;
            }

            return isInside;
        }
        static void Main(string[] args)
        {
            Rectangle Rect1 = ReadRect();
            Rectangle Rect2 = ReadRect();

            if (IsInside(Rect1,Rect2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
}
