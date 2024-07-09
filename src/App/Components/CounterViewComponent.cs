using Microsoft.AspNetCore.Mvc;

namespace App.Components
{
    public class CounterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int modelCounter)
        {
            return View(modelCounter);
        }
    }
}
