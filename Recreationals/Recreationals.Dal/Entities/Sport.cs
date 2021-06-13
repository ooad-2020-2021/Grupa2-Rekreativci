using Recreationals.Core.Constraints;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recreationals.Dal.Entities
{
    public class Sport
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(SportConstraints.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(SportConstraints.MaxPhotoUrlLength)]
        public string PhotoUrl { get; set; }

        public virtual IList<Field> Fields { get; set; }
    }
}
