using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    // declare types used
    private string _word;
    private string _inputString;

    //Make constructor
    public RepeatCounter(string word, string inputString)
    {
      _word = word;
      _inputString = inputString;
    }

    // Make boolean method to see if string contains substring
    public bool ContainsWord()
    {
     return false;
    }
  }
}
