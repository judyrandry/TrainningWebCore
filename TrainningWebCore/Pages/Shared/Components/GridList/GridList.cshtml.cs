using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace TrainningWebCore.Pages.Shared.Components.GridList
{
    [ViewComponent(Name = "gridlist")]
    public class GridListModel : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
