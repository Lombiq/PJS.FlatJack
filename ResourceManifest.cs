using Orchard.UI.Resources;

namespace PJS.FlatJack {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript("ThemeScript").SetUrl("script.min.js").SetDependencies("jQuery");
            manifest.DefineScript("Theme-ValidationEngine-en").SetUrl("jquery.validationEngine-en.js").SetVersion("2.6.2").SetDependencies("jQuery");
            manifest.DefineScript("Theme-ValidationEngine").SetUrl("jquery.validationEngine.js").SetVersion("2.6.2").SetDependencies("Theme-ValidationEngine-en");
            manifest.DefineScript("Isotope").SetUrl("jquery.isotope.min.js").SetVersion("1.5.25").SetDependencies("jQuery");
            manifest.DefineScript("prettyPhoto").SetUrl("jquery.prettyPhoto.js").SetVersion("3.1.5").SetDependencies("jQuery");
            manifest.DefineScript("Styler").SetUrl("jquery.styler.js").SetDependencies("jQuery");

            manifest.DefineStyle("ThemeStyle").SetUrl("style.min.css");
            manifest.DefineStyle("Theme-ValidationEngine").SetUrl("validationEngine.jquery.css");
            manifest.DefineStyle("prettyPhoto").SetUrl("prettyPhoto.css");
            manifest.DefineStyle("Bootstrap-Social").SetUrl("bootstrap-social.css");
        }
    }
}
