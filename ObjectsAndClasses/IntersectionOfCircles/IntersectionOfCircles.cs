namespace IntersectionOfCircles
{
    using System;
    using System.Linq;

    public class IntersectionOfCircles
    {
        public static void Main()
        {
            Circle firstCircle = ReadCircle();
            Circle secondCircle = ReadCircle();

            double distanceBetweenCirclesCenters = EuclideanDistance(firstCircle, secondCircle);
            double radiusesSum = firstCircle.Radius + secondCircle.Radius;

            if (distanceBetweenCirclesCenters > radiusesSum)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }

        public static Circle ReadCircle()
        {
            var tokens = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Circle circle = new Circle();

            circle.Center = new Point
            {
                X = tokens[0],
                Y = tokens[1]
            };

            circle.Radius = tokens[2];

            return circle;
        }

        public static double EuclideanDistance(Circle firstCircle, Circle secondCircle)
        {
            double diffX = secondCircle.Center.X - firstCircle.Center.X;
            double diffY = secondCircle.Center.Y - firstCircle.Center.Y;

            double powX = Math.Pow(diffX, 2);
            double powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}
