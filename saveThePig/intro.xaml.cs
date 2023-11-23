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

namespace saveThePig
{
    /// <summary>
    /// Interaction logic for intro.xaml
    /// </summary>
    public partial class intro : Window
    {
        string PlayerName;

        public intro()
        {
            InitializeComponent();
        }

        private void proceed_to_game(object sender, RoutedEventArgs e)
        {
            PlayerName = playerTextBox.Text;

            if(PlayerName.Length == 0)
            {
                MessageBox.Show("Please enter Player's name to proceed");
            }
            else if(PlayerName.Length > 0 && PlayerName.Length <= 8)
            {
                //Declare instance of  Main Window
                MainWindow mainWindow = new MainWindow();
                //Assign the given name to the player's name on the other window
                mainWindow.Player1.Text = PlayerName;
                //show the window
                mainWindow.Show();
                //close intro window
                this.Hide();
            }
            else
            {
                MessageBox.Show("Player's name is Too long...");
            }    
        }
    }
}
