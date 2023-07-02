﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.Api.Models
{
    public record Project : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}
