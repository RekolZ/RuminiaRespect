using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

namespace RuminiaRespect.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CNPPage.xaml
    /// </summary>
    public partial class CNPPage : Page
    {
        public CNPPage()
        {
            InitializeComponent();
        }
        string gender;
        string resident;
        string birthday;
        

        private void MaleRadioBtn_Checked(object sender, RoutedEventArgs e)
        {
            gender = "1";
        }

        private void FemaleRadioBtn_Checked(object sender, RoutedEventArgs e)
        {
            gender = "2";
        }

        private void YesRadioBtn_Checked(object sender, RoutedEventArgs e)
        {
            DateTime date1  = new DateTime(1900, 1, 1);
            DateTime date2  = new DateTime(1949, 12, 31);
            DateTime date3  = new DateTime(1950, 1, 1);
            DateTime date4  = new DateTime(1999, 12, 31);
            DateTime date5  = new DateTime(1800, 1, 1);
            DateTime date6  = new DateTime(1849, 12, 31);
            DateTime date7  = new DateTime(1850, 1, 1);
            DateTime date8  = new DateTime(1899, 12, 31);
            DateTime date9  = new DateTime(2000, 1, 1);
            DateTime date10 = new DateTime(2049, 12, 31);
            DateTime date11 = new DateTime(2050, 1, 1);
            DateTime date12 = new DateTime(2099, 12, 31);

            //string theDate = BDayDatePicker.Value.ToString("yyyy");
            //birthday = Convert.ToString(Convert.ToDateTime(BDayDatePicker) >= date1 && Convert.ToDateTime(BDayDatePicker) < date12);

        }

        private void NoRadioBtn_Checked(object sender, RoutedEventArgs e)
        {
            Random random= new Random();
            resident = Convert.ToString(random.Next(7,10));
           
        }

        private void GenerateCNPBtn_Click(object sender, RoutedEventArgs e)
        {
            string a = LastNameTBox.Text;
            byte[] ascii = Encoding.ASCII.GetBytes(a);

            CNPLabel.Content = birthday+Convert.ToString(resident)+gender+Convert.ToString(ascii);
        }
    }
}
