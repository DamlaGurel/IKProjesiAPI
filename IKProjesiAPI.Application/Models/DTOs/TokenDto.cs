﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Models.DTOs
{
    public class TokenDto
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public string Role { get; set; }
    }
}