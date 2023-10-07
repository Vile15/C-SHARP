using System;
using System.Linq;
using System.Collections.Generic;

namespace Calculadora;

public class Calculadora
{
	public static void Main()
	{
		Console.WriteLine("Escolha um operador:");
		Console.WriteLine("1-Adição");
		Console.WriteLine("2-Subtração");
		Console.WriteLine("3-Multiplicação");
		Console.WriteLine("4-Divisão");
		Console.Write("INSIRA APENAS OS NÚMEROS CORRESPONDENTE AO CALCÚLO DESEJADO:");
		string Opção = Console.ReadLine();

		if (Opção == "1")
		{
			soma();

		}


		else if (Opção == "2")
		{
			menos();

		}

		else if (Opção == " 3")
		{
			vezes();
		}

		else if (Opção == "4")
		{
			dividir();
		}
		else
		{
			Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida (1 a 4).");
		}
	}

	static void Finalizar()
	{
		bool loop = false;
		Console.WriteLine("Deseja continuar utilizando a calculadora? Insira 'S' para 'Sim' e 'N' para 'Não':");
		string Opção = Console.ReadLine();
		if (Opção == "S")
		{
			loop = true;
			while (loop)
			{
				Main();
			}
		}
		else if (Opção == "N")
		{
			Console.WriteLine("Obrigado por utilizar a calculadora.");
			Console.WriteLine("~Ass:Roberto Vile.");
			Console.ReadLine();
		}
		else
		{
			Console.WriteLine("Opção inválinda. Por favor ,insira apenas as opções dadas acima.");
			Finalizar();
		}
	}

	static void soma()
	{
		Console.Write("Insira um Número:");
		string input1 = Console.ReadLine();
		int N1;
		if (!int.TryParse(input1, out N1))
		{
			Console.WriteLine("Você não inseriu um número válido para o primeiro valor.");
			Main();

		}

		Console.Write("Insira outro Número:");
		string input2 = Console.ReadLine();

		int N2;
		if (!int.TryParse(input2, out N2))
		{
			Console.WriteLine("Você não inseriu um número válido para o segundo valor.");

			Main();
		}

		int resultado = N1 + N2;
		Console.WriteLine("O resultado é: " + resultado);

		Finalizar();

	}
	static void menos()
	{
		Console.Write("Insira um Número:");
		string input1 = Console.ReadLine();

		int N1;

		if (!int.TryParse(input1, out N1))
		{
			Console.WriteLine("Você não inseriu um número válido para o primeiro valor.");
			Main();
		}

		Console.Write("Insira outro Número:");

		string input2 = Console.ReadLine();

		int N2;
		if (!int.TryParse(input2, out N2))
		{
			Console.WriteLine("Você não inseriu um número válido para o segundo valor.");
			Main();
		}

		int resultado = N1 - N2;
		Console.WriteLine("O resultado é: " + resultado);

		Finalizar();

	}

	static void vezes()
	{


		Console.Write("Insira um Número:");
		string input1 = Console.ReadLine();

		int N1;
		if (!int.TryParse(input1, out N1))
		{
			Console.WriteLine("Você não inseriu um número válido para o primeiro valor.");
			Main();
		}

		Console.Write("Insira outro Número:");
		string input2 = Console.ReadLine();

		int N2;
		if (!int.TryParse(input2, out N2))
		{
			Console.WriteLine("Você não inseriu um número válido para o segundo valor.");
			Main();
		}

		int resultado = N1 * N2;
		Console.WriteLine("O resultado é: " + resultado);
		Finalizar();
	}





	static void dividir()
	{
		Console.Write("Insira um Número:");

		string input1 = Console.ReadLine();

		int N1;

		if (!int.TryParse(input1, out N1))
		{
			Console.WriteLine("Você não inseriu um número válido para o primeiro valor.");
			Main();
		}

		Console.Write("Insira outro Número:");
		string input2 = Console.ReadLine();

		int N2;
		if (!int.TryParse(input2, out N2))
		{
			Console.WriteLine("Você não inseriu um número válido para o segundo valor.");
			Main();
		}


		int resultado = N1 / N2;
		int resultado2 = N1 % N2;

		Console.WriteLine("O resultado é: " + resultado);
		Console.WriteLine("Cujo o resto é: " + resultado2);

		Finalizar();
	}



}
