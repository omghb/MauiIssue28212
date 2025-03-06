namespace MauiApp9
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        public static AppShell Shell { get; private set; }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Shell = new AppShell();
            Shell.Navigation.PushAsync(new MainPage());
            return new Window(Shell);
        }
    }
}