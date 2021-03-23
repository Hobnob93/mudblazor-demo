using Microsoft.AspNetCore.Components;
using Mudblazor.Shared;
using MudBlazor;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Mudblazor.Client.Shared
{
    public partial class MainLayout
    {
        private Themes themes;

        [Inject]
        public HttpClient Http { get; set; }

        public bool UseLightMode { get; set; }

        public string ToggleIcon => UseLightMode ? Icons.Filled.NightlightRound : Icons.Filled.WbSunny;
        public MudTheme CurrentTheme => UseLightMode ? themes.LightTheme : themes.DarkTheme;


        protected override async Task OnInitializedAsync()
        {
            themes = await Http.GetFromJsonAsync<Themes>("Theme");
        }

        public void ToggleTheme()
        {
            UseLightMode = !UseLightMode;
        }
    }
}
