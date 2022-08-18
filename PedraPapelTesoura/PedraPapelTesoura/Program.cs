using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesoura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int scoreJogador = 0;
            int scoreJogador2 = 0;

            Console.WriteLine("Bem vindo ao Jogo Pedra Papel Tesoura!");

            while(scoreJogador != 3 && scoreJogador2 != 3)
            {
                Console.WriteLine("Score do jogador 1 :" + scoreJogador + "." + "Score do Jogador 2: " + scoreJogador2);
                Console.WriteLine("Entre com 'r' para PEDRA, 'p' para PAPEl ou qualquer outra opção para tesoura");

                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);    
            
                if(enemyChoice == 0)
                {
                    Console.WriteLine("O Jogador 2 escolheu pedra");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Empate");
                            break;
                        case "p":
                            Console.WriteLine("O jogador 1 ganhou");
                            scoreJogador++;
                            break;
                        default:
                            Console.WriteLine("O jogador 2 ganhou esse round");
                            scoreJogador2++;
                            break;
                    }

                }
                else if(enemyChoice == 1)
                {
                    Console.WriteLine("O Jogador 2 escolheu papel");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("O jogador 2 ganhou esse jogo");
                            scoreJogador2++;
                            break;
                        case "p":
                            Console.WriteLine("Empate");
                            break;
                        default:
                            Console.WriteLine("O jogador 1 ganhou essse round");
                            scoreJogador++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("O Jogador 2 escolheu tesoura");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("O jogador 1 ganhou esse round");
                            scoreJogador++;
                            break;
                        case "p":
                            Console.WriteLine("O jogador 2 ganhou esse round");
                            scoreJogador2++;
                            break;
                        default :
                            Console.WriteLine("Empate");
                            break;
                    }

                }
            }

            if (scoreJogador == 3)
            {
                Console.WriteLine("Jogador 1 venceu");
            }
            else
            {
                Console.WriteLine("Jogador 2 venceu");
            }


        }
    }
}
