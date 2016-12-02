using Xunit;
namespace RepeatCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounter_ForTwoWordsThatDontMatch_0()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(0, testRepeatCounter.Count("c#","java"));
    }
    [Fact]
    public void RepeatCounter_ForTwoWordsThatMatch_1()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(1, testRepeatCounter.Count("c#","c#"));
    }
    [Fact]
    public void RepeatCounter_ForManyThatMatch_2()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(2, testRepeatCounter.Count("c# c#","c#"));
    }
  }
}