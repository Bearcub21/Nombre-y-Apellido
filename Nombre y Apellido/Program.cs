using System;

//William Gallardo - 14-2943
namespace Nombre_y_Apellido
{
	class Program
	{
		public static void Main(string[] args)
		{
			string Nombre, Apellido;
			Console.WriteLine("Hola! Mi Nombre es Jarvis. Cual es tu nombre?");
			Nombre= Console.ReadLine();
			Console.WriteLine("Hmmm... Y Cual es tu apellido, " + Nombre + "?");
			Apellido= Console.ReadLine();
			Console.Write("Mucho Gusto, " + Nombre + " " + Apellido + "! Tomaremos el té.");
			Console.ReadKey(true);
		}
	}
}