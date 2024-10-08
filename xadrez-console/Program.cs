﻿using System;
using tabuleiro;
using xadrez;
namespace xadrez_console
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.ExcutaMovimento(origem, destino);

                }


            }
            catch (TabuleioExeception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}