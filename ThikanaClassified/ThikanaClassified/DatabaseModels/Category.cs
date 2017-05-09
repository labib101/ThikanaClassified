using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThikanaClassified.DatabaseModels
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryPicture { get; set; }
    }
}