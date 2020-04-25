using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using Project_Ablaihan.Models.Goods;



namespace Project_Ablaihan.Models.Categories
{
    public class Category
    {

        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

   
    }
}
