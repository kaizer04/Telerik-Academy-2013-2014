/*Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

using System;

class CheckPointCircleAndRectangle
{
    static void Main()
    {
        float x;
        float y;
        //float r = 5;
        Console.Write("Enter point`s coordinates:\nx = ");
        x = float.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = float.Parse(Console.ReadLine());
        //z = ((((x >= -2) && (x <= 4)) && ((y >= -2) && (y <= 4))) && ((x * x) + (y * y)) <= 9);
        bool m = (((x <= 5) && (x >= -1)) && ((y <= 1) && (y >= -1)));
        bool z = ((((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 9);
        //Console.WriteLine(((((x >= -2) && (x <= 4)) && ((y >= -2) && (y <= 4))) && (((x - 1) * (x -1)) + ((y - 1) * (y - 1))) <= 9) ? "The point is within a circle K((1,1), 3)" : "The point is not within a circle K((1,1), 3)");
        //Console.WriteLine(((((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 9) ? "The point is within a circle K((1,1), 3)" : "The point is not within a circle K((1,1), 3)");
        //Console.WriteLine("The point is within a circle K((1,1), 3): {0}", z);
        //bool m = (((x > 5) && (x <= -1) && ()) && ((y >= 1) && (y <= -1)));
        Console.WriteLine((!m && z) ? "The point is within a circle K((1,1), 3)" : "The point is not within a circle K((1,1), 3)");
    }
}
