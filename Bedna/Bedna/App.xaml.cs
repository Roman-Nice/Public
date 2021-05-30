using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Media.Imaging;

namespace Bedna
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// C:\Users\RomanNice\source\repos\Bedna\obrazky
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            string[] imgfiles = Directory.GetFiles("obrazky");
            string[] medfiles = Directory.GetFiles("zvuky");

            MainWindow mw = new MainWindow(new ImageData(imgfiles), new MediaData(medfiles));
            mw.Show();
        }
    }
}
