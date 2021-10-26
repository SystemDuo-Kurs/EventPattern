using System;
using System.Collections.Generic;

namespace EventPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Predavac p1 = new Predavac { _ime = "Pera" };

			Slusaoc s1 = new Slusaoc { _ime = "Neko Nekic" };
			Slusaoc s2 = new Slusaoc { _ime = "Trecko Treckovic" };

			//p1.EventGovor += s1.Cuo;
			//p1.EventGovor += s2.Cuo;

			Diktafon d1 = new();

			//p1.EventGovor += d1.Snimi;

			p1.Govori("asdasd");
			
		}
	}

	class Predavac
	{
		public string _ime;

		public event Action<string> EventGovor;

		public void Govori(string govor)
		{
			Console.WriteLine($"{_ime} kaze: {govor}");
		
			EventGovor?.Invoke(govor);
		}
	}

	class Slusaoc
	{
		public string _ime;
		public void Cuo(string govor)
		{
			Console.WriteLine($"Slusaoc {_ime} cuo: {govor}");
		}
	}

	class Diktafon
	{
		public void Snimi(string govor)
		{
			Console.WriteLine($"Diktafon snimio {govor}");
		}
	}
}
