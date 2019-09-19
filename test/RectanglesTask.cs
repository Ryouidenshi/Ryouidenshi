using System;

namespace Rectangles
{
    public static class RectanglesTask
    {
        public static bool AreIntersected(Rectangle r1, Rectangle r2)
        {
            return !(r1.Right < r2.Left || r1.Top > r2.Bottom || r1.Left > r2.Right || r1.Bottom < r2.Top);
        }
        public static int IntersectionSquare(Rectangle r1, Rectangle r2)
        {
            int left = Math.Max(r1.Left, r2.Left);
            int right = Math.Min(r1.Right, r2.Right);
            if (AreIntersected(r1, r2))
            {
                if (IndexOfInnerRectangle(r1, r2) == 1)
                    return r2.Width * r2.Height;
                if (IndexOfInnerRectangle(r1, r2) == 0)
                    return r1.Width * r1.Height;
                if (r1.Top - r2.Bottom == 0 && r1.Left - r2.Left == 0 || r2.Top - r1.Bottom == 0 && r1.Left - r2.Left == 0)
                    return 0;
            }
            else
            {
                if (r1.Right < r2.Left || r2.Right < r1.Left)
                    return 0;
                if (IndexOfInnerRectangle(r1, r2) == -1)
                    return 0;
            }
            return Math.Max(right - left, 0);
        }
        public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            if (r1.Left <= r2.Left && r1.Right >= r2.Right && r1.Top <= r2.Top && r1.Bottom >= r2.Bottom)
                return 1;
            else if (r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Top >= r2.Top && r1.Bottom <= r2.Bottom)
                return 0;
            else
                return -1;
        }
    }
}
