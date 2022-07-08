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
    /// Kod służący obsłudze wpisywania maili i powiadamiania użytkownika
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            
        }
        private void SubmitMail_Click(object sender, RoutedEventArgs e)
        {
            using (DoTheyKnowMainDBEntities context = new DoTheyKnowMainDBEntities())
            {

                if (komRB.IsChecked == true)
                {


                    kom kom = new kom
                    {
                        email = contentTB.Text.ToString(),
                        phone = contentPhoneTB.Text.ToString(),
                        name = contentNameTB.Text.ToString()
                    };


                    context.koms.Add(kom);
                }
                else if (MoreleRB.IsChecked == true)
                {


                    Morele morele = new Morele
                    {
                        email = contentTB.Text.ToString(),
                        phone = contentPhoneTB.Text.ToString(),
                        name = contentNameTB.Text.ToString()
                    };


                    context.Moreles.Add(morele);
                }
                else if (wseiRB.IsChecked == true)
                {


                    wsei wsei = new wsei
                    {
                        email = contentTB.Text.ToString(),
                        phone = contentPhoneTB.Text.ToString(),
                        name = contentNameTB.Text.ToString()
                    };


                    context.wseis.Add(wsei);
                }
                context.SaveChanges();
            }
        
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
