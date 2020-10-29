using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(80, MinimumLength = 2, ErrorMessage = "The Name should have at leat twa chars and a maximum of 80")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter a valid email.")]
        [EmailAddress(ErrorMessage = "Please enter better.")]
        public string Email { get; set; }

        public bool? WillAttend { get; set; }
    }
}
