using AplicacaoTelefone.Model;
using AplicacaoTelefone.View;
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

namespace AplicacaoTelefone
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Context.Telefones.ToList<Telefone>();
        }

        CadastroContext Context = new CadastroContext();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastroTelefone cadastroTelefone = new CadastroTelefone();

            cadastroTelefone.ShowDialog();

            Context.Telefones.Add(cadastroTelefone.Telefone);
            Context.SaveChanges();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Context.Telefones.ToList<Telefone>();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var index = ((System.Windows.Controls.Primitives.Selector)sender).SelectedIndex;

            Context.Telefones.Remove((Telefone)dataGrid.Items[index]);
            Context.SaveChanges();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Context.Telefones.ToList<Telefone>();
        }
    }
}
