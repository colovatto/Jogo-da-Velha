namespace JogoDaVelha
{
    internal class Program
    {
        public static void tabelaJogo(string[,] jogoVelha)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" [{jogoVelha[i, j]}] ");
                }
                Console.WriteLine();
            }
        }

        public static int validaPosicao()
        {
            while (true)
            {
                int posicao;
                Console.WriteLine("Escolha onde deseja colocar sua marcação");
                posicao = int.Parse(Console.ReadLine());
                ;

                if (posicao < 1 || posicao > 9)
                {
                    Console.Clear();
                    Console.WriteLine("INFORME UM POSIÇÃO VÁLIDA!!!");
                    continue;

                }

                else
                {
                    return posicao;

                }
            }

        }

        public static bool Vencedor(string[,] jogoVelha)
        {
            //vertical X

            if (jogoVelha[0, 0] == "X" && jogoVelha[1, 0] == "X" && jogoVelha[2, 0] == "X")
            {
                Console.WriteLine("Vencedor é X");
                return true;

            }
            else if (jogoVelha[0, 1] == "X" && jogoVelha[1, 1] == "X" && jogoVelha[2, 1] == "X")
            {
                Console.WriteLine("Vencedor é X");
                return true;

            }
            else if (jogoVelha[0, 2] == "X" && jogoVelha[1, 2] == "X" && jogoVelha[2, 2] == "X")
            {
                Console.WriteLine("Vencedor é X");
                return true;
            }

            //vertical 0
            if (jogoVelha[0, 0] == "0" && jogoVelha[1, 0] == "0" && jogoVelha[2, 0] == "0")
            {
                Console.WriteLine("Vencedor é 0");
                return true;
            }
            else if (jogoVelha[0, 1] == "0" && jogoVelha[1, 1] == "0" && jogoVelha[2, 1] == "0")
            {
                Console.WriteLine("Vencedor é 0");
                return true;
            }
            else if (jogoVelha[0, 2] == "0" && jogoVelha[1, 2] == "0" && jogoVelha[2, 2] == "0")
            {
                Console.WriteLine("Vencedor é 0");
                return true;
            }

            //horizontal X
            else if (jogoVelha[0, 0] == "X" && jogoVelha[0, 1] == "X" && jogoVelha[0, 2] == "X")
            {
                Console.WriteLine("Vencedor é X");
                return true;
            }
            else if (jogoVelha[1, 0] == "X" && jogoVelha[1, 1] == "X" && jogoVelha[1, 2] == "X")
            {
                Console.WriteLine("Vencedor é X");
                return true;
            }
            else if (jogoVelha[2, 0] == "X" && jogoVelha[2, 1] == "X" && jogoVelha[2, 2] == "X")
            {
                Console.WriteLine("Vencedor é X");
                return true;
            }

            //horizontal 0

            else if (jogoVelha[0, 0] == "0" && jogoVelha[0, 1] == "0" && jogoVelha[0, 2] == "0")
            {
                Console.WriteLine("Vencedor é 0");
                return true;
            }
            else if (jogoVelha[1, 0] == "0" && jogoVelha[1, 1] == "0" && jogoVelha[1, 2] == "0")
            {
                Console.WriteLine("Vencedor é 0");
                return true;
            }
            else if (jogoVelha[2, 0] == "0" && jogoVelha[2, 1] == "0" && jogoVelha[2, 2] == "0")
            {
                Console.WriteLine("Vencedor é 0");
                return true;
            }

            //diagonal x

            else if (jogoVelha[0, 0] == "X" && jogoVelha[1, 1] == "X" && jogoVelha[2, 2] == "X")
            {
                Console.WriteLine("Vencedor é X");
                return true;
            }
            else if (jogoVelha[0, 2] == "X" && jogoVelha[1, 1] == "X" && jogoVelha[2, 0] == "X")
            {
                Console.WriteLine("Vencedor é X");
                return true;
            }

            //diagonal 0

            else if (jogoVelha[0, 0] == "0" && jogoVelha[1, 1] == "0" && jogoVelha[2, 2] == "0")
            {
                Console.WriteLine("Vencedor é 0");
                return true;
            }
            else if (jogoVelha[0, 2] == "0" && jogoVelha[1, 1] == "0" && jogoVelha[2, 0] == "0")
            {
                Console.WriteLine("Vencedor é 0");
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            string[,] jogoVelha = new string[3, 3];

            int i, j, posicao;
            int visualizador = 1;
            string player1, player2;
            string selecao;
            int rodadas = 0;
            int contP1 = 0;
            bool fim;


            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    jogoVelha[i, j] = visualizador.ToString();
                    visualizador++;
                }
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("BEM VINDO JOGADOR");

            while (true)
            {
                Console.WriteLine("SELECIONE X OU 0 PARA INICIAR");
                selecao = Console.ReadLine();
                if (selecao == "X")
                {
                    player1 = selecao;
                    player2 = "0";
                    break;
                }
                else if (selecao == "0")
                {
                    player1 = selecao;
                    player2 = "X";
                    break;
                }
                else
                {
                    continue;
                }

            }

            tabelaJogo(jogoVelha);


            for (; ; )
            {

                posicao = validaPosicao();

                Console.Clear();

                if (contP1 % 2 == 0)
                {
                    Console.WriteLine("Player 2 " + player2);

                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {

                            if ((posicao.ToString() == jogoVelha[i, j]))
                            {

                                jogoVelha[i, j] = player1.ToString();
                                tabelaJogo(jogoVelha);
                                contP1++;
                            }

                        }
                    }

                }


                else
                {
                    Console.WriteLine("Player 1 " + player1);
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {

                            if ((posicao.ToString() == jogoVelha[i, j]))
                            {

                                jogoVelha[i, j] = player2.ToString();
                                tabelaJogo(jogoVelha);
                                contP1++;
                            }

                        }
                    }

                }


                fim = Vencedor(jogoVelha);
                if (fim)
                {
                    break;
                }
                else if (fim == false && contP1 == 9) 
                {
                    contP1 = 0;
                    visualizador = 1;
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            
                            jogoVelha[i, j] = visualizador.ToString();
                            visualizador++;
                        }
                        Console.WriteLine();
                    }
                    Console.Clear();
                    Console.WriteLine("BEM VINDO JOGADOR");

                    while (true)
                    {
                        Console.WriteLine("SELECIONE X OU 0 PARA INICIAR");
                        selecao = Console.ReadLine();
                        if (selecao == "X")
                        {
                            player1 = selecao;
                            player2 = "0";
                            break;
                        }
                        else if (selecao == "0")
                        {
                            player1 = selecao;
                            player2 = "X";
                            break;
                        }
                        else
                        {
                            continue;
                        }

                    }

                    tabelaJogo(jogoVelha);
                }

            }

        }
    }
}
