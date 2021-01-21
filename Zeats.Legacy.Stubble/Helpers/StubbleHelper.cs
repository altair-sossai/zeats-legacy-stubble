using System.Globalization;
using Stubble.Core.Builders;
using Stubble.Core.Settings;
using Zeats.Legacy.Stubble.Format;

namespace Zeats.Legacy.Stubble.Helpers
{
    public static class StubbleHelper
    {
        static StubbleHelper()
        {
            CultureInfo = new CultureInfo("pt-br");

            RenderSettings = RenderSettings.GetDefaultRenderSettings();
            RenderSettings.SkipHtmlEncoding = true;
        }

        public static CultureInfo CultureInfo { get; set; }
        public static RenderSettings RenderSettings { get; set; }

        public static string Parse(string template, object data)
        {
            var stubble = new StubbleBuilder()
                .Configure(settings => { settings.SetFormattedInterpolationTokenRenderer(); })
                .Build();

            return stubble.Render(template, data, RenderSettings);
        }
    }
}