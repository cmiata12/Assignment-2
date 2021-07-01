using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)


        // Declare variables. Start writing your code here


        public static
            Dictionary<int, string> guests = new Dictionary<int, string>();
        int min = 1000;
        int max = 9999;
        int raffleNumber;
        Random _rdm = new Random();

        Console.WriteLine("Welcome to the Party!!");
                GetUserInfo();
        PrintGuestsName();
        PrintWinner();

        // 1. Method that retruns a string and name.

        static string GetUserInput(string message)
        {
            Console.Write(message);
            string name = Console.ReadLine();
            return name; //this is what the program should put out. 
        }

        //2. Create a method that returns nothing and name it GetUserInfo():

        static void GetUserInfo();

        string yesOrNo;

        do
        {
         raffleName = GetUserInput("Please enter your name: ");
        yesOrNo = GetUserInput("Do yo want to add another name? ").ToLower();
        nameToAdd = raffleName;
         raffleNumber = GenerateRandomNumber();
        AddGuestsInRaffle(raffleNumber, nameToAdd);

        if(yesOrNo == "yes") continue;

        else if (yesOrNo == "")
        {
            yesOrNo = GetUserInput("Do you want to add another name? ").ToLower();
        nameToAdd = raffleName;
            raffleNumber = GenerateRandomNumber();

            foreach (KeyValuePair<int, string> kvp in guests) //refers back to dictionary

            {
            if (raffleNumber = KeyValuePair.Key)
            }
                raffleNumber = GenerateRandomNumber();
            }

       
        AddGuestsinRaffle(raffleNumber, nameToAdd);
        }
                else if (yesOrNo == "no") break; //stops this loop.

            else
        {
    Console.WriteLine("You have not entered \"yes\" or \"no\", or" +
        "you have entered it incorrectly. no more names will be taken.");
    break;
}
}

             //3. Method for integer (min, max)
  private  static int GenerateRandomNumber(int min = 1000, int max = 9999);
{
    return rdm.Next(min, max);
    //c-sharpcorner.com Code to generate random number
}

          //4. returns nothing name is AddGuestsInRaffle();
    static void AddGuestsinRaffle (int raffleNumber, string nameToAdd)
{
    guests.Add(raffleNumber, nameToAdd);
}

//5. void loop to print name of all guests and their number
//

static void PrintGuestsName()
{
    Console.WriteLine();
    foreach (KeyValuePair<int,string> keyValuePair in guests)
    {
        Console.WriteLine($"{keyValuePair.Value}'s number is **{keyValuePair.Key}**"); 
    }
    Console.WriteLine();
}
//6. Pair a stored random number with a Listed winner name

public static int 
List<int> keyList = new List<int>(AddGuestsinRaffle().Keys);
int winnerNumber = KeyList[_rdm.Next(keyList.Count)];

//7. Static void Print Winner method.

static void PrintWinner()


    Console.WriteLine($"The Winner is: {WinnerName} with the #{winnerNumber}");


//other code. 
static void MultiLineAnimation() // Credit: https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
        {
            var counter = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();

                switch (counter % 4)
                {
                    case 0:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    │││ \\   ║");
                            Console.WriteLine("         ║    │││  O  ║");
                            Console.WriteLine("         ║    OOO     ║");
                            break;
                        };
                    case 1:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                    case 2:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║   / │││    ║");
                            Console.WriteLine("         ║  O  │││    ║");
                            Console.WriteLine("         ║     OOO    ║");
                            break;
                        };
                    case 3:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                }

                counter++;
                Thread.Sleep(200);
            }
        }
    }

}
