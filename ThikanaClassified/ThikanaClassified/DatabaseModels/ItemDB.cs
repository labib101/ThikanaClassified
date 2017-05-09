using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThikanaClassified.DatabaseModels
{
    public class ItemDB
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string ItemPicture { get; set; }
        public string ItemPrice { get; set; }
        public string IsPremium { get; set;}
        public string ItemLocation { get; set; }
        public string PostedDate { get; set; }
        public int Visited { get; set; }
    }
}