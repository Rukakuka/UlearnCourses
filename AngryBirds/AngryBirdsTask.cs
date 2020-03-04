using System;

namespace AngryBirds
{
	public static class AngryBirdsTask
	{
		private const double g = 9.81;
		private const double pi = 3.1415926535;
		// Ниже — это XML документация, её использует ваша среда разработки, 
		// чтобы показывать подсказки по использованию методов. 
		// Но писать её естественно не обязательно.
		/// <param name="v">Начальная скорость</param>
		/// <param name="distance">Расстояние до цели</param>
		/// <returns>Угол прицеливания в радианах от 0 до Pi/2</returns>
		public static double FindSightAngle(double v, double distance)
		{
			// S = v0^2/g * sin(2*alpha) =>
			double alpha = 0.5 * Math.Asin(distance * g / (Math.Pow(v, 2)));
			return alpha < 0 ? Double.NaN : alpha < pi / 2 ? alpha : Double.NaN;
		}
	}
}