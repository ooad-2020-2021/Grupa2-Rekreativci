using System.Collections.Generic;

namespace Recreationals.Dal.Entities
{
    public class Field
    {
        public int Id { get; set; }

        public int SportId { get; set; }
        public virtual Sport Sport { get; set; }

        public int SportsCenterId { get; set; }
        public virtual SportsCenter SportsCenter { get; set; }

        public virtual IList<Term> Terms { get; set; }
    }
}
