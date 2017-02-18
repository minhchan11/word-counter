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
     string convertedWord = _word.ToLower();
     string convertedString = _inputString.ToLower();
     return convertedString.Contains(convertedWord);
    }

    //Count only that word
    public int CountRepeatsFull()
    {
      int _counter = 0;
      string convertedWord = _word.ToLower();
      string convertedString = _inputString.ToLower();
        string[] splitInput = convertedString.Split(' ');
        foreach (string splits in splitInput)
        {
          if(splits == convertedWord.ToLower())
          {
            _counter++;
          };
        };
      return _counter;
    }

    //Make method to count the number of times string contains substring
    public int CountRepeatsPartial()
    {
      int _counter = 0;
      string convertedWord = _word.ToLower();
      string convertedString = _inputString.ToLower();
      if (convertedString.Contains(convertedWord) == true)
      {
        do
        {
          int removeAt = convertedString.IndexOf(convertedWord);
          int wordLength = convertedWord.Length;
          convertedString = convertedString.Remove(removeAt,wordLength);
          _counter++;
        }
        while(convertedString.Contains(convertedWord));
      }
      else
      {
        _counter = 0;
      }
      return _counter;
    }
  }
}
