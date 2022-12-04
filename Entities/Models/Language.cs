using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Language
    {
        [Key]
        [MaxLength(2)]
        public string Code { get; set; }
        [MaxLength(128)]
        public string Name { get; set; }
    }
}