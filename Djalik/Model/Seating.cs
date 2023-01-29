using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djalik
{
    class Seating
    {
        public int id { get; set; }

        private int hall, rowe, cole, film_id, user_id;
        private float price;
        private bool is_empty;

        public int Hall { get { return hall; } set { hall = value; } }  
        public int Rowe { get { return rowe; } set { rowe = value; } }
        public int Cole { get { return cole; } set { cole = value; } }
        public float Price { get { return price; } set { price = value; } } 
        public bool IsEmpty { get { return is_empty; } set { is_empty = value;} }
        public int Film_id { get { return film_id; } set { film_id = value; } }
        public int User_id { get { return user_id; } set { user_id = value;} }


        public Seating() { }

    }
}
