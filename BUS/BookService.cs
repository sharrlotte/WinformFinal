using DATA;
using DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BookService
    {
        public List<Book> GetAllBook() => DbContextHolder.GetContext().Books.ToList();
    }
}
