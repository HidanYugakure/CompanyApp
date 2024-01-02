﻿using CompanyApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Domain.Models
{
    public class Department :BaseEntity
    {
        public string Name { get; set; }
        public string Capacity { get; set; }
    }
}