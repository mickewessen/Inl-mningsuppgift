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
    /// Interaction logic for MessageControl.xaml
    /// </summary>
    public partial class MessageControl : UserControl
    {
        public MessageControl()
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

        public string SubjectOfMessage
        {
            get { return subjectOfMessage.Text; }
            set { subjectOfMessage.Text = value; }
        }

        private void messageButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
