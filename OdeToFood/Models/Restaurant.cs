using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Display(Name="Restaurant Name")]  // the lable displayed on front
        //[DisplayFormat]: useful for dispaly the date or time with format
        //[DataType(DataType.Text)]: set data type of input in front, it can use for password, email, etc.
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public EnumCuisineType Cuisine { get; set; }
    }
}
