using System;

namespace Triangles
{
    public enum KindTriangle
    {
        Acute,
        Right,
        Obtuse
    }

    public static class Triangle
    {
        public static KindTriangle GetKindTriangle(double a, double b, double c)
        {
            double max;
            double min1;
            double min2;

            if ((a > b) && (a > c))
            {
                max = a;
                min1 = b;
                min2 = c;
            }
            else
            {
                min1 = a;

                if (b > c)
                {
                    max = b;
                    min2 = c;
                }
                else
                {
                    max = c;
                    min2 = b;
                }
            }

            if (min1 + min2 > max)
            {
                var result = Math.Pow(max, 2) - Math.Pow(min1, 2) - Math.Pow(min2, 2);
                if (result < 0)
                    return KindTriangle.Acute;
                else if (result > 0)
                    return KindTriangle.Obtuse;
                else
                    return KindTriangle.Right;
            }
            else
                throw new Exception("Треугольника с такими сторонами не существует");
        }
    }
}
