using System;
using System.ComponentModel.DataAnnotations;

namespace Website
{
    public class GuestResponse
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста укажите, придете ли вы")]
        public bool? WillAttend { get; set; }
    }
}