﻿using System;

using OneDriveApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace OneDriveApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
