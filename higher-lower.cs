using System;
using System.Collections.Generic;
using System.Linq;

public class HighLow
{
  public static void Guess()
  {
    decimal highest = 100;
    decimal lowest = 1;
    decimal averageCalc = 50;
    decimal newGuess = 50;
    int average = Convert.ToInt32(averageCalc);
    string gameResponse = "";
    while (gameResponse != "Correct" || gameResponse != "correct")
      {
        Console.WriteLine($"Is your number higher or lower than {newGuess}? Higher/Lower/Correct");
        gameResponse = Console.ReadLine();
        if (gameResponse == "higher" || gameResponse == "Higher")
        {
          lowest = newGuess;
          averageCalc = Math.Round(((highest - lowest) / 2));
          newGuess = lowest + averageCalc;
          average = Convert.ToInt32(averageCalc);
        }
        else if (gameResponse == "lower" || gameResponse == "Lower")
        {
          highest = newGuess;
          averageCalc = Math.Round(((highest - lowest) / 2));
          newGuess = highest - averageCalc;
          average = Convert.ToInt32(averageCalc);
        }
        else
        {
          break;
        }
      }
      Console.WriteLine($"I've guessed your number... {newGuess}!");
    }
  

  public static void Main()
  {
    Console.WriteLine("Do you want to play a game? Y/N? (Of higher/lower...not Saw)");
    
    string startResponse = Console.ReadLine();
    if (startResponse == "y" || startResponse == "Y")
    {
      Console.WriteLine("Pick a whole number between 1 and 100");
      Guess();
    }
    else
    {
      Console.WriteLine("Okay bye I guess :P");
    } 
  }
}



// if higher than #{
// highest # = 
// return (((highest # - lowest #)/2)+lowest #)  
// }
// else if lower than #{
//   return (((highest # - lowest #)/2)+lowest #)
// }