using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			return r1.Left <= r2.Right && r1.Right >= r2.Left && r1.Bottom >= r2.Top && r1.Top <= r2.Bottom;
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			bool intersects = AreIntersected(r1, r2);

			if (!intersects)
				return 0;
			
			int[] xarr = { r1.Left, r1.Right, r2.Left, r2.Right };
			int[] yarr = { r1.Top, r1.Bottom, r2.Top, r2.Bottom };

			Array.Sort(xarr);
			Array.Sort(yarr);

			return (xarr[2] - xarr[1]) * (yarr[2] - yarr[1]);
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			if (CheckInner(r2, r1))
				return 0;
			if (CheckInner(r1, r2))
				return 1;
			return -1;

			bool CheckInner(Rectangle R1, Rectangle R2) => // lambda
				(R2.Left >= R1.Left &&
				 R2.Right <= R1.Right &&
				 R2.Bottom <= R1.Bottom &&
				 R2.Top >= R1.Top);
		}
	}
}