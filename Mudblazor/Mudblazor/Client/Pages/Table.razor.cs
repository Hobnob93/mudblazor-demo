using Microsoft.AspNetCore.Components;
using Mudblazor.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Mudblazor.Client.Pages
{
    public partial class Table
    {
        [Inject]
        public HttpClient Http { get; set; }

        public bool Dense { get; set; }
        public bool Hover { get; set; } = true;
        public bool Striped { get; set; }
        public bool Bordered { get; set; }
        public string SearchString { get; set; } = string.Empty;

        private Driver selectedItem = null;
        private HashSet<Driver> selectedItems = new HashSet<Driver>();
        private IEnumerable<Driver> Elements = new List<Driver>();

        protected override async Task OnInitializedAsync()
        {
            Elements = await Http.GetFromJsonAsync<List<Driver>>("Drivers");
        }

        private bool FilterFunc(Driver element)
        {
            if (string.IsNullOrWhiteSpace(SearchString))
                return true;
            if (element.Id.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.Name.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.Team.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }
    }
}
