﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopApp.webui.Models
{
    public class ResetPasswordModel
    {
        [Required]
        public string Token { get; set; }

    
        [Display(Name = "Email", Prompt = "Lütfen Email adresinizi giriniz")]
        [Required(ErrorMessage = "E-mail adresi giriniz zorunlu alan!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Password", Prompt = "Lütfen şifrenizi giriniz")]
        [Required(ErrorMessage = "Şifrenizi giriniz zorunlu alan!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
