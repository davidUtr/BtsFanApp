using BtsForever.Model;
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

namespace BtsForever.View
{
    /// <summary>
    /// Логика взаимодействия для secondTestWindow.xaml
    /// </summary>
    public partial class secondTestWindow : Window
    {
        int nomer = 0, max = 7, res, ocenca = 0;
        string name = CurrentUser.Name;
        TestMenuWindow test = new TestMenuWindow();


        Questions[] q1;

        class Questions
        {
            private string _image;

          
            private string answer1;

            public string Answer1
            {
                get { return answer1; }
                set { answer1 = value; }
            }
            private string answer2;

            public string Answer2
            {
                get { return answer2; }
                set { answer2 = value; }
            }
            private string answer3;

            public string Answer3
            {
                get { return answer3; }
                set { answer3 = value; }
            }
            private string answer4;

            public string Answer4
            {
                get { return answer4; }
                set { answer4 = value; }
            }
            public string Image
            {
                get => _image;
                set => _image = value;
            }
            private string res;

            public string Res
            {
                get { return res; }
                set { res = value; }
            }

            public Questions(string a, string b, string c, string d, string r, string image)
            {

                this.answer1 = a;
                this.answer2 = b;
                this.answer3 = c;
                this.answer4 = d;
                this.Image = image;
                this.res = r;
            }
        }
        public secondTestWindow()
        {
            InitializeComponent();
            Questions[] q =
             {
                new Questions("a. Run", "b. Fake Love", "c. No more dream", "d. Dynamite", "d",Directory.GetCurrentDirectory() +"\\Image3\\Dynamite.jpg"),
                new Questions("a. Fake Love", "b. Crystal Moet","c. Dynamite","d. Black swan", "d",Directory.GetCurrentDirectory() +"\\Image3\\Blackswan.jpg"),
                new Questions("a. Fake Love", "b. No more dream", "c. Dynamite", "d. Run", "a",Directory.GetCurrentDirectory() +"\\Image3\\Fakelove.jpg"),
                new Questions("a. No more dream", "b. Dynamite", "c. I need you", "d. Black swan", "c",Directory.GetCurrentDirectory() +"\\Image3\\Ineedyou.jpg"),
                new Questions("a. Run", "b. No more dream", "c. Boy In Love","d. Dynamite", "a",Directory.GetCurrentDirectory() +"\\Image3\\Run.jpg"),
                new Questions("a. Dynamite", "b. No more dream", "c. Run", "d. Boy In Love", "b", Directory.GetCurrentDirectory() + "\\Image3\\Nomoredream.jpg"),
                new Questions("a. I need you", "b. Boy In Love", "c. Dynamite","d. Run", "b",Directory.GetCurrentDirectory() +"\\Image3\\Boyinlov.jpg")};

            q1 = q;

            answer1.Content = q[0].Answer1;
            answer2.Content = q[0].Answer2;
            answer3.Content = q[0].Answer3;
            answer4.Content = q[0].Answer4;
            questionImg.Source = new BitmapImage(new Uri(q[0].Image));
        }
        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (nomer < max)
            {

                if (answer1.IsChecked == true)
                {
                    if (q1[nomer].Res == "a")
                    { res++; ocenca++; }
                    answer1.IsChecked = false;
                    answer2.IsChecked = false;
                    answer3.IsChecked = false;
                    answer4.IsChecked = false;
                }
                if (answer2.IsChecked == true)
                {
                    if (q1[nomer].Res == "b")
                    { res++; ocenca++; }
                    answer1.IsChecked = false;
                    answer2.IsChecked = false;
                    answer3.IsChecked = false;
                    answer4.IsChecked = false;
                }
                if (answer3.IsChecked == true)
                {
                    if (q1[nomer].Res == "c")
                    { res++; ocenca++; }
                    answer1.IsChecked = false;
                    answer2.IsChecked = false;
                    answer3.IsChecked = false;
                    answer4.IsChecked = false;
                }
                if (answer4.IsChecked == true)
                {
                    if (q1[nomer].Res == "d")
                    { res++; ocenca++; }
                    answer1.IsChecked = false;
                    answer2.IsChecked = false;
                    answer3.IsChecked = false;
                    answer4.IsChecked = false;
                }
                nomer++;
                if (nomer < max)
                {
                    answer1.Content = q1[nomer].Answer1;
                    answer2.Content = q1[nomer].Answer2;
                    answer3.Content = q1[nomer].Answer3;
                    answer4.Content = q1[nomer].Answer4;
                    questionImg.Source = new BitmapImage(new Uri(q1[nomer].Image));
                }
                else
                {
                    if (ocenca <= 3)
                    {
                        MessageBox.Show($"{name}, вы набрали: {ocenca} балла. Вы невнимательно смотрели клипы группы");
                        test.Show();
                        this.Close();
                    }
                    if (ocenca == 4 || ocenca == 5)
                    {
                        MessageBox.Show($"{name}, вы набрали: {ocenca} балла. Вы точно смотрели несколько клипов группы!");
                        test.Show();
                        this.Close();
                    }
                    if (ocenca >= 6)
                    {
                        MessageBox.Show($"{name}, вы набрали: {ocenca} баллов. Вы очень хороши. Смотрели все клипы и помните все эти кадры! Так держать!");
                        test.Show();
                        this.Close();
                    }

                }

            }

        }
        private void closeImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
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

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
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
    }
}

