using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Portal.Domain.ViewModels
{
    public class PersonWriteViewModels
    {
        public PersonWriteViewModels()
        {
            AvailableGender = new List<SelectListItem>();
            AvailableDepartment = new List<SelectListItem>();
        }


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
        public string Gender { get; set; }

       

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

        [Required]
        public long CId { get; set; }

        public List<SelectListItem> AvailableDepartment { get; set; }
        public List<SelectListItem> AvailableGender { get; set; }

    }
}
