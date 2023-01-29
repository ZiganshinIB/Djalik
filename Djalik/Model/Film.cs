using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djalik
{
    class Film
    {
        public int id { get; set; }

        private string title;
        private int n_date;
        private float price, n_time;
        public string Title { get { return title; } set { title = value; } }
        public int N_date { get { return n_date; } set { n_date = value; } } 
        public float N_time { get { return n_time; } set { n_time = value; } }  
        public float Price { get { return price; } set { price = value; } }


        public Film() { }

    }
}
