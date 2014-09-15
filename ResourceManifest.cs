using Orchard.UI.Resources;

namespace PJS.FlatJack {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript("jQuery-Migrate").SetUrl("jquery-migrate-1.2.1.min.js").SetVersion("1.2.1").SetDependencies("jQuery");
            manifest.DefineScript("Bootstrap").SetUrl("bootstrap.min.js").SetVersion("3.0.0").SetDependencies("jQuery");
            manifest.DefineScript("Easing").SetUrl("jquery.easing.min.js").SetVersion("1.3").SetDependencies("jQuery");
            manifest.DefineScript("Retina").SetUrl("retina.js").SetVersion("0.0.2");
            manifest.DefineScript("Theme-ValidationEngine-en").SetUrl("validationEngine/jquery.validationEngine-en.js").SetVersion("2.6.2").SetDependencies("jQuery");
            manifest.DefineScript("Theme-ValidationEngine").SetUrl("validationEngine/jquery.validationEngine.js").SetVersion("2.6.2").SetDependencies("Theme-ValidationEngine-en");
            manifest.DefineScript("Isotope").SetUrl("jquery.isotope.min.js").SetVersion("1.5.25").SetDependencies("jQuery");
            manifest.DefineScript("prettyPhoto").SetUrl("jquery.prettyPhoto.js").SetVersion("3.1.5").SetDependencies("jQuery");
            manifest.DefineScript("Custom").SetUrl("custom.js");

            manifest.DefineStyle("Bootstrap").SetUrl("bootstrap.min.css").SetVersion("3.0.0");
            manifest.DefineStyle("Font-Awesome").SetUrl("font-awesome-4.2.0/css/font-awesome.min.css", "font-awesome-4.2.0/css/font-awesome.css").SetVersion("4.2.0");
            manifest.DefineStyle("FlatJack").SetUrl("style.css");
            manifest.DefineStyle("Custom").SetUrl("custom.css");
            manifest.DefineStyle("Theme-ValidationEngine").SetUrl("validationEngine/validationEngine.jquery.css").SetVersion("2.6.2");
            manifest.DefineStyle("prettyPhoto").SetUrl("prettyPhoto.css");
            manifest.DefineStyle("Bootstrap-Social").SetUrl("bootstrap-social.css");
        }
    }
}
