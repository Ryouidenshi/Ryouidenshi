using System;

namespace DistanceTask
{
    public static class DistanceTask
    {
        // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            double h = Math.Abs((((bx - ax) * (y - ay)) - ((by - ay) * (x - ax))) / (Math.Sqrt(((bx - ax) * (bx - ax)) + ((by - ay) * (by - ay)))));
            double toFirstDot = Math.Abs(Math.Sqrt(Math.Pow(ax - x, 2) + Math.Pow(ay - y, 2)));
            double toSecondDot = Math.Abs( Math.Sqrt(Math.Pow(bx - x, 2) + Math.Pow(by - y, 2)));
            return Math.Min(toFirstDot, Math.Min(toSecondDot, h));           
        }
    }
}