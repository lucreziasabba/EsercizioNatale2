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
using System.IO;

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
        private const string file = "Risultati.txt";
        double risultato;
        private void Calcola_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            string operatore = "";
            if (cmbOperazione.SelectedIndex == 0)
            {
                operatore = "+";
                double somma = num1 + num2;
                risultato = somma;
                txtRisultato.Text = $"{somma}";
            }
            if (cmbOperazione.SelectedIndex == 1)
            {
                operatore = "-";
                double sottrazione = num1 - num2;
                risultato = sottrazione;
                txtRisultato.Text = $"{sottrazione}";
            }
            if (cmbOperazione.SelectedIndex == 2)
            {
                operatore = "*";
                double moltiplicazione = num1 * num2;
                risultato = moltiplicazione;
                txtRisultato.Text = $"{moltiplicazione}";
            }
            if (cmbOperazione.SelectedIndex == 3)
            {
                operatore = "/";
                double divisione = num1 / num2;
                risultato = divisione;
                txtRisultato.Text = $"{divisione}";
                if(num1==0 || num2==0)
                    MessageBox.Show("Numero non valido!");
            }
            using (StreamWriter x = new StreamWriter(file, true))
            {
                x.WriteLine($"{num1} {operatore} {num2} = {risultato}");
            }
        }
    }
}
