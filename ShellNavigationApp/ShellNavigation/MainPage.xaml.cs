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

        private void GotoTestPAgeInFolder_Clicked(object sender, EventArgs e)
        {

        }

        private void GotoTestPageInFolderClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("Pages/TestPageinFloder");
        }
    }

}
