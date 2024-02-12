using System;
namespace Auto
{
	public class Auto
	{
		public void Anlassen()
		{
			while (true)
			{
				string op = Console.ReadLine();
				if (op == "Auto anlassen")
				{
					Motor.Starten();
				}
				else
				{
					Console.WriteLine("Unbekannter Befehl");
				}
			}
		}
	}
}

