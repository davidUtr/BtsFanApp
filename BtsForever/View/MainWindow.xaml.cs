using BtsForever.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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

namespace BtsForever
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitBtn__MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            Application.Current.Shutdown();
        }

        private void InformationBtn__MouseDown(object sender, MouseButtonEventArgs e)
        {
            InfoWindow info = new InfoWindow();
            info.Show();
            this.Close();
        }

        private void ClipsBtn__MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=rBG5L7UsUxA&list=PLuyn1kMf4X1hZcAMBF3am9zS4HWxTW-FM");
        }

        private void TestsBtn__MouseDown(object sender, MouseButtonEventArgs e)
        {
            TestMenuWindow test = new TestMenuWindow();
            test.Show();
            this.Close();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
           this.DragMove();
        }
    }
}
