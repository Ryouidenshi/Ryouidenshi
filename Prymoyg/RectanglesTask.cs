using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)

		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
            
            // так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
			return !(r1.Right<r2.Left || r1.Top>r2.Bottom || r1.Left>r2.Right || r1.Bottom<r2.Top);
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
            if (AreIntersected(r1,r2))
            {
                if (IndexOfInnerRectangle(r1,r2)==1)                
                    return r2.Width * r2.Height;
                if (IndexOfInnerRectangle(r1, r2) == 0)
                    return r1.Width * r1.Height;
            }
            else
                return Math.Abs(r2.Right - r1.Right) * Math.Abs(r2.Top - r1.Top);
            return 0;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
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