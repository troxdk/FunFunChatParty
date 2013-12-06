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

namespace Funfun_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Messages> messages;
        DataAccess File = new DataAccess();

        public MainWindow()
        {
            InitializeComponent();

            addToComboBox();
            loadMessages();
            ShowMessagesOnList();
            listboxFromFile.Items.Refresh();
        }

        private void ShowMessagesOnList()
        {
            //foreach (Messages message in messages)
            //{
            //    listboxFromFile.Items.Add(message);
            //}

            listboxFromFile.ItemsSource = messages;
        }

        private void loadMessages()
        {
            messages = File.LoadMessages();
        }

        //private void saveMessages()
        //{
        //    File.SaveMessages(messages);
        //}

        private void addToComboBox()
        {
            comboBoxUser.Items.Add("Daniel");
            comboBoxUser.Items.Add("Mikkel");
        }

        private void buttonSend_Click(object sender, RoutedEventArgs e)
        {
            Messages message = new Messages();

            message.Name = comboBoxUser.SelectedItem.ToString();
            message.Text = textBoxInput.Text;

            messages.Add(message);
            //saveMessages();
            File.SaveMessages(messages);

            
        }
    }
}
