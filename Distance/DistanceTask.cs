using System;
using System.Drawing;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			double t = ((x-ax)*(bx-ax)+(y-ay)*(by-ay)) / (Math.Pow(bx-ax,2) + Math.Pow(by-ay,2));
			t = t < 0 ? 0 : t < 1 ? t : 1;
			return Math.Sqrt(Math.Pow(ax-x+t*(bx-ax),2) + Math.Pow(ay - y + t * (by - ay), 2));
		}
	}
}