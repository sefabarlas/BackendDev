using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class SystemMessage
    {
        [Required]
        [MaxLength(16)]
        public string Code { get; set; }

        [Required]
        [MaxLength(64)]
        public string MessageTypeId { get; set; }

        [Required]
        [MaxLength(2)]
        public string LanguageCode { get; set; }

        [Required]
        public string Value { get; set; }

        public string Description { get; set; }

        [JsonIgnore]
        [ForeignKey("LanguageCode")]
        public Language Language { get; set; }
    }
}
