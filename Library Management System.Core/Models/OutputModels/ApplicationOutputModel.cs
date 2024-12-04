﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Core.Models.OutputModels
{
    public class ApplicationOutputModel
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
    }
}