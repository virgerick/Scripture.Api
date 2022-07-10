using Scripture.Api.ValueObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripture.Api.Models
{
    public class Book
    {
        public int TranslationId { get; set; }
        public BookType Type { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
    }
}
