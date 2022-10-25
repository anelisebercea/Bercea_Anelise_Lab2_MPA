using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Bercea_Anelise_Lab2_MPA.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Book Book { get; set; }
        public ICollection<Book> Books { get; set; }

        public static implicit operator Author(string v)
        {
            throw new NotImplementedException();
        }
    }
}
