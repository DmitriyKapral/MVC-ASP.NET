using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace example.Models
{
    public class Recycle
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Products { get; set; }
    }
}