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

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for ContactWindow.xaml
    /// </summary>
    public partial class ContactWindow : Window
    {
        public ContactWindow()
        {
            InitializeComponent();

            contacts.Add(new Contact()
            {
                Name = "James",
                Email = "james@mail.com",
                PhoneNumber = "01234 111111"
            });
            contacts.Add(new Contact()
            {
                Name = "Bob",
                Email = "bob@mail.com",
                PhoneNumber = "01234 222222"
            });
            contacts.Add(new Contact()
            {
                Name = "Emma",
                Email = "emma@mail.com",
                PhoneNumber = "01234 333333"
            });
        }

        protected List<Contact> contacts = new List<Contact>();
        public List<Contact> Contacts
        {
            get { return contacts; }
            set { contacts = value; }
        }
    }
}
