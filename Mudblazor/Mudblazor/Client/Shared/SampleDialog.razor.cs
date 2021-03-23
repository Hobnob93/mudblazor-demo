using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Mudblazor.Client.Shared
{
    public partial class SampleDialog
    {
        [CascadingParameter]
        public MudDialogInstance MudDialog { get; set; }


        void Submit() => MudDialog.Close(DialogResult.Ok(true));
        void Cancel() => MudDialog.Cancel();
    }
}
