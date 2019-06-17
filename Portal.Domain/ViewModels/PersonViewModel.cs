using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Portal.Domain.Helper;
using Portal.Domain.Models;
using Portal.Domain.Models.Base;

namespace Portal.Domain.ViewModels
{
   public class PersonViewModel
    {
        [Key]
        public long Id { get; set; }

        public long ContactId { get; set; }
       
        public string Name { get; set; }
       

       
        public string Gender { get; set; }

       
        public string PhoneNumber { get; set; }

        
        
        public string Email { get; set; }

        [Required]
        
        public string Address { get; set; }
        public virtual Departments Departments { get; set; }
    }
}
