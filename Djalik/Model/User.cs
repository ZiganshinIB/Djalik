using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djalik
{
    public class User
    {
        public int id { get; set; }

        private string first_name, second_name, login, pass;
        private float money;
        private bool is_staff;

        public string First_name { 
            get { return first_name; }
            set { first_name = value; }
        }
        public string Second_name
        {
            get { return second_name; }
            set { second_name = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public float Money
        {
            get { return money; }
            set { money = value; }
        }
        public bool Is_staff { get { return is_staff; } set { is_staff = value; } }


        public User() { }


        public User(string first_name, string second_name, string login, string pass, float money, bool staff)
        {
            this.first_name =  first_name;
            this.second_name = second_name;
            this.login = login;
            this.pass = pass;
            this.money = money;
            this.is_staff = staff;
        }


    }
}
