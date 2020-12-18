using M14_15_SinglePage.Consultas;
using M14_15_SinglePage.Emprestimos;
using M14_15_SinglePage.Leitores;
using M14_15_SinglePage.Livros;
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

namespace M14_15_SinglePage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseDados bd = new BaseDados();
        public MainWindow()
        {
            InitializeComponent();
            _NavigationFrame.Content = new p_consultas(bd);
        }
        //leitores
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Content = new p_leitores(bd);
        }
        //livros
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Content = new p_livros(bd);
        }
        //emprestimos
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Content = new p_emprestimos(bd);
        }
        //sair
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        //consultas
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Content = new p_consultas(bd);
        }
    }
}
