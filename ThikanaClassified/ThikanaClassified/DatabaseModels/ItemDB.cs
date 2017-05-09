using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ThikanaClassified.DatabaseModels
{
    public class ItemDB
    {
        [Key]
        public int ItemID { get; set; }
        public int CategoryID { get; set; }

    [ForeignKey("CategoryID")]
        public string ItemName { get; set; }
     
        public string ItemPrice { get; set; }
        public string IsPremium { get; set;}
        public string ItemLocation { get; set; }
        public DateTime PostedDate { get; set; }
        public int Visited { get; set; }
        public List<ItemPicture> Images { get; set; }

        public Category Category { get; set; }
    }
}