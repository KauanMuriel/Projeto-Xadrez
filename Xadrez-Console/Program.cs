using System;
using tabuleiro;
using xadrez;
using tabuleiro.Exceptions;

namespace Xadrez_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			PartidaXadrez partida = new PartidaXadrez();

			Tela.ImprimirTabuleiro(partida.Tab);
		}
	}
}
