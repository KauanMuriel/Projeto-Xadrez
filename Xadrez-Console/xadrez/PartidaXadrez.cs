using System;
using tabuleiro;

namespace xadrez
{
	public class PartidaXadrez
	{
		public Tabuleiro Tab;
		private int Turno;
		private Cor JogadorAtual;

		public PartidaXadrez()
		{
			Tab = new Tabuleiro(8, 8);
			Turno = 1;
			JogadorAtual = Cor.Branca;

			ColocarPecas();
		}

		public void ExecutaMovimento(Posicao origem, Posicao destino)
		{
			Peca p = Tab.RetirarPeca(origem);
			p.IncrementarQttMovimentos();
			Peca capturada = Tab.RetirarPeca(destino);
			Tab.ColocarPeca(p, destino);
		}

		private void ColocarPecas()
		{
			Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
			Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
			Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
			Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
			Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
			Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());

			Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
			Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
			Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
			Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
			Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());
			Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());
		}
	}
}
