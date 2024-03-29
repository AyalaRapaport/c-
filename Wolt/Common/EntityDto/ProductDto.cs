﻿using Microsoft.AspNetCore.Http;
using Reposiroty.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.EntityDto

{
    public class ProductDto
    {
        public int? Id { get; set; }
        public string ? Name { get; set; }
        public double ? Price { get; set; }
        public string Description { get; set; } 
        public int ? CategoryId { get; set; }  
        public int ? StoreId{ get; set; }   
        public IFormFile ? Image { get; set; }
        public string? UrlImage { get; set; }

    }
}
