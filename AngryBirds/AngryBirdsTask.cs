using System;

namespace AngryBirds
{
	public static class AngryBirdsTask
	{
		// Ниже — это XML документация, её использует ваша среда разработки, 
		// чтобы показывать подсказки по использованию методов. 
		// Но писать её естественно не обязательно.
		/// <param name="v">Начальная скорость</param>
		/// <param name="distance">Расстояние до цели</param>
		/// <returns>Угол прицеливания в радианах от 0 до Pi/2</returns>
		public static double FindSightAngle(double v, double distance)
		{
            double g= 9.8;
            double sinAngle = (distance * g) / Math.Pow(v, 2); //Находим через формулу дистанции двойной угол синуса
            double x = Math.Asin(sinAngle); // Возращаем синус в радианы
			return x/2; //Так как угол двойной делим на 2
		}
	}
}