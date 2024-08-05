using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit.Models
{
    public class Product
    {
        public required string name { get; set; }
        public string? description { get; set; }
        public int id { get; set; }
    }
}
