using CommunityToolkit.Mvvm.Messaging;
using MessengingDemo.Messages;
using MessengingDemo.Services.Interfaces;

namespace MessengingDemo.Services
{
    public class DialogService : IDialogService
    {
        public DialogService()
        {
            WeakReferenceMessenger.Default.Register<SimpleAlertMessage>(this, async (r, m) =>
            {
                await ShowAlertAsync(m.Title, m.Message, m.Cancel);
            });
        }

        public async Task ShowAlertAsync(string title, string message, string cancel)
        {
            var currentPage = Application.Current?.Windows[0].Page;
            if (currentPage != null)
            {
                await currentPage.DisplayAlert(title, message, cancel);
            }
        }
    }
}
