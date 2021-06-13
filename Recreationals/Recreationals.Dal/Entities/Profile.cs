using System.Collections.Generic;

namespace Recreationals.Dal.Entities
{
    public class Profile
    {
        public int Id { get; set; }

        public virtual IList<Term> Terms { get; set; }
    }
}
