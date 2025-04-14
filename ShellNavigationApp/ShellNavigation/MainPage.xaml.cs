namespace ShellNavigation
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGoToAboutPageClicked(object sender, EventArgs e)
        {
           Shell.Current.GoToAsync("AboutPage");
        }
    }

}
