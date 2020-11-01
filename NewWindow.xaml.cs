using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Schema;
using System.Text.RegularExpressions;

namespace DataManagement
{
    /// <summary>
    /// Interaction logic for NewWindow.xaml
    /// </summary>
    public partial class NewWindow : Window
    {

        int totalCustomer = MainWindow.customers.Count; //Count the Customer List
        int Currentcustomer = 0;

        public NewWindow()
        {
            InitializeComponent();

            //PLEASE SAVE DATA BEFORE USE

            Customer cust = MainWindow.customers[0]; //Creating Customer List
            Display(cust); //Displaying Contents
        }

        //Method for Closing Window
        private void Close(Object sender, RoutedEventArgs e)
        {
            Close();
        }

        //Method for PREVIOUS BUTTON
        private void Previous(Object sender, RoutedEventArgs e)
        {
            //Creating a loop for Wrapping First Customer to Last Customer in List
            if (Currentcustomer - 1 < 0)
            {
                Currentcustomer = totalCustomer - 1;
            }
            else
            {
                Currentcustomer -= 1;
            }

            Customer cust = MainWindow.customers[Currentcustomer]; //Displaying Previous Customer Details
            Display(cust);
        }

        //Method for NEXT BUTTON
        private void Next(Object sender, RoutedEventArgs e)
        {
            //Creating a loop for Wrapping First Customer to Last Customer in List
            if (Currentcustomer + 1 == totalCustomer)
            {
                Currentcustomer = 0;
            }
            else
            {
                Currentcustomer += 1;
            }

            Customer cust = MainWindow.customers[Currentcustomer]; //Displaying Next Customer Details
            Display(cust);

        }

        //Method for UPDATE Button
        private void Update(Object sender, RoutedEventArgs e)
        {
            //Updating the Customer Details in TextFields
            Customer cust = MainWindow.customers[Currentcustomer];
            cust.Addresstb = Address.Text;
            cust.Dobtb = Dob.Text;
            cust.Emailtb = Email.Text;
            cust.Full_nametb = Full_name.Text;
            cust.Customer_idtb = Customer_id.Text;

            
        }

      

        //Function for Window Moment
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        //Method for Displaying the Customer Details
        public void Display(Customer cust)
        {
            //Displaying the Data
            Customer_id.Text = cust.Customer_idtb;
            Full_name.Text = cust.Full_nametb;
            Email.Text = cust.Emailtb;
            Dob.Text = cust.Dobtb;
            Address.Text = cust.Addresstb;
        }

    }
}