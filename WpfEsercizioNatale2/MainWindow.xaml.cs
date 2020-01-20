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

namespace WpfEsercizioNatale2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calcola_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
             //  MessageBox.Show("Inserisci dei numeri!");

            if (cmbOperazione.SelectedIndex == 0)
                {
                    double risultato = num1 + num2;
                    txtRisultato.Text = $"{risultato}";
                }
            if (cmbOperazione.SelectedIndex == 1)
            {
                double risultato = num1 - num2;
                txtRisultato.Text = $"{risultato}";
            }
            if (cmbOperazione.SelectedIndex == 2)
            {
                double risultato = num1 * num2;
                txtRisultato.Text = $"{risultato}";
            }
            if (cmbOperazione.SelectedIndex == 3)
            {
                double risultato = num1 / num2;
                txtRisultato.Text = $"{risultato}";
                if( num1 ==0 || num2 == 0)
                    MessageBox.Show("Numero non valido!");
            }

        }
    }
}
