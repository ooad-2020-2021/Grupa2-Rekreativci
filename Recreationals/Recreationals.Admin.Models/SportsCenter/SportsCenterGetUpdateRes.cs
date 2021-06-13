namespace Recreationals.Admin.Models.SportsCenter
{
    public class SportsCenterGetUpdateRes
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string PhotoUrl { get; set; }

        public string Address { get; set; }

        public string FacebookUrl { get; set; }

        public string WebsiteUrl { get; set; }

        public string PhoneNumber { get; set; }

        public class SportDto 
        { 
            public int Id { get; set; }
            public string Name { get; set; }
            public bool IsAvailable { get; set; }
        }
    }
}
