using System;
using System.Collections.Generic;

public class Riddle
{
  static void Main()
  {
    string userAnswer = AskRiddle();
    GetAnswer(userAnswer);
  }

  static int AskRiddle()

  {
    Dictionary<string, string> riddleDict = new Dictionary<string, string>();
      riddleDict.Add("What gets wet while drying?", 1);

      // if(riddleDictAnswers["What gets wet while drying?"] == "towel")

      // riddleDict.Add(2, "What gets wet while drying?");
      // riddleDict.Add(3, "What gets wet while drying?");
      // riddleDict.Add(4, "What gets wet while drying?");
      // riddleDict.Add(5, "What gets wet while drying?");

      // riddleDict.Add(2, "What gets wet while drying?");
      // riddleDict.Add(3, "What gets wet while drying?");
      // riddleDict.Add(4, "What gets wet while drying?");
      // riddleDict.Add(5, "What gets wet while drying?");
    

    Console.WriteLine(riddleDict[1]);

    string userAnswer = Console.ReadLine();
    return riddleDict[];
  }

  static string GetAnswer(string answer)
  {
    Dictionary<int, string> riddleDictAnswers = new Dictionary<int, string>();
    riddleDict.Add(1, "towel");
    string returnString = "";

    if (answer == correctAnswer)
    {
      returnString = (correctAnswer + " is correct");
      Console.WriteLine(returnString);
      return returnString;
    }
    else
    {
      returnString = ("Sphinx eats user");
      Console.WriteLine(returnString);
      return returnString;
    }
  }
}