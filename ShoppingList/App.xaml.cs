﻿using ShoppingList.Util;
using System;
using System.Windows;

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App() : base()
        {
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
        }

        private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Logger.Instance.WriteToLog($"Unhandled exception{(e.ExceptionObject as Exception)}");
        }

    }
}
