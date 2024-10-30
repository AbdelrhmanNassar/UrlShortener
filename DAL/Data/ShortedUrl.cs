using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    internal class ShortedUrl
    {
        public int Id { get; set; }

        public required string LongUrl { get; set; }

        public required string ShortUrl { get; set; }

        public  DateTime CreatedAt { get; set; }

        public DateTime ExpirationDate  { get; set; }

    }
}
