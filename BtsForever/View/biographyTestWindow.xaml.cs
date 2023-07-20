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
    /// Логика взаимодействия для biographyTestWindow.xaml
    /// </summary>
    public partial class biographyTestWindow : Window
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
        public biographyTestWindow()
        {
            InitializeComponent();
            Questions[] q =
                   {
                new Questions("1. В каком году дебютировала группа?", "a. 2012", "b. 2011", "c. 2013", "d. 2009", "c",Directory.GetCurrentDirectory() +"\\Image5\\a1.jpg"),
                new Questions("2. Самый старший участник группы?", "a. Ким Сокджин", "b. Пак Чимин","c. Чон Чонгук","d. Мин Юнги", "a",Directory.GetCurrentDirectory() +"\\Image5\\a2.jpg"),
                new Questions("3. Как называют фанатов группы?", "a. Blink", "b. Suga", "c. Btsniki", "d. Army", "d",Directory.GetCurrentDirectory() +"\\Image5\\a3.jpg"),
                new Questions("4. До дебюта состав BTS часто менялся. В итоге в группе остался только один участник из первоначального состава. Кто он?", "a. V", "b. JK", "c. SUGA", "d. RM", "d",Directory.GetCurrentDirectory() +"\\Image5\\a4.jpg"),
                new Questions("5. Какой альбом BTS стал первым k-pop альбомом, занявшим первое место в Billboard 200?","a. Love Yourself: Tear", "b. Be", "c. Wings","d. Map of the Soul: Persona", "a",Directory.GetCurrentDirectory() +"\\Image5\\a5.jpg"),
                new Questions("6. С какой песней впервые была представлена вселенная BTS?", "a. Blood Sweat & Tears", "b. Boy with love", "c. I need you", "d. Dynamite", "c", Directory.GetCurrentDirectory() + "\\Image5\\a6.jpg"),
                new Questions("7. С каким синглом дебютировали BTS?","a. No More Dream", "b. N.O", "c. Danger","d. War of Hormone", "a",Directory.GetCurrentDirectory() +"\\Image5\\a7.jpg")};

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
                        MessageBox.Show($"{name}, вы набрали: {ocenca} балла. Вы плохо знакомы с группой");
                        test.Show();
                        this.Close();
                    }
                    if (ocenca == 4)
                    {
                        MessageBox.Show($"{name}, вы набрали: {ocenca} балла. Вы не плохо знакомы с группой, но вам есть ещё куда расти");
                        test.Show();
                        this.Close();
                    }
                    if (ocenca >= 5)
                    {
                        MessageBox.Show($"{name}, вы набрали: {ocenca} баллов. Вы хорошо знаете группу и вы истинный ARMY. Поздравляем!");
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
