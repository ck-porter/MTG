﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MTG.View;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MTG
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ViewModel.CardViewModel CardViewModel { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            this.CardViewModel = new ViewModel.CardViewModel();
            CardViewModel.CardColor = "White";
            CardViewModel.BackgroundColor = "White";
        }

        private void Battle_Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Battle));
        }

      

        private void About_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(About));
        }


     

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
