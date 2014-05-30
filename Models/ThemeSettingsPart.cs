using Orchard.ContentManagement;

namespace PJS.FlatJack.Models {
    public class ThemeSettingsPart : ContentPart {
        public string Base {
            get { return this.Retrieve(r => r.Base, Constants.BaseDefault); }
            set { this.Store(r => r.Base, value); }
        }

        public string Highlight {
            get { return this.Retrieve(r => r.Highlight, Constants.HighlightDefault); }
            set { this.Store(r => r.Highlight, value); }
        }
    }
}