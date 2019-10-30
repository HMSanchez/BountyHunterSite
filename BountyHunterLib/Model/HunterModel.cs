using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BountyHunterLib.Model
{
   public class HunterModel
    {
        public int HunterId { get; set; }

        [Required(ErrorMessage = "An name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "An Image Url is required")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "An wage is required")]
        public string Wage { get; set; }
        [Required(ErrorMessage = "An description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "A detail is required")]
        public string DetailOne { get; set; }
        [Required(ErrorMessage = "A detail two is required")]
        public string DetailTwo { get; set; }
        [Required(ErrorMessage = "An detail three is required")]
        public string DetailThree { get; set; }

        public HunterModel()
        {

        }
    }
}
