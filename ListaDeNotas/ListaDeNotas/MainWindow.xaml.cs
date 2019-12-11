using ListaDeNotas.Classes;
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

namespace ListaDeNotas
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = Notas;
        }
        List<Nota> Notas = new List<Nota>
        {
            new Nota()
            {
                Materia = "Geografia",
                Valor = 8
            },
            new Nota()
            {
                Materia = "História",
                Valor = 9
            },
            new Nota()
            {
                Materia = "Matemática",
                Valor = 8
            }
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var media = Notas.Average(x => x.Valor);
            if (media >= 7)
            {
                MessageBox.Show($"Média final: {media}. Parabéns você está aprovado!");
            }
            else
            {
                MessageBox.Show($"Média final: {media}. Você está reprovado.");
            }

            //Como fazer If de uma linha só: 
        }   //MessageBox.Show($"Você está " + (Notas.Average(x => x.Valor) >=7? "Aprovado":"Reprovado"));
        
    }
}
