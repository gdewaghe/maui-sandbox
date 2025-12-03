using CommunityToolkit.Mvvm.DependencyInjection;

namespace IoCDemo
{
    public partial class CustomApp : Application
    {
        public CustomApp(IServiceProvider services)
        {
            Ioc.Default.ConfigureServices(services);
        }
    }
}
