using BtsForever.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Linq;

namespace BtsForever.View
{
    /// <summary>
    /// Логика взаимодействия для InfoWindow.xaml
    /// </summary>
    /// 
    public partial class InfoWindow : Window
    {
        
            public InfoWindow()
        {
            InitializeComponent();
            infoText.Document.Blocks.Clear();

        }
        private void closeImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
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

        private void returnMaiNWindow_MouseEnter(object sender, MouseEventArgs e)
        {
            returnMaiNWindow.Opacity = 1;
        }

        private void returnMaiNWindow_MouseLeave(object sender, MouseEventArgs e)
        {
            returnMaiNWindow.Opacity = 0.6;
        }

        private void returnMaiNWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void TeGook_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
              
                string rtf = "Txt_Files\\TeGuk.rtf";
                System.IO.FileStream streamToRtfFile = new System.IO.FileStream(rtf, System.IO.FileMode.Open);
                infoText.Selection.Load(streamToRtfFile, DataFormats.Rtf);
            }
            catch
            {
                infoText.Document.Blocks.Clear();
                MessageBox.Show("Произошла ошибка! Делаем всё возможное чтобы это исправить");
            }
        }

        private void ChonGuk_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
       
            string rtf = "Txt_Files\\ChonGuk.rtf";
            System.IO.FileStream streamToRtfFile = new System.IO.FileStream(rtf, System.IO.FileMode.Open);
            infoText.Selection.Load(streamToRtfFile, DataFormats.Rtf);
            }
            catch
            {
                infoText.Document.Blocks.Clear();
                MessageBox.Show("Произошла ошибка! Делаем всё возможное чтобы это исправить");

            }
        }

 
        private void returnBtn_Click(object sender, RoutedEventArgs e)
        {
        
            InfoWindow info = new InfoWindow();
          
            info.Show();
         
            this.Close();
            infoText.Document.Blocks.Clear();

        }

        private void Chimin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {

                string rtf = "Txt_Files\\Chimin.rtf";
                System.IO.FileStream streamToRtfFile = new System.IO.FileStream(rtf, System.IO.FileMode.Open);
                infoText.Selection.Load(streamToRtfFile, DataFormats.Rtf);
            }
            catch
            {
                infoText.Document.Blocks.Clear();
                MessageBox.Show("Произошла ошибка! Делаем всё возможное чтобы это исправить");
            }
        }

        private void Ungi_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {

                string rtf = "Txt_Files\\Ungi.rtf";
                System.IO.FileStream streamToRtfFile = new System.IO.FileStream(rtf, System.IO.FileMode.Open);
                infoText.Selection.Load(streamToRtfFile, DataFormats.Rtf);
            }
            catch
            {
                infoText.Document.Blocks.Clear();
                MessageBox.Show("Произошла ошибка! Делаем всё возможное чтобы это исправить");
            }
        }

        private void SokJin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {

                string rtf = "Txt_Files\\SokJin.rtf";
                System.IO.FileStream streamToRtfFile = new System.IO.FileStream(rtf, System.IO.FileMode.Open);
                infoText.Selection.Load(streamToRtfFile, DataFormats.Rtf);
            }
            catch
            {
                infoText.Document.Blocks.Clear();
                MessageBox.Show("Произошла ошибка! Делаем всё возможное чтобы это исправить");
            }
        }

        private void NamJun_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {

                string rtf = "Txt_Files\\NamJun.rtf";
                System.IO.FileStream streamToRtfFile = new System.IO.FileStream(rtf, System.IO.FileMode.Open);
                infoText.Selection.Load(streamToRtfFile, DataFormats.Rtf);
            }
            catch
            {
                infoText.Document.Blocks.Clear();
                MessageBox.Show("Произошла ошибка! Делаем всё возможное чтобы это исправить");
            }
        }

        private void Hosok_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {

                string rtf = "Txt_Files\\Hosok.rtf";
                System.IO.FileStream streamToRtfFile = new System.IO.FileStream(rtf, System.IO.FileMode.Open);
                infoText.Selection.Load(streamToRtfFile, DataFormats.Rtf);
            }
            catch
            {
                infoText.Document.Blocks.Clear();
                MessageBox.Show("Произошла ошибка! Делаем всё возможное чтобы это исправить");
            }
        }

        private void rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
