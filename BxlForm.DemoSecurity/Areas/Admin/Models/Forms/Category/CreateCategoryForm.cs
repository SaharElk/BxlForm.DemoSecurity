﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BxlForm.DemoSecurity.Areas.Admin.Models.Forms.Category
{
    public class CreateCategoryForm
    {
        [Required]
        [StringLength(125)]
        public string Name { get; set; }
    }
}
