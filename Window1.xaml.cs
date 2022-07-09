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

namespace DoTheyKnow
{
    /// <summary>
    /// Kod służący obsłudze wpisywania danych do bazy
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            
        }
        private void SubmitMail_Click(object sender, RoutedEventArgs e)
        {
            using (DoTheyKnowMainDBEntities context = new DoTheyKnowMainDBEntities()) // Wpisanie bazy do obiektu
            {

                if (komRB.IsChecked == true) // sprawdzenie do ktorej bazy wpisać rekord
                {


                    kom kom = new kom //tworzenie obiektu do wpisania
                    {
                        email = contentTB.Text.ToString(),
                        phone = contentPhoneTB.Text.ToString(),
                        name = contentNameTB.Text.ToString()
                    };


                    context.koms.Add(kom);//dodanie do bazy
                }
                else if (MoreleRB.IsChecked == true)// sprawdzenie do ktorej bazy wpisać rekord
                {


                    Morele morele = new Morele //tworzenie obiektu do wpisania
                    {
                        email = contentTB.Text.ToString(),
                        phone = contentPhoneTB.Text.ToString(),
                        name = contentNameTB.Text.ToString()
                    };


                    context.Moreles.Add(morele);//dodanie do bazy
                }
                else if (wseiRB.IsChecked == true)// sprawdzenie do ktorej bazy wpisać rekord
                {


                    wsei wsei = new wsei//tworzenie obiektu do wpisania
                    {
                        email = contentTB.Text.ToString(),
                        phone = contentPhoneTB.Text.ToString(),
                        name = contentNameTB.Text.ToString()
                    };


                    context.wseis.Add(wsei);//dodanie do bazy
                }
                context.SaveChanges();
            }
        
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
