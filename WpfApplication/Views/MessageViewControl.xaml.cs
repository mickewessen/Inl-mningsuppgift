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

namespace WpfApplication.Views
{
    /// <summary>
    /// Interaction logic for MessageViewControl.xaml
    /// </summary>
    public partial class MessageViewControl : UserControl
    {
        public MessageViewControl()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, RoutedEventArgs e)
        {
            time.Text = "Onsdag 12:45";
            subject.Text = "Påminnelse om domännamn";
            from.Text = "Samuel Wessén <samuelwessen@hotmail.com>";
            to.Text = "Michael Wessén";
            body.Text = "Test";
                
        }
    }
}
