using System;
using System.Collections.Generic;

public class Test{

  static void Main(){
    Dictionary<int, string> riddle = new Dictionary<int, string>();

    riddle.Add(1, "When is a door no longer a door?");
    riddle.Add(2, "What gets wetter as it dries?");
    riddle.Add(3, "What tastes better than it smells");
    riddle.Add(4, "What building has the most stories?"); 

    Dictionary<string, string> answer = new Dictionary<string, string>();

    answer.Add("When is a door no longer a door?", "ajar");
    answer.Add("What gets wetter as it dries?", "towel");
    answer.Add("What tastes better than it smells", "tongue");
    answer.Add("What building has the most stories?", "library"); 


    /*MAKE A RANDOM NUMBER*/
    int count = 0;
    foreach (var i in riddle){
      count++;
    }

    Random rnd = new Random();  //makes a random number?
    int num = rnd.Next(1,count);  //0-4

    /*GRAB RANDOM RIDDLE*/
    string chosenRiddle = riddle[num];
    Console.WriteLine(riddle[num]);

    /*MATCH RIDDLE TO ANSWER*/
    string userAnswer = Console.ReadLine();
    if(userAnswer == answer[chosenRiddle]) {
      Console.WriteLine("GREAT SUCCESS");
    }
    
    
    
    //grab random quote using the generated random number

    


    // foreach (var i in riddle){
    //   Console.WriteLine(i);
    // }

    // foreach (var i in riddle){
    //   Console.WriteLine(i.Key);
    // }


    //1. Create a dictionary full of riddles and values
    //2. Generate a random number between 1 and the amount of riddles
    //3. Grab a dictionary key based on that random number
  }


}