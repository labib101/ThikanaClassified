﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThikanaClassified.DatabaseModels
{
    public class Authentication
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}