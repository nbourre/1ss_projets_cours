using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace progressbar_timer
{
    /// <summary>
    /// Interaction logic for App.xaml
	/// Auteur : nicol
	/// Creation date : 11/28/2022 3:44:53 PM
    /// GUID : 9db4a205-5223-4e3e-9ac8-4cb017875cbc
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow win = new MainWindow();

            win.Show();
        }
    }
}
