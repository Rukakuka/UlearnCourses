using System;

namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			var mod100 = count % 100;
			var mod10 = mod100 % 10;

			if (mod10 == 1 && mod100 != 11)
			{
				return "рубль";
			}
			if (mod10 > 1 && mod10 < 5 && (mod100 < 12 || mod100 > 15))
			{
				return "рубля";
			}
			return "рублей";
		}
	}
}