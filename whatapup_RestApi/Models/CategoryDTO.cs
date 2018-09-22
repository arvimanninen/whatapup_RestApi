using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace whatapup_RestApi.Models
{
    public class CategoryDTO
    {
        public int Name { get; set; }
        public List<ItemDTO> ItemDtos { get; set; }
    }
}
