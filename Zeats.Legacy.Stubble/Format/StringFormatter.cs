using Stubble.Core.Renderers.StringRenderer.TokenRenderers;
using Stubble.Core.Settings;

namespace Zeats.Legacy.Stubble.Format
{
    public static class StringFormatter
    {
        public static RendererSettingsBuilder SetFormattedInterpolationTokenRenderer(this RendererSettingsBuilder builder)
        {
            builder.TokenRenderers.Replace<InterpolationTokenRenderer>(new FormattedInterpolationTokenRenderer());
            return builder;
        }
    }
}