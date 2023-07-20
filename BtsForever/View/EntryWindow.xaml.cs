using BtsForever.Model;
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
    /// Логика взаимодействия для EntryWindow.xaml
    /// </summary>
    public partial class EntryWindow : Window
    {
        public EntryWindow()
        {
            InitializeComponent();
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            if (nameTextBlock.Text == "")
            {
                MessageBox.Show("Введите имя или псевдоним");
            }
            else
            {
                CurrentUser.Name = nameTextBlock.Text;
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }
        private void closeImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizedRec_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void SupportImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SupportWindow support = new SupportWindow();
            support.Show();
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

        private void SupportImg_MouseEnter(object sender, MouseEventArgs e)
        {
            SupportImg.Opacity= 1;
        }

        private void SupportImg_MouseLeave(object sender, MouseEventArgs e)
        {
            SupportImg.Opacity = 0.3;
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
