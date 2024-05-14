﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.WebApp.ViewModel
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }

        public string Description { get; set; }
    }
}
