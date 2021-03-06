﻿using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Adv_1_Hands_On_1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.LoadData();
        }

        public static readonly DependencyProperty IsLoadingProperty = DependencyProperty.Register(
            "IsLoading", typeof(bool), typeof(MainPage), new PropertyMetadata(false)
            );

        public Boolean IsLoading
        {
            get { return (Boolean)GetValue(IsLoadingProperty); }
            set { SetValue(IsLoadingProperty, value); }
        }

        async void LoadData()
        {
            this.IsLoading = true;

            await Task.Delay(5000);

            this.IsLoading = false;
        }
    }
}
