using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MessengingDemo.Messages;

namespace MessengingDemo.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _baseNumber = 1;

        [ObservableProperty]
        private long _factorial = -1;

        [RelayCommand]
        private void ShowDialog()
        {
            var message = new SimpleAlertMessage
            {
                Title = "Hello",
                Message = "This is a simple alert message.",
                Cancel = "Ok"
            };
            WeakReferenceMessenger.Default.Send(message);
        }

        [RelayCommand]
        private void ComputeFactorial()
        {
            Factorial = WeakReferenceMessenger.Default.Send(new ComputeFactorialMessage { BaseNumber = this.BaseNumber });
        }
    }
}
