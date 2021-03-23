using Microsoft.AspNetCore.Components;
using Mudblazor.Shared;
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
