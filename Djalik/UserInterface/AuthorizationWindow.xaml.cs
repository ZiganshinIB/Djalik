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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void reg_Window_Button_Click(object sender, RoutedEventArgs e)
        {
            Registration_Window registration_Window = new Registration_Window();
            registration_Window.Show();
            Close();

        }

        private void authButton_Click(object sender, RoutedEventArgs e)
        {

            string login = login_Text.Text.Trim();
            string pass = pass_Text.Password.Trim();

            User authUser = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                authUser = db.Users.Where(b => b.Login == login).FirstOrDefault();
            }
            if (authUser != null)
            {
                if (authUser.Pass != pass)
                {
                    pass_Text.ToolTip = "Пороль Не верный подбери другой";
                    pass_Text.Background = Brushes.Red;
                }
                else
                {
                    PersonWindow person_Window = new PersonWindow(authUser);
                    person_Window.Show();
                    Close();
                }
                
            }

            
        }
    }
}
