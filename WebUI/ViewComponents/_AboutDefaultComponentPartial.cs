using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class _AboutDefaultComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}

