﻿using Library_Management_System.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.BLL.Models.InputModels
{
    public class ApplicationInputModel
    {
        public DateTime CreationDate { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
