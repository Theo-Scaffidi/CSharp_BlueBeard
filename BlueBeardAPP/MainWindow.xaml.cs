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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace BlueBeardAPP
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MySqlConnection connexion = new MySqlConnection("database=MyDB; server=localhost; user id=root; pwd=");
            try {
                connexion.Open();
                MessageBox.Show("Connecté");
                connexion.Close();
            }
            catch
            {
                MessageBox.Show("Non Connecté");
            }
        }
    }
}
