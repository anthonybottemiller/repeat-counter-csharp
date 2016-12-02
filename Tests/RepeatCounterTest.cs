using Xunit;
namespace RepeatCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounter_ForStringsThatDontMatch_0()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(0, testRepeatCounter.Count("c#","java"));
    }
  }
}