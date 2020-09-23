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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication.Control
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        public ImageSource ContactImage
        {
            get { return contactImage.Source; }
            set { contactImage.Source = value; }
        }

        public string ContactName
        {
            get { return fromcontactName.Text; }
            set { fromcontactName.Text = value; }
        }

        public string ContactRole
        {
            get { return contactRole.Text; }
            set { contactRole.Text = value; }
        }

        public string EmailAdress
        {
            get { return emailAdress.Text; }
            set { emailAdress.Text = value; }
        }

        public string PostalAdress
        {
            get { return postalAdress.Text; }
            set { postalAdress.Text = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber.Text; }
            set { phoneNumber.Text = value; }
        }

        private void contactButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
