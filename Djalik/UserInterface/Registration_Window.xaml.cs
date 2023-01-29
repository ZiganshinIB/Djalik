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
    /// Логика взаимодействия для Registration_Window.xaml
    /// </summary>
    public partial class Registration_Window : Window
    {
        ApplicationContext db;
        public Registration_Window()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void authButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            string first_name = fistName_Text.Text.Trim();
            string second_name = secondName_Text.Text.Trim();
            string login = login_Text.Text.Trim();
            string pass = pass_Text.Password.Trim();
            string pass2 = pass2_Text.Password.Trim();
            float money = 1000;
            bool staff = false;

            User authUser = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                authUser = db.Users.Where(b => b.Login == login).FirstOrDefault();
            }


            if (login.Length < 5)
            {
                login_Text.ToolTip = "Очень кароткий";
                login_Text.Background = Brushes.Gray;
            }
            else if (authUser != null)
            {
                login_Text.ToolTip = "Уже есть такой";
                login_Text.Background = Brushes.Olive;
            } 
            else if (pass.Length < 8)
            {
                pass_Text.ToolTip = "Пороль должень быть больше 8 символов";
                pass_Text.Background = Brushes.Gray;
            }
            else if (pass != pass2)
            {
                pass2_Text.ToolTip = "Пороль не совподает";
                pass2_Text.Background = Brushes.MintCream;
            }
            else
            {
                fistName_Text.ToolTip = "";
                secondName_Text.ToolTip = "";
                login_Text.ToolTip = "";
                pass_Text.ToolTip = "";
                pass2_Text.ToolTip = "";
                fistName_Text.Background = Brushes.Transparent;
                secondName_Text.Background = Brushes.Transparent;
                login_Text.Background = Brushes.Transparent;
                pass_Text.Background = Brushes.Transparent;
                pass2_Text.Background = Brushes.Transparent;
                  
                User user = new User(first_name, second_name, login, pass, money, staff);
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("\"вы\" (Я) Молодец ;-)");
      
            }
        }
    }


}
