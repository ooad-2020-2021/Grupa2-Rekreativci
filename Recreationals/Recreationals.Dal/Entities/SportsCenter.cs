using Recreationals.Core.Constraints;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recreationals.Dal.Entities
{
    public class SportsCenter
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(SportsCenterConstraints.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(SportsCenterConstraints.MaxDescriptionLength)]
        public string Description { get; set; }

        [MaxLength(SportsCenterConstraints.MaxPhotoUrlLength)]
        public string PhotoUrl { get; set; }

        [MaxLength(SportsCenterConstraints.MaxAddressLength)]
        public string Address { get; set; }

        [MaxLength(SportsCenterConstraints.MaxFacebookUrlLength)]   
        public string FacebookUrl { get; set; }

        [MaxLength(SportsCenterConstraints.MaxWebsiteUrlLength)]
        public string WebsiteUrl { get; set; }

        [MaxLength(SportsCenterConstraints.MaxPhoneNumberLength)]
        public string PhoneNumber { get; set; }

        public virtual IList<Field> Fields { get; set; }
    }
}
