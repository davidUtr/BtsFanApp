using BtsForever.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
using static System.Net.Mime.MediaTypeNames;

namespace BtsForever.View
{
    /// <summary>
    /// Логика взаимодействия для firstTestWindow.xaml
    /// </summary>
    public partial class firstTestWindow : Window
    {
        int nomer = 0, max = 7, res, ocenca = 0;
        string name = CurrentUser.Name;
        TestMenuWindow test = new TestMenuWindow();


        Questions[] q1;

        class Questions
        {
            private string _image;
            private string qustion;
            public string Qustion
            {
                get { return qustion; }
                set { qustion = value; }
            }
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

            public Questions(string _question, string a, string b, string c, string d, string r, string image)
            {
                this.qustion = _question;
                this.answer1 = a;
                this.answer2 = b;
                this.answer3 = c;
                this.answer4 = d;
                this.Image = image;
                this.res = r;
            }
        }
        public firstTestWindow()
        {
            InitializeComponent();

            Questions[] q =
               {
                new Questions("1. Ким Тэхён", "a. V", "b. JK", "c. JM", "d. Suga", "a",Directory.GetCurrentDirectory() +"\\Image2\\Teguk.jpg"),
                new Questions("2. Чон Чонгук", "a. JM", "b. RM","c. JK","d. Agust D", "c",Directory.GetCurrentDirectory() +"\\Image2\\Chonguk.jpg"),
                new Questions("3. Мин Юнги", "a. RM", "b. Suga", "c. V", "d. J-Hope", "b",Directory.GetCurrentDirectory() +"\\Image2\\Ungi.jpg"),
                new Questions("4. Ким Сокджин", "a. V", "b. Worldwide handsome", "c. SUGA", "d. JK", "b",Directory.GetCurrentDirectory() +"\\Image2\\Sokjin.jpg"),
                new Questions("5. Пак Чимин","a. JM", "b. JK", "c. JC","d. PJ", "a",Directory.GetCurrentDirectory() +"\\Image2\\Chimin.jpg"),
                new Questions("6. Ким Намджун", "a. JM", "b. J-Hope", "c. RM", "d. Suga", "c", Directory.GetCurrentDirectory() + "\\Image2\\Namjun.jpg"),
                new Questions("7. Чон Хосок","a. Hosok", "b. RM", "c. JM","d. J-Hope", "d",Directory.GetCurrentDirectory() +"\\Image2\\hosok.jpg")};

        q1 = q;
            Question.Text = q[0].Qustion;
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
                    Question.Text = q1[nomer].Qustion;
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
                        MessageBox.Show($"{name}, вы набрали: {ocenca} балла. Вы плохо знакомы с группой и не знаете их псевдонимы");
                        test.Show();
                        this.Close();
                    }
                    if (ocenca ==4)
                    {
                        MessageBox.Show($"{name}, вы набрали: {ocenca} балла. Вы не плохо знакомы с группой и знаете некоторые псевдонимы");
                        test.Show();
                        this.Close();
                    }
                    if (ocenca >= 5)
                    {
                        MessageBox.Show($"{name}, вы набрали: {ocenca} баллов. Вы хорошо знаете псевдонимы участников группы. Вы большой молодец!");
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
