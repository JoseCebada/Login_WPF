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

namespace LoginWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Login con puerta abierta";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnIniciar_Click(object sender, RoutedEventArgs e)
        {
            if(txtName.Text == "juancho" && txtPass.Text == "123tamarindo")
            {
                Window form = new Window();
                form.ShowDialog();
            }
        }
    }
}
