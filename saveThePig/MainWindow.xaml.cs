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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace saveThePig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public class Player
    {
        public String Name { get; set; }
        public int Score { get; set; }
    }

    public partial class MainWindow : Window
    {
        List<string> Words = new List<string>();
        List<Player> players = new List<Player>();
        public static Random random = new Random();
        public static int scoreValue = 10;
        public static readonly int MAXIMUM_TRIAL = 6;
        // current target word
        public static string Word ="";
        //var to store the name
        string PlayerNameOne;


        public MainWindow()
        {
            LoadWords();
            InitializeComponent();
            NewRandomWord();

            int NUMBER_OF_USER = 3;
            for (int i = 0; i < NUMBER_OF_USER; i++)
                players.Add(new Player { Name ="Player "+(i+1), Score = 0});

        }

        private void LoadWords()
        {
            StreamReader WordsFileReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory+"Words.txt");
            while(!WordsFileReader.EndOfStream)
            {
                Words.Add(WordsFileReader.ReadLine());
            }
            WordsFileReader.Close();
        }

        private void NewRandomWord()
        {
            do
            {
                Word = Words[random.Next(0, Words.Count)];
            } while (Word.Length < 3 || Word.Length > 10);

            // disable button

            for(int i = Word.Length+1; i<11 ; i++)
            {
                ((Label)this.FindName("Label"+i)).Visibility = System.Windows.Visibility.Hidden;
            }

        }
        void InputButtonClick(object sender, RoutedEventArgs e)
        {
            char guess = ((Button)e.Source).Content.ToString().ToLower()[0];

            // if the word exist in targetWord
            if(Word.ToLower().Contains(guess))
            {
                // disable button
                ((Button)e.Source).IsEnabled = false;

                // display word
                for (int i = 0; i < Word.Length; i++)
                {
                    if(Word[i] == guess)
                    ((Label)this.FindName("Label" +(i+1))).Content = guess.ToString().ToUpper();
                }

                // get score

                // turn doens't change
            }
            else
            {
                // change turn

                // pig will go down
            }
        }

        private void refresh_game(object sender, RoutedEventArgs e)
        {
            //NOT WORKING NEED TO RE ADJUST...s
            //Declare instance of  Main Window
            MainWindow mainWindow = new MainWindow();
            PlayerNameOne = Player1.Text;
            //Assign the given name to the player's name on the other window
            mainWindow.Player1.Text = PlayerNameOne;
            //show the window
            mainWindow.Show();
            //close intro window
            this.Hide();
        }
    }
}
