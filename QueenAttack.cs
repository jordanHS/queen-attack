using System; 
using System.Collections.Generic;

class Queen
{
    public static bool canAttack(int queenX, int queenY, int compX, int compY)
    {   
        // vertucal and hrizontal
        if (queenX == compX || queenY == compY)
        {
            return true;
        }
        // diagnal
        else if (Math.Abs(queenX - compX) == Math.Abs(queenY - compY))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static Dictionary<string, int> xCoordinates = new Dictionary<string, int>() { {"A", 1}, {"B", 2}, {"C", 3}, {"D", 4} };
    static void Main()
    {
       Console.WriteLine("Please enter vertical coordinate for Queen, (A - D).");
       string userInput = Console.ReadLine();
       int queenX = xCoordinates[userInput];

       Console.WriteLine("Please enter horizontal coordinate for Queen, (1 - 4).");
       int queenY = int.Parse(Console.ReadLine());

       Console.WriteLine("Please enter vertical coordinate for Computer, (A - D).");
       userInput = Console.ReadLine();
       int compX = xCoordinates[userInput];

       Console.WriteLine("Please enter horizontal coordinate for Computer, (1 - 4)");
       int compY = int.Parse(Console.ReadLine());
       
       bool result = canAttack(queenX, queenY, compX, compY);
       if(result)
       {
           Console.WriteLine("The Queen attacked!");
       }
       else
       {
           Console.WriteLine("The Queen didn't attack.");
       }
    }
}

