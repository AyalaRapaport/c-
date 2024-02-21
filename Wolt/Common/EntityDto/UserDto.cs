﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.EntityDto

{
    public class UserDto
    {
        public int? Id { get; set; }
        public string IdUser { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }
    }
}
