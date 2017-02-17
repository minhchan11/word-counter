using Nancy;
using System;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounterApp
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        string userWord = Request.Form["word"];
        string userSentence = Request.Form["sentence"];
        RepeatCounter userCounter = new RepeatCounter( userWord, userSentence);
        int fullMatch = userCounter.CountRepeatsFull();
        string fullResult = fullMatch.ToString();
        int partialMatch = userCounter.CountRepeatsPartial();
        string partialResult = partialMatch.ToString();
        Dictionary<string,string> model = new Dictionary<string,string>{};
        model.Add("userWord",userWord);
        model.Add("userSentence",userSentence);
        model.Add("fullResult", fullResult);
        model.Add("partialResult", partialResult);
        return View["result.cshtml", model];
      };
    }
  }
}
