using MessengingDemo.Services;

namespace MessengingDemo
{
    public partial class App : Application
    {
        public DialogService DialogService { get; }
        public FactorialService FactorialService { get; }

        public App()
        {
            InitializeComponent();
            DialogService = new();
            FactorialService = new();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}