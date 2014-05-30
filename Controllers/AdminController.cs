using System.Web.Mvc;
using Orchard;
using Orchard.ContentManagement;
using Orchard.Localization;
using Orchard.UI.Notify;
using PJS.FlatJack.Models;
using PJS.FlatJack.ViewModels;

namespace PJS.FlatJack.Controllers {
    [ValidateInput(false)]
    public class AdminController : Controller {
        public AdminController(IOrchardServices services) {
            Services = services;
            T = NullLocalizer.Instance;
        }

        public IOrchardServices Services { get; set; }
        public Localizer T { get; set; }

        public ActionResult Index() {
            var settings = Services.WorkContext.CurrentSite.As<ThemeSettingsPart>();

            var viewModel = new ThemeSettingsViewModel {
                Base = settings.Base,
                Highlight = settings.Highlight
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(ThemeSettingsViewModel viewModel) {
            if (!Services.Authorizer.Authorize(PJS.FlatJack.Permissions.ManageThemeSettings, T("Couldn't update Theme settings")))
                return new HttpUnauthorizedResult();

            var settings = Services.WorkContext.CurrentSite.As<ThemeSettingsPart>();
            settings.Base = viewModel.Base;
            settings.Highlight = viewModel.Highlight;

            Services.Notifier.Information(T("Your settings have been saved."));

            return View(viewModel);
        }
    }
}