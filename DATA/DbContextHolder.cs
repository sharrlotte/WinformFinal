using DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class DbContextHolder
    {
        private static Db context;
        public static Db GetContext()
        {
            if (context == null)
                context = new Db();

            return context;
        }
    }
}
