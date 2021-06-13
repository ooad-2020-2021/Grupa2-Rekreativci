using System;

namespace Recreationals.Dal.Entities
{
    public class Term
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int FieldId { get; set; }
        public virtual Field Field { get; set; }

        public int? ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
