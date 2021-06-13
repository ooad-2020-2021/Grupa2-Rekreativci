using Recreationals.Core.Constraints;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Recreationals.Admin.Models.SportsCenter
{
    public class SportsCenterCreateUpdateBaseReq
    {
        [Required]
        [MinLength(SportsCenterConstraints.MinNameLength)]
        [MaxLength(SportsCenterConstraints.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(SportsCenterConstraints.MinDescriptionLength)]
        [MaxLength(SportsCenterConstraints.MaxDescriptionLength)]
        public string Description { get; set; }

        [MinLength(SportsCenterConstraints.MinPhotoUrlLength)]
        [MaxLength(SportsCenterConstraints.MaxPhotoUrlLength)]
        public string PhotoUrl { get; set; }

        [MinLength(SportsCenterConstraints.MinAddressLength)]
        [MaxLength(SportsCenterConstraints.MaxAddressLength)]
        public string Address { get; set; }

        [MinLength(SportsCenterConstraints.MinFacebookUrlLength)]
        [MaxLength(SportsCenterConstraints.MaxFacebookUrlLength)]
        public string FacebookUrl { get; set; }

        [MinLength(SportsCenterConstraints.MinWebsiteUrlLength)]
        [MaxLength(SportsCenterConstraints.MaxWebsiteUrlLength)]
        public string WebsiteUrl { get; set; }

        [MinLength(SportsCenterConstraints.MinPhoneNumberLength)]
        [MaxLength(SportsCenterConstraints.MaxPhoneNumberLength)]
        public string PhoneNumber { get; set; }

        public IList<string> SelectedSports { get; set; }
        public IList<SelectListItem> AvailableSports { get; set; }

        public SportsCenterCreateUpdateBaseReq()
        {
            SelectedSports = new List<string>();
            AvailableSports = new List<SelectListItem>();
        }
    }
}
