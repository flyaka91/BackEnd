using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Core.Models.OutputModels
{
    public class BookOutputModel
    {
        public Guid BookId { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }

        public enum Status
        {
            Available,
            Unavailable
        }
    }
}
