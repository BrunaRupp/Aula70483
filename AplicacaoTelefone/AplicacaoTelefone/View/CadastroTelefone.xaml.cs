using AplicacaoTelefone.Model;
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

namespace AplicacaoTelefone.View
{
    /// <summary>
    /// Lógica interna para CadastroTelefone.xaml
    /// </summary>
    public partial class CadastroTelefone : Window
    {
        public CadastroTelefone()
        {
            InitializeComponent();
        }

        public Telefone Telefone { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Telefone = new Telefone()
            {
                Numero = tbxNumero.Text
            };

            this.Close();

        }
    }
}
