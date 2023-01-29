using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Djalik
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<User>Users{ set; get; } // имя переменой совподает с имением таблицы

        public ApplicationContext() : base("DefaultConnection") { }
    }
}
