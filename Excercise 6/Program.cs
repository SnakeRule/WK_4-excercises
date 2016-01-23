using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] book = new Book[10];
            Game[] game = new Game[10];
            GameConsole[] gameconsole = new GameConsole[10];
            int i = 0, o = 0, u = 0;
            bool loop = true;
            int input;
            do
            {
                Console.WriteLine("Bookcase Menu");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Add game");
                Console.WriteLine("3. Add console");
                Console.WriteLine("4. Show bookcase contents");
                Console.WriteLine("5. Quit");

                input = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (input)
                {
                    case 1:
                        {
                            book[i] = new Book();
                            book[i].EnterData();
                            book[i].EnterDataBook();
                            i++;
                            if (i >= 10)
                                i = 0;
                            break;
                        }

                    case 2:
                        {
                            game[o] = new Game();
                            game[o].EnterData();
                            game[o].EnterDataGame();
                            o++;
                            if (o >= 10)
                                o = 0;
                            break;
                        }

                    case 3:
                        {
                            gameconsole[u] = new GameConsole();
                            gameconsole[u].EnterData();
                            gameconsole[u].EnterDataGameConsole();
                            u++;
                            if (u >= 10)
                                u = 0;
                            break;
                        }

                    case 4:
                        {
                            for (int y = 0; y < 10; y++)
                            {
                                if (book[y] == null)
                                    break;
                                else
                                {
                                    book[y].PrintData();
                                    book[y].PrintDataBook();
                                    Console.WriteLine();
                                }
                            }
                            for (int y = 0; y < 10; y++)
                            {
                                if (game[y] == null)
                                    break;
                                else
                                {
                                    game[y].PrintData();
                                    game[y].PrintDataGame();
                                    Console.WriteLine();
                                }
                                    
                            }
                            for (int y = 0; y < 10; y++)
                            {
                                if (gameconsole[y] == null)
                                    break;
                                else
                                {
                                    gameconsole[y].PrintData();
                                    gameconsole[y].PrintDataGameConsole();
                                    Console.WriteLine();
                                }
                            }
                            break;
                        }
                }
            } while (loop == true);
        }
    }
}
