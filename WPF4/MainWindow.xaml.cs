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

namespace WPF4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Us(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateUs.Text);
            double sum = Convert.ToDouble(sumUs.Text);
            resUs.Text = (rate * sum).ToString();
        }

        private void Button_Click_Eu(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateEu.Text);
            double sum = Convert.ToDouble(sumEu.Text);
            resEu.Text = (rate * sum).ToString();
        }

        private void Button_Click_Ua(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateUa.Text);
            double sum = Convert.ToDouble(sumUa.Text);
            resUa.Text = (rate * sum).ToString();
        }

        private void Button_Click_Am(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateAm.Text);
            double sum = Convert.ToDouble(sumAm.Text);
            resAm.Text = (rate * sum).ToString();
        }

        private void Button_Click_Ins(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateIns.Text);
            resIns.Text = (rate * 0.0254).ToString();
        }

        private void Button_Click_Ft(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateFt.Text);
            resFt.Text = (rate * 0.3048).ToString();
        }

        private void Button_Click_Mile(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateMile.Text);
            resMile.Text = (rate * 1609.34).ToString();
        }

        private void Button_Click_Ver(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateVer.Text);
            resVer.Text = (rate * 1066.8).ToString();
        }
    }
}
