using Microsoft.AspNetCore.Components;
using Mudblazor.Shared;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Mudblazor.Client.Pages
{
    public partial class Toolbar
    {
        [Inject]
        public HttpClient Http { get; set; }

        public List<ChartSeries> BarSeries { get; set; } = new List<ChartSeries>();
        public string[] XAxisLabels { get; set; } = Array.Empty<string>();
        public double[] PieData { get; set; } = Array.Empty<double>();
        public string[] PieLabels { get; set; } = Array.Empty<string>();

        private IEnumerable<Driver> drivers = new List<Driver>();

        protected override async Task OnInitializedAsync()
        {
            BarSeries.Clear();
            XAxisLabels = Array.Empty<string>();
            PieData = Array.Empty<double>();
            PieLabels = Array.Empty<string>();

            drivers = await Http.GetFromJsonAsync<List<Driver>>("Drivers");

            var chartSeries = new ChartSeries
            {
                Name = "Driver's Points",
                Data = drivers.Take(10).Select(d => (double)d.Points).ToArray()
            };
            BarSeries.Add(chartSeries);

            XAxisLabels = drivers.Take(10).Select(d => d.Id).ToArray();

            var teams = drivers.GroupBy(d => d.Team).ToDictionary(g => g.Key, g => g.Sum(d => d.Points));
            PieLabels = teams.Select(t => t.Key).ToArray();
            PieData = teams.Select(t => (double)t.Value).ToArray();
        }
    }
}
