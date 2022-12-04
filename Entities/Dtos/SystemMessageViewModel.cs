using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class SystemMessageViewModel
    {
        public string? Code { get; set; }
        public string? Value { get; set; }
        public string? LanguageCode { get; set; }
    }
}