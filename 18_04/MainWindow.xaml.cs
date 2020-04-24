
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;


namespace _18_04
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        readonly MediaPlayer playerScreamer = new MediaPlayer();
        private void PlayScreamer(object sender, RoutedEventArgs e)
        {
            CrashWindow crashWindow = new CrashWindow();
            crashWindow.Show();
            this.Close();
            cakeBoyInMenu.Stop();
            playerScreamer.Open(new Uri("C:/Users/Stas74/Desktop/18_04/Music/skrip.mp3", UriKind.RelativeOrAbsolute));
            playerScreamer.Play();
        }

        private string Size { get; set; }
        private string Massive { get; set; }
        private bool GoNextLevel { get; set; }

        private void Checked(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.RadioButton pressed = (System.Windows.Controls.RadioButton)sender;
            switch (pressed.Content.ToString())
            {
                case "Stack":
                    Massive = "Stack";
                    break;
                case "Double":
                    Size = "Double";
                    break;
                case "Int":
                    Size = "Int";
                    break;
                case "Long":
                    Size = "Long";
                    break;
                case "List":
                    Massive = "List";
                    break;
                case "Dictionary":
                    Massive = "Dictionary";
                    break;
            }
            if (Size == "Double" && Massive == "Stack")
                GoNextLevel = true;
        }

        private void ButtonToMoveNextLevelIfTrueAnswer(object sender, RoutedEventArgs e)
        {
            LevelSecond levelSecond = new LevelSecond();
            if (GoNextLevel)
            {
                this.Close();
                cakeBoyInMenu.Stop();
                levelSecond.Show();
            }
            else
                System.Windows.MessageBox.Show("Вы ответили неверно");
        }

        readonly MediaPlayer cakeBoyInMenu = new MediaPlayer();
        private bool Playing { get; set; }

        private bool FileIsOpened { get; set; }

        private void PlayMusic(object sender, RoutedEventArgs e)
        {
            if (!FileIsOpened)
            {
                cakeBoyInMenu.Open(new Uri("C:/Users/Stas74/Desktop/18_04/Music/music.mp3", UriKind.RelativeOrAbsolute));
                FileIsOpened = true;
            }

            if (!Playing)
            {
                cakeBoyInMenu.Play();
                Playing = true;
            }
            else
            {
                cakeBoyInMenu.Pause();
                Playing = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/jekalya");
        }      
    }  

}
