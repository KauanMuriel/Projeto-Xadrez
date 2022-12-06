﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
	class Peca
	{
		public Posicao Posicao { get; set; }
		public Cor Cor { get; protected set; }
		public int QtdeMovimentos { get; protected set; }
		public Tabuleiro Tabuleiro { get; protected set; }

		public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
		{
			Posicao = posicao;
			Tabuleiro = tab;
			Cor = cor;
			QtdeMovimentos = 0;
		}
	}
}
