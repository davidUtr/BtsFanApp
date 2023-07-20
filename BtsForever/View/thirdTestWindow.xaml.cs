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
    /// Логика взаимодействия для thirdTestWindow.xaml
    /// </summary>
    public partial class thirdTestWindow : Window
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
        public thirdTestWindow()
        {
            InitializeComponent();
            Questions[] q =
                  {
                new Questions("a. Ким Тэхён", "b. Ким Сокджин", "c. Чон Чонгук", "d. Чон Хосок", "b",Directory.GetCurrentDirectory() +"\\Image4\\Sokjin.jpg"),
                new Questions("a. Ким Сокджин", "b. Чон Хосок","c. Ким Тэхён","d. Мин Юнги", "c",Directory.GetCurrentDirectory() +"\\Image4\\Teguk.jpg"),
                new Questions("a. Ким Намджун", "b. Ким Тэхён", "c. Ким Сокджин", "d. Чон Хосок", "a",Directory.GetCurrentDirectory() +"\\Image4\\Namjun.jpg"),
                new Questions("a. Мин Юнги", "b. Пак Чимин", "c. Ким Сокджин", "d. Чон Чонгук", "a",Directory.GetCurrentDirectory() +"\\Image4\\Ungi.jpg"),
                new Questions("a. Чон Хосок", "b. Пак Чимин", "c. Чон Чонгук","d. Ким Тэхён", "c",Directory.GetCurrentDirectory() +"\\Image4\\Chonguk.jpg"),
                new Questions("a. Ким Сокджин", "b. Чон Хосок", "c. Ким Тэхён", "d. Пак Чимин", "b", Directory.GetCurrentDirectory() + "\\Image4\\Hosok.jpg"),
                new Questions("a. Чон Чонгук", "b. Ким намджун", "c. Чон Хосок","d. Пак Чимин", "d",Directory.GetCurrentDirectory() +"\\Image4\\Chimin.jpg")};

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
                        MessageBox.Show($"{name}, вы набрали: {ocenca} балла. Вы не узнали этих милых малышей");
                        test.Show();
                        this.Close();
                    }
                    if (ocenca == 4 || ocenca == 5)
                    {
                        MessageBox.Show($"{name}, вы набрали: {ocenca} балла. Вы узнали этих милых малышей!");
                        test.Show();
                        this.Close();
                    }
                    if (ocenca >= 6)
                    {
                        MessageBox.Show($"{name}, вы набрали: {ocenca} баллов. Вы точно за ними следите и любите этих малышей!");
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