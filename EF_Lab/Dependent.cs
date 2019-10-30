using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Lab
{

    public class Dependent
    {
        [Key]
        [Required]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 1)]
        public string Name { get; set; }

        [Column(Order = 2)]
        [ForeignKey("PrincipalId")]
        public Principal Principal { get; set; }
    }
}
