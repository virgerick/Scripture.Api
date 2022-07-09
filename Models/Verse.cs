﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripture.Api.Models
{
    public struct Verse
    {
        public int TranslationId { get;set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Number { get; set; }
        public string Text { get; set; }
    }
}
