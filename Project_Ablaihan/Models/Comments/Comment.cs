using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


using Project_Ablaihan.Models.Categories;
using Project_Ablaihan.Models.Goods;
using Project_Ablaihan.Models.Users;


namespace Project_Ablaihan.Models.Comments
{
    public class Comment
    {
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Text")]
        public string Name { get; set; }

        [Display(Name = "Author")]
        public User Author{ get; set; }



    }
}
