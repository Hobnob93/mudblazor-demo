using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mudblazor.Client.Pages
{
    public partial class OtherStuff : IDisposable
    {
        [Inject]
        public ISnackbar Snackbar { get; set; }

        public bool ShowPopover { get; set; }
        public int ProgressAmount { get; set; }

        private IList<IBrowserFile> Files = new List<IBrowserFile>();
        private bool disposed;
        private Random random;


        protected override void OnInitialized()
        {
            random = new Random(DateTime.Now.Millisecond);
            StartTimerAsync();
        }

        public void TogglePopover()
        {
            ShowPopover = !ShowPopover;
        }

        public async void StartTimerAsync()
        {
            if (disposed)
                return;

            ProgressAmount = 0;
            while (ProgressAmount < 100)
            {
                ProgressAmount += random.Next(0, 10);
                StateHasChanged();
                await Task.Delay(500);

                if (disposed)
                    return;
            }

            ProgressAmount = 0;
            StartTimerAsync();
        }

        private void UploadFiles(InputFileChangeEventArgs e)
        {
            foreach (var file in e.GetMultipleFiles())
            {
                Files.Add(file);
            }
            //TODO upload the files to the server
        }

        public void Dispose()
        {
            disposed = true;
        }
    }
}
