using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThikanaClassified.DatabaseModels
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryPicture { get; set; }

        public List<ItemDB> ItemDB { get; set; }
    }
}