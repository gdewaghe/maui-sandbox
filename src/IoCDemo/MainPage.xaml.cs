using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace IoCDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var service = Ioc.Default.GetRequiredService<IConfiguration>();
            ServiceLabel.Text = $"Service = {service.GetType()}";
        }
    }
}
