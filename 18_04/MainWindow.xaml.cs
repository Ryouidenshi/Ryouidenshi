
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
            playerInMenu.Stop();
            playerScreamer.Open(new Uri("C:/Users/Stas74/Desktop/18_04/skrip.mp3", UriKind.RelativeOrAbsolute));
            playerScreamer.Play();
        }

        string size;
        string massive;
        bool goNextLevel = false;
       private void Checked(object sender, RoutedEventArgs e)
       {
            System.Windows.Controls.RadioButton pressed = (System.Windows.Controls.RadioButton)sender;
            if (pressed.IsChecked==true && pressed.Content.ToString() == "Stack")
                massive = "Stack";
            if (pressed.IsChecked == true && pressed.Content.ToString() == "Double")
                size = "Double";
            if (pressed.IsChecked == true && pressed.Content.ToString() == "Int")
                size = "Int";
            if (pressed.IsChecked == true && pressed.Content.ToString() == "Long")
                size = "Long";
            if (pressed.IsChecked == true && pressed.Content.ToString() == "List")
                massive = "List";
            if (pressed.IsChecked == true && pressed.Content.ToString() == "Dictionary")
                massive = "Dictionary";
            if (size == "Double" && massive == "Stack")
                goNextLevel = true;
        }

        private void ButtonToMoveNextLevelIfTrueAnswer(object sender, RoutedEventArgs e)
        {
            LevelSecond levelSecond = new LevelSecond();
            CrashWindow crashWindow;
            if (goNextLevel)
            {
                this.Close();
                playerInMenu.Stop();
                levelSecond.Show();
            }
            else
                System.Windows.MessageBox.Show("Вы ответили неверно");
        }
        readonly MediaPlayer playerInMenu = new MediaPlayer();
        bool playing = false;
        private void PlayMusic(object sender, RoutedEventArgs e)
        {        
            if (!playing)
            {
                playerInMenu.MediaFailed += (s, k) => System.Windows.MessageBox.Show("Error");
                playerInMenu.Open(new Uri("C:/Users/Stas74/Desktop/18_04/music.mp3", UriKind.RelativeOrAbsolute));
                playerInMenu.Play();
                playing = true;
            }
            else
            {
                playerInMenu.Stop();
                playing = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/jekalya");
        }      
    }  

}
