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

namespace PrezzoQuantitàWPF
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

        private void btmMostra_Click(object sender, RoutedEventArgs e)
        {
            int s;
            if (txtSconto.Text != "")
                s = int.Parse(txtSconto.Text);
            else
                s = 0;

            if (s < 0 ||  s > 100)
                {
                MessageBox.Show("Sconto non accettato", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
                else
            {
                if (txtQuantita.Text != "" && txtPrezzo.Text != "")
                {


                    try
                    {
                        double p = double.Parse(txtPrezzo.Text);
                        int q = int.Parse(txtQuantita.Text);
                        double prezzo = p * q;
                        if (txtSconto.Text == "" ||  s < 20)
                            {
                            lblRisultato.Content = prezzo;
                        }
                            else
                        {
                            double sconto = (prezzo * s) / 100;
                            double totale = prezzo - sconto;
                            lblRisultato.Content = totale;
                        }

                    }
                    catch (Exception ex)
                    {
                        lblRisultato.Content = ex.Message;
                    }
                }
                else
                {
                    MessageBox.Show("Inserire tutti i valori richiesti", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
