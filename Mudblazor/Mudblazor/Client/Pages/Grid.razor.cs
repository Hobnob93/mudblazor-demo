namespace Mudblazor.Client.Pages
{
    public partial class Grid
    {
        public int Spacing { get; set; } = 2;

        void AddSpacing()
        {
            Spacing++;
            Spacing %= 10;

            StateHasChanged();
        }
    }
}
