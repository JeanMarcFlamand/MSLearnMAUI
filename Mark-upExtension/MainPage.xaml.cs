namespace Mark_upExtension
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public const double MyFontSize = 16;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }


    }
    [ContentProperty("Member")]
    public class StaticExtensionn : IMarkupExtension
    {
        public string Member { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return MainPage.MyFontSize;
        }
    }
}