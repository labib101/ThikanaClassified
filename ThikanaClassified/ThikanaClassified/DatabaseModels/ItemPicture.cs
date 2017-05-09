using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThikanaClassified.DatabaseModels
{
    public class ItemPicture
    {
        public int ID { get; set; }
        public string PictureName { get; set; }

        
        public int ItemID { get; set; }

        [ForeignKey("ItemID")]

        public ItemDB ItemDB { get; set; }
    }
}