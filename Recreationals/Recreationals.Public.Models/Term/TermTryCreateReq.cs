using System;
using System.ComponentModel.DataAnnotations;

namespace Recreationals.Public.Models.Term
{
    public class TermTryCreateReq
    {
        [Required]
        public int? FieldId { get; set; }

        [Required]
        public DateTime? StartTime { get; set; }

        [Required]
        public DateTime? EndTime { get; set; }
    }
}
