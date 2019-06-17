using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Portal.Domain.ViewModels
{
    public class PersonEditViewModel
    {

        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string FirstName { get; set; }
        public string OtherName { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        public long Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(11)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        public string HouseAddress { get; set; }

        [Required]
        public long Department { get; set; }
    }
}
