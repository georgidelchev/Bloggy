using Bloggy.Services.Data;
using Bloggy.Web.ViewModels.Administration.Dashboard;

using Microsoft.AspNetCore.Mvc;

namespace Bloggy.Web.Areas.Administration.Controllers
{
    public class DashboardController : AdministrationController
    {
        private readonly ISettingsService settingsService;

        public DashboardController(
            ISettingsService settingsService)
        {
            this.settingsService = settingsService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel { SettingsCount = this.settingsService.GetCount(), };

            return this.View(viewModel);
        }
    }
}
