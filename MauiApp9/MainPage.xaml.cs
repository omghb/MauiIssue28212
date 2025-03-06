namespace MauiApp9
{
    public partial class MainPage : ContentPage
    {
        private readonly Lazy<SecondPage> secondPage = new(() => new SecondPage());

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            App.Shell.Navigation.PushAsync(secondPage.Value);
        }
    }
}
