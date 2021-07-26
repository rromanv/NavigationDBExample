﻿using NavigationDBExample.Models;
using NavigationDBExample.Pages;
using System;
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

namespace NavigationDBExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            db();
            InitializeComponent();
            navFrame.NavigationService.Navigate(new MainPage());
        }

        public void db()
        {
            using var dbContext = new SqliteDBContext();
            dbContext.Database.EnsureCreated();
        }
    }
}
