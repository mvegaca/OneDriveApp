using System;

using OneDriveApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace OneDriveApp.Views
{
    public sealed partial class LogInPage : Page
    {
        public LogInViewModel ViewModel { get; } = new LogInViewModel();

        public LogInPage()
        {
            InitializeComponent();
        }
    }
}
