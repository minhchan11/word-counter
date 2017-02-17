using System;
using System.Collections.Generic;
using Xunit;

namespace WordCounter.Objects
{
  public class RepeatCounterTest
  {
    //Assert true in case word is contained in string
    [Fact]
    public void ContainsWord_WordPresent_true()
    {
      // Arrange
      RepeatCounter testRepeat = new RepeatCounter("cat","cathedral");
      // Assert
      Assert.Equal(true, testRepeat.ContainsWord());
    }

    //Assert false in case word is not contained in string
    [Fact]
    public void ContainsWord_WordPresent_false()
    {
      // Arrange
      RepeatCounter testRepeat = new RepeatCounter("dog","cathedral");
      // Assert
      Assert.Equal(false, testRepeat.ContainsWord());
    }
  }
}
