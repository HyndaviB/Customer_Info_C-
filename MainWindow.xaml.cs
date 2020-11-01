using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Text.RegularExpressions;

namespace DataManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow
    {
        public static List<Customer> customers; //Creating customer details in a list

        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Please Enter Data Before Viewing");
            customers = new List<Customer>(); //Creating a Varable for List
        }

        //For Button SAVE
        private void Save(Object sender, RoutedEventArgs e)
        {

            Customer cust = new Customer(); //Creating a Object For Customer List
            cust.Addresstb = Address.Text; //Assinging Content In The Textfield To Variable
            cust.Dobtb = Dob.Text;
            cust.Emailtb = Email.Text;
            cust.Full_nametb = Full_name.Text;
            cust.Customer_idtb = Customer_id.Text;

            TextBoxValidation(cust); //Calling Validation Method For Contents In The TextFields

            Address.Clear(); //Clearing The Screen After Saving Data
            //Dob = null;
            Email.Clear();
            Full_name.Clear();
            Customer_id.Clear();

        }

        public void TextBoxValidation(Customer cust)
        {
            int count = 0;

            //Regular Expression For Validating the Fields

            string Customerid = @"[0-9]";
            string name = @"[^0-9]*$";
            string emailPattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            string addressPattern = @"^[a-zA-Z0-9_ ]*$";

            //Checking Whether String is Matching or Not

            bool isCustomeridValid = Regex.IsMatch(Customer_id.Text, Customerid);
            bool isnameValid = Regex.IsMatch(Full_name.Text, name);
            bool isEmailValid = Regex.IsMatch(Email.Text, emailPattern);
            bool isaddressValid = Regex.IsMatch(Address.Text, addressPattern);

            //If Condition Failed Displaying a MessageBox

            if (!isCustomeridValid || !isnameValid || !isEmailValid || !isaddressValid)
            {
                MessageBox.Show("ERROR BOX : " + "\n" + "Please Enter Only Integer For Customer ID " + "\n" + "Please Enter Only String For FUll Name " + "\n" + "Please Enter Valid Email Address " + "\n" + "Please Enter Valid Address ");
                count += 1;
            }
            if (count == 0)
            {
                customers.Add(cust); //Adding the Data to List 
            }

        }

        // Closing the Window 
        private void Close(Object sender, RoutedEventArgs e)
        {
            Close();
        }

        //Function for Displaying or Calling another Window
        private void View(Object sender, RoutedEventArgs e)
        {
            var w = new NewWindow();
            w.Show();
        }

        //Function for Window Moment
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}