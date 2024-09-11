﻿using System;
using tabuleiro;
using xadrez;
namespace xadrez_console
{

    class Program
    {
        static void Main(string[] args)
        {

            //PosicaoXadrex pos = new PosicaoXadrex('a',1);
            //Console.WriteLine(pos);
            //Console.WriteLine(pos.toPosicao());
            try
            {

                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 5));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(4, 4));




                Tela.imprimirTabuleiro(tab);

                Console.WriteLine("Posição: " + tab);
            }
            catch (TabuleioExeception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}