using System;



class Program
{
    static string[] position = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    static void MakeBoard()
    {
        Console.WriteLine($"   {position[1]}  |  {position[2]}  |  {position[3]}   ");
        Console.WriteLine("-------------------");
        Console.WriteLine($"   {position[4]}  |  {position[5]}  |  {position[6]}   ");
        Console.WriteLine("-------------------");
        Console.WriteLine($"   {position[7]}  |  {position[8]}  |  {position[9]}   ");
    }

    static void Main(string[] args)
    {
        bool turn = true;
        int chosenPoint = 0;
        bool endGame = false;
        int menuManager;
        do
        {
            Console.WriteLine("1-play");
            Console.WriteLine("2-author");
            Console.WriteLine("3.exit");
            Console.WriteLine("Give number from 1-3");
            menuManager = Convert.ToInt32(Console.ReadLine());
            if(menuManager == 1 || menuManager == 2 || menuManager == 3)
            {
                break;
            }
        } while (true);
        
        switch (menuManager)
        {
            case 1:
                Console.Clear();
                MakeBoard();
                do
                {
                    do
                    {
                        Console.WriteLine("give number");
                        chosenPoint = Convert.ToInt32(Console.ReadLine());
                        if(chosenPoint == 1 || chosenPoint == 2 || chosenPoint == 3 || chosenPoint == 4 || chosenPoint == 5 || chosenPoint == 6 || chosenPoint == 7 || chosenPoint == 8 || chosenPoint == 9)
                        {
                            break;
                        }
                    } while (true);



                    do
                    {

                        if (position[chosenPoint] != "x" && position[chosenPoint] != "o")
                        {
                            if (turn == true)
                            {
                                position[chosenPoint] = "x";
                            }
                            else
                            {
                                position[chosenPoint] = "o";
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("CellWasAlreadyUsed");
                            Console.WriteLine("give different number");
                            chosenPoint = Convert.ToInt32(Console.ReadLine());
                        }


                    } while (true);


                    //change player turn
                    if (turn == true)
                    {
                        turn = false;
                    }
                    else
                    {
                        turn = true;
                    }

                    Console.Clear();
                    MakeBoard();

                    //endloop(GAME)
                    endGame = WinCon(turn, position);
                    if (endGame)
                    {
                        endGameScript(turn);
                        break;
                    }

                } while (true);


                break;
            case 2:
                Console.Clear();
                Console.WriteLine("o mnie");
                break;
            case 3:
                break;
        }
        
    }


    static bool WinCon(bool who, string[] argument)
    {
        bool winner = false;
        if (argument[1] == argument[5] && argument[9] == argument[5] ||
            argument[3] == argument[5] && argument[5] == argument[7] ||
            argument[1] == argument[4] && argument[4] == argument[7] ||
            argument[2] == argument[5] && argument[5] == argument[8] ||
            argument[3] == argument[6] && argument[6] == argument[9] ||
            argument[1] == argument[2] && argument[2] == argument[3] ||
            argument[4] == argument[5] && argument[5] == argument[6] ||
            argument[7] == argument[8] && argument[8] == argument[9])
        {
            winner = true;
            return winner;
        }
        return winner;
    }

    static void endGameScript(bool whichPlayer)
    {
        if (whichPlayer == true)
        {
            Console.WriteLine("player x won");
            System.Threading.Thread.Sleep(1000);
        }
        else
        {
            Console.WriteLine("player o won");
            System.Threading.Thread.Sleep(1000);
        }
    }

}
