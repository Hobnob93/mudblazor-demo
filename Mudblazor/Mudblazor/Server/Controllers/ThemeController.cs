using Microsoft.AspNetCore.Mvc;
using Mudblazor.Shared;
using MudBlazor;

namespace Mudblazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ThemeController : ControllerBase
    {
        [HttpGet]
        public Themes Get()
        {
            // Get this from a service, or some config
            return new Themes
            {
                DarkTheme = new MudTheme
                {
                    Palette = new Palette
                    {
                        Black = "#27272f",
                        Background = "#32333d",
                        BackgroundGrey = "#27272f",
                        Surface = "#2f2f37",
                        DrawerBackground = "#27272f",
                        DrawerText = "rgba(255, 255, 255, 0.50)",
                        DrawerIcon = "rgba(255, 255, 255, 0.50)",
                        AppbarBackground = "#27272f",
                        AppbarText = "rgba(255, 255, 255, 0.70)",
                        TextPrimary = "rgba(255, 255, 255, 0.70)",
                        TextSecondary = "rgba(255, 255, 255, 0.50)",
                        ActionDefault = "#adadb1",
                        ActionDisabled = "rgba(255, 255, 255, 0.26)",
                        ActionDisabledBackground = "rgba(255, 255, 255, 0.12)",
                        Primary = "#5996e2",
                        Secondary = "#8ac8a5",
                        Tertiary = "#ff9381",
                        Error = "#ff9381"
                    }
                },

                LightTheme = new MudTheme() // default theme
            };
        }
    }
}
