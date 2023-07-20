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
using System.Windows.Shapes;

namespace BtsForever.View
{
    /// <summary>
    /// Логика взаимодействия для TestMenuWindow.xaml
    /// </summary>
    public partial class TestMenuWindow : Window
    {
        public TestMenuWindow()
        {
            InitializeComponent();
        }

        private void InformationBtn__MouseDown(object sender, MouseButtonEventArgs e)
        {
            firstTestWindow first = new firstTestWindow();
            first.Show();
            this.Close();
        }
        private void closeImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void MinimizedRec_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }



        private void closeImage_MouseEnter(object sender, MouseEventArgs e)
        {
            closeImage.Opacity = 0.8;
        }

        private void closeImage_MouseLeave(object sender, MouseEventArgs e)
        {
            closeImage.Opacity = 0.3;
        }

        private void MinimizedRec_MouseEnter(object sender, MouseEventArgs e)
        {
            MinimizedRec.Opacity = 1;
        }

        private void MinimizedRec_MouseLeave(object sender, MouseEventArgs e)
        {
            MinimizedRec.Opacity = 0.7;
        }

        private void ClipsBtn__MouseDown(object sender, MouseButtonEventArgs e)
        {
            secondTestWindow second = new secondTestWindow();
            second.Show();
            this.Close();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void TestsBtn__MouseDown(object sender, MouseButtonEventArgs e)
        {
            thirdTestWindow thirdTest = new thirdTestWindow();
            thirdTest.Show();
            this.Close();
        }

        private void ExitBtn__MouseDown(object sender, MouseButtonEventArgs e)
        {
            biographyTestWindow biography = new biographyTestWindow();
            biography.Show();
            this.Close();
        }
    }
}
