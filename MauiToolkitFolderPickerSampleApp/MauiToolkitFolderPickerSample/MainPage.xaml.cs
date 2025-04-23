#if ANDROID
using Android.Widget;
#endif

using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Storage;
using System.ComponentModel;



namespace MauiToolkitFolderPickerSample
{

    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {

        // FR : Propriété de liaison pour le nom du dossier
        // EN : Binding property for folder name
        private string mFolderName;

        public string FolderName
        {
            get => mFolderName;
            set
            {
                if (mFolderName != value)
                {
                    mFolderName = value;
                    OnPropertyChanged(nameof(FolderName));
                }
            }
        }

        int count = 0;
        private readonly IFolderPicker folderPicker;

        public MainPage(IFolderPicker folderPicker)
        {
            InitializeComponent();
            // FR : Contexte de liaison défini à l’instance elle-même
            // EN : Set binding context to the page itself

            BindingContext = this;
            this.folderPicker = folderPicker;
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

        private async void OnPickFolderClicked(object sender, EventArgs e)
        {
            await PickFolder(CancellationToken.None);
        }

        async Task PickFolder(CancellationToken cancellationToken)
        {
            var result = await folderPicker.PickAsync(cancellationToken);
            result.EnsureSuccess();
            FolderName = result.Folder.Path;


            _ = DisplayAlert("Folder Picked", $"Name: {result.Folder.Name}, Path: {result.Folder.Path}", "OK");
            // await Toast.Make($"Folder picked: Name - {result.Folder.Name}, Path - {result.Folder.Path}", ToastDuration.Long).Show(cancellationToken);
        }

    }

}

