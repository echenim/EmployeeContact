using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Domain.Models.Base
{
    public class IdentificationNumberWithCreationDate
    {
         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public long Id { get; set; }


         [Required]
         [DataType(DataType.DateTime)]
         public DateTime CreatedOn { get; set; }
         


    }
}
