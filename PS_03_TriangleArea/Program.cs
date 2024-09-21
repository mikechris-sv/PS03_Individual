using System.Runtime.InteropServices;

namespace PS_03_TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first side of a triangle: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Enter second side of a triangle: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Enter third side of a triangle: ");
            float c = float.Parse(Console.ReadLine());


            HeronFormula(a, b, c);


        }

        static void HeronFormula(float a, float b, float c)
        {
            float s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"The area of the three sides of a triangle is: {area:F2}");
        }
    }
}
