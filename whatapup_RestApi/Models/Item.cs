using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace whatapup_RestApi.Models
{
    public class Item
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool Completed { get; set; }
        public virtual Category Category { get; set; }
    }
}
