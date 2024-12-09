using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DAL.Dtos
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Book> Books { get; set; } = [];
        public ICollection<Application> Applications { get; set; } = [];
    }
}
