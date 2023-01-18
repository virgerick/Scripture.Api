using System;
namespace Scripture.Api.Models;

public record BibleRecord(int Id,string Language,string Abbreviation,string TextDirection,ICollection<BookRecord> Books);

