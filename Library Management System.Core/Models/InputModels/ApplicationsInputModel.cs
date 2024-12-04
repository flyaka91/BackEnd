using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Core.Models.InputModels
{
    public class ApplicationsInputModel
    {
        public DateTime CreationDate { get; set; }
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
    }
}
