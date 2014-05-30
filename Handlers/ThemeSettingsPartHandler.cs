using JetBrains.Annotations;
using PJS.FlatJack.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;

namespace PJS.FlatJack.Handlers {
    [UsedImplicitly]
    public class ThemeSettingsPartHandler : ContentHandler {
        public ThemeSettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<ThemeSettingsPart>("Site"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
        }
    }
}