using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Mudblazor.Client.Shared
{
    public partial class SampleDialog
    {
        [CascadingParameter]
        public MudDialogInstance MudDialog { get; set; }

        [Parameter]
        public string PostedBy { get; set; }
        [Parameter]
        public string Location { get; set; }


        void Submit() => MudDialog.Close(DialogResult.Ok(true));
        void Cancel() => MudDialog.Cancel();
    }
}
