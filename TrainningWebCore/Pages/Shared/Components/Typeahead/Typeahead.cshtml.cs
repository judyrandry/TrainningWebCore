using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace TrainningWebCore.Pages.Shared.Components.Typeahead
{
    [ViewComponent(Name = "typeahead")]
    public class TypeaheadModel : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
