using System;
namespace Auto
{
	public class Motor
	{
		public static void Starten()
		{
			Console.WriteLine("Motor Starten");
			Benzinpumpe.Pumpen();
			Anlasser.Starten();
			Regeln();
		}

		public static void Regeln()
		{
			for(int i = 0; i < 7; i++)
			{
				Console.WriteLine("Motor regeln");
			}
			Anlasser.Stoppen();
		}
	}
}

