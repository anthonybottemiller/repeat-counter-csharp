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
        var wordCount = new RepeatCounter(Request.Form["input-string"], Request.Form["comparison-string"]);
        wordCount.Count();
        return View["result.cshtml", wordCount];
      };
    }
  }
}