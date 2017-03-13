﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sync
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
          
            
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            Sync_Browser.Navigate(textBox_suchbox.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Sync_Browser.Navigate("http://www.google.com");
        }

        private void button_Back(object sender, RoutedEventArgs e)
        {
            if (Sync_Browser.CanGoBack)
            {
                Sync_Browser.GoBack();
            }
            else
            {
                MessageBox.Show("du kannst nicht mehr zurück!");
            }
            
        }

        private void button_Click_Vor(object sender, RoutedEventArgs e)
        {
            if (Sync_Browser.CanGoForward)
            {
                Sync_Browser.GoForward();
            }
            else
            {
                MessageBox.Show("du kannst nicht mehr vor!");
            }
        }

           private void Sync_Browser_Navigating_1(object sender, NavigatingCancelEventArgs e)
        {
            textBox_suchbox.Text = e.Uri.OriginalString;
        }

       
        private void button_Click_New_Tab(object sender, RoutedEventArgs e)
        {
            TabItem tab = new TabItem();
            tab.Header = "New Tab";
            Grid grid_web = new Grid();
            WebBrowser web = new WebBrowser();
            web.Navigate("http://www.google.com");
            grid_web.Children.Add(web);
            tab.Content = grid_web;

            tabControl.Items.Add(tab);



        }

      

    
    }
}
