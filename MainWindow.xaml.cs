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

namespace DoTheyKnow
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

    }
        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            string ValueToCheck = InputTB.Text;
            DoTheyKnowMainDBEntities context = new DoTheyKnowMainDBEntities();
            

            if (mail.IsChecked == true)
            {
                kom wynik = context.koms.FirstOrDefault(k => k.email == InputTB.Text);
                try
                {
                    konsola.Text = wynik.Id.ToString();
                }
                catch (NullReferenceException exep)
                {
                    //Code to do something with e
                    konsola.Text = "jestes bezpieczny";

                }
            }
            else if (phone.IsChecked == true)
            {
                kom wynik = context.koms.FirstOrDefault(k => k.phone == InputTB.Text);
                try
                {
                    konsola.Text = wynik.Id.ToString();
                }
                catch (NullReferenceException exep)
                {
                    //Code to do something with e
                    konsola.Text = "jestes bezpieczny";

                }
            }
            else if (imie.IsChecked == true)
            {
                kom wynik = context.koms.FirstOrDefault(k => k.name == InputTB.Text);
                try
                {
                    konsola.Text = wynik.Id.ToString();
                }
                catch (NullReferenceException exep)
                {
                    //Code to do something with e
                    konsola.Text = "jestes bezpieczny";

                }
            }
            else
            {
                konsola.Text = "Nie wybrano opcji!";
            }
        }

    }
    

}
