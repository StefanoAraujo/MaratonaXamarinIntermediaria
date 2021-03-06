﻿using MonkeyHubApp.Services;
using MonkeyHubApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MonkeyHubApp
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel ViewModel => BindingContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
            var monkeyHubApiService = DependencyService.Get<IMonkeyHubApiService>();
            BindingContext = new MainViewModel(monkeyHubApiService);
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                ViewModel.ShowCategoriaCommand.Execute(e.SelectedItem);
            }
        }
    }
}
