using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			char d = 's';
			while (d == 's')
			{
				Console.WriteLine("Informe 3 números respectivamente:");

				char x = 'a';
				double a = 0;
				double b = 0;
				double c = 0;
				while (x == 'a')
				{
					string ab = Console.ReadLine();
					try
					{
						a = Convert.ToDouble(ab);
						x = 'b';
					}
					catch (FormatException)
					{
						Console.WriteLine("Informe um número válido.");
						x = 'a';
					}
				}
				while (x == 'b')
				{
					string bc = Console.ReadLine();
					try
					{
						b = Convert.ToDouble(bc);
						x = 'a';
					}
					catch (FormatException)
					{
						Console.WriteLine("Informe um numero inteiro válido.");
						x = 'b';
					}
				}
				while (x == 'a')
				{
					string cd = Console.ReadLine();
					try
					{
						c = Convert.ToDouble(cd);
						x = 'b';
					}
					catch (FormatException)
					{
						Console.WriteLine("Informe um numero inteiro válido.");
						x = 'a';
					}
				}

				if (a < b && a < c && b != c)
				{
					Console.WriteLine("O menor numero é o primeiro.");
				}
				else if (b < a && b < c && a != c)
				{
					Console.WriteLine("O menor numero é o segundo.");
				}
				else if (c < b && c < a && b != a)
				{
					Console.WriteLine("O menor numero é o terceiro.");
				}
				else if (a == c && a == b)
				{
					Console.WriteLine("Vejam, é uma TRINCA!");
				}
				else if (a == c)
				{
					Console.WriteLine("O primeiro e o ultimo numero são iguais!");
				}
				else if (a == b)
				{
					Console.WriteLine("O primeiro e o segundo numero são iguais!");
				}
				else
				{
					Console.WriteLine("O ultimo e o segundo numero são iguais!");
				}
				Console.WriteLine("Digite s para continuar:");
				d = Convert.ToChar(Console.ReadLine());
			}
			Console.WriteLine("Até mais!");
			Console.ReadLine();
		}

	}
}
