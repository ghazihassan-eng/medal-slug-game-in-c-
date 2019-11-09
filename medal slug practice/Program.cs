using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace medal_slug_practice
{
    class Program
    {
        static void Main(string[] args)
        {

           
           

           
                Console.WriteLine("PRESS ANY KEY TO START GAME");
                string click = Console.ReadLine();
                int x = 50;
                int x1 = 19;
                int health1 = 50;

                
                int health2 = 50;

                int bullets = 6;

                string arrow = "";

                int j = 2;
                
                for (int i = 0; ; i++)
                {
                     

                    Random r = new Random();
                    int rnd = r.Next(1, 5);

                    Random rd = new Random();
                    int rndm = rd.Next(1, 5);

                    Console.SetCursorPosition(25, 1);
                    Console.WriteLine(" health of user :" + health1);

                    Console.SetCursorPosition(25, 2);
                    Console.WriteLine(" health of robot :" + health2);
                    if (x < 5)
                    {
                        if (j <= 0)
                        {
                            health1 -= rnd;
                        }
                    }

                    if (health1 <= 0)
                    {
                        Console.SetCursorPosition(25, 10);
                        Console.WriteLine("ROBOT WIN THE GAME"); break;
                    }
                    if (health2 <= 0)
                    {
                        Console.SetCursorPosition(25, 10);
                        Console.WriteLine("USER WIN THE GAME"); break;
                    }
                    if (x < 5)
                    {
                        x = 50;
                    }
                    if (x1 > 53)
                    {
                        health2 -= rndm;
                        bullets--;

                        x1 = 19;

                    }

                   
                        if (x < 6)
                        {
                            j --;
                           
                        }
                        else if (j == 0)
                        {
                            Console.WriteLine("for life jacket press s");
                            string e = Console.ReadLine();
                            if (e == "s")
                            {
                                j = 2;
                            }
                            else if (e != "s")
                            {
                                j = 0;
                            }
                        }
                        else if (j < 0)
                        {
                            j = 0;
                        }
                   
                   
                    
                    Console.SetCursorPosition(3, 8);
                    Console.WriteLine("USER");
                    Console.SetCursorPosition(3, 9);
                    Console.WriteLine("life jacket :{0}",j);
                   
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("  ______");
                    Console.WriteLine(" | o  o |");
                    Console.WriteLine(" |______|");
                    Console.WriteLine("     |_____|------>");
                    Console.WriteLine("     |-----|o");
                    Console.WriteLine("     |");
                    Console.WriteLine("    / \\");



                    if (bullets > 0)
                    {

                        Console.SetCursorPosition(x1, 13);
                        Console.WriteLine("-");
                        Console.WriteLine();
                        x1++;


                    }
                    else
                    {
                        Console.WriteLine("RELOAD GUN, PRESS W");
                        arrow = Console.ReadLine();
                        if (arrow == "w")
                        {



                            Console.SetCursorPosition(0, 10);
                            Console.WriteLine("  ______");
                            Console.WriteLine(" | o  o |");
                            Console.WriteLine(" |______|");
                            Console.WriteLine("     |_____|------>");
                            Console.WriteLine("     |-----|o");
                            Console.WriteLine("     |");
                            Console.WriteLine("    / \\");
                            Console.Clear();

                            Console.SetCursorPosition(0, 5);
                            Console.WriteLine("  ______");
                            Console.WriteLine(" | o  o |");
                            Console.WriteLine(" |______|");
                            Console.WriteLine("     |_____|------>");
                            Console.WriteLine("     |-----|o");
                            Console.WriteLine("     |");
                            Console.WriteLine("    / \\");


                            bullets = 6;
                            Console.SetCursorPosition(x1, 13);
                            Console.WriteLine("-");
                            Console.WriteLine();

                            x1++;



                        }


                    }

                    Console.SetCursorPosition(55, 8);
                    Console.WriteLine("ROBOT");
                    Console.SetCursorPosition(50, 10);
                    Console.WriteLine("        ______");
                    Console.SetCursorPosition(50, 11);
                    Console.WriteLine("       | o  o | ");
                    Console.SetCursorPosition(50, 12);
                    Console.WriteLine("       |______| ");
                    Console.SetCursorPosition(50, 13);
                    Console.WriteLine(" <____-----|    ");
                    Console.SetCursorPosition(50, 14);
                    Console.WriteLine("     |-----|    ");
                    Console.SetCursorPosition(50, 15);
                    Console.WriteLine("           |    ");
                    Console.SetCursorPosition(50, 16);
                    Console.WriteLine("          / \\  ");
                    Console.SetCursorPosition(50, 17);



                    Console.SetCursorPosition(x, 13);
                    Console.WriteLine("=");
                    x--;

                    Console.ReadLine();
                    Console.Clear();



                }



                Console.WriteLine();
                Console.WriteLine();
                Console.SetCursorPosition(30, 12);
                Console.WriteLine(" game over");
                Console.ReadLine();
            }

        }
}
            















































