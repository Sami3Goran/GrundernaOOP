namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Circle cirkel1 = new Circle(5.0m);
            decimal firstradie = cirkel1.Getradie();
            Console.WriteLine($"The radius of the first circle is: {firstradie}");

            decimal Cirkel1Area = cirkel1.GetArea();
            Console.WriteLine($"And the Area of the first circle is: {Cirkel1Area:0.00}");

            decimal cirkel1omkrets = cirkel1.GetCircumference();
            Console.WriteLine($"The Circumference of the circle is: {cirkel1omkrets:F2}");

            decimal cirkel1volym = cirkel1.GetVolym();
            Console.WriteLine($"The volym of the circle is: {cirkel1volym:0.000}");

            decimal nyradie = 7;
            cirkel1.radius = nyradie; //använding av set för att ändra radie
            nyradie = cirkel1.Getradie();
            Console.WriteLine($"the new radius of the first circle is now: {nyradie}");

            Console.WriteLine("--------------------------------");

            Circle cirkel2 = new Circle(6);
            decimal secondradie = cirkel2.Getradie();
            Console.WriteLine($"The radius of the second circle is: {secondradie}");

            decimal cirkel2Area = cirkel2.GetArea();
            Console.WriteLine($"And the area of the second circle is: {cirkel2Area:F2}");

            decimal cirkel2omkrets = cirkel2.GetCircumference();
            Console.WriteLine($"The circumference of the circle is: {cirkel2omkrets:F3}");

            decimal circkel2volym = cirkel2.GetVolym();
            Console.WriteLine($"The volym of the circle is: {circkel2volym:0.00}");



            Console.WriteLine("----------------------------------------------------");

            Triangle TriangleOne = new Triangle(2, 3, 4, 5);

            TriangleOne.TriangleMeasurements();
            Console.WriteLine("------------------------------");

            double triangleCircumference = TriangleOne.TriangleCircum();
            Console.WriteLine($"The circumference of the Triangle is: {triangleCircumference}");

            double TriangleArea = TriangleOne.TriangleArea();
            Console.WriteLine($"The Area of the triangle is: {TriangleArea}");

        }
    }
}