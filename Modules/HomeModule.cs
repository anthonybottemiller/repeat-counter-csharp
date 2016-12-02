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
        return View["result.cshtml"];
      };
    }
  }
}