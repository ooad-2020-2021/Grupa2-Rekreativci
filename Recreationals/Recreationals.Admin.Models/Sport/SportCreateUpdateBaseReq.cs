using Recreationals.Core.Constraints;
using System.ComponentModel.DataAnnotations;

namespace Recreationals.Admin.Models.Sport
{
    public class SportCreateUpdateBaseReq
    {
        [Required]
        [MinLength(SportConstraints.MinNameLength)]
        [MaxLength(SportConstraints.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(SportConstraints.MinPhotoUrlLength)]
        [MaxLength(SportConstraints.MaxPhotoUrlLength)]
        public string PhotoUrl { get; set; }
    }
}
