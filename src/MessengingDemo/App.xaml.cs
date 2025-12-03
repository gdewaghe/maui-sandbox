using MessengingDemo.Services;

namespace MessengingDemo
{
    public partial class App : Application
    {
        public DialogService DialogService { get; }

        public App()
        {
            InitializeComponent();
            DialogService = new();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}