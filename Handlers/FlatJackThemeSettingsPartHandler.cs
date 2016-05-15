using PJS.FlatJack.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;

namespace PJS.FlatJack.Handlers {
    public class FlatJackThemeSettingsPartHandler : ContentHandler {
        public FlatJackThemeSettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<FlatJackThemeSettingsPart>("Site"));
            Filters.Add(new TemplateFilterForPart<FlatJackThemeSettingsPart>("FlatJackThemeSettings", "Parts/FlatJackThemeSettings", "Theme-FlatJack"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Theme-FlatJack")));
        }
    }
}