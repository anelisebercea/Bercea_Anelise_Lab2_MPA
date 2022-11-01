using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
namespace Bercea_Anelise_Lab2_MPA.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        
        public decimal Price { get; set; }
        //public string FullName { get; set; }

        //Foreign key
        public int? AuthorId { get; set; }
        // Navigation property
        public Author? Author { get; set; }
        public ICollection<Order>? Orders { get; set; }
        // public object AuthorForeignKey { get; internal set; }
    }
}
