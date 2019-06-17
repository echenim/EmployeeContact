using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Portal.Domain.Helper;
using Portal.Domain.Models.Base;

namespace Portal.Domain.Models
{
   public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [MaxLength(7)]
        public string Gender { get; set; }

        

        [Required]
        [ForeignKey(nameof(Departments))]
        public long DepartmentId { get; set; }

        [NotMapped]
        public string Name 
            => $"{FirstName} {StringUtils.OptimizedFirstLetter(OtherName)} {LastName}";


        public virtual Departments Departments { get; set; }
      

      
        public ICollection<Contacts> Contacts { get; set; }

    }
}
