using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Lab
{
    public class Principal
    {
        [Column(Order = 0)]
        [Required]
        [Key]
        public int Id { get; set; }

        [Column(Order = 1)]
        [Required]
        public String Name { get; set; }

        public IEnumerable<Dependent> Dependents { get; set; }
    }
}
