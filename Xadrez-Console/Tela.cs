using System;
using tabuleiro;

namespace Xadrez_Console
{
	public class Tela
	{
		public static void ImprimirTabuleiro(Tabuleiro tab)
		{
			for(int i = 0; i < tab.Linhas; i++)
			{
				Console.Write(8 - i + " ");
				for(int j = 0; j <tab.Colunas; j++)
				{
					if (tab.Peca(i, j) == null)
					{
						Console.Write("- ");
					}
					else
					{
						ImprimirPeca(tab.Peca(i, j));
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine("  a b c d e f g h");
		}

		public static void ImprimirPeca(Peca peca)
		{
			if(peca.Cor == Cor.Branca)
			{
				Console.Write(peca + " ");
			}
			else
			{
				ConsoleColor aux = Console.ForegroundColor;
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write(peca + " ");
				Console.ForegroundColor = aux;
			}
		}
	}
}
