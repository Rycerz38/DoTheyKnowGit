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
    /// Główne okno do sprawdzania danych w bazie.
    /// Aplikacja startuje tutaj i pozwala użytkonikowi na sprawdzenie czy jego dane są w bazie wyciekniętych danych
    /// ponadto możemy stąd wejść do okna rozszerzenia bazy danych o kolejne rekordy
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e) 
        {
            CzyNull = false; //czyszczenie zmiennej
        }
        public bool CzyNull = false; //zmienna odpowiedzialna za stan "czy rekord jest w bazie"
        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            string ValueToCheck = InputTB.Text; //zczytanie danych wejściowych
            DoTheyKnowMainDBEntities context = new DoTheyKnowMainDBEntities();


            if (mail.IsChecked == true) // sprawdzamy którą daną będziemy sprawdzać
            {
                kom wynik = context.koms.FirstOrDefault(k => k.email == InputTB.Text); //wyszukanie w bazie rekordu i sprawdzenie czy istnieje
                try
                {
                    CzyNull = true ;
                    konsola.Text = wynik.Id.ToString();
                    if (wynik !=null) {
                    CzyNull=false;
                    }
                }
                catch (NullReferenceException)
                {

                }
                Morele wynik2 = context.Moreles.FirstOrDefault(m => m.email == InputTB.Text);//wyszukanie w bazie rekordu i sprawdzenie czy istnieje
                try
                {
                    konsola.Text = wynik2 .Id.ToString();
                    if (wynik2 != null)
                    {
                        CzyNull = false;
                    }
                }
                catch (NullReferenceException)
                {


                }
                wsei wynik3 = context.wseis.FirstOrDefault(w => w.email == InputTB.Text);//wyszukanie w bazie rekordu i sprawdzenie czy istnieje
                try
                {
                    konsola.Text = wynik3.Id.ToString();
                    if (wynik3 != null)
                    {
                        CzyNull = false;
                    }
                }
                catch (NullReferenceException)
                {
                    //Code to do something with exeption
                    CzyNull = true;

                }
                konsola.Text = "Nie musisz nic zmieniac :)!";

                if (!CzyNull) //instrukcja warunkowa która wyświetla okno "Your data Leaked"
                {
                    konsola.Text = "Zmień adres email!";
                    Window3 win3 = new Window3();
                    win3.Show();

                }
                else //instrukcja która wyświetla okno "Your data is safe"
                {

                    konsola.Text = "jestes bezpieczny";
                    Window2 win2 = new Window2();
                    win2.Show();
                }
            }
            else if (phone.IsChecked == true)// sprawdzamy którą daną będziemy sprawdzać
            {


                kom wynik = context.koms.FirstOrDefault(k => k.phone == InputTB.Text);//wyszukanie w bazie rekordu i sprawdzenie czy istnieje
                try
                {
                    CzyNull = true;
                    konsola.Text = wynik.Id.ToString();
                    if (wynik != null)
                    {
                        CzyNull = false;
                    }
                }
                catch (NullReferenceException)
                {

                }
                Morele wynik2 = context.Moreles.FirstOrDefault(m => m.phone == InputTB.Text);//wyszukanie w bazie rekordu i sprawdzenie czy istnieje
                try
                {
                    konsola.Text = wynik2.Id.ToString();
                    if (wynik2 != null)
                    {
                        CzyNull = false;
                    }
                }
                catch (NullReferenceException)
                {


                }
                wsei wynik3 = context.wseis.FirstOrDefault(w => w.phone == InputTB.Text);//wyszukanie w bazie rekordu i sprawdzenie czy istnieje
                try
                {
                    konsola.Text = wynik3.Id.ToString();
                    if (wynik3 != null)
                    {
                        CzyNull = false;
                    }
                }
                catch (NullReferenceException)
                {
                    //Code to do something with exeption
                    CzyNull = true;

                }
                konsola.Text = "Nie musisz nic zmieniac :)!";

                if (!CzyNull)//instrukcja która wyświetla okno "Your data Leaked"
                {
                    konsola.Text = "Zmień numer telefonu!";
                    Window3 win3 = new Window3();
                    win3.Show();

                }
                else//instrukcja która wyświetla okno "Your data is safe"
                {

                    konsola.Text = "jestes bezpieczny";
                    Window2 win2 = new Window2();
                    win2.Show();
                }

            }
            else if (imie.IsChecked == true)// sprawdzamy którą daną będziemy sprawdzać
            {
                kom wynik = context.koms.FirstOrDefault(k => k.name == InputTB.Text);//wyszukanie w bazie rekordu i sprawdzenie czy istnieje
                try
                {
                    CzyNull = true;
                    konsola.Text = wynik.Id.ToString();
                    if (wynik != null)
                    {
                        CzyNull = false;
                    }
                }
                catch (NullReferenceException)
                {

                }
                Morele wynik2 = context.Moreles.FirstOrDefault(m => m.name == InputTB.Text);//wyszukanie w bazie rekordu i sprawdzenie czy istnieje
                try
                {
                    konsola.Text = wynik2.Id.ToString();
                    if (wynik2 != null)
                    {
                        CzyNull = false;
                    }
                }
                catch (NullReferenceException)
                {


                }
                wsei wynik3 = context.wseis.FirstOrDefault(w => w.name == InputTB.Text);//wyszukanie w bazie rekordu i sprawdzenie czy istnieje
                try
                {
                    konsola.Text = wynik3.Id.ToString();
                    if (wynik3 != null)
                    {
                        CzyNull = false;
                    }
                }
                catch (NullReferenceException)
                {
                    //Code to do something with exeption
                    CzyNull = true;

                }
                konsola.Text = "Nie musisz nic zmieniac :)!";

                if (!CzyNull) //instrukcja która wyświetla okno "Your data Leaked"
                {
                    konsola.Text = "Zmień adres email!";
                    Window3 win3 = new Window3();
                    win3.Show();

                }
                else //instrukcja która wyświetla okno "Your data is safe"
                {

                    konsola.Text = "jestes bezpieczny";
                    Window2 win2 = new Window2();
                    win2.Show();
                }
            }
            else //sytuacja gdy użytkownik nie wybierze żadnego radio buttona
            {
                konsola.Text = "Nie wybrano opcji!";
            }

        }

        private void subscribeButton_Click(object sender, RoutedEventArgs e)
        {
            //Window1 win = new Window1();
            //win.Show();
        }
    }
}
