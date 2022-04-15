using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopologyAPI.Models
{
    public class RootComponent
    {
        [Key]
        public int Id { get; set; } 
        public string Type  { get; set; }
        public string defualt { get; set; }
        public int min { get; set; }
        public int max { get; set; }

        public string t1 { get; set; }
        public string t2 { get; set; }

        public string drain { get; set; }

        public string gate { get; set; }

        public string source { get; set; }


    }
}
