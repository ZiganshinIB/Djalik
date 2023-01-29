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

namespace Djalik
{
    /// <summary>
    /// Логика взаимодействия для PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        User person;   
        public PersonWindow()
        {
            InitializeComponent();  
        }

        public PersonWindow(User user)
        {
            person = user;

            InitializeComponent();

            First_name_Box.Text = person.First_name.ToString();
            Second_name_Box.Text = person.Second_name.ToString();
        }
    }
}
