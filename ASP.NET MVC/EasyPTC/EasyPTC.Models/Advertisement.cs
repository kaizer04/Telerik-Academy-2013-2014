﻿using EasyPTC.Data.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPTC.Models
{
    public class Advertisement : DeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public int AvailableClicks { get; set; }
    }
}
