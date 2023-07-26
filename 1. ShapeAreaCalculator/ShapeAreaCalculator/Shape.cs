namespace ShapeAreaCalculator
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        double Radius { get; set; }
        /// <summary>
        /// Calculates the area of circle based on radius.
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
        /// <summary>
        /// Creates Circle object based on radius
        /// </summary>
        /// <param name="radius">Radius</param>
        public Circle(double radius)
        {
            if (radius <= 0) throw new ShapeArgumentException("Not a Circle. Diametr are 0 or less");
            this.Radius = radius;
        }
    }
    public class Triangle : IShape
    {

        double[] sides;

        double A
        {
            get
            {
                return sides[0];
            }
        }
        double B
        {
            get
            {
                return sides[1];
            }
        }
        double C
        {
            get
            {
                return sides[2];
            }
        }
        /// <summary>
        /// Indicates whether triangle is right or not
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            if (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2)) return true;
            else return false;

        }
        /// <summary>
        /// Calculates the area of triangle based on sides lenghts.
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            if (IsRight())
            {
                return A * B / 2;
            }
            else
            {
                var p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
        /// <summary>
        /// Create Triangle object based on sides lenghts.
        /// </summary>
        /// <param name="a">Side 1</param>
        /// <param name="b">Side 2</param>
        /// <param name="c">Side 3</param>
        public Triangle(double a, double b, double c)
        {
            if (IsTriangle(a, b, c))
            {
                sides = new double[] { a, b, c };
                Array.Sort(sides);
            }
            else throw new ShapeArgumentException("Not a triangle. One of the sides are bigger than sum of other ones.");
        }
        static bool IsTriangle(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a) return false;
            else return true;
        }
    }
    public class ShapeArgumentException : Exception
    {
        public ShapeArgumentException(string message)
            : base(message) { }
    }
}