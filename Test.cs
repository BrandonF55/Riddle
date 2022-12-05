using System;
using System.Collections.Generic;

public class Test{

  static void Main(){
    Dictionary<string, string> riddle = new Dictionary<string, string>();

    riddle.Add("Check out this riddle biiiiitch", "towel");
    riddle.Add("What gets wetter as it dries?", "towel");

    

    if(riddle["Check out this riddle biiiiitch"] == riddle[1]){
      Console.WriteLine("The answer to " + riddle[1] + " is " + answer[1]);
    }

  }


}