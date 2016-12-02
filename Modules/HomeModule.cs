using Nancy;

namespace RepeatCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/count"] = _ => {
        var wordCount = new RepeatCounter();
        wordCount.Count(Request.Form["input-string"], Request.Form["comparison-string"]);
        return View["result.cshtml"];
      };
    }
  }
}