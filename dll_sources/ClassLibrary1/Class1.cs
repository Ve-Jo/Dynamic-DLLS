namespace ClassLibrary1
{
    public class Geometry
    {
        public static double SquareArea(double side)
        {
            return side * side;
        }

        public static double RectangleArea(double width, double height)
        {
            return width * height;
        }

        public static double TriangleArea(double bas, double height)
        {
            return bas * height / 2;
        }
        
    }
}