using ClasseCarros.Classes;
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

namespace ClasseCarros
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = Carros;

        }
        List<Carro> Carros = new List<Carro>
        {
            new Carro()
            {
                 Modelo = "Gol",
                 Marca = "VW",
                 Ano = 2012
            },
            new Carro()
            {
                Modelo = "Sandero",
                Marca = "Renault",
                Ano = 2018
            },
            new Carro()
            {
                 Modelo = "Chevette",
                 Marca = "Chevrolet",
                 Ano = 1974
            }

        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Carros.Add(new Carro()
            {
                Modelo = tbxModelo.Text,
                Marca = tbxMarca.Text,
                Ano = int.Parse(tbxAno.Text)
            });

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Carros;

        }
    }
}
