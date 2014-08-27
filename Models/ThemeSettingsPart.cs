using Orchard.ContentManagement;

namespace PJS.FlatJack.Models {
    public class ThemeSettingsPart : ContentPart {
        public string Base {
            get { return this.Retrieve(r => r.Base, "dark"); }
            set { this.Store(r => r.Base, value); }
        }
        public string Highlight {
            get { return this.Retrieve(r => r.Highlight, "red"); }
            set { this.Store(r => r.Highlight, value); }
        }
        public bool FixedHeader {
            get { return this.Retrieve(r => r.FixedHeader, false); }
            set { this.Store(r => r.FixedHeader, value); }
        }
    }
}