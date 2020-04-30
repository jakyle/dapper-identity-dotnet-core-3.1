﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace identity_dapper.ManageViewModels
{
    public class AddRoleViewModel
    {
        [Display(Name = "Role Name")]
        [Required]
        public string RoleName { get; set; }
    }
}
