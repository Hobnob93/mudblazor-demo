using Microsoft.AspNetCore.Components;
using Mudblazor.Client.Shared;
using MudBlazor;
using System.Threading.Tasks;

namespace Mudblazor.Client.Pages
{
    public partial class Cards
    {
        [Inject]
        public IDialogService Dialog { get; set; }

        public MudMessageBox MBox { get; set; }
        public string MessageBoxResult { get; set; }


        protected override void OnInitialized()
        {
            MessageBoxResult = "No message box response yet.";
        }

        public void ShowDialog()
        {
            Dialog.Show<SampleDialog>("Sample Dialog");
        }

        public async Task ShowDefaultMessageBox()
        {
            var result = await Dialog.ShowMessageBox(
                "Warning",
                "Deleting can not be undone!",
                yesText: "Delete!", cancelText: "Cancel");
            MessageBoxResult = result == null ? "Cancelled" : "Deleted!";
        }

        public async Task ShowMessageBox()
        {
            bool? result = await MBox.Show();
            MessageBoxResult = result == null ? "Cancelled" : "Deleted!";
        }
    }
}
