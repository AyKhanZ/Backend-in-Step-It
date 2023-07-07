﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPassSql.Data.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = null!; 
        public string Password { get; set; } = null!; 
    }
}
