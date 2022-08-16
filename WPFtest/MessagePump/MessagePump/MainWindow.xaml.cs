﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace MessagePump
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private  async void btnDostff_Click(object sender, RoutedEventArgs e)
        {
            btnDostff.IsEnabled = false;
            lblStatus.Content = "Doing Stuff";
            await Task.Delay(4000);
            lblStatus.Content = "Not Doing Anything";
            btnDostff.IsEnabled = true;
        }
    }
}
