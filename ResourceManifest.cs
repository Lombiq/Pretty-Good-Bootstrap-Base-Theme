using Orchard.UI.Resources;

namespace Lombiq.PrettyGoodBootstrapBaseTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineStyle("Lombiq.PrettyGoodBootstrapBaseTheme.ConsentBanner").SetUrl("consent-banner.min.css", "consent-banner.css");
        }
    }
}