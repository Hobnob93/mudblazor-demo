using Microsoft.AspNetCore.Components;
using System.Text.RegularExpressions;

namespace Mudblazor.Client.Shared
{
    public partial class CardItem
    {
        private Regex RegInitials = new Regex(@"(\b[a-zA-Z])[a-zA-Z]* ?");

        [Parameter]
        public string PostedBy { get; set; }
        [Parameter]
        public string Location { get; set; }
        [Parameter]
        public string ImageAddress { get; set; }
        [Parameter]
        public string Description { get; set; }


        public string Initials => RegInitials.Replace(PostedBy, "$1");
    }
}
