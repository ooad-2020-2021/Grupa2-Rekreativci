using System;
using System.Collections.Generic;

namespace Recreationals.Public.Models.Field
{
    public class FieldGetDetailsRes
    {
        public int Id { get; set; }

        public string SportName { get; set; }
        public string SportsCenterName { get; set; }

        public IList<TermDto> Terms { get; set; }

        public class TermDto
        {
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
        }
    }
}
