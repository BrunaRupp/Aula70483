using ClasseCadastroPessoas.Classes;
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

namespace ClasseCadastroPessoas
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Pessoa> Pessoas = new List<Pessoa>
        {
            new Pessoa()
            {
                NomeCompleto = "João Arthur",
                DataNascimento = "15/07/1990"

            },
            new Pessoa()
            {
                NomeCompleto = "Maria Joana",
                DataNascimento = "25/02/1927"
            },
            new Pessoa()
            {
                NomeCompleto = "Luiz Miguel",
                DataNascimento = "30/10/2010"
            }

        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ()
        }
    }
}
